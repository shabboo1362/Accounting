using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using RustemSoft.DataGridColumns;

namespace Accounting
{
	/// <summary>
	/// Summary description for reports.
	/// </summary>
	public class reports : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private string fcode1="",criteria="",tcode1="",code1="",limit1="",fdate1="",tdate1="",fnumber1="",snumber1="",scode1="",ncode1="",document1="",sort1="";
		public System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private DataSet dataset=new DataSet();
		private codebehind ob=new codebehind();
		private DataGridPrint PrintGrid;
		private int a=0,d=0,credit=0,debit=0;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label creditlbl;
		private System.Windows.Forms.Label debitlbl;
		private System.Windows.Forms.Label tashkhislbl;
		private System.Windows.Forms.Label mondelbl;
		private System.Windows.Forms.Button print;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public reports(string code,string fcode,string tcode,string limit,string fdate,string tdate,string fnumber,string snumber,string scode,string ncode,string document,string sort)
		{
			code1=code;
			limit1=limit;
			fdate1=fdate;
			tdate1=tdate;
			fnumber1=fnumber;
			snumber1=snumber;
			scode1=scode;
			ncode1=ncode;
			document1=document;
			sort1=sort;
			fcode1=fcode;
			tcode1=tcode;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(reports));
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.creditlbl = new System.Windows.Forms.Label();
			this.debitlbl = new System.Windows.Forms.Label();
			this.tashkhislbl = new System.Windows.Forms.Label();
			this.mondelbl = new System.Windows.Forms.Label();
			this.print = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowDrop = true;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.CaptionText = "œ› —";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(32, 32);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGrid1.Size = new System.Drawing.Size(660, 368);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5,
																												  this.dataGridTextBoxColumn6,
																												  this.dataGridTextBoxColumn7});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "DocumentRow";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "‘„«—Â ”‰œ";
			this.dataGridTextBoxColumn1.MappingName = "DocumentNr";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 30;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = " «—ÌŒ";
			this.dataGridTextBoxColumn2.MappingName = "date";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 80;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn3.MappingName = "RowDescription";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 200;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "»œÂò«—";
			this.dataGridTextBoxColumn4.MappingName = "RowCreditCost";
			this.dataGridTextBoxColumn4.NullText = "0";
			this.dataGridTextBoxColumn4.ReadOnly = true;
			this.dataGridTextBoxColumn4.Width = 90;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "»” «‰ò«—";
			this.dataGridTextBoxColumn5.MappingName = "RowDebitCost";
			this.dataGridTextBoxColumn5.NullText = "0";
			this.dataGridTextBoxColumn5.ReadOnly = true;
			this.dataGridTextBoxColumn5.Width = 90;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = " ‘ŒÌ’";
			this.dataGridTextBoxColumn6.MappingName = "DocumentDescription";
			this.dataGridTextBoxColumn6.NullText = "";
			this.dataGridTextBoxColumn6.ReadOnly = true;
			this.dataGridTextBoxColumn6.Width = 40;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "„«‰œÂ";
			this.dataGridTextBoxColumn7.MappingName = "DetailedCode1";
			this.dataGridTextBoxColumn7.NullText = "0";
			this.dataGridTextBoxColumn7.ReadOnly = true;
			this.dataGridTextBoxColumn7.Width = 120;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(352, 400);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ã„⁄ :";
			// 
			// creditlbl
			// 
			this.creditlbl.Location = new System.Drawing.Point(248, 400);
			this.creditlbl.Name = "creditlbl";
			this.creditlbl.Size = new System.Drawing.Size(96, 23);
			this.creditlbl.TabIndex = 4;
			// 
			// debitlbl
			// 
			this.debitlbl.Location = new System.Drawing.Point(136, 400);
			this.debitlbl.Name = "debitlbl";
			this.debitlbl.TabIndex = 5;
			// 
			// tashkhislbl
			// 
			this.tashkhislbl.Location = new System.Drawing.Point(104, 400);
			this.tashkhislbl.Name = "tashkhislbl";
			this.tashkhislbl.Size = new System.Drawing.Size(24, 23);
			this.tashkhislbl.TabIndex = 7;
			// 
			// mondelbl
			// 
			this.mondelbl.Location = new System.Drawing.Point(16, 400);
			this.mondelbl.Name = "mondelbl";
			this.mondelbl.Size = new System.Drawing.Size(80, 23);
			this.mondelbl.TabIndex = 8;
			// 
			// print
			// 
			this.print.BackColor = System.Drawing.Color.Lavender;
			this.print.ForeColor = System.Drawing.Color.RoyalBlue;
			this.print.Location = new System.Drawing.Point(80, 8);
			this.print.Name = "print";
			this.print.TabIndex = 9;
			this.print.Text = "ç«Å";
			this.print.Click += new System.EventHandler(this.print_Click);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(132, 174);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// reports
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(692, 466);
			this.Controls.Add(this.print);
			this.Controls.Add(this.mondelbl);
			this.Controls.Add(this.tashkhislbl);
			this.Controls.Add(this.debitlbl);
			this.Controls.Add(this.creditlbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGrid1);
			this.Name = "reports";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ê“«—‘«  œ›« —";
			this.Load += new System.EventHandler(this.reports_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void reports_Load(object sender, System.EventArgs e)
		{
			switch (code1)
			{
				case "Detailed1":
					dataGrid1.CaptionText="œ› —  ›’Ì·Ì 1        òœ Õ”«» :  "+fcode1;
					criteria="DetailedCode1='"+fcode1+"'";
					break;
				case "Detailed2":
					dataGrid1.CaptionText="œ› —  ›’Ì·Ì 2        òœ Õ”«» :  "+fcode1;
					criteria="DetailedCode2='"+fcode1+"'";
					break;
				case "Detailed3":
					dataGrid1.CaptionText="œ› —  ›’Ì·Ì 3        òœ Õ”«» :  "+fcode1;
					criteria="DetailedCode3='"+fcode1+"'";
					break;
				case "General":
					dataGrid1.CaptionText="œ› — ò·        «“ òœ Õ”«» :  "+fcode1+"       « òœ Õ”«» : "+tcode1;
					criteria="GeneralCode between ('"+fcode1+"') AND ('"+tcode1+"')";
					break;
				case "Subsidiary":
					dataGrid1.CaptionText="œ› — „⁄Ì‰        «“ òœ Õ”«» :  "+fcode1+"       « òœ Õ”«» : "+tcode1;
					criteria="SubsidiaryCode between ('"+fcode1+"') AND ('"+tcode1+"')";
					break;
			}
			switch (limit1){
				case "number":
					criteria+="AND Document.DocumentNr between ('"+fnumber1+"') And ('"+snumber1+"')";
					break;
				case "date":
					criteria+="AND RowDate between '"+fdate1+"' And '"+tdate1+"'";
					break;
			}
			switch (scode1)
			{
				case "general":
					criteria+="AND GeneralCode='"+ncode1+"'";
					break;
				case "subsidiary":
					criteria+="AND SubsidiaryCode='"+ncode1+"'";
					break;
			}
			switch (document1)
			{
				case "temporary":
					criteria+="AND DocumentType=0";
					break;
				case "constant":
					criteria+="AND DocumentType=1";
					break;
			}
			switch (sort1)
			{
				case "number":
					criteria+="ORDER BY Document.DocumentNr";
					break;
				case "date":
					criteria+="ORDER BY RowDate";
					break;
			}
			ob.get_Info("DocumentRow.DocumentNr,RowDate,RowDescription,RowDebitCost,RowCreditCost,Detailedcode1,DocumentDescription,FirstName as date","(DocumentRow INNER JOIN Document ON Document.DocumentNr=DocumentRow.DocumentNr) inner join Employee On Document.DocumentRegisterCode=Employee.EmployeeCode",criteria,dataset,"DocumentRow");
			dataGrid1.SetDataBinding(dataset,"DocumentRow");
			for(int i=0;i<dataset.Tables["DocumentRow"].Rows.Count;i++)
			{
				dataGrid1[i,1]=Persia.Calendar.ConvertToPersian(DateTime.Parse(dataset.Tables["DocumentRow"].Rows[i][1].ToString())).Simple.ToString();
				credit+=int.Parse(dataset.Tables["DocumentRow"].Rows[i][4].ToString());
				debit+=int.Parse(dataset.Tables["DocumentRow"].Rows[i][3].ToString());
				a+=int.Parse(dataset.Tables["DocumentRow"].Rows[i][3].ToString())-int.Parse(dataset.Tables["DocumentRow"].Rows[i][4].ToString());
				if(a<0)
				{
					dataGrid1[i,5]="»œ";
					tashkhislbl.Text="»œ";
					d=-a;
				}
				else if(a>0)
				{
					dataGrid1[i,5]="»”";
					d=a;
					tashkhislbl.Text="»”";
				}
				else
				{
					dataGrid1[i,5]="0";
					d=a;
				}
				dataGrid1[i,6]=d;
			}
			creditlbl.Text=credit.ToString();
			debitlbl.Text=debit.ToString();
			mondelbl.Text=d.ToString();
			
		}

		private void print_Click(object sender, System.EventArgs e)
		{
			printDialog1.Document = printDocument1; 
			pageSetupDialog1.Document = printDocument1; 
			printPreviewDialog1.Document = printDocument1; 
			frmPrint fpr = new frmPrint(); 
			fpr.Title = dataGrid1.CaptionText; 
			fpr.ShowDialog(); 
			if (fpr.Result > 0) 
			{ 
				PrintGrid = new DataGridPrint(printDocument1, dataGrid1, fpr.bBlackWhite); 
				PrintGrid.PrintTitle = fpr.bTitle; 
				PrintGrid.Title = fpr.Title; 
				if (fpr.Result == 1) // Print 
				{ 
					if (printDialog1.ShowDialog() == DialogResult.OK) 
					{ 
						printDocument1.Print(); 
					} 
				} 
				else if (fpr.Result == 2) // Page setup
				{ 
					pageSetupDialog1.ShowDialog(); 
				} 
				else if (fpr.Result == 3) // Preview
				{ 
					printPreviewDialog1.Icon = fpr.Icon; 
					printPreviewDialog1.ShowDialog(); 
				} 
			}		
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.HasMorePages = PrintGrid.Print(e.Graphics); 
		}

	}
}
