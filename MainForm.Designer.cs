/*
 * Created by SharpDevelop.
 * User: wikajustyna
 * Date: 10.10.2021
 * Time: 17:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rjgen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.stationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.radioChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hour1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hour2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tracksNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brakeMass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.trainID = new System.Windows.Forms.TextBox();
			this.trainName = new System.Windows.Forms.TextBox();
			this.firstStation = new System.Windows.Forms.TextBox();
			this.autoStations = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.trainType = new System.Windows.Forms.TextBox();
			this.trainCategory = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.lastStation = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Location = new System.Drawing.Point(1081, 378);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Author: Tor424";
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 3;
			this.columnHeader4.Text = "Godzina przyjazdu";
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 4;
			this.columnHeader5.Text = "Godzina odjazdu";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.plikToolStripMenuItem,
									this.pomocToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1195, 28);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// plikToolStripMenuItem
			// 
			this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.otwórzToolStripMenuItem,
									this.zapiszToolStripMenuItem});
			this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
			this.plikToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.plikToolStripMenuItem.Text = "&Plik";
			// 
			// otwórzToolStripMenuItem
			// 
			this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
			this.otwórzToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
			this.otwórzToolStripMenuItem.Text = "&Otwórz";
			// 
			// zapiszToolStripMenuItem
			// 
			this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
			this.zapiszToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
			this.zapiszToolStripMenuItem.Text = "Zapisz";
			this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.ZapiszToolStripMenuItemClick);
			// 
			// pomocToolStripMenuItem
			// 
			this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.oProgramieToolStripMenuItem});
			this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
			this.pomocToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
			this.pomocToolStripMenuItem.Text = "Pomoc";
			// 
			// oProgramieToolStripMenuItem
			// 
			this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
			this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.oProgramieToolStripMenuItem.Text = "O programie";
			this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.OProgramieToolStripMenuItemClick);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(706, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Podgląd rozkładu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.stationName,
									this.km,
									this.vmax,
									this.radioChannel,
									this.hour1,
									this.hour2,
									this.tracksNumber});
			this.dataGridView1.Location = new System.Drawing.Point(0, 46);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(706, 347);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellEndEdit);
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellValueChanged);
			// 
			// stationName
			// 
			this.stationName.HeaderText = "Nazwa stacji";
			this.stationName.Name = "stationName";
			// 
			// km
			// 
			this.km.HeaderText = "KM";
			this.km.Name = "km";
			// 
			// vmax
			// 
			this.vmax.HeaderText = "VMax";
			this.vmax.Name = "vmax";
			// 
			// radioChannel
			// 
			this.radioChannel.HeaderText = "Opis stacji";
			this.radioChannel.Name = "radioChannel";
			this.radioChannel.ToolTipText = "Kanał radiowy, skróty posterunków, pole postoju";
			// 
			// hour1
			// 
			this.hour1.HeaderText = "Godzina przyjazdu";
			this.hour1.Name = "hour1";
			// 
			// hour2
			// 
			this.hour2.HeaderText = "Godzina odjazdu";
			this.hour2.Name = "hour2";
			// 
			// tracksNumber
			// 
			this.tracksNumber.HeaderText = "Torowość stacji";
			this.tracksNumber.Name = "tracksNumber";
			this.tracksNumber.Visible = false;
			// 
			// brakeMass
			// 
			this.brakeMass.Location = new System.Drawing.Point(986, 307);
			this.brakeMass.Name = "brakeMass";
			this.brakeMass.Size = new System.Drawing.Size(197, 22);
			this.brakeMass.TabIndex = 9;
			this.brakeMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BrakeMassKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(721, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(197, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Rodzaj i numer pociągu";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(973, 283);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(229, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "Wymagany % ciężaru hamującego";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label13.Location = new System.Drawing.Point(712, 204);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(483, 32);
			this.label13.TabIndex = 32;
			this.label13.Text = "Informacje o składzie";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trainID
			// 
			this.trainID.Location = new System.Drawing.Point(721, 258);
			this.trainID.Name = "trainID";
			this.trainID.Size = new System.Drawing.Size(197, 22);
			this.trainID.TabIndex = 6;
			// 
			// trainName
			// 
			this.trainName.Location = new System.Drawing.Point(986, 258);
			this.trainName.Name = "trainName";
			this.trainName.Size = new System.Drawing.Size(197, 22);
			this.trainName.TabIndex = 8;
			// 
			// firstStation
			// 
			this.firstStation.Location = new System.Drawing.Point(972, 94);
			this.firstStation.Name = "firstStation";
			this.firstStation.Size = new System.Drawing.Size(197, 22);
			this.firstStation.TabIndex = 3;
			// 
			// autoStations
			// 
			this.autoStations.Location = new System.Drawing.Point(963, 173);
			this.autoStations.Name = "autoStations";
			this.autoStations.Size = new System.Drawing.Size(232, 21);
			this.autoStations.TabIndex = 5;
			this.autoStations.Text = "Pobierz na podstawie rozkładu";
			this.autoStations.UseVisualStyleBackColor = true;
			this.autoStations.CheckedChanged += new System.EventHandler(this.AutoStationsCheckedChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(973, 119);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(196, 21);
			this.label10.TabIndex = 28;
			this.label10.Text = "Stacja końcowa";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trainType
			// 
			this.trainType.Location = new System.Drawing.Point(721, 307);
			this.trainType.Name = "trainType";
			this.trainType.Size = new System.Drawing.Size(197, 22);
			this.trainType.TabIndex = 7;
			// 
			// trainCategory
			// 
			this.trainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.trainCategory.FormattingEnabled = true;
			this.trainCategory.Items.AddRange(new object[] {
									"R",
									"RP",
									"iR",
									"sR",
									"Os",
									"OsP",
									"P",
									"EIP",
									"EIC",
									"IC",
									"TLK",
									"Ł",
									"ŁP",
									"ŁS"});
			this.trainCategory.Location = new System.Drawing.Point(852, 356);
			this.trainCategory.Name = "trainCategory";
			this.trainCategory.Size = new System.Drawing.Size(197, 24);
			this.trainCategory.TabIndex = 10;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.Location = new System.Drawing.Point(940, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(255, 32);
			this.label12.TabIndex = 31;
			this.label12.Text = "Relacja pociągu";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(852, 332);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(197, 21);
			this.label5.TabIndex = 18;
			this.label5.Text = "Kategoria pociągu";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(972, 70);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(197, 21);
			this.label9.TabIndex = 26;
			this.label9.Text = "Stacja początkowa";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(730, 94);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(188, 33);
			this.button2.TabIndex = 1;
			this.button2.Text = "Usuń wybraną stację/po";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(730, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Dodaj stacje/po";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(986, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(197, 21);
			this.label6.TabIndex = 20;
			this.label6.Text = "Nazwa pociągu";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lastStation
			// 
			this.lastStation.Location = new System.Drawing.Point(972, 145);
			this.lastStation.Name = "lastStation";
			this.lastStation.Size = new System.Drawing.Size(197, 22);
			this.lastStation.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(730, 147);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(188, 33);
			this.button3.TabIndex = 2;
			this.button3.Text = "Wyczyść rozkład";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(712, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(513, 21);
			this.label4.TabIndex = 17;
			this.label4.Text = "________________________________________________________________";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(721, 283);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(206, 21);
			this.label8.TabIndex = 24;
			this.label8.Text = "Seria i obciążenie lokomotywy";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(940, 28);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(17, 166);
			this.label11.TabIndex = 30;
			this.label11.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1195, 404);
			this.Controls.Add(this.autoStations);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lastStation);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.firstStation);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.trainType);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.brakeMass);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.trainName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.trainCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.trainID);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generator rozkładów jazdy MaSzyna";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn tracksNumber;
		private System.Windows.Forms.CheckBox autoStations;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox firstStation;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox trainType;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox brakeMass;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox trainName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox trainCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn km;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn hour2;
		private System.Windows.Forms.DataGridViewTextBoxColumn hour1;
		private System.Windows.Forms.DataGridViewTextBoxColumn radioChannel;
		private System.Windows.Forms.DataGridViewTextBoxColumn vmax;
		private System.Windows.Forms.DataGridViewTextBoxColumn stationName;
		protected internal System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lastStation;
		private System.Windows.Forms.TextBox trainID;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
