using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for transferform.
	/// </summary>
	public class transferform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dnumbertxt;
		private System.Windows.Forms.TextBox ddnumbertxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox datetxt;
		private codebehind ob=new codebehind();
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Button cancelcmd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button gcancelcmd;
		private DataSet dataset=new DataSet();
		private int year=0,month=0,day=0;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public transferform()
		{
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dnumbertxt = new System.Windows.Forms.TextBox();
			this.ddnumbertxt = new System.Windows.Forms.TextBox();
			this.submitcmd = new System.Windows.Forms.Button();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.datetxt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gcancelcmd = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(352, 16);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "‘„«—Â ”‰œ „Êﬁ  :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label2.Location = new System.Drawing.Point(376, 88);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.TabIndex = 1;
			this.label2.Text = "‘„«—Â ”‰œ œ«∆„ :";
			// 
			// dnumbertxt
			// 
			this.dnumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dnumbertxt.Location = new System.Drawing.Point(280, 16);
			this.dnumbertxt.Name = "dnumbertxt";
			this.dnumbertxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dnumbertxt.Size = new System.Drawing.Size(72, 20);
			this.dnumbertxt.TabIndex = 2;
			this.dnumbertxt.Text = "0";
			this.dnumbertxt.TextChanged += new System.EventHandler(this.dnumbertxt_TextChanged);
			// 
			// ddnumbertxt
			// 
			this.ddnumbertxt.Enabled = false;
			this.ddnumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ddnumbertxt.Location = new System.Drawing.Point(256, 88);
			this.ddnumbertxt.Name = "ddnumbertxt";
			this.ddnumbertxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ddnumbertxt.TabIndex = 3;
			this.ddnumbertxt.Text = "0";
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(320, 152);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.submitcmd.TabIndex = 4;
			this.submitcmd.Text = " «ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(120, 152);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.TabIndex = 5;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label3.Location = new System.Drawing.Point(136, 16);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.TabIndex = 6;
			this.label3.Text = " «—ÌŒ ÃœÌœ ”‰œ :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label4.Location = new System.Drawing.Point(112, 80);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "«‰ ﬁ«· œÂ‰œÂ :   1";
			// 
			// datetxt
			// 
			this.datetxt.Location = new System.Drawing.Point(0, 16);
			this.datetxt.Name = "datetxt";
			this.datetxt.Size = new System.Drawing.Size(128, 26);
			this.datetxt.TabIndex = 8;
			this.datetxt.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.button1.Location = new System.Drawing.Point(240, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.gcancelcmd);
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Location = new System.Drawing.Point(0, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 192);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// gcancelcmd
			// 
			this.gcancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.gcancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.gcancelcmd.Location = new System.Drawing.Point(192, 168);
			this.gcancelcmd.Name = "gcancelcmd";
			this.gcancelcmd.TabIndex = 12;
			this.gcancelcmd.Text = "«‰’—«›";
			this.gcancelcmd.Click += new System.EventHandler(this.gcancelcmd_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.CaptionText = "«”‰«œ „Êﬁ ";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(456, 144);
			this.dataGrid1.TabIndex = 11;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn2});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "Document";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "‘„«—Â ”‰œ";
			this.dataGridTextBoxColumn1.MappingName = "DocumentNr";
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 70;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = " «—ÌŒ ”‰œ";
			this.dataGridTextBoxColumn3.MappingName = "date";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 80;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "‘—Õ ”‰œ";
			this.dataGridTextBoxColumn2.MappingName = "DocumentDescription";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 200;
			// 
			// transferform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(480, 206);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.datetxt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cancelcmd);
			this.Controls.Add(this.submitcmd);
			this.Controls.Add(this.ddnumbertxt);
			this.Controls.Add(this.dnumbertxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.Name = "transferform";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "«‰ ﬁ«· Ìò ”‰œ „Êﬁ  »Â œ›« —";
			this.Load += new System.EventHandler(this.transferform_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			date(datetxt.Text);	
			if(ob.get_ID("DocumentNr","Document","DocumentNr='"+dnumbertxt.Text+"' AND DocumentType=0")==0)
			    MessageBox.Show("òœ Ê—ÊœÌ „⁄ »— ‰„Ì »«‘œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else if(ddnumbertxt.Text=="" )
				MessageBox.Show("  «—ÌŒ Ê—ÊœÌ „⁄ »— ‰„Ì »«‘œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else 
			{
				MessageBox.Show("«Ì‰ ”‰œ »⁄œ «“ «‰ ﬁ«· ﬁ«»· «’·«Õ ‰„Ì»«‘œ!¬Ì« Ê«ﬁ« „Ì ŒÊ«ÂÌœ «Ì‰ ”‰œ —« «‰ ﬁ«· œÂÌœ!","Å—”‘",MessageBoxButtons.OKCancel);
				ob.update("Document","DocumentType=1,DocumentDate='"+Persia.Calendar.ConvertToGregorian(year,month,day)+"',DocumentTransferCode=1","DocumentNr='"+dnumbertxt.Text+"'");
				this.Close();
			}
		}

		private void dnumbertxt_TextChanged(object sender, System.EventArgs e)
		{
			ddnumbertxt.Text=dnumbertxt.Text;
		}

		private void transferform_Load(object sender, System.EventArgs e)
		{
			datetxt.Text=Persia.Calendar.ConvertToPersian(System.DateTime.Today.Date).Simple.ToString();
		}

		private void cancelcmd_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			groupBox1.Visible=true;
			ob.get_Info("DocumentNr,DocumentDescription,Documentdate,FirstName  as date","Document INNER JOIN Employee ON Document.DocumentRegisterCode=Employee.EmployeeCode","DocumentType=0",dataset,"Document");
			dataGrid1.SetDataBinding(dataset,"Document");
			for(int i=0;i<dataset.Tables["Document"].Rows.Count;i++)
			{
				dataGrid1[i,1]=Persia.Calendar.ConvertToPersian(System.DateTime.Parse(dataset.Tables["Document"].Rows[i][2].ToString())).Simple.ToString();
			}
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			dnumbertxt.Text=dataGrid1[dataGrid1.CurrentRowIndex,0].ToString();
			groupBox1.Visible=false;
			dataset.Clear();
		}

		private void gcancelcmd_Click(object sender, System.EventArgs e)
		{
			groupBox1.Visible=false;
		}
		public void date(string date)
		{
			string y,m,d;
			Persia.SunDate dr=new Persia.SunDate();
			if(date!="")
			{
				dr.Simple=(date);
				y=dr.Simple.Substring(0,4);
				m=dr.Simple.Substring(5,2);
				if(m.Substring(1,1)=="/")
				{
					m=dr.Simple.Substring(5,1);
					if(dr.Simple.Length==8)
						d=dr.Simple.Substring(7,1);
					else
						d=dr.Simple.Substring(7,2);
				}
				else
				{
					if(dr.Simple.Length==9)
						d=dr.Simple.Substring(8,1);
					else
						d=dr.Simple.Substring(8,2);
				}
				year  = int.Parse(Persia.Number.ConvertToLatin(y));
				month =int.Parse(Persia.Number.ConvertToLatin(m) );
				day   =int.Parse(Persia.Number.ConvertToLatin(d));
				
			}
		}

		
	}
}
