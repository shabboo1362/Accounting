using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for editcode.
	/// </summary>
	public class editcode : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox nametxt;
		private System.Windows.Forms.TextBox descriptiontxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label namelbl;
		private System.Windows.Forms.Label descriptionlbl;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Button cancelcmd;
		private SqlDataReader datareader;
		private codebehind ob =new codebehind();
		private int type=0;
		private System.Windows.Forms.Label codelbl;
		private System.Windows.Forms.Button codecmd;
		private System.Windows.Forms.TextBox ncodetxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private string table="";
		private DataSet dataset=new DataSet("code");
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.Button cancel1;
		private System.Windows.Forms.Button deletecmd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public editcode(string table1)
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
			this.deletecmd = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.nametxt = new System.Windows.Forms.TextBox();
			this.descriptiontxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.namelbl = new System.Windows.Forms.Label();
			this.descriptionlbl = new System.Windows.Forms.Label();
			this.submitcmd = new System.Windows.Forms.Button();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.codelbl = new System.Windows.Forms.Label();
			this.codecmd = new System.Windows.Forms.Button();
			this.ncodetxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cancel1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.deletecmd);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.nametxt);
			this.groupBox1.Controls.Add(this.descriptiontxt);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.namelbl);
			this.groupBox1.Controls.Add(this.descriptionlbl);
			this.groupBox1.Controls.Add(this.submitcmd);
			this.groupBox1.Controls.Add(this.cancelcmd);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(12, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 241);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// deletecmd
			// 
			this.deletecmd.BackColor = System.Drawing.Color.Lavender;
			this.deletecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.deletecmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.deletecmd.Location = new System.Drawing.Point(216, 208);
			this.deletecmd.Name = "deletecmd";
			this.deletecmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.deletecmd.TabIndex = 11;
			this.deletecmd.Text = "Õ–›";
			this.deletecmd.Click += new System.EventHandler(this.deletecmd_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.radioButton5);
			this.groupBox3.Controls.Add(this.radioButton4);
			this.groupBox3.Controls.Add(this.radioButton3);
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Location = new System.Drawing.Point(8, 72);
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
			// nametxt
			// 
			this.nametxt.Location = new System.Drawing.Point(184, 16);
			this.nametxt.Name = "nametxt";
			this.nametxt.TabIndex = 0;
			this.nametxt.Text = "";
			// 
			// descriptiontxt
			// 
			this.descriptiontxt.Location = new System.Drawing.Point(184, 48);
			this.descriptiontxt.Name = "descriptiontxt";
			this.descriptiontxt.TabIndex = 1;
			this.descriptiontxt.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(152, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "*";
			this.label4.Visible = false;
			// 
			// namelbl
			// 
			this.namelbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.namelbl.Location = new System.Drawing.Point(344, 16);
			this.namelbl.Name = "namelbl";
			this.namelbl.TabIndex = 2;
			this.namelbl.Text = "‰«„ Õ”«»";
			// 
			// descriptionlbl
			// 
			this.descriptionlbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.descriptionlbl.Location = new System.Drawing.Point(344, 48);
			this.descriptionlbl.Name = "descriptionlbl";
			this.descriptionlbl.TabIndex = 3;
			this.descriptionlbl.Text = "‘—Õ Õ”«»";
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(328, 208);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.submitcmd.TabIndex = 4;
			this.submitcmd.Text = "ÊÌ—«Ì‘";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(112, 208);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.TabIndex = 5;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// codelbl
			// 
			this.codelbl.Location = new System.Drawing.Point(344, 8);
			this.codelbl.Name = "codelbl";
			this.codelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.codelbl.TabIndex = 3;
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
			// ncodetxt
			// 
			this.ncodetxt.Location = new System.Drawing.Point(200, 8);
			this.ncodetxt.Name = "ncodetxt";
			this.ncodetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ncodetxt.TabIndex = 4;
			this.ncodetxt.Text = "";
			this.ncodetxt.Validated += new System.EventHandler(this.codetxt_Validated);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(168, 8);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(24, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "*";
			this.label2.Visible = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.codelbl);
			this.groupBox4.Controls.Add(this.codecmd);
			this.groupBox4.Controls.Add(this.ncodetxt);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(12, 7);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox4.Size = new System.Drawing.Size(456, 40);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGrid1);
			this.groupBox2.Controls.Add(this.cancel1);
			this.groupBox2.Location = new System.Drawing.Point(44, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 272);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Visible = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowDrop = true;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.Size = new System.Drawing.Size(384, 216);
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
			// cancel1
			// 
			this.cancel1.BackColor = System.Drawing.Color.Lavender;
			this.cancel1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancel1.Location = new System.Drawing.Point(128, 240);
			this.cancel1.Name = "cancel1";
			this.cancel1.TabIndex = 1;
			this.cancel1.Text = "«‰’—«›";
			this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
			// 
			// editcode
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 310);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.Name = "editcode";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ÊÌ—«Ì‘ Ê Õ–› òœ";
			this.Load += new System.EventHandler(this.editcode_Load);
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
			switch (table)
			{
				case"general":
					ob.get_Info("GeneralCode as code,GeneralName as name,Type as description","General","GeneralCode is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì ò·";
					break;
				case"subsidiary":
					ob.get_Info("SubsidiaryCode as code,SubsidiaryName as name,SubsidiaryDescription as description","Subsidiary","SubsidiaryCode is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì „⁄Ì‰";
					break;
				case"detailed1":
					ob.get_Info("DetailedCode1 as code,DetailedName as name,DetailedDescription as description","DetailedCode1","DetailedCode1 is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì  ›’Ì·Ì1";
					break;
				case"detailed2":
					ob.get_Info("DetailedCode2 as code,DetailedName as name,DetailedDescription as description","DetailedCode2","DetailedCode2 is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì  ›’Ì·Ì2";
					break;
				case"detailed3":
					ob.get_Info("DetailedCode3 as code,DetailedName as name,DetailedDescription as description","DetailedCode3","DetailedCode3 is not null",dataset,"code");
					dataGrid1.CaptionText="Õ”«» Â«Ì  ›’Ì·Ì3";
					break;

			}
			groupBox2.Visible=true;
			dataGrid1.DataSource=dataset;
			dataGrid1.DataMember="code";
			
		}

		private void codetxt_Validated(object sender, System.EventArgs e)
		{
			validate();
		}

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			submit();
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

		private void cancelcmd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void editcode_Load(object sender, System.EventArgs e)
		{
			codelbl.Text="‘„«—Â Õ”«»";
			switch (table)
			{
				case "general":
					descriptionlbl.Visible=false;
					descriptiontxt.Visible=false;
					groupBox3.Visible=true;
					this.Text+=" ò·";
					break;
				case"subsidiary":
					this.Text+=" „⁄Ì‰";
					break;
				case"detailed1":
					this.Text+="  ›’Ì·Ì 1";
					break;
				case"detailed2":
					this.Text+="  ›’Ì·Ì 2";
					break;
				case"detailed3":
					this.Text+="  ›’Ì·Ì 3";
					break;

			}
			ncodetxt.Focus();
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			ncodetxt.Text=dataGrid1[dataGrid1.CurrentRowIndex,0].ToString();
			nametxt.Text=dataGrid1[dataGrid1.CurrentRowIndex,1].ToString();
			if(table=="general")
			{
				type=int.Parse(dataGrid1[dataGrid1.CurrentRowIndex,2].ToString());
				switch (type)
				{
					case 1:
						radioButton1.Checked=true;
						break;
					case 2:
						radioButton2.Checked=true;
						break;
					case 3:
						radioButton3.Checked=true;
						break;
					case 4:
						radioButton4.Checked=true;
						break;
					case 5:
						radioButton5.Checked=true;
						break;
				}
			}
			else
				descriptiontxt.Text=dataGrid1[dataGrid1.CurrentRowIndex,2].ToString();
			groupBox1.Enabled=true;
			groupBox2.Visible=false;
		}

		private void cancel1_Click(object sender, System.EventArgs e)
		{
			groupBox2.Visible=false;
		}
		private void validate()
		{
			if(ncodetxt.Text!="")
			{
				switch (table)
				{
					case"general":
						if(ob.get_ID("GeneralCode","General","GeneralCode='"+ncodetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							ncodetxt.Text="";
							ncodetxt.Focus();
							groupBox1.Enabled=false;
						}
						else
						{
							groupBox1.Enabled=true;
							try
							{
								datareader=ob.get_UserInfo("GeneralName,Type","General","GeneralCode='"+ncodetxt.Text+"'");
								while(datareader.Read())
								{
									nametxt.Text=datareader.GetValue(0).ToString();
									type=int.Parse(datareader.GetValue(1).ToString());
								}
								switch (type)
								{
									case 1:
										radioButton1.Checked=true;
										break;
									case 2:
										radioButton2.Checked=true;
										break;
									case 3:
										radioButton3.Checked=true;
										break;
									case 4:
										radioButton4.Checked=true;
										break;
									case 5:
										radioButton5.Checked=true;
										break;
								}
							}
							finally
							{
								datareader.Close();
							}
						}
						break;
					case "subsidiary":
						if(ob.get_ID("SubsidiaryCode","Subsidiary","SubsidiaryCode='"+ncodetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							ncodetxt.Text="";
							ncodetxt.Focus();
						}
						else
						{
							groupBox1.Enabled=true;
							try
							{
								datareader=ob.get_UserInfo("SubsidiaryName,SubsidiaryDescription","Subsidiary","SubsidiaryCode='"+ncodetxt.Text+"'");
								while(datareader.Read())
								{
									nametxt.Text=datareader.GetValue(0).ToString();
									descriptiontxt.Text=datareader.GetValue(1).ToString();
								}
							}
							finally
							{
								datareader.Close();
							}
						}
						break;
					case"detailed1":
						if(ob.get_ID("DetailedCode1","DetailedCode1","DetailedCode1='"+ncodetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							ncodetxt.Text="";
							ncodetxt.Focus();
						}
						else
						{
							groupBox1.Enabled=true;
							try
							{
								datareader=ob.get_UserInfo("DetailedName,DetailedDescription","DetailedCode1","DetailedCode1='"+ncodetxt.Text+"'");
								while(datareader.Read())
								{
									nametxt.Text=datareader.GetValue(0).ToString();
									descriptiontxt.Text=datareader.GetValue(1).ToString();
								}
							}
							finally
							{
								datareader.Close();
							}
						}
						break;
					case "detailed2":
						if(ob.get_ID("DetailedCode2","DetailedCode2","DetailedCode2='"+ncodetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							ncodetxt.Text="";
							ncodetxt.Focus();
						}
						else
						{
							groupBox1.Enabled=true;
							try
							{
								datareader=ob.get_UserInfo("DetailedName,DetailedDescription","DetailedCode2","DetailedCode2='"+ncodetxt.Text+"'");
								while(datareader.Read())
								{
									nametxt.Text=datareader.GetValue(0).ToString();
									descriptiontxt.Text=datareader.GetValue(1).ToString();
								}
							}
							finally
							{
								datareader.Close();
							}
						}
						break;
					case "detailed3":
						if(ob.get_ID("DetailedCode3","DetailedCode3","DetailedCode3='"+ncodetxt.Text+"'")==0)
						{
							MessageBox.Show("«Ì‰ òœ Õ”«» ÊÃÊœ ‰œ«—œ ·ÿ›« òœ œÌê—Ì Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
							ncodetxt.Text="";
							ncodetxt.Focus();
						}
						else
						{
							groupBox1.Enabled=true;
							try
							{
								datareader=ob.get_UserInfo("DetailedName,DetailedDescription","DetailedCode3","DetailedCode3='"+ncodetxt.Text+"'");
								while(datareader.Read())
								{
									nametxt.Text=datareader.GetValue(0).ToString();
									descriptiontxt.Text=datareader.GetValue(1).ToString();
								}
							}
							finally
							{
								datareader.Close();
							}
						}
						break;
				}
			}
		}
			private void submit()
			{
				if(nametxt.Text=="" || ncodetxt.Text=="")
				{
					MessageBox.Show("·ÿ›« ﬁ”„  Â«ÌÌ òÂ ⁄·«„  * œ«—‰œ —« Ê«—œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
					label2.Visible=true;
					label4.Visible=true;
				}
				else if(ncodetxt.Text!="")
				{
					switch (table)
					{
						case"general":
							ob.update("General","GeneralName='"+nametxt.Text+"',Type='"+type+"'","GeneralCode='"+ncodetxt.Text+"'");
							this.Close();
							break;
						case"subsidiary":
							ob.update("Subsidiary","SubsidiaryName='"+nametxt.Text+"'","SubsidiaryCode='"+ncodetxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("Subsidiary","SubsidiaryDescription='"+descriptiontxt.Text+"'","SubsidiaryCode='"+ncodetxt.Text+"'");
							this.Close();
							break;
						case "detailed1":
							ob.update("DetailedCode1","DetailedName='"+nametxt.Text+"'","DetailedCode1='"+ncodetxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("DetailedCode1","DetailedDescription='"+descriptiontxt.Text+"'","DetailedCode1='"+ncodetxt.Text+"'");
							this.Close();
							break;
						case"detailed2":
							ob.update("DetailedCode2","DetailedName='"+nametxt.Text+"'","DetailedCode2='"+ncodetxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("DetailedCode2","DetailedDescription='"+descriptiontxt.Text+"'","DetailedCode2='"+ncodetxt.Text+"'");
							this.Close();
							break;
						case "detailed3":
							ob.update("DetailedCode3","DetailedName='"+nametxt.Text+"'","DetailedCode3='"+ncodetxt.Text+"'");
							if(descriptiontxt.Text!="")
								ob.update("DetailedCode3","DetailedDescription='"+descriptiontxt.Text+"'","DetailedCode3='"+ncodetxt.Text+"'");
							this.Close();
							break;
					}
				}

			}

		private void deletecmd_Click(object sender, System.EventArgs e)
		{
			switch (table)
			{
				case"general":
					if (MessageBox.Show("»« Õ–› «Ì‰ òœ  „«„ òœ Â«Ì „⁄Ì‰ ° ›’Ì·Ì1° ›’Ì·Ì2 Ê  ›’Ì·Ì 3 „—»Êÿ »Â «Ì‰ òœ Õ–› „Ì‘Êœ","«Œÿ«—",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
					{
						ob.delete("DetailedCode3","DetailedCode2 IN (select DetailedCode2 from (Subsidiary INNER JOIN(DetailedCode2 inner join DetailedCode1 ON DetailedCode2.DetailedCode1=DetailedCode1.DetailedCode1)ON DetailedCode1.SubsidiaryCode=Subsidiary.SubsidiaryCode) Where GeneralCode='"+ncodetxt.Text+"')");
						ob.delete("DetailedCode2","DetailedCode1 IN (select DetailedCode1 from Subsidiary INNER JOIN DetailedCode1 ON DetailedCode1.SubsidiaryCode=Subsidiary.SubsidiaryCode Where GeneralCode='"+ncodetxt.Text+"')");
						ob.delete("DetailedCode1","DetailedCode1 IN (select DetailedCode1 from (Subsidiary INNER JOIN DetailedCode1 ON DetailedCode1.SubsidiaryCode=Subsidiary.SubsidiaryCode) Where GeneralCode='"+ncodetxt.Text+"')");
						ob.delete("Subsidiary","GeneralCode='"+ncodetxt.Text+"'");
						ob.delete("General","GeneralCode='"+ncodetxt.Text+"'");
					}
						this.Close();
					break;
				case"subsidiary":
					if (MessageBox.Show("»« Õ–› «Ì‰ òœ  „«„ òœ Â«Ì  ›’Ì·Ì1° ›’Ì·Ì2 Ê  ›’Ì·Ì 3 „—»Êÿ »Â «Ì‰ òœ Õ–› „Ì‘Êœ","«Œÿ«—",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
					{
						ob.delete("DetailedCode3","DetailedCode2 IN (select DetailedCode2 from (DetailedCode2 inner join DetailedCode1 ON DetailedCode2.DetailedCode1=DetailedCode1.DetailedCode1) Where SubsidiaryCode='"+ncodetxt.Text+"')");
						ob.delete("DetailedCode2","DetailedCode1 IN (select DetailedCode1 from (Subsidiary INNER JOIN DetailedCode1 ON DetailedCode1.SubsidiaryCode=Subsidiary.SubsidiaryCode) Where Subsidiary.SubsidiaryCode='"+ncodetxt.Text+"')");
						ob.delete("DetailedCode1","SubsidiaryCode='"+ncodetxt.Text+"'");
						ob.delete("Subsidiary","SubsidiaryCode='"+ncodetxt.Text+"'");
					}
					this.Close();
					break;
				case "detailed1":
					if (MessageBox.Show("»« Õ–› «Ì‰ òœ  „«„ òœ Â«Ì  ›’Ì·Ì2 Ê  ›’Ì·Ì 3 „—»Êÿ »Â «Ì‰ òœ Õ–› „Ì‘Êœ","«Œÿ«—",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
					{
						ob.delete("DetailedCode3","DetailedCode2 IN (select DetailedCode2 from (DetailedCode2 inner join DetailedCode1 ON DetailedCode2.DetailedCode1=DetailedCode1.DetailedCode1) Where DetailedCode1.DetailedCode1='"+ncodetxt.Text+"')");
						ob.delete("DetailedCode2","DetailedCode1='"+ncodetxt.Text+"'");
						ob.delete("DetailedCode1","DetailedCode1='"+ncodetxt.Text+"'");
					}
					this.Close();
					break;
				case"detailed2":
					if (MessageBox.Show("»« Õ–› «Ì‰ òœ  „«„ òœ Â«Ì  ›’Ì·Ì 3 „—»Êÿ »Â «Ì‰ òœ Õ–› „Ì‘Êœ","«Œÿ«—",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
					{
						ob.delete("DetailedCode3","DetailedCode2='"+ncodetxt.Text+"'");
						ob.delete("DetailedCode2","DetailedCode2='"+ncodetxt.Text+"'");
					}
					this.Close();
					break;
				case "detailed3":
					if (MessageBox.Show("¬Ì« „«Ì· »Â Õ–› «Ì‰ òœ „Ì»«‘Ìœ","«Œÿ«—",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
					{
						ob.delete("DetailedCode3","DetailedCode3='"+ncodetxt.Text+"'");
					}
					this.Close();
					break;
			}
		}

		
	}
}
