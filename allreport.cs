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
	/// Summary description for allreport.
	/// </summary>
	public class allreport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private string str1="",limit1="",fdate1="",tdate1="",fnumber1="",tnumber1="",document1="",sort1="";
		private string criteria="";
		string text="",tb="DetailedCode";
		private codebehind ob=new codebehind();
		private DataSet dataset=new DataSet();
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label creditlbl;
		private System.Windows.Forms.Label debitlbl;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
		private System.Windows.Forms.Label credit1lbl;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label debit1lbl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn25;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn26;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn27;
		private System.Windows.Forms.Button printcmd;
		private DataGridPrint PrintGrid;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public allreport(string str,string limit, string fdate,string tdate,string fnumber,string tnumber,string document,string sort)
		{
			str1=str;
			limit1=limit;
			fdate1=fdate;
			tdate1=tdate;
			fnumber1=fnumber;
			tnumber1=tnumber;
			document1=document;
			sort1=sort;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(allreport));
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.creditlbl = new System.Windows.Forms.Label();
			this.debitlbl = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.credit1lbl = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.debit1lbl = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.printcmd = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowDrop = true;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 32);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(790, 368);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1,
																								  this.dataGridTableStyle2,
																								  this.dataGridTableStyle3,
																								  this.dataGridTableStyle4});
			this.dataGrid1.TabStop = false;
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
			this.dataGridTableStyle1.MappingName = "document";
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
			this.dataGridTextBoxColumn1.Width = 50;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = " «—ÌŒ";
			this.dataGridTextBoxColumn2.MappingName = "DocumentDescription";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 80;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn3.MappingName = "GeneralCode";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 50;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn4.MappingName = "GeneralName";
			this.dataGridTextBoxColumn4.NullText = "";
			this.dataGridTextBoxColumn4.Width = 120;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn5.MappingName = "RowDescription";
			this.dataGridTextBoxColumn5.NullText = "";
			this.dataGridTextBoxColumn5.ReadOnly = true;
			this.dataGridTextBoxColumn5.Width = 200;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "»œÂò«—";
			this.dataGridTextBoxColumn6.MappingName = "RowCreditCost";
			this.dataGridTextBoxColumn6.NullText = "0";
			this.dataGridTextBoxColumn6.ReadOnly = true;
			this.dataGridTextBoxColumn6.Width = 150;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "»” «‰ò«—";
			this.dataGridTextBoxColumn7.MappingName = "RowDebitCost";
			this.dataGridTextBoxColumn7.NullText = "0";
			this.dataGridTextBoxColumn7.ReadOnly = true;
			this.dataGridTextBoxColumn7.Width = 150;
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.DataGrid = this.dataGrid1;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn8,
																												  this.dataGridTextBoxColumn9,
																												  this.dataGridTextBoxColumn10,
																												  this.dataGridTextBoxColumn11,
																												  this.dataGridTextBoxColumn12,
																												  this.dataGridTextBoxColumn13,
																												  this.dataGridTextBoxColumn14});
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle2.MappingName = "DetailedCode";
			this.dataGridTableStyle2.ReadOnly = true;
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn8.MappingName = "d1";
			this.dataGridTextBoxColumn8.NullText = "";
			this.dataGridTextBoxColumn8.ReadOnly = true;
			this.dataGridTextBoxColumn8.Width = 80;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.Format = "";
			this.dataGridTextBoxColumn9.FormatInfo = null;
			this.dataGridTextBoxColumn9.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn9.MappingName = "DetailedName";
			this.dataGridTextBoxColumn9.NullText = "";
			this.dataGridTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridTextBoxColumn10
			// 
			this.dataGridTextBoxColumn10.Format = "";
			this.dataGridTextBoxColumn10.FormatInfo = null;
			this.dataGridTextBoxColumn10.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn10.MappingName = "DetailedDescription";
			this.dataGridTextBoxColumn10.NullText = "";
			this.dataGridTextBoxColumn10.ReadOnly = true;
			this.dataGridTextBoxColumn10.Width = 200;
			// 
			// dataGridTextBoxColumn11
			// 
			this.dataGridTextBoxColumn11.Format = "";
			this.dataGridTextBoxColumn11.FormatInfo = null;
			this.dataGridTextBoxColumn11.HeaderText = "»œÂò«— ";
			this.dataGridTextBoxColumn11.MappingName = "credit";
			this.dataGridTextBoxColumn11.NullText = "0";
			this.dataGridTextBoxColumn11.ReadOnly = true;
			// 
			// dataGridTextBoxColumn12
			// 
			this.dataGridTextBoxColumn12.Format = "";
			this.dataGridTextBoxColumn12.FormatInfo = null;
			this.dataGridTextBoxColumn12.HeaderText = "»” «‰ò«—";
			this.dataGridTextBoxColumn12.MappingName = "debit";
			this.dataGridTextBoxColumn12.NullText = "0";
			this.dataGridTextBoxColumn12.ReadOnly = true;
			// 
			// dataGridTextBoxColumn13
			// 
			this.dataGridTextBoxColumn13.Format = "";
			this.dataGridTextBoxColumn13.FormatInfo = null;
			this.dataGridTextBoxColumn13.HeaderText = "„«‰œÂ »œÂò«—";
			this.dataGridTextBoxColumn13.MappingName = "d2";
			this.dataGridTextBoxColumn13.NullText = "0";
			// 
			// dataGridTextBoxColumn14
			// 
			this.dataGridTextBoxColumn14.Format = "";
			this.dataGridTextBoxColumn14.FormatInfo = null;
			this.dataGridTextBoxColumn14.HeaderText = "„«‰œÂ »” «‰ò«—";
			this.dataGridTextBoxColumn14.MappingName = "d3";
			this.dataGridTextBoxColumn14.NullText = "0";
			// 
			// dataGridTableStyle3
			// 
			this.dataGridTableStyle3.DataGrid = this.dataGrid1;
			this.dataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn15,
																												  this.dataGridTextBoxColumn16,
																												  this.dataGridTextBoxColumn17,
																												  this.dataGridTextBoxColumn18,
																												  this.dataGridTextBoxColumn19,
																												  this.dataGridTextBoxColumn20});
			this.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle3.MappingName = "General";
			this.dataGridTableStyle3.ReadOnly = true;
			// 
			// dataGridTextBoxColumn15
			// 
			this.dataGridTextBoxColumn15.Format = "";
			this.dataGridTextBoxColumn15.FormatInfo = null;
			this.dataGridTextBoxColumn15.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn15.MappingName = "GeneralCode";
			this.dataGridTextBoxColumn15.NullText = "";
			this.dataGridTextBoxColumn15.ReadOnly = true;
			this.dataGridTextBoxColumn15.Width = 80;
			// 
			// dataGridTextBoxColumn16
			// 
			this.dataGridTextBoxColumn16.Format = "";
			this.dataGridTextBoxColumn16.FormatInfo = null;
			this.dataGridTextBoxColumn16.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn16.MappingName = "GeneralName";
			this.dataGridTextBoxColumn16.NullText = "";
			this.dataGridTextBoxColumn16.ReadOnly = true;
			this.dataGridTextBoxColumn16.Width = 150;
			// 
			// dataGridTextBoxColumn17
			// 
			this.dataGridTextBoxColumn17.Format = "";
			this.dataGridTextBoxColumn17.FormatInfo = null;
			this.dataGridTextBoxColumn17.HeaderText = "»œÂò«—";
			this.dataGridTextBoxColumn17.MappingName = "credit";
			this.dataGridTextBoxColumn17.NullText = "";
			this.dataGridTextBoxColumn17.ReadOnly = true;
			// 
			// dataGridTextBoxColumn18
			// 
			this.dataGridTextBoxColumn18.Format = "";
			this.dataGridTextBoxColumn18.FormatInfo = null;
			this.dataGridTextBoxColumn18.HeaderText = "»” «‰ò«—";
			this.dataGridTextBoxColumn18.MappingName = "debit";
			this.dataGridTextBoxColumn18.NullText = "0";
			this.dataGridTextBoxColumn18.ReadOnly = true;
			// 
			// dataGridTextBoxColumn19
			// 
			this.dataGridTextBoxColumn19.Format = "";
			this.dataGridTextBoxColumn19.FormatInfo = null;
			this.dataGridTextBoxColumn19.HeaderText = "„«‰œÂ »œÂò«—";
			this.dataGridTextBoxColumn19.MappingName = "mcredit";
			this.dataGridTextBoxColumn19.NullText = "";
			this.dataGridTextBoxColumn19.ReadOnly = true;
			// 
			// dataGridTextBoxColumn20
			// 
			this.dataGridTextBoxColumn20.Format = "";
			this.dataGridTextBoxColumn20.FormatInfo = null;
			this.dataGridTextBoxColumn20.HeaderText = "„«‰œÂ »” «‰ò«—";
			this.dataGridTextBoxColumn20.MappingName = "mdebit";
			this.dataGridTextBoxColumn20.NullText = "0";
			this.dataGridTextBoxColumn20.ReadOnly = true;
			// 
			// dataGridTableStyle4
			// 
			this.dataGridTableStyle4.DataGrid = this.dataGrid1;
			this.dataGridTableStyle4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn21,
																												  this.dataGridTextBoxColumn22,
																												  this.dataGridTextBoxColumn23,
																												  this.dataGridTextBoxColumn24,
																												  this.dataGridTextBoxColumn25,
																												  this.dataGridTextBoxColumn26,
																												  this.dataGridTextBoxColumn27});
			this.dataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle4.MappingName = "Subsidiary";
			this.dataGridTableStyle4.ReadOnly = true;
			// 
			// dataGridTextBoxColumn21
			// 
			this.dataGridTextBoxColumn21.Format = "";
			this.dataGridTextBoxColumn21.FormatInfo = null;
			this.dataGridTextBoxColumn21.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn21.MappingName = "SubsidiaryCode";
			this.dataGridTextBoxColumn21.NullText = "0";
			this.dataGridTextBoxColumn21.ReadOnly = true;
			this.dataGridTextBoxColumn21.Width = 50;
			// 
			// dataGridTextBoxColumn22
			// 
			this.dataGridTextBoxColumn22.Format = "";
			this.dataGridTextBoxColumn22.FormatInfo = null;
			this.dataGridTextBoxColumn22.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn22.MappingName = "SubsidiaryName";
			this.dataGridTextBoxColumn22.NullText = "0";
			this.dataGridTextBoxColumn22.ReadOnly = true;
			// 
			// dataGridTextBoxColumn23
			// 
			this.dataGridTextBoxColumn23.Format = "";
			this.dataGridTextBoxColumn23.FormatInfo = null;
			this.dataGridTextBoxColumn23.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn23.MappingName = "SubsidiaryDescription";
			this.dataGridTextBoxColumn23.NullText = "0";
			this.dataGridTextBoxColumn23.ReadOnly = true;
			this.dataGridTextBoxColumn23.Width = 200;
			// 
			// dataGridTextBoxColumn24
			// 
			this.dataGridTextBoxColumn24.Format = "";
			this.dataGridTextBoxColumn24.FormatInfo = null;
			this.dataGridTextBoxColumn24.HeaderText = "»œÂò«—";
			this.dataGridTextBoxColumn24.MappingName = "credit";
			this.dataGridTextBoxColumn24.NullText = "0";
			this.dataGridTextBoxColumn24.ReadOnly = true;
			// 
			// dataGridTextBoxColumn25
			// 
			this.dataGridTextBoxColumn25.Format = "";
			this.dataGridTextBoxColumn25.FormatInfo = null;
			this.dataGridTextBoxColumn25.HeaderText = "»” «‰ò«—";
			this.dataGridTextBoxColumn25.MappingName = "debit";
			this.dataGridTextBoxColumn25.NullText = "0";
			this.dataGridTextBoxColumn25.ReadOnly = true;
			// 
			// dataGridTextBoxColumn26
			// 
			this.dataGridTextBoxColumn26.Format = "";
			this.dataGridTextBoxColumn26.FormatInfo = null;
			this.dataGridTextBoxColumn26.HeaderText = "„«‰œÂ »œÂò«—";
			this.dataGridTextBoxColumn26.MappingName = "mcredit";
			this.dataGridTextBoxColumn26.NullText = "0";
			this.dataGridTextBoxColumn26.ReadOnly = true;
			// 
			// dataGridTextBoxColumn27
			// 
			this.dataGridTextBoxColumn27.Format = "";
			this.dataGridTextBoxColumn27.FormatInfo = null;
			this.dataGridTextBoxColumn27.HeaderText = "„«‰œÂ »” «‰ò«—";
			this.dataGridTextBoxColumn27.MappingName = "mdebit";
			this.dataGridTextBoxColumn27.NullText = "0";
			this.dataGridTextBoxColumn27.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(336, 408);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "Ã„⁄ »œÂò«—";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// creditlbl
			// 
			this.creditlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.creditlbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.creditlbl.Location = new System.Drawing.Point(336, 440);
			this.creditlbl.Name = "creditlbl";
			this.creditlbl.TabIndex = 2;
			this.creditlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// debitlbl
			// 
			this.debitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.debitlbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.debitlbl.Location = new System.Drawing.Point(224, 440);
			this.debitlbl.Name = "debitlbl";
			this.debitlbl.TabIndex = 4;
			this.debitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label4.Location = new System.Drawing.Point(224, 408);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Ã„⁄ »” «‰ò«—";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// credit1lbl
			// 
			this.credit1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.credit1lbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.credit1lbl.Location = new System.Drawing.Point(112, 440);
			this.credit1lbl.Name = "credit1lbl";
			this.credit1lbl.TabIndex = 7;
			this.credit1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.credit1lbl.Visible = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label5.Location = new System.Drawing.Point(112, 408);
			this.label5.Name = "label5";
			this.label5.TabIndex = 6;
			this.label5.Text = "Ã„⁄  „«‰œÂ »œÂò«—";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Visible = false;
			// 
			// debit1lbl
			// 
			this.debit1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.debit1lbl.ForeColor = System.Drawing.Color.RoyalBlue;
			this.debit1lbl.Location = new System.Drawing.Point(0, 440);
			this.debit1lbl.Name = "debit1lbl";
			this.debit1lbl.TabIndex = 9;
			this.debit1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.debit1lbl.Visible = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label7.Location = new System.Drawing.Point(0, 408);
			this.label7.Name = "label7";
			this.label7.TabIndex = 8;
			this.label7.Text = "Ã„⁄  „«‰œÂ »” «‰ò«—";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.Visible = false;
			// 
			// printcmd
			// 
			this.printcmd.BackColor = System.Drawing.Color.Lavender;
			this.printcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.printcmd.Location = new System.Drawing.Point(24, 8);
			this.printcmd.Name = "printcmd";
			this.printcmd.TabIndex = 10;
			this.printcmd.Text = "ç«Å";
			this.printcmd.Click += new System.EventHandler(this.printcmd_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(260, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// allreport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 466);
			this.Controls.Add(this.printcmd);
			this.Controls.Add(this.debit1lbl);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.credit1lbl);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.debitlbl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.creditlbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGrid1);
			this.Name = "allreport";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ê“«—‘ Õ”«»œ«—Ì";
			this.Load += new System.EventHandler(this.allreport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void allreport_Load(object sender, System.EventArgs e)
		{
			filldataset();
			dataGrid1.SetDataBinding(dataset,tb);
//			dataGrid1.DataSource=dataset;
//			dataGrid1.DataMember=tb;
				hesab();
			
		}
		private void filldataset()
		{
			switch (document1)
			{
				case "constant":
					text+="«”‰«œ œ«∆„         ";
					criteria="DocumentType=1";
					break;
				case "temporary":
					text+="«”‰«œ „Êﬁ          ";
					criteria="DocumentType=0";
					break;
			}
			switch(limit1)
			{
				case "number":
					text+="«“ ‘„«—Â : "+fnumber1+"      « ‘„«—Â : "+tnumber1;
					criteria+=" AND Document.DocumentNr between ('"+fnumber1+"') And ('"+tnumber1+"')";
					break;
				case "date":
					criteria+=" AND RowDate BETWEEN '"+fdate1+"' And '"+tdate1+"'";
					break;
			}
			if(str1=="ra")
			{
				switch (sort1)
				{
					case "number":
						criteria+=" ORDER BY Document.DocumentNr";
						break;
					case "date":
						criteria+=" ORDER BY RowDate";
						break;
				}
			}
			switch (str1)
			{
				case "ra":
					tb="document";
					ob.get_Info("Document.DocumentNr,RowDate,GeneralName,DocumentRow.GeneralCode,RowDescription,RowCreditCost,RowDebitCost,DocumentDescription","Document INNER JOIN (DocumentRow INNER JOIN General ON DocumentRow.GeneralCode=General.GeneralCode)ON Document.DocumentNr=DocumentRow.DocumentNr",criteria,dataset,"document");
					dataGrid1.CaptionText="ê“«—‘ —Ì“ «”‰«œ            "+text;
					break;
				case "ght1":
					
					criteria+=" AND DocumentRow.DetailedCode1 is Not NULL Group by DocumentRow.DetailedCode1,DetailedName,DetailedCode2,DetailedCode3,DetailedDescription";
					ob.get_Info("DocumentRow.DetailedCode1 as d1,DetailedCode2 as d2,DetailedCode3 as d3,DetailedName,DetailedDescription,sum(RowCreditCost) as credit,Sum(RowDebitCost) as debit","Document INNER JOIN (DocumentRow INNER JOIN DetailedCode1 ON DocumentRow.DetailedCode1=DetailedCode1.DetailedCode1)ON Document.DocumentNr=DocumentRow.DocumentNr",criteria,dataset,"DetailedCode");
					dataGrid1.CaptionText="ê“«—‘ ò· Õ”«» Â«Ì  ›’Ì·Ì 1            "+text;
					break;
				case "ght2":
					criteria+=" AND DocumentRow.DetailedCode2 is Not NULL Group by DocumentRow.DetailedCode2,DocumentRow.DetailedCode1,DetailedCode3,DetailedName,DetailedDescription";
					ob.get_Info("DocumentRow.DetailedCode2 as d1,DocumentRow.DetailedCode1 as d2,DetailedCode3 as d3,DetailedName,DetailedDescription,sum(RowCreditCost) as credit,Sum(RowDebitCost) as debit","Document INNER JOIN (DocumentRow INNER JOIN DetailedCode2 ON DocumentRow.DetailedCode2=DetailedCode2.DetailedCode2)ON Document.DocumentNr=DocumentRow.DocumentNr",criteria,dataset,"DetailedCode");
					dataGrid1.CaptionText="ê“«—‘ ò· Õ”«» Â«Ì  ›’Ì·Ì 2            "+text;
					break;
				case "ght3":
					criteria+=" AND DocumentRow.DetailedCode3 is Not NULL Group by DocumentRow.DetailedCode3,DocumentRow.DetailedCode1 ,DocumentRow.DetailedCode2 ,DetailedName,DetailedDescription";
					ob.get_Info("DocumentRow.DetailedCode3 as d1,DocumentRow.DetailedCode1 as d2,DocumentRow.DetailedCode2 as d3,DetailedName,DetailedDescription,sum(RowCreditCost) as credit,Sum(RowDebitCost) as debit","Document INNER JOIN (DocumentRow INNER JOIN DetailedCode3 ON DocumentRow.DetailedCode3=DetailedCode3.DetailedCode3)ON Document.DocumentNr=DocumentRow.DocumentNr",criteria,dataset,"DetailedCode");
					dataGrid1.CaptionText="ê“«—‘ ò· Õ”«» Â«Ì  ›’Ì·Ì 3            "+text;
					break;
				case "tak":
					tb="General";
					criteria+=" And DocumentRow.GeneralCode is not null Group by DocumentRow.GeneralCode,DetailedCode1 ,DetailedCode2 ,GeneralName";
					ob.get_Info("DocumentRow.GeneralCode,DetailedCode1 as mcredit,DetailedCode2 as mdebit,GeneralName,sum(RowCreditCost) as credit,Sum(RowDebitCost) as debit","Document INNER JOIN (DocumentRow INNER JOIN General ON DocumentRow.GeneralCode=General.GeneralCode)ON Document.DocumentNr=DocumentRow.DocumentNr",criteria,dataset,"General");
					dataGrid1.CaptionText=" —«“ ¬“„«Ì‘Ì Õ”«» Â«Ì ò·           "+text; 
					break;
				case "tam":
					tb="Subsidiary";
					criteria+=" AND DocumentRow.SubsidiaryCode is Not NULL Group by DocumentRow.SubsidiaryCode,DetailedCode1 ,DetailedCode2 ,SubsidiaryName,SubsidiaryDescription";
					ob.get_Info("DocumentRow.SubsidiaryCode ,DetailedCode1 as mcredit,DetailedCode2 as mdebit,SubsidiaryName,SubsidiaryDescription,sum(RowCreditCost) as credit,Sum(RowDebitCost) as debit","Document INNER JOIN (DocumentRow INNER JOIN Subsidiary ON DocumentRow.SubsidiaryCode=Subsidiary.SubsidiaryCode)ON Document.DocumentNr=DocumentRow.DocumentNr",criteria,dataset,"Subsidiary");
					dataGrid1.CaptionText=" —«“ ¬“„«Ì‘Ì Õ”«» Â«Ì „⁄Ì‰             "+text;
					break;
			}
		}
			private void hesab(){
				int debit=0,credit=0,credit1=0,debit1=0;
				if(tb=="DetailedCode" || tb=="Subsidiary" )
				{
					for(int i=0;i<dataset.Tables[tb].Rows.Count;i++)
					{
						if(dataGrid1[i,3]!=dataset.Tables[tb].Columns[1].DefaultValue)
							credit+=int.Parse(dataGrid1[i,3].ToString());
						if(dataGrid1[i,4]!=dataset.Tables[tb].Columns[2].DefaultValue)
							debit+=int.Parse(dataGrid1[i,4].ToString());
						int a=int.Parse(dataGrid1[i,3].ToString())-int.Parse(dataGrid1[i,4].ToString());
						if(a>0)
						{
							dataGrid1[i,5]=a;
							dataGrid1[i,6]=0;
						}
						else if(a<0)
						{
							dataGrid1[i,6]=-a;
							dataGrid1[i,5]=0;
						}
						else
						{
							dataGrid1[i,6]=-a;
							dataGrid1[i,5]=0;
						}
						if(dataGrid1[i,5]!=dataset.Tables[tb].Columns[1].DefaultValue)
							credit1+=int.Parse(dataGrid1[i,5].ToString());
						if(dataGrid1[i,6]!=dataset.Tables[tb].Columns[2].DefaultValue)
							debit1+=int.Parse(dataGrid1[i,6].ToString());
					}
				}

					if(tb=="General")
					{
						for(int i=0;i<dataset.Tables["General"].Rows.Count;i++)
						{
							if(dataGrid1[i,2]!=dataset.Tables["General"].Columns[1].DefaultValue)
								credit+=int.Parse(dataGrid1[i,2].ToString());
							if(dataGrid1[i,3]!=dataset.Tables["General"].Columns[2].DefaultValue)
								debit+=int.Parse(dataGrid1[i,3].ToString());
							int a=int.Parse(dataGrid1[i,2].ToString())-int.Parse(dataGrid1[i,3].ToString());
							if(a>0)
							{
								dataGrid1[i,4]=a;
								dataGrid1[i,5]=0;
							}
							else if(a<0)
							{
								dataGrid1[i,5]=-a;
								dataGrid1[i,4]=0;
							}
							else
							{
								dataGrid1[i,5]=-a;
								dataGrid1[i,4]=0;
							}
							if(dataGrid1[i,4]!=dataset.Tables["General"].Columns[1].DefaultValue)
								credit1+=int.Parse(dataGrid1[i,4].ToString());
							if(dataGrid1[i,5]!=dataset.Tables["General"].Columns[2].DefaultValue)
								debit1+=int.Parse(dataGrid1[i,5].ToString());
						}
					}
					if(tb=="General" || tb=="DetailedCode" || tb=="Subsidiary")
					{
						creditlbl.Text=credit.ToString();
						debitlbl.Text=debit.ToString();
						credit1lbl.Visible=true;
						debit1lbl.Visible=true;
						label5.Visible=true;
						label7.Visible=true;
						credit1lbl.Text=credit1.ToString();
						debit1lbl.Text=debit1.ToString();
					}
					if(tb=="document")
					{
					for(int i=0;i<dataset.Tables["document"].Rows.Count;i++)
					{
						dataGrid1[i,1]=Persia.Calendar.ConvertToPersian(DateTime.Parse(dataset.Tables["document"].Rows[i][1].ToString())).Simple;
						if(dataGrid1[i,5]!=dataset.Tables["document"].Columns[5].DefaultValue)
							credit+=int.Parse(dataGrid1[i,5].ToString());
						if(dataGrid1[i,6]!=dataset.Tables["document"].Columns[6].DefaultValue)
							debit+=int.Parse(dataGrid1[i,6].ToString());
					}
					creditlbl.Text=credit.ToString();
					debitlbl.Text=debit.ToString();
				}
		}

		private void printcmd_Click(object sender, System.EventArgs e)
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
				if (fpr.Result == 1) 
				{ 
					if (printDialog1.ShowDialog() == DialogResult.OK) 
					{ 
						printDocument1.Print(); 
					} 
				} 
				else if (fpr.Result == 2)
				{ 
					pageSetupDialog1.ShowDialog(); 
				} 
				else if (fpr.Result == 3)
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
