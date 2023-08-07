using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for addcode.
	/// </summary>
	public class addcode : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cancelcmd;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Label descriptionlbl;
		private System.Windows.Forms.Label namelbl;
		private System.Windows.Forms.TextBox descriptiontxt;
		private System.Windows.Forms.TextBox nametxt;
		private System.Windows.Forms.Button codecmd;
		private System.Windows.Forms.TextBox codetxt;
		private System.Windows.Forms.Label codelbl;
		private System.Windows.Forms.Label ncodelbl;
		private System.Windows.Forms.TextBox ncodetxt;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.Label label1;
		private string table="";
		private int type=0;
		private codebehind ob=new codebehind();
		private DataSet dataset=new DataSet();
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public addcode(string table1)
		{
			table=table1;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.ncodetxt = new System.Windows.Forms.TextBox();
			this.nametxt = new System.Windows.Forms.TextBox();
			this.descriptiontxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ncodelbl = new System.Windows.Forms.Label();
			this.namelbl = new System.Windows.Forms.Label();
			this.descriptionlbl = new System.Windows.Forms.Label();
			this.submitcmd = new System.Windows.Forms.Button();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.codecmd = new System.Windows.Forms.Button();
			this.codetxt = new System.Windows.Forms.TextBox();
			this.codelbl = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.ncodetxt);
			this.groupBox1.Controls.Add(this.nametxt);
			this.groupBox1.Controls.Add(this.descriptiontxt);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.ncodelbl);
			this.groupBox1.Controls.Add(this.namelbl);
			this.groupBox1.Controls.Add(this.descriptionlbl);
			this.groupBox1.Controls.Add(this.submitcmd);
			this.groupBox1.Controls.Add(this.cancelcmd);
			this.groupBox1.Location = new System.Drawing.Point(0, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 312);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Crimson;
			this.label5.Location = new System.Drawing.Point(288, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "„Ê«—œ ” «—Â œ«— —« Õ „«Ò Ê«—œ ‰„«ÌÌœ.";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.radioButton5);
			this.groupBox3.Controls.Add(this.radioButton4);
			this.groupBox3.Controls.Add(this.radioButton3);
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Location = new System.Drawing.Point(8, 104);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(432, 128);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Visible = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.Crimson;
			this.label1.Location = new System.Drawing.Point(344, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 88);
			this.label1.TabIndex = 5;
			this.label1.Text = "„«ÂÌ   Õ”«»";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButton5
			// 
			this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.radioButton5.ForeColor = System.Drawing.Color.RoyalBlue;
			this.radioButton5.Location = new System.Drawing.Point(200, 88);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(128, 24);
			this.radioButton5.TabIndex = 4;
			this.radioButton5.Text = "„ »œÂò«— Ê „ »” «‰ò«—";
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.radioButton4.ForeColor = System.Drawing.Color.RoyalBlue;
			this.radioButton4.Location = new System.Drawing.Point(48, 56);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(120, 24);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "»œÊ‰ „«‰œÂ »œÂò«—Ì";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.radioButton3.ForeColor = System.Drawing.Color.RoyalBlue;
			this.radioButton3.Location = new System.Drawing.Point(208, 56);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(120, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "»œÊ‰ „«‰œÂ »” «‰ò«—Ì";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.radioButton2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.radioButton2.Location = new System.Drawing.Point(64, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "›ﬁÿ »” «‰ò«—";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.radioButton1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.radioButton1.Location = new System.Drawing.Point(224, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "›ﬁÿ »œÂò«—";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// ncodetxt
			// 
			this.ncodetxt.Location = new System.Drawing.Point(184, 16);
			this.ncodetxt.Name = "ncodetxt";
			this.ncodetxt.TabIndex = 6;
			this.ncodetxt.Text = "";
			this.ncodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nametxt
			// 
			this.nametxt.Location = new System.Drawing.Point(184, 48);
			this.nametxt.Name = "nametxt";
			this.nametxt.TabIndex = 0;
			this.nametxt.Text = "";
			// 
			// descriptiontxt
			// 
			this.descriptiontxt.Location = new System.Drawing.Point(184, 80);
			this.descriptiontxt.Name = "descriptiontxt";
			this.descriptiontxt.TabIndex = 1;
			this.descriptiontxt.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(152, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "*";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(152, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "*";
			// 
			// ncodelbl
			// 
			this.ncodelbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.ncodelbl.Location = new System.Drawing.Point(344, 16);
			this.ncodelbl.Name = "ncodelbl";
			this.ncodelbl.TabIndex = 7;
			this.ncodelbl.Text = "‘„«—Â Õ”«»";
			// 
			// namelbl
			// 
			this.namelbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.namelbl.Location = new System.Drawing.Point(344, 48);
			this.namelbl.Name = "namelbl";
			this.namelbl.TabIndex = 2;
			this.namelbl.Text = "‰«„ Õ”«»";
			// 
			// descriptionlbl
			// 
			this.descriptionlbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.descriptionlbl.Location = new System.Drawing.Point(344, 80);
			this.descriptionlbl.Name = "descriptionlbl";
			this.descriptionlbl.TabIndex = 3;
			this.descriptionlbl.Text = "‘—Õ Õ”«»";
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(224, 280);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.submitcmd.TabIndex = 4;
			this.submitcmd.Text = " «ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(128, 280);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.TabIndex = 5;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// codecmd
			// 
			this.codecmd.BackColor = System.Drawing.Color.Lavender;
			this.codecmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.codecmd.Location = new System.Drawing.Point(304, 8);
			this.codecmd.Name = "codecmd";
			this.codecmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.codecmd.Size = new System.Drawing.Size(32, 23);
			this.codecmd.TabIndex = 5;
			this.codecmd.Text = "...";
			this.codecmd.Click += new System.EventHandler(this.codecmd_Click);
			// 
			// codetxt
			// 
			this.codetxt.Location = new System.Drawing.Point(200, 8);
			this.codetxt.Name = "codetxt";
			this.codetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.codetxt.TabIndex = 4;
			this.codetxt.Text = "";
			this.codetxt.Validated += new System.EventHandler(this.codetxt_Validated);
			// 
			// codelbl
			// 
			this.codelbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.codelbl.Location = new System.Drawing.Point(344, 8);
			this.codelbl.Name = "codelbl";
			this.codelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.codelbl.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.codelbl);
			this.groupBox4.Controls.Add(this.codecmd);
			this.groupBox4.Controls.Add(this.codetxt);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(456, 40);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(168, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "*";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGrid1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Location = new System.Drawing.Point(36, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 328);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Visible = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 0);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.Size = new System.Drawing.Size(384, 280);
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
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "code";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn1.MappingName = "code";
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn2.MappingName = "name";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 120;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn3.MappingName = "description";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 200;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.button2.Location = new System.Drawing.Point(136, 296);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "«‰’—«›";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// addcode
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 366);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.Name = "addcode";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "«÷«›Â ò—œ‰ òœ";
			this.Load += new System.EventHandler(this.addcode_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void codecmd_Click(object sender, System.EventArgs e)
		{
			switch (table){
				case"subsidiary":
					ob.get_Info("GeneralCode as code,GeneralName as name,Type as description","General","GeneralCode is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì ò·";
					break;
				case"detailed1":
					ob.get_Info("SubsidiaryCode as code,SubsidiaryName as name,SubsidiaryDescription as description","Subsidiary","SubsidiaryCode is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì „⁄Ì‰";
					break;
				case"detailed2":
					ob.get_Info("DetailedCode1 as code,DetailedName as name,DetailedDescription as description","DetailedCode1","DetailedCode1 is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì  ›’Ì·Ì1";
					break;
				case"detailed3":
					ob.get_Info("DetailedCode2 as code,DetailedName as name,DetailedDescription as description","DetailedCode2","DetailedCode2 is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì  ›’Ì·Ì2";
					break;

			}
			dataGrid1.DataSource=dataset;
			dataGrid1.DataMember="code";
			groupBox2.Visible=true;
			
		}

		private void addcode_Load(object sender, System.EventArgs e)
		{
			switch (table)
			{
				case "general":
					ncodetxt.Text=""+(ob.get_ID("max(GeneralCode)","General","GeneralCode is not null")+1);
					ncodetxt.Focus();
					descriptionlbl.Visible=false;
					descriptiontxt.Visible=false;
					groupBox3.Visible=true;
					groupBox4.Visible=false;
					this.Text+=" ò·";
					break;
				case"subsidiary":
					ncodetxt.Text=""+(ob.get_ID("max(SubsidiaryCode)","Subsidiary","SubsidiaryCode is not null")+1);
					codelbl.Text="òœ ò· :";
					this.Text+=" „⁄Ì‰";
					codetxt.Focus();
					break;
				case"detailed1":
					ncodetxt.Text=""+(ob.get_ID("max(DetailedCode1)","DetailedCode1","DetailedCode1 is not null")+1);
					codetxt.Focus();
					codelbl.Text="òœ „⁄Ì‰ :";
					this.Text+="  ›’Ì·Ì 1";
					break;
				case"detailed2":
					ncodetxt.Text=""+(ob.get_ID("max(DetailedCode2)","DetailedCode2","DetailedCode2 is not null")+1);
					codetxt.Focus();
					codelbl.Text="òœ  ›’Ì·Ì 1 :";
					this.Text+="  ›’Ì·Ì 2";
					break;
				case"detailed3":
					ncodetxt.Text=""+(ob.get_ID("max(DetailedCode3)","DetailedCode3","DetailedCode3 is not null")+1);
					codetxt.Focus();
					codelbl.Text="òœ  ›’Ì·Ì 2 :";
					this.Text+="  ›’Ì·Ì 3";
					break;

			}
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			codetxt.Text=dataGrid1[dataGrid1.CurrentRowIndex,0].ToString();
			groupBox2.Visible=false;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			groupBox2.Visible=false;
		}

		private void cancelcmd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			if(table=="general" && (nametxt.Text=="" || ncodetxt.Text==""))
			{
				MessageBox.Show("·ÿ›« ﬁ”„  Â«ÌÌ òÂ ⁄·«„  * œ«—‰œ —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				label3.Visible=true;
				label4.Visible=true;
			}
			else if(table!="general" && (nametxt.Text=="" || ncodetxt.Text==""|| codetxt.Text=="")){
				MessageBox.Show("·ÿ›« ﬁ”„  Â«ÌÌ òÂ ⁄·«„  * œ«—‰œ —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
				label2.Visible=true;
				label3.Visible=true;
				label4.Visible=true;																				 
			 }
			else if(ncodetxt.Text!="")
			{
				switch (table)
				{
					case"general":
						if(ob.get_ID("GeneralCode","General","GeneralCode='"+ncodetxt.Text+"'")==0)
						{
							ob.add("General","GeneralCode,GeneralName,Type","'"+ncodetxt.Text+"','"+nametxt.Text+"','"+type+"'");
							this.Close();
						}
						else
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
						break;
					case"subsidiary":
						if(ob.get_ID("SubsidiaryCode","Subsidiary","SubsidiaryCode='"+ncodetxt.Text+"'")==0)
						{
							ob.add("Subsidiary","GeneralCode,SubsidiaryCode,SubsidiaryName","'"+codetxt.Text+"','"+ncodetxt.Text+"','"+nametxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("Subsidiary","SubsidiaryDescription='"+descriptiontxt.Text+"'","SubsidiaryCode='"+ncodetxt.Text+"'");
							this.Close();
						}
						else
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
						break;
					case "detailed1":
						if(ob.get_ID("DetailedCode1","DetailedCode1","DetailedCode1='"+ncodetxt.Text+"'")==0)
						{
							ob.add("DetailedCode1","SubsidiaryCode,DetailedCode1,DetailedName","'"+codetxt.Text+"','"+ncodetxt.Text+"','"+nametxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("DetailedCode1","DetailedDescription='"+descriptiontxt.Text+"'","DetailedCode1='"+ncodetxt.Text+"'");
							this.Close();
						}
						else
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
						break;
					case"detailed2":
						if(ob.get_ID("DetailedCode2","DetailedCode2","DetailedCode2='"+ncodetxt.Text+"'")==0)
						{
							ob.add("DetailedCode2","DetailedCode1,DetailedCode2,DetailedName","'"+codetxt.Text+"','"+ncodetxt.Text+"','"+nametxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("DetailedCode2","DetailedDescription='"+descriptiontxt.Text+"'","DetailedCode2='"+ncodetxt.Text+"'");
							this.Close();
						}
						else
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
						break;
					case "detailed3":
						if(ob.get_ID("DetailedCode3","DetailedCode3","DetailedCode3='"+ncodetxt.Text+"'")==0)
						{
							ob.add("DetailedCode3","DetailedCode2,DetailedCode3,DetailedName","'"+codetxt.Text+"','"+ncodetxt.Text+"','"+nametxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("DetailedCode3","DetailedDescription='"+descriptiontxt.Text+"'","DetailedCode3='"+ncodetxt.Text+"'");
							this.Close();
						}
						else
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
						break;
				}
			}
			
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			type=1;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			type=2;
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			type=3;
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			type=4;
		}

		private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
		{
			type=5;
		}

		private void codetxt_Validated(object sender, System.EventArgs e)
		{
			if(codetxt.Text!="")
			{
				switch (table)
				{
					case"subsidiary":
						if(ob.get_ID("GeneralCode","General","GeneralCode='"+codetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							codetxt.Text="";
							codetxt.Focus();
						}
						break;
					case "detailed1":
						if(ob.get_ID("SubsidiaryCode","Subsidiary","SubsidiaryCode='"+codetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							codetxt.Text="";
							codetxt.Focus();
						}
						break;
					case"detailed2":
						if(ob.get_ID("DetailedCode1","DetailedCode1","DetailedCode1='"+codetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							codetxt.Text="";
							codetxt.Focus();
						}
						break;
					case "detailed3":
						if(ob.get_ID("DetailedCode2","DetailedCode2","DetailedCode2='"+codetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							codetxt.Text="";
							codetxt.Focus();
						}
						break;
				}
			}
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			groupBox2.Visible=false;
		}

	
		}

		
	}
