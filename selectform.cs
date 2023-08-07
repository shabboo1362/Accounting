using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for selectform.
	/// </summary>
	public class selectform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox orderbox;
		private System.Windows.Forms.RadioButton numberorderrb;
		private System.Windows.Forms.RadioButton dateorderrb;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox limitbox;
		private System.Windows.Forms.RadioButton allrb;
		private System.Windows.Forms.RadioButton numberrb;
		private System.Windows.Forms.RadioButton daterb;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tonumbertxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox fromnumbertxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox typebox;
		private System.Windows.Forms.RadioButton temporarirb;
		private System.Windows.Forms.RadioButton constantrb;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Button cancelcmd;
		private string str1="",limit="all",fdate1="",tdate1="",fnumber="",tnumber="",document="temporary",sort="number";
		private System.Windows.Forms.ComboBox tcomboDays;
		private System.Windows.Forms.TextBox ttxtSetYear;
		private System.Windows.Forms.ComboBox tcomboMonth;
		private System.Windows.Forms.ComboBox comboDays;
		private System.Windows.Forms.TextBox txtSetYear;
		private System.Windows.Forms.ComboBox comboMonth;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public selectform(string str)
		{
			str1=str;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			Persia.SunDate sunDate = Persia.Calendar.ConvertToPersian(DateTime.Now);
			txtSetYear.Text = Persia.Number.ConvertToPersian(sunDate.ArrayType[0]);
			comboMonth.SelectedIndex = sunDate.ArrayType[1]-1;
			comboDays.SelectedIndex  = sunDate.ArrayType[2]-1;
			ttxtSetYear.Text = Persia.Number.ConvertToPersian(sunDate.ArrayType[0]);
			tcomboMonth.SelectedIndex = sunDate.ArrayType[1]-1;
			tcomboDays.SelectedIndex  = sunDate.ArrayType[2]-1;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.orderbox = new System.Windows.Forms.GroupBox();
			this.numberorderrb = new System.Windows.Forms.RadioButton();
			this.dateorderrb = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tcomboDays = new System.Windows.Forms.ComboBox();
			this.ttxtSetYear = new System.Windows.Forms.TextBox();
			this.tcomboMonth = new System.Windows.Forms.ComboBox();
			this.comboDays = new System.Windows.Forms.ComboBox();
			this.txtSetYear = new System.Windows.Forms.TextBox();
			this.comboMonth = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.limitbox = new System.Windows.Forms.GroupBox();
			this.allrb = new System.Windows.Forms.RadioButton();
			this.numberrb = new System.Windows.Forms.RadioButton();
			this.daterb = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tonumbertxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.fromnumbertxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.typebox = new System.Windows.Forms.GroupBox();
			this.temporarirb = new System.Windows.Forms.RadioButton();
			this.constantrb = new System.Windows.Forms.RadioButton();
			this.submitcmd = new System.Windows.Forms.Button();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.orderbox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.limitbox.SuspendLayout();
			this.panel3.SuspendLayout();
			this.typebox.SuspendLayout();
			this.SuspendLayout();
			// 
			// orderbox
			// 
			this.orderbox.Controls.Add(this.numberorderrb);
			this.orderbox.Controls.Add(this.dateorderrb);
			this.orderbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.orderbox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.orderbox.Location = new System.Drawing.Point(32, 272);
			this.orderbox.Name = "orderbox";
			this.orderbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.orderbox.Size = new System.Drawing.Size(552, 56);
			this.orderbox.TabIndex = 12;
			this.orderbox.TabStop = false;
			this.orderbox.Text = "‰ÕÊÂ „— » ”«“Ì";
			// 
			// numberorderrb
			// 
			this.numberorderrb.Checked = true;
			this.numberorderrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.numberorderrb.Location = new System.Drawing.Point(360, 24);
			this.numberorderrb.Name = "numberorderrb";
			this.numberorderrb.Size = new System.Drawing.Size(184, 24);
			this.numberorderrb.TabIndex = 1;
			this.numberorderrb.TabStop = true;
			this.numberorderrb.Text = "„— » ”«“Ì »— «”«” ‘„«—Â «”‰«œ";
			this.numberorderrb.CheckedChanged += new System.EventHandler(this.numberorderrb_CheckedChanged);
			// 
			// dateorderrb
			// 
			this.dateorderrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.dateorderrb.Location = new System.Drawing.Point(80, 24);
			this.dateorderrb.Name = "dateorderrb";
			this.dateorderrb.Size = new System.Drawing.Size(176, 24);
			this.dateorderrb.TabIndex = 0;
			this.dateorderrb.Text = "„— » ”«“Ì »— «”«”  «—ÌŒ «”‰«œ";
			this.dateorderrb.CheckedChanged += new System.EventHandler(this.dateorderrb_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.tcomboDays);
			this.panel2.Controls.Add(this.ttxtSetYear);
			this.panel2.Controls.Add(this.tcomboMonth);
			this.panel2.Controls.Add(this.comboDays);
			this.panel2.Controls.Add(this.txtSetYear);
			this.panel2.Controls.Add(this.comboMonth);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(8, 200);
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel2.Size = new System.Drawing.Size(376, 64);
			this.panel2.TabIndex = 9;
			this.panel2.Visible = false;
			// 
			// tcomboDays
			// 
			this.tcomboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tcomboDays.DropDownWidth = 40;
			this.tcomboDays.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.tcomboDays.ItemHeight = 13;
			this.tcomboDays.Items.AddRange(new object[] {
															"1",
															"2",
															"3",
															"4",
															"5",
															"6",
															"7",
															"8",
															"9",
															"10",
															"11",
															"12",
															"13",
															"14",
															"15",
															"16",
															"17",
															"18",
															"19",
															"20",
															"21",
															"22",
															"23",
															"24",
															"25",
															"26",
															"27",
															"28",
															"29",
															"30",
															"31"});
			this.tcomboDays.Location = new System.Drawing.Point(238, 36);
			this.tcomboDays.Name = "tcomboDays";
			this.tcomboDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tcomboDays.Size = new System.Drawing.Size(40, 21);
			this.tcomboDays.TabIndex = 38;
			// 
			// ttxtSetYear
			// 
			this.ttxtSetYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.ttxtSetYear.Location = new System.Drawing.Point(94, 36);
			this.ttxtSetYear.Name = "ttxtSetYear";
			this.ttxtSetYear.Size = new System.Drawing.Size(48, 21);
			this.ttxtSetYear.TabIndex = 37;
			this.ttxtSetYear.Text = "";
			// 
			// tcomboMonth
			// 
			this.tcomboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tcomboMonth.DropDownWidth = 80;
			this.tcomboMonth.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.tcomboMonth.ItemHeight = 13;
			this.tcomboMonth.Items.AddRange(new object[] {
															 "›—Ê—œÌ‰",
															 "«—œÌ»Â‘ ",
															 "Œ—œ«œ",
															 " Ì—",
															 "„—œ«œ",
															 "‘Â—ÌÊ—",
															 "„Â—",
															 "¬»«‰",
															 "¬–—",
															 "œÌ",
															 "»Â„‰",
															 "«”›‰œ"});
			this.tcomboMonth.Location = new System.Drawing.Point(150, 36);
			this.tcomboMonth.Name = "tcomboMonth";
			this.tcomboMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tcomboMonth.Size = new System.Drawing.Size(80, 21);
			this.tcomboMonth.TabIndex = 36;
			// 
			// comboDays
			// 
			this.comboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDays.DropDownWidth = 40;
			this.comboDays.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.comboDays.ItemHeight = 13;
			this.comboDays.Items.AddRange(new object[] {
														   "1",
														   "2",
														   "3",
														   "4",
														   "5",
														   "6",
														   "7",
														   "8",
														   "9",
														   "10",
														   "11",
														   "12",
														   "13",
														   "14",
														   "15",
														   "16",
														   "17",
														   "18",
														   "19",
														   "20",
														   "21",
														   "22",
														   "23",
														   "24",
														   "25",
														   "26",
														   "27",
														   "28",
														   "29",
														   "30",
														   "31"});
			this.comboDays.Location = new System.Drawing.Point(238, 4);
			this.comboDays.Name = "comboDays";
			this.comboDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboDays.Size = new System.Drawing.Size(40, 21);
			this.comboDays.TabIndex = 35;
			// 
			// txtSetYear
			// 
			this.txtSetYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.txtSetYear.Location = new System.Drawing.Point(94, 4);
			this.txtSetYear.Name = "txtSetYear";
			this.txtSetYear.Size = new System.Drawing.Size(48, 21);
			this.txtSetYear.TabIndex = 34;
			this.txtSetYear.Text = "";
			// 
			// comboMonth
			// 
			this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboMonth.DropDownWidth = 80;
			this.comboMonth.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.comboMonth.ItemHeight = 13;
			this.comboMonth.Items.AddRange(new object[] {
															"›—Ê—œÌ‰",
															"«—œÌ»Â‘ ",
															"Œ—œ«œ",
															" Ì—",
															"„—œ«œ",
															"‘Â—ÌÊ—",
															"„Â—",
															"¬»«‰",
															"¬–—",
															"œÌ",
															"»Â„‰",
															"«”›‰œ"});
			this.comboMonth.Location = new System.Drawing.Point(150, 4);
			this.comboMonth.Name = "comboMonth";
			this.comboMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboMonth.Size = new System.Drawing.Size(80, 21);
			this.comboMonth.TabIndex = 33;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(312, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "«“  «—ÌŒ:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(312, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = " «  «—ÌŒ:";
			// 
			// limitbox
			// 
			this.limitbox.Controls.Add(this.allrb);
			this.limitbox.Controls.Add(this.numberrb);
			this.limitbox.Controls.Add(this.daterb);
			this.limitbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.limitbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.limitbox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.limitbox.Location = new System.Drawing.Point(392, 112);
			this.limitbox.Name = "limitbox";
			this.limitbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.limitbox.Size = new System.Drawing.Size(200, 120);
			this.limitbox.TabIndex = 8;
			this.limitbox.TabStop = false;
			this.limitbox.Text = " ⁄ÌÌ‰ „ÕœÊœÂ";
			// 
			// allrb
			// 
			this.allrb.Checked = true;
			this.allrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.allrb.Location = new System.Drawing.Point(88, 24);
			this.allrb.Name = "allrb";
			this.allrb.TabIndex = 2;
			this.allrb.TabStop = true;
			this.allrb.Text = "Â„Â «”‰«œ";
			this.allrb.CheckedChanged += new System.EventHandler(this.allrb_CheckedChanged);
			// 
			// numberrb
			// 
			this.numberrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.numberrb.Location = new System.Drawing.Point(88, 56);
			this.numberrb.Name = "numberrb";
			this.numberrb.TabIndex = 1;
			this.numberrb.Text = "»— Õ”» ‘„«—Â";
			this.numberrb.CheckedChanged += new System.EventHandler(this.numberrb_CheckedChanged);
			// 
			// daterb
			// 
			this.daterb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.daterb.Location = new System.Drawing.Point(88, 88);
			this.daterb.Name = "daterb";
			this.daterb.TabIndex = 0;
			this.daterb.Text = "»— Õ”»  «—ÌŒ";
			this.daterb.CheckedChanged += new System.EventHandler(this.daterb_CheckedChanged);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.tonumbertxt);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.fromnumbertxt);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(16, 160);
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel3.Size = new System.Drawing.Size(368, 32);
			this.panel3.TabIndex = 10;
			this.panel3.Visible = false;
			// 
			// tonumbertxt
			// 
			this.tonumbertxt.Location = new System.Drawing.Point(16, 0);
			this.tonumbertxt.Name = "tonumbertxt";
			this.tonumbertxt.Size = new System.Drawing.Size(110, 20);
			this.tonumbertxt.TabIndex = 7;
			this.tonumbertxt.Text = "1";
			this.tonumbertxt.TextChanged += new System.EventHandler(this.tonumbertxt_TextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(136, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = " « ‘„«—Â:";
			// 
			// fromnumbertxt
			// 
			this.fromnumbertxt.Location = new System.Drawing.Point(200, 3);
			this.fromnumbertxt.Name = "fromnumbertxt";
			this.fromnumbertxt.Size = new System.Drawing.Size(110, 20);
			this.fromnumbertxt.TabIndex = 5;
			this.fromnumbertxt.Text = "1";
			this.fromnumbertxt.TextChanged += new System.EventHandler(this.fromnumbertxt_TextChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label5.ForeColor = System.Drawing.Color.Crimson;
			this.label5.Location = new System.Drawing.Point(312, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "«“ ‘„«—Â:";
			// 
			// typebox
			// 
			this.typebox.Controls.Add(this.temporarirb);
			this.typebox.Controls.Add(this.constantrb);
			this.typebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.typebox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.typebox.Location = new System.Drawing.Point(384, 16);
			this.typebox.Name = "typebox";
			this.typebox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.typebox.Size = new System.Drawing.Size(200, 80);
			this.typebox.TabIndex = 11;
			this.typebox.TabStop = false;
			this.typebox.Text = "‰Ê⁄ ”‰œ";
			// 
			// temporarirb
			// 
			this.temporarirb.Checked = true;
			this.temporarirb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.temporarirb.Location = new System.Drawing.Point(88, 48);
			this.temporarirb.Name = "temporarirb";
			this.temporarirb.TabIndex = 1;
			this.temporarirb.TabStop = true;
			this.temporarirb.Text = "”‰œ „Êﬁ ";
			this.temporarirb.CheckedChanged += new System.EventHandler(this.temporarirb_CheckedChanged);
			// 
			// constantrb
			// 
			this.constantrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.constantrb.Location = new System.Drawing.Point(88, 16);
			this.constantrb.Name = "constantrb";
			this.constantrb.TabIndex = 0;
			this.constantrb.Text = "”‰œ œ«∆„";
			this.constantrb.CheckedChanged += new System.EventHandler(this.constantrb_CheckedChanged);
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(336, 344);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.TabIndex = 13;
			this.submitcmd.Text = " «ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(200, 344);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.TabIndex = 14;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// selectform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 382);
			this.Controls.Add(this.cancelcmd);
			this.Controls.Add(this.submitcmd);
			this.Controls.Add(this.orderbox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.limitbox);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.typebox);
			this.Name = "selectform";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Load += new System.EventHandler(this.selectform_Load);
			this.TextChanged += new System.EventHandler(this.fdate);
			this.orderbox.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.limitbox.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.typebox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void selectform_Load(object sender, System.EventArgs e)
		{
			switch (str1)
			{
				case "ra":
					this.Text="ê“«—‘ —Ì“ «”‰«œ";
					break;
				case "ght1":
					this.Text="ê“«—‘ ò·ÌÂ Õ”«» Â«Ì  ›’Ì·Ì1";
					break;
				case "ght2":
					this.Text=" ê“«—‘ ò·ÌÂ Õ”«» Â«Ì  ›’Ì·Ì2";
					break;
				case "ght3":
					this.Text=" ê“«—‘ ò·ÌÂ Õ”«» Â«Ì  ›’Ì·Ì3";
					break;
				case "tak":
					this.Text="  —«“ ¬“„«Ì‘Ì Õ”«» Â«Ì ò·";
					break;
				case "tam":
					this.Text="  —«“ ¬“„«Ì‘Ì Õ”«» Â«Ì „⁄Ì‰";
					break;
			}
		}

		private void constantrb_CheckedChanged(object sender, System.EventArgs e)
		{
			document="constant";
		}

		private void temporarirb_CheckedChanged(object sender, System.EventArgs e)
		{
			document="temporary";
		}

		private void allrb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=false;
			panel3.Visible=false;
			limit="all";
		}

		private void numberrb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=false;
			panel3.Visible=true;
			limit="number";
			fromnumbertxt.Focus();
			fnumber=fromnumbertxt.Text;
			tnumber=tonumbertxt.Text;
		}

		private void daterb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=true;
			panel3.Visible=false;
			limit="date";
		}

		private void numberorderrb_CheckedChanged(object sender, System.EventArgs e)
		{
			sort="number";
		}

		private void dateorderrb_CheckedChanged(object sender, System.EventArgs e)
		{
			sort="Date";
		}

		private void cancelcmd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			if(daterb.Checked==true)
			{
				tdate(null,null);
				fdate(null,null);
			}
			allreport form=new allreport(str1,limit,fdate1,tdate1,fnumber,tnumber,document,sort);
			form.ShowDialog();
		}

		private void fromnumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			fnumber=fromnumbertxt.Text;
		}

		private void tonumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			tnumber=tonumbertxt.Text;
		}

		private void fdate(object sender, System.EventArgs e)
		{
			int year  = int.Parse(Persia.Number.ConvertToLatin(txtSetYear.Text));
			int month = comboMonth.SelectedIndex + 1;
			int day   = comboDays.SelectedIndex + 1;
			fdate1=Persia.Calendar.ConvertToGregorian(year, month, day).ToShortDateString().ToString();
		}

		private void tdate(object sender, System.EventArgs e)
		{
			int year  = int.Parse(Persia.Number.ConvertToLatin(ttxtSetYear.Text));
			int month = tcomboMonth.SelectedIndex + 1;
			int day   = tcomboDays.SelectedIndex + 1;
			tdate1=Persia.Calendar.ConvertToGregorian(year, month, day).ToShortDateString().ToString();
		}
	}
}
