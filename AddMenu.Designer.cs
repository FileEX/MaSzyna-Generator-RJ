/*
 * Created by SharpDevelop.
 * User: wikajustyna
 * Date: 10.10.2021
 * Time: 18:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rjgen
{
	partial class AddMenu
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
			this.label1 = new System.Windows.Forms.Label();
			this.stationName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.stationKM = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.stationVelocity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.stationRadio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.stationPO = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.stationPlace = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.stationNum = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.stationHour1_H = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.stationHour1_M = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.stationHour2_M = new System.Windows.Forms.TextBox();
			this.stationHour2_H = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nazwa stacji";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationName
			// 
			this.stationName.Location = new System.Drawing.Point(8, 69);
			this.stationName.Name = "stationName";
			this.stationName.Size = new System.Drawing.Size(163, 22);
			this.stationName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kilometraż";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationKM
			// 
			this.stationKM.Location = new System.Drawing.Point(8, 116);
			this.stationKM.Name = "stationKM";
			this.stationKM.Size = new System.Drawing.Size(163, 22);
			this.stationKM.TabIndex = 3;
			this.stationKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationKMKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Prędkość rozkładowa";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationVelocity
			// 
			this.stationVelocity.Location = new System.Drawing.Point(12, 163);
			this.stationVelocity.Name = "stationVelocity";
			this.stationVelocity.Size = new System.Drawing.Size(163, 22);
			this.stationVelocity.TabIndex = 5;
			this.stationVelocity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationVelocityKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(196, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Kanał radiowy";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationRadio
			// 
			this.stationRadio.Location = new System.Drawing.Point(196, 69);
			this.stationRadio.Name = "stationRadio";
			this.stationRadio.Size = new System.Drawing.Size(163, 22);
			this.stationRadio.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(196, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "Skróty posterunku";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationPO
			// 
			this.stationPO.Location = new System.Drawing.Point(196, 116);
			this.stationPO.Name = "stationPO";
			this.stationPO.Size = new System.Drawing.Size(163, 22);
			this.stationPO.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(196, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 19);
			this.label6.TabIndex = 10;
			this.label6.Text = "Oznaczenie postoju";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationPlace
			// 
			this.stationPlace.Location = new System.Drawing.Point(196, 163);
			this.stationPlace.Name = "stationPlace";
			this.stationPlace.Size = new System.Drawing.Size(163, 22);
			this.stationPlace.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(381, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "Torowść szlaku";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stationNum
			// 
			this.stationNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stationNum.FormattingEnabled = true;
			this.stationNum.Items.AddRange(new object[] {
									"Jednotorowy (1)",
									"Wielotorowy (2)"});
			this.stationNum.Location = new System.Drawing.Point(381, 67);
			this.stationNum.Name = "stationNum";
			this.stationNum.Size = new System.Drawing.Size(169, 24);
			this.stationNum.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(401, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Godzina przyjazdu";
			// 
			// stationHour1_H
			// 
			this.stationHour1_H.Location = new System.Drawing.Point(422, 116);
			this.stationHour1_H.Name = "stationHour1_H";
			this.stationHour1_H.Size = new System.Drawing.Size(28, 22);
			this.stationHour1_H.TabIndex = 15;
			this.stationHour1_H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationHour1_HKeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(401, 142);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(126, 19);
			this.label9.TabIndex = 17;
			this.label9.Text = "Godzina odjazdu";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.Location = new System.Drawing.Point(-1, 5);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(578, 31);
			this.label10.TabIndex = 18;
			this.label10.Text = "Parametry stacji";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(196, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(172, 26);
			this.button1.TabIndex = 20;
			this.button1.Text = "Dodaj";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// stationHour1_M
			// 
			this.stationHour1_M.Location = new System.Drawing.Point(476, 116);
			this.stationHour1_M.Name = "stationHour1_M";
			this.stationHour1_M.Size = new System.Drawing.Size(28, 22);
			this.stationHour1_M.TabIndex = 16;
			this.stationHour1_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationHour1_MKeyPress);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(456, 116);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(14, 22);
			this.label11.TabIndex = 21;
			this.label11.Text = ":";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.Location = new System.Drawing.Point(456, 164);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(14, 22);
			this.label12.TabIndex = 24;
			this.label12.Text = ":";
			// 
			// stationHour2_M
			// 
			this.stationHour2_M.Location = new System.Drawing.Point(476, 164);
			this.stationHour2_M.Name = "stationHour2_M";
			this.stationHour2_M.Size = new System.Drawing.Size(28, 22);
			this.stationHour2_M.TabIndex = 19;
			this.stationHour2_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationHour2_MKeyPress);
			// 
			// stationHour2_H
			// 
			this.stationHour2_H.Location = new System.Drawing.Point(422, 164);
			this.stationHour2_H.Name = "stationHour2_H";
			this.stationHour2_H.Size = new System.Drawing.Size(28, 22);
			this.stationHour2_H.TabIndex = 18;
			this.stationHour2_H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationHour2_HKeyPress);
			// 
			// AddMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 233);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.stationHour2_M);
			this.Controls.Add(this.stationHour2_H);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.stationHour1_M);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.stationHour1_H);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.stationNum);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.stationPlace);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.stationPO);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.stationRadio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.stationVelocity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.stationKM);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.stationName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dodaj stację";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox stationHour2_H;
		private System.Windows.Forms.TextBox stationHour2_M;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox stationHour1_M;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox stationHour1_H;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox stationNum;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox stationPlace;
		private System.Windows.Forms.TextBox stationPO;
		private System.Windows.Forms.TextBox stationRadio;
		private System.Windows.Forms.TextBox stationVelocity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox stationKM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox stationName;
	}
}
