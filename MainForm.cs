/*
 * Created by SharpDevelop.
 * User: wikajustyna
 * Date: 10.10.2021
 * Time: 17:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

namespace rjgen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Dictionary<string,string> speeds = new Dictionary<string,string>();
		//int lastIndex = -5;
		
		public MainForm()
		{
			InitializeComponent();
			
		    Rectangle screen = Screen.PrimaryScreen.WorkingArea;
		    int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
		    this.Location = new Point((screen.Width - w) / 2, screen.Height / 2 - Height / 2);
		    this.Size = new Size(w, Height);
		}
			
		private bool isOpened(string name)
		{
			FormCollection formColl = Application.OpenForms;
			
			foreach(Form itForm in formColl)
			{
				if (itForm.Text == name)
				{
					return true;
				}
			}
			return false;
		}
		
		void OProgramieToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (!isOpened("O programie"))
				new About().ShowDialog(this);
		}
		
		void Button1Click(object sender, EventArgs e)
		{	
			if (!isOpened("Dodaj stację"))
			{
				var adder = new AddMenu();
				adder.frm = this;

				adder.ShowDialog(this);				
			}
		}	
		
		void Button3Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			foreach (DataGridViewCell row  in dataGridView1.SelectedCells)
			{
			     dataGridView1.Rows.RemoveAt(row.RowIndex);
			}
			
			dataGridView1.ClearSelection();
		}
		
		void ZapiszToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (trainID.Text.Length > 0 &&/*trainName.Text.Length > 0 &&*/ trainType.Text.Length > 0 && brakeMass.Text.Length > 0) {
				//if (trainCategory.SelectedIndex > -1) {
					if ((firstStation.Text.Length > 0 && lastStation.Text.Length > 0) || autoStations.Checked) {
						if (dataGridView1.Rows.Count > 0) {
							saveFileDialog1.FileName = trainID.Text.ToLower(); // set filename
							
							if (saveFileDialog1.ShowDialog() == DialogResult.OK)
							{
								var path = Path.GetFullPath(saveFileDialog1.FileName);
								int lastRow = dataGridView1.Rows.Count - 2;
								
								string firstSt; //  pierwsza stacja
								string lastSt; // ostatnia stacja
								
								if (!autoStations.Checked) // pobieramy relacje automatycznie lub wprowadzona
								{
									firstSt = firstStation.Text;
									lastSt = lastStation.Text;
								} else { // generujemy samemu
									firstSt = dataGridView1.Rows[0].Cells["stationName"].Value.ToString();
									lastSt = dataGridView1.Rows[lastRow].Cells["stationName"].Value.ToString().Replace("_po","");
								}
								
								string firstLine = " ____________________________________________________________________";
								
								string category;
								
								if (trainCategory.SelectedIndex > -1) {
									category = trainCategory.SelectedItem.ToString();
								} else {
									category = "";
								}
								
								string[] contentData = {
									firstLine, // Zaczynamy rozkład
									"[ Rodzaj i numer pociągu                         | " + trainID.Text.ToUpper(), // Pierwsze informacje
									"[ Kategoria                                      | " + category, // kategoria
									"[ Nazwa pociągu                                  | " + trainName.Text, // nazwa pociagu
									"[________________________________________________|___________________]",
									"[                                                | " + firstSt, // Relacja pociagu
									"[ Relacja pociągu                                | " + lastSt, // stacja końcowa
									"[________________________________________________|___________________]",
									"[ Wymagany % ciężaru hamującego                  |     " + brakeMass.Text.Replace("%","") + "%", // informacje
									"[________________________________________________|___________________]",
									"[ Seria i obciążenie lokomotywy                  |  " + trainType.Text.ToUpper(),
									"[________________________________________________|___________________]",
								};
								
								List<string> content = new List<string>(contentData);
								
								if (category == "") {
									content.RemoveAt(2);
								}
								
								if (trainName.Text.Length <= 0 || trainName.Text == "" || trainName.Text == String.Empty) {
									content.RemoveAt(category == "" ? 2 : 3);
								}
								
								// szerokości kolumn
								string stationWidth = "__________________________________";
								string kmWidth = "______";
								string vmaxWidth = "____";
								string timeWidth = "________";
								string minWidth = "______  ";
								
								int trackNum = 0;
								
								int loop_i = 0;
								foreach (DataGridViewRow row in dataGridView1.Rows)
								{
									var stationNameData = row.Cells["stationName"].Value;
									
									if (stationNameData != null) {
										string stationNameText = stationNameData.ToString();
										int nameDiff = stationWidth.Length - stationNameText.Length;
										
										string kmText = row.Cells["km"].Value.ToString();
										int kmDiff = kmWidth.Length - kmText.Length;
										
										int lastVmax = 0;
										string vmaxText;
										
										var vmaxData = row.Cells["vmax"].Value;
										
										if (vmaxData == null)
										{
											vmaxText = "";
										} else {
											vmaxText = vmaxData.ToString();
										}
										
										if (row.Index >= 1) // jeśli taki sam jak poprzedni to nie powtarzamy
										{
											if (vmaxText == dataGridView1.Rows[row.Index-1].Cells["vmax"].Value.ToString())
												vmaxText = "";
										}
										 // wyliczamy spacje i wyrównujemy cały rozkład do 1 linii
										int vmaxDiff = vmaxWidth.Length - vmaxText.Length;
										
										int vmaxInt = Convert.ToInt32(vmaxText.Length > 0 ? vmaxText : "0");
										
										string time1Text = row.Cells["hour1"].Value.ToString();
										int timeDiff = timeWidth.Length - time1Text.Length;
										
										string time2Text = row.Cells["hour2"].Value.ToString();
										int timeDiff2 = timeWidth.Length - time2Text.Length;
										
										string minuteText = "";
										
										if (row.Index >= 1) { // obliczamy czas przejazdu
											var hour2 = dataGridView1.Rows[row.Index-1].Cells["hour2"].Value;
											var hour1 = row.Cells["hour1"].Value;
							
											string hour1Str = hour1.ToString();
											string hour2Str = hour2.ToString();
											
											if (hour2Str.Length > 0 && hour1Str.Length > 0)
											{
												if (!(hour1Str == "0" || hour1Str == "|" || hour1Str == ":" || hour1Str == "." || hour1Str == "" || hour1Str == String.Empty))
												{
													if (!(hour2Str == "0" || hour2Str == "|" || hour2Str == ":" || hour2Str == "." || hour2Str == "" || hour2Str == String.Empty))
													{
														DateTime startTime = Convert.ToDateTime(hour2);
														DateTime endTime = Convert.ToDateTime(hour1);
														
														TimeSpan span = endTime.Subtract(startTime);
														
														minuteText = span.Minutes.ToString();
													}
												} else { // nie ma godziny przyjazdu to obliczamy od godziny odjazdu do odjazdu
													if (!(hour2Str == "0" || hour2Str == "|" || hour2Str == ":" || hour2Str == "." || hour2Str == "" || hour2Str == String.Empty))
													{
														var hour1_e = row.Cells["hour2"].Value;
														
														DateTime startTime = Convert.ToDateTime(hour2);
														DateTime endTime = Convert.ToDateTime(hour1_e);
														
														TimeSpan span = endTime.Subtract(startTime);
														
														minuteText = span.Minutes.ToString();
													}
												}
											}
										} else {
											minuteText = "";
										}
										
										if (vmaxText != String.Empty && vmaxText != "" && vmaxText.Length > 0) { // jesli nowy vmax to aktualizujemy
											if (vmaxInt != lastVmax)
												lastVmax = vmaxInt;
										}
										
										int minDiff = minWidth.Length - minuteText.Length;
										
										trackNum = Convert.ToInt32(row.Cells["tracksNumber"].Value);
										
										if (vmaxText.Count() > 0 && loop_i > 0)
										{
											content[content.Count-1] = content[content.Count-1].Remove(9,5).Insert(9, "_____");
										}
										
										content.Add( // dodajemy stacje do rozkładu linia 1
										            "[ " + kmText + String.Concat(Enumerable.Repeat(" ", kmDiff)) + "| " + vmaxText + String.Concat(Enumerable.Repeat(" ", vmaxDiff)) + "| " + stationNameText + String.Concat(Enumerable.Repeat(" ", nameDiff-1)) + trackNum + " " + time1Text + String.Concat(Enumerable.Repeat(" ", timeDiff)) + "| " + minuteText + String.Concat(Enumerable.Repeat(" ", minDiff)) + "]"
										);
										
										content.Add( // linia 2
											"[       |     |                                  " + trackNum + " " + time2Text + String.Concat(Enumerable.Repeat(" ", timeDiff2)) + "|         ]"
										);
										
										string channelText = "";
										bool newChannel = false;
										
										var channelData = row.Cells["radioChannel"].Value;
										
										if (channelData == null) // kanał radiowy i informacje przy tym
										{
											channelText = "";
										} else {
											channelText = channelData.ToString();
											newChannel = true;
										}
										
										if (row.Index >= 1) // jeśli taki sam jak poprzedni to nie powtarzamy
										{
											if (channelText == dataGridView1.Rows[row.Index-1].Cells["radioChannel"].Value.ToString())
											{
												channelText = "";
												newChannel = false;
											}
										}
										
										if (newChannel) // tylko jesli zapisujemy to w wierszu
										{
											StringBuilder sbd = new StringBuilder(content[content.Count-1]);
											int charIndex = 49 - channelText.Length - 2; // obliczamy pozycje opisu posterunku
											
											sbd.Remove(charIndex, channelText.Length + 2);
											sbd.Insert(charIndex, channelText + "  ");
											
											content[content.Count-1] = sbd.ToString();
										}
									
										if (row.Index < dataGridView1.Rows.Count-2) // do ostatniego wiersza nie dodajemy
										{
											content.Add( // linia 3
												"[       |     |----------------------------------" + trackNum + "---------|---------]"
											);
										}
										
										loop_i++;
									}
								}
								
								for(int i = 0 ; i < content.Count ; i++) // Obliczamy spacje i wyrównujemy rozkład
								{
									int lenDiff = firstLine.Length - content[i].Length;
									
									if (lenDiff > 0) 
									{
										content[i] = content[i] + String.Concat(Enumerable.Repeat(" ", lenDiff)) + "]";
									}
									
									content[i] = content[i].Replace(":", "."); // zamieniamy pod zapis : na . dla symka
								}
								
								content.Add("[_______|_____|__________________________________" + trackNum + "_________|_________]"); // kończymy rozkład
								
								File.WriteAllLines(path, content, System.Text.Encoding.GetEncoding(1252));
							}
						} else {
							MessageBox.Show("Nie można wygenerować pustego rozkładu", "Informacja", MessageBoxButtons.OK);
						}
					} else {
						MessageBox.Show("Należy podać relację pociągu lub zaznaczyć pole automatycznego wybierania relacji", "Informacja", MessageBoxButtons.OK);
					}
				//}  else {
					//MessageBox.Show("Należy wybrać kategorię pociągu", "Informacja", MessageBoxButtons.OK);
				//}
			} else {
				MessageBox.Show("Należy wypełnić wszystkie informacje o składzie", "Informacja", MessageBoxButtons.OK);
			}
		}
		
		void AutoStationsCheckedChanged(object sender, EventArgs e)
		{
			bool state = autoStations.Checked;
			firstStation.Enabled = !state;
			lastStation.Enabled = !state;
		}
		
		void BrakeMassKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.'))
			{
				e.Handled = true;
			}
		}
		
		void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			if (val == null || val.ToString() == "" || val.ToString() == String.Empty) {
				if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
				{
					dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "|";
				} else if (e.ColumnIndex == 0) {
					dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "???";
				}
			}
		}
		
		void OtwórzToolStripMenuItemClick(object sender, EventArgs e)
		{
			string path = "";
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				path = openFileDialog1.FileName;
			}
			
			if (File.Exists(path)) {
				string[] readData = File.ReadAllLines(path, System.Text.Encoding.GetEncoding(65001));
				
				dataGridView1.Rows.Clear();
				dataGridView1.ClearSelection();
				
				trainName.Text = "";
				trainCategory.SelectedIndex = -1;
				
				string typeVal = Regex.Replace(Regex.Match(readData[1], @"(?<=\|)\s.+?(?=\])").ToString(), @"\s+?", "");
				trainID.Text = typeVal;
				
				string secLVal = Regex.Replace(Regex.Match(readData[2], @"(?<=\|)\s.+?(?=\])").ToString(), @"\s+?", "");
				
				int nextLine = 3;
				if (readData[2].Contains("Kategoria")) {
					for (int i = 0; i < trainCategory.Items.Count; i++) {
						if (trainCategory.GetItemText(trainCategory.Items[i]) == secLVal)
						{
							trainCategory.SelectedIndex = i;
							break;
						}
					}
					
					nextLine = 4;
					
					if (readData[3].Contains("Nazwa poci")) {
						trainName.Text = Regex.Replace(Regex.Match(readData[3], @"(?<=\|)\s.+?(?=\])").ToString(), @"\s+?", "");
						nextLine = 5;
					}
				} else if (readData[2].Contains("Nazwa poci")) {
					trainName.Text = secLVal;
					nextLine = 4;
				}
				
				string firstStationName = Regex.Replace(Regex.Match(readData[nextLine], @"(?<=\|)\s.+?(?=\])").ToString(), @"\s+?", "");
				string lastStationName = Regex.Replace(Regex.Match(readData[nextLine+1], @"(?<=\|)\s.+?(?=\])").ToString(), @"\s+?", "");
				
				int brakeMassInt = nextLine+3;
				brakeMass.Text = Regex.Replace(Regex.Match(readData[brakeMassInt], @"(?<=\|)\s.+?(?=\])").ToString(), @"\s+?", "");
				
				string data_type = Regex.Match(readData[brakeMassInt+2], @"(?<=\|)\s.+?(?=\])").ToString().Trim();
				trainType.Text = Regex.Match(data_type, @"([A-Za-z 0-9]+[0-9]+)").ToString();
				
				int startTable = brakeMassInt+4;
				
				for (int i = startTable; i < readData.Count()-1; i++) {
					if (readData[i] != null && !readData[i].Contains("----------------------------------"))
					{
						string name = Regex.Match(readData[i], @"(?<=^[^|]*\|[^|]*\|).*?(?=\b[21]\b)").ToString().Trim();
						
						if (name.Count() > 2 && !name.Contains(","))
						{
							string km = Regex.Match(readData[i], @"(?<=\[).+?(?=\|)").ToString().Trim();
							string velocity = Regex.Match(readData[i], @"(?<=\|)[\s0-9]+?(?=\|)").ToString().Trim();
							string track = Regex.Match(readData[i], @"(\s\s+\b[21]\b\s)").ToString().Trim();
							string desc = Regex.Match(readData[i+1], @"(?<=^[^|]*\|[^|]*\|).*?(?=\b[21]\b)").ToString().Trim();
							string h1 = Regex.Match(readData[i], @"(?<=\b[21]\b).*?(?=\|)").ToString().Trim();
							string h2 = Regex.Match(readData[i+1], @"(?<=\b[21]\b).*?(?=\|)").ToString().Trim();
							
							if (h1.Count() <= 0 || h1 == String.Empty)
								h1 = "|";
							
							if (h2.Count() <= 0 || h2 == String.Empty)
								h2 = "|";
							
							var row = new string[] {name, km, velocity, desc, h1.Replace(".", ":"), h2.Replace(".", ":"), track};
							dataGridView1.Rows.Add(row);
						}
					}
				}
				
				int lastRow = dataGridView1.Rows.Count - 2;
				if (dataGridView1.Rows[0].Cells["stationName"].Value.ToString() == firstStationName && dataGridView1.Rows[lastRow].Cells["stationName"].Value.ToString() == lastStationName)
				{
					autoStations.Checked = true;
				} else {
					firstStation.Text = firstStationName;
					lastStation.Text = lastStationName;
				}
			}
		}
		
		
		/*void SceneryListSelectedIndexChanged(object sender, EventArgs e)
		{
			if (sceneryList.SelectedIndex > -1 && sceneryList.SelectedIndex != lastIndex)
			{
				string scn = sceneryList.SelectedItem.ToString();
				
				speeds.Clear();
				
				using (TextFieldParser parser = new TextFieldParser(AppContext.BaseDirectory + @"\sceneryData\" + scn + ".rjd"))
				{
				    parser.TextFieldType = FieldType.Delimited;
				    parser.SetDelimiters(",");
				    while (!parser.EndOfData)
				    {
				        string[] fields = parser.ReadFields();
				        foreach (string field in fields)
				        {
				            //MessageBox.Show(field, "d");
				            string[] data = field.Split(',');
				            speeds.Add(data[0], data[1]);
				        }
				    }
				}
				
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					var name = row.Cells["stationName"].Value;
					
					if (name != null)
					{
						string nameStr = name.ToString();
						
						if (speeds.ContainsKey(nameStr))
						{
							var vmax = Convert.ToInt32(row.Cells["vmax"].Value);
							
							if (vmax > Convert.ToInt32(speeds[nameStr]))
							{
								row.Cells["vmax"].Value = speeds[nameStr];
							}
						}
					}
				}
				
				//lastIndex = sceneryList.SelectedIndex;
			}
		}*/
	}
}
