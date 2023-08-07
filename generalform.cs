using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for generalform.
	/// </summary>
	public class generalform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox orderbox;
		private System.Windows.Forms.RadioButton numberorderrb;
		private System.Windows.Forms.RadioButton dateorderrb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox typebox;
		private System.Windows.Forms.RadioButton temporarirb;
		private System.Windows.Forms.RadioButton constantrb;
		private System.Windows.Forms.Button cancelcmd;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tonumbertxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox fromnumbertxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox limitbox;
		private System.Windows.Forms.RadioButton allrb;
		private System.Windows.Forms.RadioButton numberrb;
		private System.Windows.Forms.RadioButton daterb;
		private System.Windows.Forms.TextBox fgeneralcodetxt;
		private System.Windows.Forms.Button fgeneralcodecmd;
		private System.Windows.Forms.TextBox tgeneralcodetxt;
		private System.Windows.Forms.Button tgeneralcodecmd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button dcancelcmd;
		public System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private codebehind ob=new codebehind();
		private string box="";
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private string str="",limit="all",fcode="",tcode="",fdate1="",tdate1="",fnumber="",tnumber="",scode="",ncode="",document="temporary",sort="number";

		private void tdate(object sender, System.EventArgs e)
		{
			int year  = int.Parse(Persia.Number.ConvertToLatin(ttxtSetYear.Text));
			int month = tcomboMonth.SelectedIndex + 1;
			int day   = tcomboDays.SelectedIndex + 1;
			tdate1=Persia.Calendar.ConvertToGregorian(year, month, day).ToShortDateString().ToString();
		}
	
		private System.Windows.Forms.Label label3;
		private int s=0;
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

		public generalform(int a)
		{
			s=a;

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
			this.dateorderrb = new System.Windows.Forms.RadioButton();
			this.numberorderrb = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tgeneralcodetxt = new System.Windows.Forms.TextBox();
			this.tgeneralcodecmd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.fgeneralcodetxt = new System.Windows.Forms.TextBox();
			this.fgeneralcodecmd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.typebox = new System.Windows.Forms.GroupBox();
			this.temporarirb = new System.Windows.Forms.RadioButton();
			this.constantrb = new System.Windows.Forms.RadioButton();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.submitcmd = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tonumbertxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.fromnumbertxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.limitbox = new System.Windows.Forms.GroupBox();
			this.allrb = new System.Windows.Forms.RadioButton();
			this.numberrb = new System.Windows.Forms.RadioButton();
			this.daterb = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dcancelcmd = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tcomboDays = new System.Windows.Forms.ComboBox();
			this.ttxtSetYear = new System.Windows.Forms.TextBox();
			this.tcomboMonth = new System.Windows.Forms.ComboBox();
			this.comboDays = new System.Windows.Forms.ComboBox();
			this.txtSetYear = new System.Windows.Forms.TextBox();
			this.comboMonth = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.orderbox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.typebox.SuspendLayout();
			this.panel3.SuspendLayout();
			this.limitbox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// orderbox
			// 
			this.orderbox.Controls.Add(this.dateorderrb);
			this.orderbox.Controls.Add(this.numberorderrb);
			this.orderbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.orderbox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.orderbox.Location = new System.Drawing.Point(384, 200);
			this.orderbox.Name = "orderbox";
			this.orderbox.Size = new System.Drawing.Size(200, 80);
			this.orderbox.TabIndex = 18;
			this.orderbox.TabStop = false;
			this.orderbox.Text = "‰ÕÊÂ „— » ”«“Ì";
			// 
			// dateorderrb
			// 
			this.dateorderrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.dateorderrb.Location = new System.Drawing.Point(16, 16);
			this.dateorderrb.Name = "dateorderrb";
			this.dateorderrb.Size = new System.Drawing.Size(176, 24);
			this.dateorderrb.TabIndex = 0;
			this.dateorderrb.Text = "„— » ”«“Ì »— «”«”  «—ÌŒ «”‰«œ";
			this.dateorderrb.CheckedChanged += new System.EventHandler(this.dateorderrb_CheckedChanged);
			// 
			// numberorderrb
			// 
			this.numberorderrb.Checked = true;
			this.numberorderrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.numberorderrb.Location = new System.Drawing.Point(8, 48);
			this.numberorderrb.Name = "numberorderrb";
			this.numberorderrb.Size = new System.Drawing.Size(184, 24);
			this.numberorderrb.TabIndex = 1;
			this.numberorderrb.TabStop = true;
			this.numberorderrb.Text = "„— » ”«“Ì »— «”«” ‘„«—Â «”‰«œ";
			this.numberorderrb.CheckedChanged += new System.EventHandler(this.numberorderrb_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.tgeneralcodetxt);
			this.panel1.Controls.Add(this.tgeneralcodecmd);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.fgeneralcodetxt);
			this.panel1.Controls.Add(this.fgeneralcodecmd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(584, 35);
			this.panel1.TabIndex = 12;
			// 
			// tgeneralcodetxt
			// 
			this.tgeneralcodetxt.Location = new System.Drawing.Point(144, 0);
			this.tgeneralcodetxt.Name = "tgeneralcodetxt";
			this.tgeneralcodetxt.Size = new System.Drawing.Size(125, 20);
			this.tgeneralcodetxt.TabIndex = 5;
			this.tgeneralcodetxt.Text = "";
			this.tgeneralcodetxt.Validated += new System.EventHandler(this.tgeneralcodetxt_Validated);
			// 
			// tgeneralcodecmd
			// 
			this.tgeneralcodecmd.BackColor = System.Drawing.Color.Lavender;
			this.tgeneralcodecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.tgeneralcodecmd.Location = new System.Drawing.Point(272, 0);
			this.tgeneralcodecmd.Name = "tgeneralcodecmd";
			this.tgeneralcodecmd.Size = new System.Drawing.Size(30, 25);
			this.tgeneralcodecmd.TabIndex = 4;
			this.tgeneralcodecmd.Text = "...";
			this.tgeneralcodecmd.Click += new System.EventHandler(this.tgeneralcodecmd_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label6.Location = new System.Drawing.Point(232, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = " « òœ ò·:";
			// 
			// fgeneralcodetxt
			// 
			this.fgeneralcodetxt.Location = new System.Drawing.Point(360, 0);
			this.fgeneralcodetxt.Name = "fgeneralcodetxt";
			this.fgeneralcodetxt.Size = new System.Drawing.Size(125, 20);
			this.fgeneralcodetxt.TabIndex = 2;
			this.fgeneralcodetxt.Text = "";
			this.fgeneralcodetxt.Validated += new System.EventHandler(this.fgeneralcodetxt_Validated);
			// 
			// fgeneralcodecmd
			// 
			this.fgeneralcodecmd.BackColor = System.Drawing.Color.Lavender;
			this.fgeneralcodecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.fgeneralcodecmd.Location = new System.Drawing.Point(488, 0);
			this.fgeneralcodecmd.Name = "fgeneralcodecmd";
			this.fgeneralcodecmd.Size = new System.Drawing.Size(30, 25);
			this.fgeneralcodecmd.TabIndex = 1;
			this.fgeneralcodecmd.Text = "...";
			this.fgeneralcodecmd.Click += new System.EventHandler(this.fgeneralcodecmd_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(448, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "«“ òœ ò·:";
			// 
			// typebox
			// 
			this.typebox.Controls.Add(this.temporarirb);
			this.typebox.Controls.Add(this.constantrb);
			this.typebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.typebox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.typebox.Location = new System.Drawing.Point(384, 304);
			this.typebox.Name = "typebox";
			this.typebox.Size = new System.Drawing.Size(200, 80);
			this.typebox.TabIndex = 17;
			this.typebox.TabStop = false;
			this.typebox.Text = "‰Ê⁄ ”‰œ";
			// 
			// temporarirb
			// 
			this.temporarirb.Checked = true;
			this.temporarirb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.temporarirb.Location = new System.Drawing.Point(88, 16);
			this.temporarirb.Name = "temporarirb";
			this.temporarirb.TabIndex = 1;
			this.temporarirb.TabStop = true;
			this.temporarirb.Text = "”‰œ „Êﬁ ";
			this.temporarirb.CheckedChanged += new System.EventHandler(this.temporarirb_CheckedChanged);
			// 
			// constantrb
			// 
			this.constantrb.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.constantrb.Location = new System.Drawing.Point(88, 48);
			this.constantrb.Name = "constantrb";
			this.constantrb.TabIndex = 0;
			this.constantrb.Text = "”‰œ œ«∆„";
			this.constantrb.CheckedChanged += new System.EventHandler(this.constantrb_CheckedChanged);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(192, 430);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.Size = new System.Drawing.Size(100, 30);
			this.cancelcmd.TabIndex = 20;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(360, 430);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.Size = new System.Drawing.Size(100, 30);
			this.submitcmd.TabIndex = 19;
			this.submitcmd.Text = " « ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
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
			this.panel3.Location = new System.Drawing.Point(8, 112);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(368, 30);
			this.panel3.TabIndex = 16;
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
			// limitbox
			// 
			this.limitbox.Controls.Add(this.allrb);
			this.limitbox.Controls.Add(this.numberrb);
			this.limitbox.Controls.Add(this.daterb);
			this.limitbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.limitbox.ForeColor = System.Drawing.Color.RoyalBlue;
			this.limitbox.Location = new System.Drawing.Point(384, 62);
			this.limitbox.Name = "limitbox";
			this.limitbox.Size = new System.Drawing.Size(200, 120);
			this.limitbox.TabIndex = 13;
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dcancelcmd);
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Location = new System.Drawing.Point(88, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(392, 440);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// dcancelcmd
			// 
			this.dcancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.dcancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.dcancelcmd.Location = new System.Drawing.Point(144, 400);
			this.dcancelcmd.Name = "dcancelcmd";
			this.dcancelcmd.TabIndex = 1;
			this.dcancelcmd.Text = "«‰’—«›";
			this.dcancelcmd.Click += new System.EventHandler(this.dcancelcmd_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.CaptionText = "Õ”«» Â«Ì ò·";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeadersVisible = false;
			this.dataGrid1.Size = new System.Drawing.Size(368, 376);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "General";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn1.MappingName = "GeneralCode";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "‰«„ Õ”«»";
			this.dataGridTextBoxColumn2.MappingName = "GeneralName";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 75;
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
			this.panel2.Location = new System.Drawing.Point(0, 152);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 64);
			this.panel2.TabIndex = 22;
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
			this.tcomboDays.Location = new System.Drawing.Point(240, 38);
			this.tcomboDays.Name = "tcomboDays";
			this.tcomboDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tcomboDays.Size = new System.Drawing.Size(40, 21);
			this.tcomboDays.TabIndex = 38;
			// 
			// ttxtSetYear
			// 
			this.ttxtSetYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.ttxtSetYear.Location = new System.Drawing.Point(96, 38);
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
			this.tcomboMonth.Location = new System.Drawing.Point(152, 38);
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
			this.comboDays.Location = new System.Drawing.Point(240, 6);
			this.comboDays.Name = "comboDays";
			this.comboDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboDays.Size = new System.Drawing.Size(40, 21);
			this.comboDays.TabIndex = 35;
			// 
			// txtSetYear
			// 
			this.txtSetYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.txtSetYear.Location = new System.Drawing.Point(96, 6);
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
			this.comboMonth.Location = new System.Drawing.Point(152, 6);
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
			// generalform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 466);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.orderbox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.typebox);
			this.Controls.Add(this.cancelcmd);
			this.Controls.Add(this.submitcmd);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.limitbox);
			this.MaximizeBox = false;
			this.Name = "generalform";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ê“Ì‰‘ œ› — ò·";
			this.Load += new System.EventHandler(this.generalform_Load);
			this.orderbox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.typebox.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.limitbox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void daterb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=true;
			panel3.Visible=false;
			limit="date";
		}

		private void numberrb_CheckedChanged(object sender, System.EventArgs e)
		{
			panel2.Visible=false;
			panel3.Visible=true;
			limit="number";
			fnumber=fromnumbertxt.Text;
			tnumber=tonumbertxt.Text;
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

		private void fgeneralcodecmd_Click(object sender, System.EventArgs e)
		{
			box="box1";
			groupBox1.Visible=true;
		}

		private void generalform_Load(object sender, System.EventArgs e)
		{
			DataSet dataset=new DataSet("General");
			ob.get_Info("GeneralCode,GeneralName","General","GeneralCode is not null",dataset,"General");
			dataGrid1.DataSource=dataset;
			dataGrid1.DataMember="General";
		}

		private void tgeneralcodecmd_Click(object sender, System.EventArgs e)
		{
			box="box2";
			groupBox1.Visible=true;
		}

		private void dcancelcmd_Click(object sender, System.EventArgs e)
		{
			groupBox1.Visible=false;
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			string str=dataGrid1[dataGrid1.CurrentRowIndex,0].ToString();
			switch (box)
			{
				case "box1" :
					fgeneralcodetxt.Text=str;
					break;
				case "box2" :
					tgeneralcodetxt.Text=str;
					break;
			}
			groupBox1.Visible=false;
		}
		private void check(TextBox tb)
		{
			if(tb.Text!="")
			{
				if(ob.get_ID("GeneralCode","General","GeneralCode='"+tb.Text+"'")==0)
				{
					MessageBox.Show("òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);	
					tb.Text="";
					tb.Focus();
				}
			}
		}

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			if(daterb.Checked==true)
			{
				tdate(null,null);
				fdate(null,null);
			}
			if(fgeneralcodetxt.Text=="") 
			{
				MessageBox.Show("òœ ò· —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				fgeneralcodetxt.Focus();
			}
			else if(tgeneralcodetxt.Text=="")
			{
				MessageBox.Show("òœ ò· —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				tgeneralcodetxt.Focus();
			}
			else
			{
				reports form=new reports("General",fcode,tcode,limit,fdate1,tdate1,fnumber,tnumber,scode,ncode,document,sort);
				form.ShowDialog();
			}
		
		}

		private void fgeneralcodetxt_Validated(object sender, System.EventArgs e)
		{
			check(fgeneralcodetxt);
			fcode=fgeneralcodetxt.Text;
		
		}

		private void tgeneralcodetxt_Validated(object sender, System.EventArgs e)
		{
			check(tgeneralcodetxt);
			tcode=tgeneralcodetxt.Text;
		}

		private void fromnumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			fnumber=fromnumbertxt.Text;
		}

		private void tonumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			tnumber=tonumbertxt.Text;
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

		private void fdate(object sender, System.EventArgs e)
		{
			int year  = int.Parse(Persia.Number.ConvertToLatin(txtSetYear.Text));
			int month = comboMonth.SelectedIndex + 1;
			int day   = comboDays.SelectedIndex + 1;
			fdate1=Persia.Calendar.ConvertToGregorian(year, month, day).ToShortDateString().ToString();
		}



	}
	
}
