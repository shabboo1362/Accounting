using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for editdocument.
	/// </summary>
	public class editdocument : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox documentntxt;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private codebehind ob=new codebehind();
		private int type1=0;
		private int type2=0;
		private string ceriteria="";
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public editdocument(int type)
		{
			type1=type;
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.documentntxt = new System.Windows.Forms.TextBox();
			this.submitcmd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 64);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(450, 400);
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
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = " «—ÌŒ";
			this.dataGridTextBoxColumn2.MappingName = "date";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 75;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "‘—Õ ”‰œ";
			this.dataGridTextBoxColumn3.MappingName = "DocumentDescription";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 200;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(280, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "‘„«—Â ”‰œ œ—ŒÊ«” Ì »—«Ì ÊÌ—«Ì‘ :";
			// 
			// documentntxt
			// 
			this.documentntxt.Location = new System.Drawing.Point(168, 8);
			this.documentntxt.Name = "documentntxt";
			this.documentntxt.TabIndex = 2;
			this.documentntxt.Text = "";
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(64, 8);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.TabIndex = 3;
			this.submitcmd.Text = " «ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// editdocument
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 466);
			this.Controls.Add(this.submitcmd);
			this.Controls.Add(this.documentntxt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGrid1);
			this.Name = "editdocument";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ê“Ì‰‘ ”‰œ";
			this.Load += new System.EventHandler(this.editdocument_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			if(documentntxt.Text!="0" || documentntxt.Text!="")
			{
				if(ob.get_ID("DocumentNr","Document","DocumentNr='"+documentntxt.Text+"' AND DocumentType='"+type2+"'")==0)
					MessageBox.Show("òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ","Œÿ«");
				else
				{
					documentform form=new documentform(int.Parse(documentntxt.Text),type1);
					form.ShowDialog();
				}
			}
			else
				MessageBox.Show("òœ —« Ê«—œ ‰„«ÌÌœ","Œÿ«");
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			documentform form=new documentform(int.Parse(dataGrid1[dataGrid1.CurrentRowIndex,0].ToString()),type1);
			form.ShowDialog();
		}

		private void editdocument_Load(object sender, System.EventArgs e)
		{
			check();
			DataSet dataset=new DataSet();
			ob.get_Info("DocumentNr,DocumentDescription,Documentdate,FirstName  as date","Document INNER JOIN Employee ON Document.DocumentRegisterCode=Employee.EmployeeCode",ceriteria,dataset,"Document");
			dataGrid1.DataSource=dataset;
			dataGrid1.DataMember="Document";
			for(int i=0;i<dataset.Tables["Document"].Rows.Count;i++)
			{
				dataGrid1[i,1]=Persia.Calendar.ConvertToPersian(System.DateTime.Parse(dataset.Tables["Document"].Rows[i][2].ToString())).Simple.ToString();
			}
		}
		private void check(){
			if(type1==0)
				ceriteria="DocumentType=0";
			else if(type1==1)
			{
				type2=1;
				ceriteria="DocumentType=1";
				this.Text="ê“Ì‰‘ »«“»Ì‰Ì ”‰œ œ«∆„";
				label1.Text="‘„«—Â ”‰œ œ—ŒÊ«” Ì »—«Ì »«“»Ì‰Ì :";
			}
			else if(type1==5)
			{
				ceriteria="DocumentType=0";
				this.Text="ê“Ì‰‘ »«“»Ì‰Ì ”‰œ „Êﬁ ";
				label1.Text="‘„«—Â ”‰œ œ—ŒÊ«” Ì »—«Ì »«“»Ì‰Ì :";
			}
			else
			{
				type2=1;
				ceriteria="DocumentType=1 AND DocumentTransferCode=1";
				this.Text="ê“Ì‰‘ »«“»Ì‰Ì ”‰œ «‰ ﬁ«· Ì«› Â";
				label1.Text="‘„«—Â ”‰œ œ—ŒÊ«” Ì »—«Ì »«“»Ì‰Ì :";
			}
		}

	}
}
