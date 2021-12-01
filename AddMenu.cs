/*
 * Created by SharpDevelop.
 * User: wikajustyna
 * Date: 10.10.2021
 * Time: 18:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace rjgen
{
	public partial class AddMenu : Form
	{
		public MainForm frm;
		
		public AddMenu()
		{
			InitializeComponent();
		}
		
		private void Button1Click(object sender, EventArgs e)
		{	
			if (stationNum.SelectedIndex == -1)
			{
				MessageBox.Show("Należy uzupełnić wszystkie parametry stacji", "Informacja", MessageBoxButtons.OK);
				return;
			}
			
			foreach (Control c in this.Controls)
			{
			    if (c is TextBox)
			    {
			        TextBox textBox = c as TextBox;
			        if (!(textBox == stationRadio || textBox == stationPO || textBox == stationPlace) && textBox.Text == string.Empty)
			        {
			        	MessageBox.Show("Należy uzupełnić wszystkie parametry stacji", "Informacja", MessageBoxButtons.OK);
			        	return;
			        }
			    }
			}
			
			//var row = new string[] {stationName.Text, textBox6.Text, stationKM.Text, textBox3.Text, textBox4.Text.Replace(".",":"), textBox5.Text.Replace(".",":")};
			string stationDesc = stationRadio.Text;
			
			if (stationPO.Text.Length > 0)
			{
				string sep = ",";
				
				if (stationDesc.Length <= 0)
					sep = "";
				
				stationDesc = stationDesc + sep + stationPO.Text;
			}
			
			if (stationPlace.Text.Length > 0)
			{
				string sep = ",";
				
				if (stationDesc.Length <= 0)
					sep = "";
				
				stationDesc = stationDesc + sep + stationPlace.Text;
			}
			
			string hour1 = stationHour1_H.Text + ":" + stationHour1_M.Text;
			string hour2 = stationHour2_H.Text + ":" + stationHour2_M.Text;
			
			if (hour1.Replace(":","").Replace(".","") == "00")
				hour1 = "|";
			
			if (hour2.Replace(":","").Replace(".","") == "00")
				hour2 = "|";
			
			string trackNumbers = stationNum.SelectedItem.ToString();
			
			if (trackNumbers == "Jednotorowy (1)") {
				trackNumbers = "1";
			} else {
				if (trackNumbers == "Wielotorowy (2)") {
					trackNumbers = "2";
				}
			}
			
			var row = new string[] {stationName.Text, stationKM.Text, stationVelocity.Text, stationDesc, hour1.Replace(".",":"), hour2.Replace(".",":"), trackNumbers};
			frm.dataGridView1.Rows.Add(row);
		}
		
		private void StationHour1_HKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		
		private void StationHour1_MKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.'))
			{
				e.Handled = true;
			}
		}
		
		private void StationHour2_HKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		
		private void StationHour2_MKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.'))
			{
				e.Handled = true;
			}
		}
		
		
		private void StationVelocityKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.'))
			{
				e.Handled = true;
			}
		}
		
		private void StationKMKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.'))
			{
				e.Handled = true;
			}
		}
	}
}
