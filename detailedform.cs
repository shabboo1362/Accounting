using System;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;

namespace Accounting
{
	/// <summary>
	/// Summary description for detailedform.
	/// </summary>
	public class detailedform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox detailedcodetxt;
		private System.Windows.Forms.GroupBox limitbox;
		private System.Windows.Forms.RadioButton daterb;
		private System.Windows.Forms.RadioButton numberrb;
		private System.Windows.Forms.RadioButton allrb;
		private System.Windows.Forms.GroupBox codebox;
		private System.Windows.Forms.RadioButton allcaserb;
		private System.Windows.Forms.RadioButton subsidiaricoderb;
		private System.Windows.Forms.RadioButton generalcoderb;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tonumbertxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox fromnumbertxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton constantrb;
		private System.Windows.Forms.RadioButton temporarirb;
		private System.Windows.Forms.RadioButton dateorderrb;
		private System.Windows.Forms.RadioButton numberorderrb;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button subsidiarycmd;
		private System.Windows.Forms.TextBox subsidiarytxt;
		private System.Windows.Forms.TextBox generaltxt;
		private System.Windows.Forms.Button generalcmd;
		private System.Windows.Forms.Button detailedcodecmd;
		private System.Windows.Forms.GroupBox typebox;
		private System.Windows.Forms.GroupBox orderbox;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Button cancelcmd;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.DataGrid dataGrid1;
		private codebehind ob=new codebehind();
		private System.Windows.Forms.Button dcancelcmd;
		public System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		public System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		public System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private string table="";
		private string str="",limit="all",fcode="",fdate1="",tdate1="",fnumber="",tnumber="",scode="all",ncode="",document="temporary",sort="number";

		private void tdate(object sender, System.EventArgs e)
		{
			int year  = int.Parse(Persia.Number.ConvertToLatin(ttxtSetYear.Text));
			int month = tcomboMonth.SelectedIndex + 1;
			int day   = tcomboDays.SelectedIndex + 1;
			tdate1=Persia.Calendar.ConvertToGregorian(year, month, day).ToShortDateString().ToString();
		}
	
		private System.Windows.Forms.ComboBox comboDays;
		private System.Windows.Forms.TextBox txtSetYear;
		private System.Windows.Forms.ComboBox comboMonth;
		private System.Windows.Forms.ComboBox tcomboDays;
		private System.Windows.Forms.TextBox ttxtSetYear;
		private System.Windows.Forms.ComboBox tcomboMonth;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public detailedform()
		{
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.detailedcodetxt = new System.Windows.Forms.TextBox();
			this.detailedcodecmd = new System.Windows.Forms.Button();
			this.limitbox = new System.Windows.Forms.GroupBox();
			this.allrb = new System.Windows.Forms.RadioButton();
			this.numberrb = new System.Windows.Forms.RadioButton();
			this.daterb = new System.Windows.Forms.RadioButton();
			this.codebox = new System.Windows.Forms.GroupBox();
			this.generalcoderb = new System.Windows.Forms.RadioButton();
			this.subsidiaricoderb = new System.Windows.Forms.RadioButton();
			this.allcaserb = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tcomboDays = new System.Windows.Forms.ComboBox();
			this.ttxtSetYear = new System.Windows.Forms.TextBox();
			this.tcomboMonth = new System.Windows.Forms.ComboBox();
			this.comboDays = new System.Windows.Forms.ComboBox();
			this.txtSetYear = new System.Windows.Forms.TextBox();
			this.comboMonth = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tonumbertxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.fromnumbertxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.typebox = new System.Windows.Forms.GroupBox();
			this.temporarirb = new System.Windows.Forms.RadioButton();
			this.constantrb = new System.Windows.Forms.RadioButton();
			this.orderbox = new System.Windows.Forms.GroupBox();
			this.numberorderrb = new System.Windows.Forms.RadioButton();
			this.dateorderrb = new System.Windows.Forms.RadioButton();
			this.submitcmd = new System.Windows.Forms.Button();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.subsidiarytxt = new System.Windows.Forms.TextBox();
			this.subsidiarycmd = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.generaltxt = new System.Windows.Forms.TextBox();
			this.generalcmd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dcancelcmd = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1.SuspendLayout();
			this.limitbox.SuspendLayout();
			this.codebox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.typebox.SuspendLayout();
			this.orderbox.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(184, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = ": ⁄ÌÌ‰ òœ Õ”«»  ›’Ì·Ì 1";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.detailedcodetxt);
			this.panel1.Controls.Add(this.detailedcodecmd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(256, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 35);
			this.panel1.TabIndex = 1;
			// 
			// detailedcodetxt
			// 
			this.detailedcodetxt.Location = new System.Drawing.Point(16, 0);
			this.detailedcodetxt.Name = "detailedcodetxt";
			this.detailedcodetxt.Size = new System.Drawing.Size(125, 23);
			this.detailedcodetxt.TabIndex = 2;
			this.detailedcodetxt.Text = "";
			this.detailedcodetxt.Validated += new System.EventHandler(this.detailedcodetxt_Validated);
			// 
			// detailedcodecmd
			// 
			this.detailedcodecmd.BackColor = System.Drawing.Color.Lavender;
			this.detailedcodecmd.CausesValidation = false;
			this.detailedcodecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.detailedcodecmd.Location = new System.Drawing.Point(144, 0);
			this.detailedcodecmd.Name = "detailedcodecmd";
			this.detailedcodecmd.Size = new System.Drawing.Size(30, 25);
			this.detailedcodecmd.TabIndex = 1;
			this.detailedcodecmd.Text = "...";
			this.detailedcodecmd.Click += new System.EventHandler(this.detailedcodecmd_Click);
			// 
			// limitbox
			// 
			this.limitbox.Controls.Add(this.allrb);
			this.limitbox.Controls.Add(this.numberrb);
			this.limitbox.Controls.Add(this.daterb);
			this.limitbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.limitbox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.limitbox.Location = new System.Drawing.Point(384, 56);
			this.limitbox.Name = "limitbox";
			this.limitbox.Size = new System.Drawing.Size(200, 120);
			this.limitbox.TabIndex = 2;
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
			// codebox
			// 
			this.codebox.Controls.Add(this.generalcoderb);
			this.codebox.Controls.Add(this.subsidiaricoderb);
			this.codebox.Controls.Add(this.allcaserb);
			this.codebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.codebox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.codebox.Location = new System.Drawing.Point(384, 200);
			this.codebox.Name = "codebox";
			this.codebox.Size = new System.Drawing.Size(200, 112);
			this.codebox.TabIndex = 3;
			this.codebox.TabStop = false;
			this.codebox.Text = " ⁄Ì‰ òœ ò· Ì« „⁄Ì‰";
			// 
			// generalcoderb
			// 
			this.generalcoderb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.generalcoderb.Location = new System.Drawing.Point(88, 80);
			this.generalcoderb.Name = "generalcoderb";
			this.generalcoderb.TabIndex = 2;
			this.generalcoderb.Text = "«‰ Œ«» òœ ò·";
			this.generalcoderb.CheckedChanged += new System.EventHandler(this.generalcoderb_CheckedChanged);
			// 
			// subsidiaricoderb
			// 
			this.subsidiaricoderb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.subsidiaricoderb.Location = new System.Drawing.Point(88, 48);
			this.subsidiaricoderb.Name = "subsidiaricoderb";
			this.subsidiaricoderb.TabIndex = 1;
			this.subsidiaricoderb.Text = "«‰ Œ«» òœ „⁄Ì‰";
			this.subsidiaricoderb.CheckedChanged += new System.EventHandler(this.subsidiaricoderb_CheckedChanged);
			// 
			// allcaserb
			// 
			this.allcaserb.Checked = true;
			this.allcaserb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.allcaserb.Location = new System.Drawing.Point(88, 16);
			this.allcaserb.Name = "allcaserb";
			this.allcaserb.TabIndex = 0;
			this.allcaserb.TabStop = true;
			this.allcaserb.Text = "Â„Â „Ê«—œ";
			this.allcaserb.CheckedChanged += new System.EventHandler(this.allcaserb_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.tcomboDays);
			this.panel2.Controls.Add(this.ttxtSetYear);
			this.panel2.Controls.Add(this.tcomboMonth);
			this.panel2.Controls.Add(this.comboDays);
			this.panel2.Controls.Add(this.txtSetYear);
			this.panel2.Controls.Add(this.comboMonth);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(0, 144);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 80);
			this.panel2.TabIndex = 4;
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
			this.tcomboDays.Location = new System.Drawing.Point(248, 32);
			this.tcomboDays.Name = "tcomboDays";
			this.tcomboDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tcomboDays.Size = new System.Drawing.Size(40, 21);
			this.tcomboDays.TabIndex = 26;
			// 
			// ttxtSetYear
			// 
			this.ttxtSetYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.ttxtSetYear.Location = new System.Drawing.Point(104, 32);
			this.ttxtSetYear.Name = "ttxtSetYear";
			this.ttxtSetYear.Size = new System.Drawing.Size(48, 21);
			this.ttxtSetYear.TabIndex = 25;
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
			this.tcomboMonth.Location = new System.Drawing.Point(160, 32);
			this.tcomboMonth.Name = "tcomboMonth";
			this.tcomboMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tcomboMonth.Size = new System.Drawing.Size(80, 21);
			this.tcomboMonth.TabIndex = 24;
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
			this.comboDays.Location = new System.Drawing.Point(248, 0);
			this.comboDays.Name = "comboDays";
			this.comboDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboDays.Size = new System.Drawing.Size(40, 21);
			this.comboDays.TabIndex = 23;
			// 
			// txtSetYear
			// 
			this.txtSetYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.txtSetYear.Location = new System.Drawing.Point(104, 0);
			this.txtSetYear.Name = "txtSetYear";
			this.txtSetYear.Size = new System.Drawing.Size(48, 21);
			this.txtSetYear.TabIndex = 22;
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
			this.comboMonth.Location = new System.Drawing.Point(160, 0);
			this.comboMonth.Name = "comboMonth";
			this.comboMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboMonth.Size = new System.Drawing.Size(80, 21);
			this.comboMonth.TabIndex = 21;
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
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.tonumbertxt);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.fromnumbertxt);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(8, 104);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(368, 80);
			this.panel3.TabIndex = 5;
			this.panel3.Visible = false;
			// 
			// tonumbertxt
			// 
			this.tonumbertxt.Location = new System.Drawing.Point(16, 0);
			this.tonumbertxt.Name = "tonumbertxt";
			this.tonumbertxt.Size = new System.Drawing.Size(110, 23);
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
			this.fromnumbertxt.Size = new System.Drawing.Size(110, 23);
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
			this.typebox.Location = new System.Drawing.Point(72, 328);
			this.typebox.Name = "typebox";
			this.typebox.Size = new System.Drawing.Size(200, 80);
			this.typebox.TabIndex = 6;
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
			// orderbox
			// 
			this.orderbox.Controls.Add(this.numberorderrb);
			this.orderbox.Controls.Add(this.dateorderrb);
			this.orderbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.orderbox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.orderbox.Location = new System.Drawing.Point(384, 328);
			this.orderbox.Name = "orderbox";
			this.orderbox.Size = new System.Drawing.Size(200, 80);
			this.orderbox.TabIndex = 7;
			this.orderbox.TabStop = false;
			this.orderbox.Text = "‰ÕÊÂ „— » ”«“Ì";
			// 
			// numberorderrb
			// 
			this.numberorderrb.Checked = true;
			this.numberorderrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.numberorderrb.Location = new System.Drawing.Point(8, 16);
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
			this.dateorderrb.Location = new System.Drawing.Point(16, 48);
			this.dateorderrb.Name = "dateorderrb";
			this.dateorderrb.Size = new System.Drawing.Size(176, 24);
			this.dateorderrb.TabIndex = 0;
			this.dateorderrb.Text = "„— » ”«“Ì »— «”«”  «—ÌŒ «”‰«œ";
			this.dateorderrb.CheckedChanged += new System.EventHandler(this.dateorderrb_CheckedChanged);
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(360, 472);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.Size = new System.Drawing.Size(100, 30);
			this.submitcmd.TabIndex = 8;
			this.submitcmd.Text = " « ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(192, 472);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.Size = new System.Drawing.Size(100, 30);
			this.cancelcmd.TabIndex = 9;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.subsidiarytxt);
			this.panel4.Controls.Add(this.subsidiarycmd);
			this.panel4.Location = new System.Drawing.Point(232, 240);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(144, 30);
			this.panel4.TabIndex = 10;
			this.panel4.Visible = false;
			// 
			// subsidiarytxt
			// 
			this.subsidiarytxt.Location = new System.Drawing.Point(8, 0);
			this.subsidiarytxt.Name = "subsidiarytxt";
			this.subsidiarytxt.TabIndex = 1;
			this.subsidiarytxt.Text = "";
			this.subsidiarytxt.Validated += new System.EventHandler(this.subsidiarytxt_Validated);
			// 
			// subsidiarycmd
			// 
			this.subsidiarycmd.BackColor = System.Drawing.Color.Lavender;
			this.subsidiarycmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.subsidiarycmd.Location = new System.Drawing.Point(112, 0);
			this.subsidiarycmd.Name = "subsidiarycmd";
			this.subsidiarycmd.Size = new System.Drawing.Size(30, 25);
			this.subsidiarycmd.TabIndex = 0;
			this.subsidiarycmd.Text = "...";
			this.subsidiarycmd.Click += new System.EventHandler(this.subsidiarycmd_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.generaltxt);
			this.panel5.Controls.Add(this.generalcmd);
			this.panel5.Location = new System.Drawing.Point(232, 280);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(144, 30);
			this.panel5.TabIndex = 11;
			this.panel5.Visible = false;
			// 
			// generaltxt
			// 
			this.generaltxt.Location = new System.Drawing.Point(8, 0);
			this.generaltxt.Name = "generaltxt";
			this.generaltxt.TabIndex = 3;
			this.generaltxt.Text = "";
			this.generaltxt.Validated += new System.EventHandler(this.generaltxt_Validated);
			// 
			// generalcmd
			// 
			this.generalcmd.BackColor = System.Drawing.Color.Lavender;
			this.generalcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.generalcmd.Location = new System.Drawing.Point(112, 0);
			this.generalcmd.Name = "generalcmd";
			this.generalcmd.Size = new System.Drawing.Size(30, 25);
			this.generalcmd.TabIndex = 2;
			this.generalcmd.Text = "...";
			this.generalcmd.Click += new System.EventHandler(this.generalcmd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.CausesValidation = false;
			this.groupBox1.Controls.Add(this.dcancelcmd);
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Location = new System.Drawing.Point(112, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 472);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// dcancelcmd
			// 
			this.dcancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.dcancelcmd.CausesValidation = false;
			this.dcancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.dcancelcmd.Location = new System.Drawing.Point(120, 432);
			this.dcancelcmd.Name = "dcancelcmd";
			this.dcancelcmd.TabIndex = 1;
			this.dcancelcmd.Text = "«‰’—«›";
			this.dcancelcmd.Click += new System.EventHandler(this.dcancelcmd_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowDrop = true;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.CausesValidation = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeadersVisible = false;
			this.dataGrid1.Size = new System.Drawing.Size(320, 400);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1,
																								  this.dataGridTableStyle2,
																								  this.dataGridTableStyle3});
			this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "DetailedCode1";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn1.MappingName = "Detailedcode1";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 30;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn2.MappingName = "DetailedName";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 90;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn3.MappingName = "DetailedDescription";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 200;
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.DataGrid = this.dataGrid1;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5,
																												  this.dataGridTextBoxColumn6});
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle2.MappingName = "Subsidiary";
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn4.MappingName = "SubsidiaryCode";
			this.dataGridTextBoxColumn4.NullText = "";
			this.dataGridTextBoxColumn4.ReadOnly = true;
			this.dataGridTextBoxColumn4.Width = 30;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn5.MappingName = "SubsidiaryName";
			this.dataGridTextBoxColumn5.ReadOnly = true;
			this.dataGridTextBoxColumn5.Width = 90;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn6.MappingName = "SubsidiaryDescription";
			this.dataGridTextBoxColumn6.ReadOnly = true;
			this.dataGridTextBoxColumn6.Width = 200;
			// 
			// dataGridTableStyle3
			// 
			this.dataGridTableStyle3.DataGrid = this.dataGrid1;
			this.dataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn7,
																												  this.dataGridTextBoxColumn8});
			this.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle3.MappingName = "General";
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn7.MappingName = "GeneralCode";
			this.dataGridTextBoxColumn7.Width = 30;
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn8.MappingName = "GeneralName";
			this.dataGridTextBoxColumn8.Width = 75;
			// 
			// detailedform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(592, 516);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.cancelcmd);
			this.Controls.Add(this.submitcmd);
			this.Controls.Add(this.orderbox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.codebox);
			this.Controls.Add(this.limitbox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.typebox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.MaximizeBox = false;
			this.Name = "detailedform";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ê“Ì‰‘ œ› —  ›’Ì·Ì 1";
			this.panel1.ResumeLayout(false);
			this.limitbox.ResumeLayout(false);
			this.codebox.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.typebox.ResumeLayout(false);
			this.orderbox.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		

		private void subsidiaricoderb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel4.Visible=true;
			panel5.Visible=false;
			generaltxt.Text="";
			scode="subsidiary";
			subsidiarytxt.Focus();
			ncode=subsidiarytxt.Text;
		}

		private void generalcoderb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel5.Visible=true;
			panel4.Visible=false;
			subsidiarytxt.Text="";
			generaltxt.Focus();
			scode="general";
			ncode=generaltxt.Text;
		}

		private void daterb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=true;
			panel3.Visible=false;
			limit="date";
			fdate1=System.DateTime.Today.Date.ToShortDateString();
			tdate1=System.DateTime.Today.Date.ToShortDateString();
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

		private void allcaserb_CheckedChanged(object sender, System.EventArgs e)
		{
			generaltxt.Text="";
			subsidiarytxt.Text="";
			panel4.Visible=false;
			panel5.Visible=false;
			scode="all";
		}

		private void allrb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=false;
			panel3.Visible=false;
			limit="all";
			
		}

		private void cancelcmd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			fcode=detailedcodetxt.Text;
			if(daterb.Checked==true)
			{
				tdate(null,null);
				fdate(null,null);
			}
			if(detailedcodetxt.Text==""){
				MessageBox.Show("òœ  ›’Ì·Ì —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				detailedcodetxt.Focus();
			}
			else if(subsidiaricoderb.Checked==true && subsidiarytxt.Text=="")
			{
				MessageBox.Show("òœ „⁄Ì‰ —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				subsidiarytxt.Focus();
			}
			else if(generalcoderb.Checked==true && generaltxt.Text==""){
			MessageBox.Show("òœ ò· —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			generaltxt.Focus();
			}
			else
			{
				
				reports form=new reports("Detailed1",fcode,"",limit,fdate1,tdate1,fnumber,tnumber,scode,ncode,document,sort);
				form.ShowDialog();
			}
			
		}

		private void subsidiarycmd_Click(object sender, System.EventArgs e)
		{
			if(detailedcodetxt.Text=="")
			{
				MessageBox.Show("·ÿ›« òœ  ›’Ì·Ì —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				detailedcodetxt.Focus();
			}
			else
			{
				groupBox1.Visible=true;
				table="subsidiary";
				DataSet dataset =new DataSet("DetailedCode1");
				ob.get_Info("*","Subsidiary INNER JOIN DetailedCode1 ON Subsidiary.SubsidiaryCode=DetailedCode1.SubsidiaryCode ","DetailedCode1='"+detailedcodetxt.Text+"'",dataset,"Subsidiary");
				dataGrid1.DataSource=dataset;
				dataGrid1.DataMember="Subsidiary";
				dataGrid1.CaptionText="Õ”«» Â«Ì „⁄Ì‰";
			}
		
		}
		private void dateorderrb_CheckedChanged(object sender, System.EventArgs e)
		{
			sort="date";
		}

		private void numberorderrb_CheckedChanged(object sender, System.EventArgs e)
		{
			sort="number";
		}
		private void constantrb_CheckedChanged(object sender, System.EventArgs e)
		{
			document="constant";
		}

		private void temporarirb_CheckedChanged(object sender, System.EventArgs e)
		{
			document="temporary";
		}

		private void fromnumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			if(fromnumbertxt.Text=="")
				fnumber="1";
			else
				fnumber=fromnumbertxt.Text;
		}

		private void tonumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			if(tonumbertxt.Text=="")
				tnumber="1";
			else
				tnumber=tonumbertxt.Text;
		}
		private void detailedcodecmd_Click(object sender, System.EventArgs e)
		{
			groupBox1.Visible=true;
			table="Detailed";
			DataSet dataset =new DataSet("DetailedCode1");
			ob.get_Info("*","DetailedCode1","DetailedCode1 is not null",dataset,"DetailedCode1");
			dataGrid1.DataSource=dataset;
			dataGrid1.DataMember="DetailedCode1";
			dataGrid1.CaptionText="Õ”«» Â«Ì  ›’Ì·Ì 1";
		}
		private void generalcmd_Click(object sender, System.EventArgs e)
		{
			if(detailedcodetxt.Text=="")
			{
				MessageBox.Show("·ÿ›« òœ  ›’Ì·Ì —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				detailedcodetxt.Focus();
			}
			else
			{
				table="general";
				groupBox1.Visible=true;
				DataSet dataset =new DataSet("DetailedCode1");
				ob.get_Info("*","General INNER JOIN (Subsidiary INNER JOIN DetailedCode1 ON Subsidiary.SubsidiaryCode=DetailedCode1.SubsidiaryCode)ON Subsidiary.GeneralCode=General.GeneralCode  ","DetailedCode1='"+detailedcodetxt.Text+"'",dataset,"General");
				dataGrid1.DataSource=dataset;
				dataGrid1.DataMember="General";
				dataGrid1.CaptionText="Õ”«» Â«Ì ò·";
			}
		
		}

		private void dcancelcmd_Click(object sender, System.EventArgs e)
		{
			groupBox1.Visible=false;
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			str=dataGrid1[dataGrid1.CurrentRowIndex,0].ToString();
			switch (table)
			{
				case "Detailed" :
					detailedcodetxt.Text=str;
					break;
				case "general" :
					generaltxt.Text=str;
					break;
				case "subsidiary" :
					subsidiarytxt.Text=str;
					break;
			}
			groupBox1.Visible=false;
		
		}

		private void detailedcodetxt_Validated(object sender, System.EventArgs e)
		{
			if(detailedcodetxt.Text!="")
			{
				if(ob.get_ID("DetailedCode1","DetailedCode1","DetailedCode1='"+detailedcodetxt.Text+"'")==0)
				{
					MessageBox.Show("òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);	
					detailedcodetxt.Text="";
					detailedcodetxt.Focus();
				}
				else
					fcode=detailedcodetxt.Text;
			}
		}

		private void subsidiarytxt_Validated(object sender, System.EventArgs e)
		{
			if(detailedcodetxt.Text=="")
			{
				MessageBox.Show("·ÿ›« òœ  ›’Ì·Ì —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				subsidiarytxt.Text="";
				detailedcodetxt.Focus();
			}
			else if(subsidiarytxt.Text!="")
			{
				if(ob.get_ID("Subsidiary.SubsidiaryCode","Subsidiary INNER JOIN DetailedCode1 ON Subsidiary.SubsidiaryCode=DetailedCode1.SubsidiaryCode ","DetailedCode1='"+detailedcodetxt.Text+"' AND Subsidiary.SubsidiaryCode='"+subsidiarytxt.Text+"'")==0)
				{
					MessageBox.Show("òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);	
					subsidiarytxt.Text="";
					subsidiarytxt.Focus();
				}
				else
					ncode=subsidiarytxt.Text;
			}
		}

		private void generaltxt_Validated(object sender, System.EventArgs e)
		{
			if(detailedcodetxt.Text=="")
			{
				MessageBox.Show("·ÿ›« òœ  ›’Ì·Ì —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				generaltxt.Text="";
				detailedcodetxt.Focus();
			}
			else if(generaltxt.Text!="")
			{
			if(ob.get_ID("General.GeneralCode","General INNER JOIN (Subsidiary INNER JOIN DetailedCode1 ON Subsidiary.SubsidiaryCode=DetailedCode1.SubsidiaryCode)ON Subsidiary.GeneralCode=General.GeneralCode  ","DetailedCode1='"+detailedcodetxt.Text+"' AND General.GeneralCode='"+generaltxt.Text+"'")==0)
				 {
					 MessageBox.Show("òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);	
					 generaltxt.Text="";
					 generaltxt.Focus();
				 }
				 else
					 ncode=generaltxt.Text;
			}
		}

		private void fdate(object sender, System.EventArgs e)
		{
			int year  = int.Parse(Persia.Number.ConvertToLatin(txtSetYear.Text));
			int month = comboMonth.SelectedIndex + 1;
			int day   = comboDays.SelectedIndex + 1;
			fdate1=Persia.Calendar.ConvertToGregorian(year, month, day).ToShortDateString().ToString();
		}
	
	}
}
