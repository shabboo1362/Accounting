using System;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using RustemSoft.DataGridColumns;

namespace Accounting
{
	/// <summary>
	/// Summary description for document.
	/// </summary>
	public class documentform : System.Windows.Forms.Form
	{
		private DataGridPrint PrintGrid; 
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox documentnumbertxt;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox datetxt;
		private codebehind ob=new codebehind();
		public System.Windows.Forms.DataGrid dataGrid1;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGrid dataGrid2;
		public System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private String table="";
		private String str="";
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		public System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem generalitem;
		private System.Windows.Forms.MenuItem subsidiaryitem;
		private System.Windows.Forms.MenuItem detaileditem1;
		private System.Windows.Forms.MenuItem detaileditem2;
		private System.Windows.Forms.MenuItem detaileditem3;
		private DataSet dataset1=new DataSet();
		private DataSet dataset=new DataSet();
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.TextBox descriptiontxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button exitcmd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label creditlbl;
		private System.Windows.Forms.Label debitlbl;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.Button submitcmd;
		private System.Windows.Forms.Button cancelcmd;
		private string ceriteria="";
		private SqlDataReader datareader;
		private int nr1=0;
		private int row=0, year=0,month=0,day=0;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private int type1=0;
		private System.Windows.Forms.Button printcmd;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public documentform(int nr, int type)
		{
			type1=type;
			nr1=nr;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(documentform));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.datetxt = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.documentnumbertxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle5 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle6 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.exitcmd = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.generalitem = new System.Windows.Forms.MenuItem();
			this.subsidiaryitem = new System.Windows.Forms.MenuItem();
			this.detaileditem1 = new System.Windows.Forms.MenuItem();
			this.detaileditem2 = new System.Windows.Forms.MenuItem();
			this.detaileditem3 = new System.Windows.Forms.MenuItem();
			this.descriptiontxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.creditlbl = new System.Windows.Forms.Label();
			this.debitlbl = new System.Windows.Forms.Label();
			this.submitcmd = new System.Windows.Forms.Button();
			this.cancelcmd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.printcmd = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(424, 8);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.datetxt);
			this.panel1.Controls.Add(this.label);
			this.panel1.Controls.Add(this.documentnumbertxt);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(980, 30);
			this.panel1.TabIndex = 1;
			// 
			// datetxt
			// 
			this.datetxt.Location = new System.Drawing.Point(456, 0);
			this.datetxt.Name = "datetxt";
			this.datetxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.datetxt.Size = new System.Drawing.Size(125, 20);
			this.datetxt.TabIndex = 3;
			this.datetxt.Text = "";
			// 
			// label
			// 
			this.label.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label.Location = new System.Drawing.Point(592, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(64, 23);
			this.label.TabIndex = 2;
			this.label.Text = " «—ÌŒ ’œÊ— :";
			// 
			// documentnumbertxt
			// 
			this.documentnumbertxt.Location = new System.Drawing.Point(784, 0);
			this.documentnumbertxt.Name = "documentnumbertxt";
			this.documentnumbertxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.documentnumbertxt.Size = new System.Drawing.Size(125, 20);
			this.documentnumbertxt.TabIndex = 1;
			this.documentnumbertxt.Text = "";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label2.Location = new System.Drawing.Point(920, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "‘„«—Â ”‰œ :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowDrop = true;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 80);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(1000, 400);
			this.dataGrid1.TabIndex = 2;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn9,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5,
																												  this.dataGridTextBoxColumn6,
																												  this.dataGridTextBoxColumn7,
																												  this.dataGridTextBoxColumn8,
																												  this.dataGridTextBoxColumn10,
																												  this.dataGridTextBoxColumn11});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "DocumentRow";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "‘„«—Â —œÌ›";
			this.dataGridTextBoxColumn1.MappingName = "DocumentRowNr";
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 50;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.Format = "";
			this.dataGridTextBoxColumn9.FormatInfo = null;
			this.dataGridTextBoxColumn9.HeaderText = " «—ÌŒ";
			this.dataGridTextBoxColumn9.MappingName = "DocumentDescription";
			this.dataGridTextBoxColumn9.NullText = "";
			this.dataGridTextBoxColumn9.Width = 80;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "òœ ò·";
			this.dataGridTextBoxColumn2.MappingName = "GeneralCode";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.Width = 50;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "òœ „⁄Ì‰";
			this.dataGridTextBoxColumn4.MappingName = "SubsidiaryCode";
			this.dataGridTextBoxColumn4.NullText = "";
			this.dataGridTextBoxColumn4.Width = 50;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "òœ  ›’Ì·Ì1";
			this.dataGridTextBoxColumn5.MappingName = "DetailedCode1";
			this.dataGridTextBoxColumn5.NullText = "";
			this.dataGridTextBoxColumn5.Width = 50;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "òœ  ›’Ì·Ì2";
			this.dataGridTextBoxColumn6.MappingName = "DetailedCode2";
			this.dataGridTextBoxColumn6.NullText = "";
			this.dataGridTextBoxColumn6.Width = 50;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "òœ  ›’Ì·Ì3";
			this.dataGridTextBoxColumn7.MappingName = "DetailedCode3";
			this.dataGridTextBoxColumn7.NullText = "";
			this.dataGridTextBoxColumn7.Width = 50;
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = "‘—Õ —œÌ›";
			this.dataGridTextBoxColumn8.MappingName = "RowDescription";
			this.dataGridTextBoxColumn8.NullText = "";
			this.dataGridTextBoxColumn8.Width = 300;
			// 
			// dataGridTextBoxColumn10
			// 
			this.dataGridTextBoxColumn10.Format = "";
			this.dataGridTextBoxColumn10.FormatInfo = null;
			this.dataGridTextBoxColumn10.HeaderText = "»œÂò«—";
			this.dataGridTextBoxColumn10.MappingName = "RowCreditcost";
			this.dataGridTextBoxColumn10.NullText = "";
			this.dataGridTextBoxColumn10.Width = 150;
			// 
			// dataGridTextBoxColumn11
			// 
			this.dataGridTextBoxColumn11.Format = "";
			this.dataGridTextBoxColumn11.FormatInfo = null;
			this.dataGridTextBoxColumn11.HeaderText = "»” «‰ò«—";
			this.dataGridTextBoxColumn11.MappingName = "RowDebitCost";
			this.dataGridTextBoxColumn11.NullText = "";
			this.dataGridTextBoxColumn11.Width = 150;
			// 
			// dataGrid2
			// 
			this.dataGrid2.AllowDrop = true;
			this.dataGrid2.CaptionBackColor = System.Drawing.Color.Pink;
			this.dataGrid2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.dataGrid2.CaptionForeColor = System.Drawing.Color.RoyalBlue;
			this.dataGrid2.CausesValidation = false;
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(8, 16);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.Size = new System.Drawing.Size(480, 248);
			this.dataGrid2.TabIndex = 4;
			this.dataGrid2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle2,
																								  this.dataGridTableStyle3,
																								  this.dataGridTableStyle4,
																								  this.dataGridTableStyle5,
																								  this.dataGridTableStyle6});
			this.dataGrid2.DoubleClick += new System.EventHandler(this.dataGrid2_DoubleClick);
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.DataGrid = this.dataGrid2;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn24});
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle2.MappingName = "General";
			this.dataGridTableStyle2.ReadOnly = true;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn3.MappingName = "GeneralCode";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 75;
			// 
			// dataGridTextBoxColumn24
			// 
			this.dataGridTextBoxColumn24.Format = "";
			this.dataGridTextBoxColumn24.FormatInfo = null;
			this.dataGridTextBoxColumn24.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn24.MappingName = "GeneralName";
			this.dataGridTextBoxColumn24.NullText = "";
			this.dataGridTextBoxColumn24.ReadOnly = true;
			this.dataGridTextBoxColumn24.Width = 120;
			// 
			// dataGridTableStyle3
			// 
			this.dataGridTableStyle3.DataGrid = this.dataGrid2;
			this.dataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn12,
																												  this.dataGridTextBoxColumn13,
																												  this.dataGridTextBoxColumn14});
			this.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle3.MappingName = "Subsidiary";
			this.dataGridTableStyle3.ReadOnly = true;
			// 
			// dataGridTextBoxColumn12
			// 
			this.dataGridTextBoxColumn12.Format = "";
			this.dataGridTextBoxColumn12.FormatInfo = null;
			this.dataGridTextBoxColumn12.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn12.MappingName = "SubsidiaryCode";
			this.dataGridTextBoxColumn12.ReadOnly = true;
			this.dataGridTextBoxColumn12.Width = 75;
			// 
			// dataGridTextBoxColumn13
			// 
			this.dataGridTextBoxColumn13.Format = "";
			this.dataGridTextBoxColumn13.FormatInfo = null;
			this.dataGridTextBoxColumn13.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn13.MappingName = "SubsidiaryName";
			this.dataGridTextBoxColumn13.Width = 120;
			// 
			// dataGridTextBoxColumn14
			// 
			this.dataGridTextBoxColumn14.Format = "";
			this.dataGridTextBoxColumn14.FormatInfo = null;
			this.dataGridTextBoxColumn14.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn14.MappingName = "SubsidiaryDescription";
			this.dataGridTextBoxColumn14.NullText = "";
			this.dataGridTextBoxColumn14.ReadOnly = true;
			this.dataGridTextBoxColumn14.Width = 200;
			// 
			// dataGridTableStyle4
			// 
			this.dataGridTableStyle4.DataGrid = this.dataGrid2;
			this.dataGridTableStyle4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn15,
																												  this.dataGridTextBoxColumn17,
																												  this.dataGridTextBoxColumn16});
			this.dataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle4.MappingName = "DetailedCode1";
			this.dataGridTableStyle4.ReadOnly = true;
			// 
			// dataGridTextBoxColumn15
			// 
			this.dataGridTextBoxColumn15.Format = "";
			this.dataGridTextBoxColumn15.FormatInfo = null;
			this.dataGridTextBoxColumn15.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn15.MappingName = "DetailedCode1";
			this.dataGridTextBoxColumn15.NullText = "";
			this.dataGridTextBoxColumn15.ReadOnly = true;
			this.dataGridTextBoxColumn15.Width = 75;
			// 
			// dataGridTextBoxColumn17
			// 
			this.dataGridTextBoxColumn17.Format = "";
			this.dataGridTextBoxColumn17.FormatInfo = null;
			this.dataGridTextBoxColumn17.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn17.MappingName = "DetailedName";
			this.dataGridTextBoxColumn17.NullText = "";
			this.dataGridTextBoxColumn17.ReadOnly = true;
			this.dataGridTextBoxColumn17.Width = 120;
			// 
			// dataGridTextBoxColumn16
			// 
			this.dataGridTextBoxColumn16.Format = "";
			this.dataGridTextBoxColumn16.FormatInfo = null;
			this.dataGridTextBoxColumn16.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn16.MappingName = "DetailedDescription";
			this.dataGridTextBoxColumn16.NullText = "";
			this.dataGridTextBoxColumn16.ReadOnly = true;
			this.dataGridTextBoxColumn16.Width = 200;
			// 
			// dataGridTableStyle5
			// 
			this.dataGridTableStyle5.DataGrid = this.dataGrid2;
			this.dataGridTableStyle5.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn18,
																												  this.dataGridTextBoxColumn19,
																												  this.dataGridTextBoxColumn20});
			this.dataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle5.MappingName = "DetailedCode2";
			this.dataGridTableStyle5.ReadOnly = true;
			// 
			// dataGridTextBoxColumn18
			// 
			this.dataGridTextBoxColumn18.Format = "";
			this.dataGridTextBoxColumn18.FormatInfo = null;
			this.dataGridTextBoxColumn18.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn18.MappingName = "DetailedCode2";
			this.dataGridTextBoxColumn18.NullText = "";
			this.dataGridTextBoxColumn18.ReadOnly = true;
			this.dataGridTextBoxColumn18.Width = 75;
			// 
			// dataGridTextBoxColumn19
			// 
			this.dataGridTextBoxColumn19.Format = "";
			this.dataGridTextBoxColumn19.FormatInfo = null;
			this.dataGridTextBoxColumn19.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn19.MappingName = "DetailedName";
			this.dataGridTextBoxColumn19.NullText = "";
			this.dataGridTextBoxColumn19.ReadOnly = true;
			this.dataGridTextBoxColumn19.Width = 120;
			// 
			// dataGridTextBoxColumn20
			// 
			this.dataGridTextBoxColumn20.Format = "";
			this.dataGridTextBoxColumn20.FormatInfo = null;
			this.dataGridTextBoxColumn20.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn20.MappingName = "DetailedDescription";
			this.dataGridTextBoxColumn20.NullText = "";
			this.dataGridTextBoxColumn20.ReadOnly = true;
			this.dataGridTextBoxColumn20.Width = 200;
			// 
			// dataGridTableStyle6
			// 
			this.dataGridTableStyle6.DataGrid = this.dataGrid2;
			this.dataGridTableStyle6.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn21,
																												  this.dataGridTextBoxColumn22,
																												  this.dataGridTextBoxColumn23});
			this.dataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle6.MappingName = "DetailedCode3";
			this.dataGridTableStyle6.ReadOnly = true;
			// 
			// dataGridTextBoxColumn21
			// 
			this.dataGridTextBoxColumn21.Format = "";
			this.dataGridTextBoxColumn21.FormatInfo = null;
			this.dataGridTextBoxColumn21.HeaderText = "òœ Õ”«»";
			this.dataGridTextBoxColumn21.MappingName = "DetailedCode3";
			this.dataGridTextBoxColumn21.NullText = "";
			this.dataGridTextBoxColumn21.ReadOnly = true;
			this.dataGridTextBoxColumn21.Width = 75;
			// 
			// dataGridTextBoxColumn22
			// 
			this.dataGridTextBoxColumn22.Format = "";
			this.dataGridTextBoxColumn22.FormatInfo = null;
			this.dataGridTextBoxColumn22.HeaderText = "⁄‰Ê«‰ Õ”«»";
			this.dataGridTextBoxColumn22.MappingName = "DetailedName";
			this.dataGridTextBoxColumn22.NullText = "";
			this.dataGridTextBoxColumn22.ReadOnly = true;
			this.dataGridTextBoxColumn22.Width = 120;
			// 
			// dataGridTextBoxColumn23
			// 
			this.dataGridTextBoxColumn23.Format = "";
			this.dataGridTextBoxColumn23.FormatInfo = null;
			this.dataGridTextBoxColumn23.HeaderText = "‘—Õ";
			this.dataGridTextBoxColumn23.MappingName = "DetailedDescription";
			this.dataGridTextBoxColumn23.NullText = "";
			this.dataGridTextBoxColumn23.ReadOnly = true;
			this.dataGridTextBoxColumn23.Width = 200;
			// 
			// groupBox1
			// 
			this.groupBox1.CausesValidation = false;
			this.groupBox1.Controls.Add(this.exitcmd);
			this.groupBox1.Controls.Add(this.dataGrid2);
			this.groupBox1.Location = new System.Drawing.Point(192, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 312);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// exitcmd
			// 
			this.exitcmd.BackColor = System.Drawing.Color.Lavender;
			this.exitcmd.CausesValidation = false;
			this.exitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.exitcmd.Location = new System.Drawing.Point(184, 280);
			this.exitcmd.Name = "exitcmd";
			this.exitcmd.TabIndex = 5;
			this.exitcmd.Text = "Œ—ÊÃ";
			this.exitcmd.Click += new System.EventHandler(this.exitcmd_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.generalitem,
																					  this.subsidiaryitem,
																					  this.detaileditem1,
																					  this.detaileditem2,
																					  this.detaileditem3});
			// 
			// generalitem
			// 
			this.generalitem.Index = 0;
			this.generalitem.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.generalitem.Text = "„‘«ÂœÂ Õ”«» Â«Ì ò·   f1";
			this.generalitem.Click += new System.EventHandler(this.generalitem_Click);
			// 
			// subsidiaryitem
			// 
			this.subsidiaryitem.Index = 1;
			this.subsidiaryitem.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.subsidiaryitem.Text = "„‘«ÂœÂ Õ”«»Â«Ì „⁄Ì‰   f2";
			this.subsidiaryitem.Click += new System.EventHandler(this.subsidiaryitem_Click);
			// 
			// detaileditem1
			// 
			this.detaileditem1.Index = 2;
			this.detaileditem1.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.detaileditem1.Text = "„‘«ÂœÂ Õ”«»Â«Ì  ›’Ì·Ì1   f3";
			this.detaileditem1.Click += new System.EventHandler(this.detaileditem1_Click);
			// 
			// detaileditem2
			// 
			this.detaileditem2.Index = 3;
			this.detaileditem2.Shortcut = System.Windows.Forms.Shortcut.F4;
			this.detaileditem2.Text = "„‘«ÂœÂ Õ”«»Â«Ì  ›’Ì·Ì2   f4";
			this.detaileditem2.Click += new System.EventHandler(this.detaileditem2_Click);
			// 
			// detaileditem3
			// 
			this.detaileditem3.Index = 4;
			this.detaileditem3.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.detaileditem3.Text = "„‘«ÂœÂ Õ”«»Â«Ì  ›’Ì·Ì3   f5";
			this.detaileditem3.Click += new System.EventHandler(this.detaileditem3_Click);
			// 
			// descriptiontxt
			// 
			this.descriptiontxt.Location = new System.Drawing.Point(464, 488);
			this.descriptiontxt.Name = "descriptiontxt";
			this.descriptiontxt.Size = new System.Drawing.Size(408, 20);
			this.descriptiontxt.TabIndex = 7;
			this.descriptiontxt.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label3.Location = new System.Drawing.Point(888, 488);
			this.label3.Name = "label3";
			this.label3.TabIndex = 8;
			this.label3.Text = "‘—Õ ”‰œ:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label5.Location = new System.Drawing.Point(128, 8);
			this.label5.Name = "label5";
			this.label5.TabIndex = 10;
			this.label5.Text = "Ã„⁄ »œÂò«—";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label6.Location = new System.Drawing.Point(128, 40);
			this.label6.Name = "label6";
			this.label6.TabIndex = 11;
			this.label6.Text = "Ã„⁄ »” «‰ò«—";
			// 
			// creditlbl
			// 
			this.creditlbl.Location = new System.Drawing.Point(16, 8);
			this.creditlbl.Name = "creditlbl";
			this.creditlbl.Size = new System.Drawing.Size(104, 23);
			this.creditlbl.TabIndex = 12;
			this.creditlbl.Text = "0";
			// 
			// debitlbl
			// 
			this.debitlbl.Location = new System.Drawing.Point(8, 40);
			this.debitlbl.Name = "debitlbl";
			this.debitlbl.Size = new System.Drawing.Size(112, 23);
			this.debitlbl.TabIndex = 13;
			this.debitlbl.Text = "0";
			// 
			// submitcmd
			// 
			this.submitcmd.BackColor = System.Drawing.Color.Lavender;
			this.submitcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.submitcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.submitcmd.Location = new System.Drawing.Point(544, 560);
			this.submitcmd.Name = "submitcmd";
			this.submitcmd.TabIndex = 14;
			this.submitcmd.Text = " «ÌÌœ";
			this.submitcmd.Click += new System.EventHandler(this.submitcmd_Click);
			// 
			// cancelcmd
			// 
			this.cancelcmd.BackColor = System.Drawing.Color.Lavender;
			this.cancelcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cancelcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cancelcmd.Location = new System.Drawing.Point(336, 560);
			this.cancelcmd.Name = "cancelcmd";
			this.cancelcmd.TabIndex = 15;
			this.cancelcmd.Text = "«‰’—«›";
			this.cancelcmd.Click += new System.EventHandler(this.cancelcmd_Click);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label4.Location = new System.Drawing.Point(888, 528);
			this.label4.Name = "label4";
			this.label4.TabIndex = 17;
			this.label4.Text = " ‰ŸÌ„ ò‰‰œÂ :   1";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label7.Location = new System.Drawing.Point(776, 528);
			this.label7.Name = "label7";
			this.label7.TabIndex = 18;
			this.label7.Text = "«‰ ﬁ«· œÂ‰œÂ :   .....";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label8.Location = new System.Drawing.Point(888, 568);
			this.label8.Name = "label8";
			this.label8.TabIndex = 19;
			this.label8.Text = "¬’·«Õ ò‰‰œÂ :   .....";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.creditlbl);
			this.panel2.Controls.Add(this.debitlbl);
			this.panel2.Location = new System.Drawing.Point(8, 488);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(240, 100);
			this.panel2.TabIndex = 20;
			// 
			// printcmd
			// 
			this.printcmd.BackColor = System.Drawing.Color.Lavender;
			this.printcmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.printcmd.Location = new System.Drawing.Point(24, 8);
			this.printcmd.Name = "printcmd";
			this.printcmd.TabIndex = 21;
			this.printcmd.Text = "ç«Å";
			this.printcmd.Click += new System.EventHandler(this.printcmd_Click);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(238, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// documentform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(992, 595);
			this.Controls.Add(this.printcmd);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cancelcmd);
			this.Controls.Add(this.submitcmd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.descriptiontxt);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Menu = this.mainMenu1;
			this.Name = "documentform";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "’œÊ— ”‰œ „Êﬁ ";
			this.Load += new System.EventHandler(this.documentform_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void documentform_Load(object sender, System.EventArgs e)
		{
			eceriteria();
			ob.get_Info("DocumentRowNr,SubsidiaryCode,DetailedCode1,DetailedCode2,DetailedCode3,RowDate,RowDebitCost,RowCreditCost,GeneralCode,RowDescription,DocumentDescription","DocumentRow inner join Document on DocumentRow.DocumentNr=Document.DocumentNr",ceriteria,dataset1,"DocumentRow");
			dataset1.Tables["DocumentRow"].Columns[10].DefaultValue=Persia.Calendar.ConvertToPersian(System.DateTime.Today.Date).Simple.ToString();
			dataset1.Tables["DocumentRow"].Columns[1].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[2].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[3].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[4].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[6].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[7].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[9].DefaultValue=0;
			dataset1.Tables["DocumentRow"].Columns[0].AutoIncrement=true;
			dataset1.Tables["DocumentRow"].Columns[0].AutoIncrementSeed=(dataset1.Tables["DocumentRow"].Rows.Count);
			dataset1.Tables["DocumentRow"].Columns[0].ReadOnly=true;
			dataset1.Tables["DocumentRow"].Columns[9].DefaultValue="";
			row=dataset1.Tables["DocumentRow"].Rows.Count;
			dataGrid1.SetDataBinding(dataset1,"DocumentRow");
			dataGrid1.AllowDrop=true;
			for(int i=0;i<dataset1.Tables["DocumentRow"].Rows.Count;i++)
			{
				 dataGrid1[i,1]=Persia.Calendar.ConvertToPersian(System.DateTime.Parse(dataset1.Tables["DocumentRow"].Rows[i][5].ToString())).Simple.ToString();
			}
			if(type1==3)
				fillgride();
			else
			{
				for(int i=0;i<dataset1.Tables["DocumentRow"].Rows.Count;i++)
				{
	
					if(dataGrid1[i,4].ToString()=="")
						dataGrid1[i,4]=0;
					if(dataGrid1[i,5].ToString()=="")
						dataGrid1[i,5]=0;
					if(dataGrid1[i,6].ToString()=="")
						dataGrid1[i,6]=0;
					
				}
			}
			hesab();
			if(type1==1 || type1==5 || type1==4)
				dataGrid1.Enabled=false;
			
			
		}
		private void dataGrid2_DoubleClick(object sender, System.EventArgs e)
		{
		
		}

		private void generalitem_Click(object sender, System.EventArgs e)
		{
			ob.get_Info("*","General","GeneralCode is not null",dataset,"General");
			dataGrid2.DataSource=dataset;
			dataGrid2.DataMember="General";	
			dataGrid2.CaptionText="Õ”«» ò·";
			groupBox1.Visible=true;
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			check();
		}
		private void check(){
			if(dataGrid1.CurrentCell.ColumnNumber==2)
			{
				dataGrid1[dataGrid1.CurrentRowIndex,3]=0;
				dataGrid1[dataGrid1.CurrentRowIndex,4]=0;
				dataGrid1[dataGrid1.CurrentRowIndex,5]=0;
				dataGrid1[dataGrid1.CurrentRowIndex,6]=0;
			}
			if(dataGrid1.CurrentCell.ColumnNumber==3)
			{
				dataGrid1[dataGrid1.CurrentRowIndex,4]=0;
				dataGrid1[dataGrid1.CurrentRowIndex,5]=0;
				dataGrid1[dataGrid1.CurrentRowIndex,6]=0;
				if(dataGrid1[dataGrid1.CurrentRowIndex,2].ToString()==dataset1.Tables["DocumentRow"].Columns[2].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« òœ ò· —« Ê«—œ ò‰Ìœ");
					dataGrid1[dataGrid1.CurrentRowIndex,3]=0;
				}
				
			 else if(ob.get_ID("GeneralCode","General","GeneralCode='"+dataGrid1[dataGrid1.CurrentRowIndex,2]+"'")==0)
				{
					MessageBox.Show(" òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ");
					dataGrid1[dataGrid1.CurrentRowIndex,2]=0;
				}
			}
			if(dataGrid1.CurrentCell.ColumnNumber==4)
			{
				dataGrid1[dataGrid1.CurrentRowIndex,5]=0;
				dataGrid1[dataGrid1.CurrentRowIndex,6]=0;
				if(dataGrid1[dataGrid1.CurrentRowIndex,3].ToString()==dataset1.Tables["DocumentRow"].Columns[3].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« òœ „⁄Ì‰ —« Ê«—œ ò‰Ìœ");
					dataGrid1[dataGrid1.CurrentRowIndex,3]=0;
				}
				
				else if(ob.get_ID("Subsidiary.SubsidiaryCode","Subsidiary INNER JOIN General ON Subsidiary.GeneralCode=General.GeneralCode "," Subsidiary.SubsidiaryCode='"+dataGrid1[dataGrid1.CurrentRowIndex,3]+"'")==0)
				{
					MessageBox.Show(" òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ");
					dataGrid1[dataGrid1.CurrentRowIndex,3]=0;
				}
			}
			if(dataGrid1.CurrentCell.ColumnNumber==5)
			{
				dataGrid1[dataGrid1.CurrentRowIndex,6]=0;
				if(dataGrid1[dataGrid1.CurrentRowIndex,4].ToString()==dataset1.Tables["DocumentRow"].Columns[4].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« òœ  ›’Ì·Ì1 —« Ê«—œ ò‰Ìœ");
					dataGrid1[dataGrid1.CurrentRowIndex,4]=0;
				}
				
				else if(ob.get_ID("DetailedCode1","Subsidiary INNER JOIN DetailedCode1 ON DetailedCode1.SubsidiaryCode=Subsidiary.SubsidiaryCode","DetailedCode1.SubsidiaryCode='"+dataGrid1[dataGrid1.CurrentRowIndex,3]+"'")==0)
				{
					MessageBox.Show(" òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ");
					dataGrid1[dataGrid1.CurrentRowIndex,4]=0;
				}
			}
			if(dataGrid1.CurrentCell.ColumnNumber==6)
			{
				if(dataGrid1[dataGrid1.CurrentRowIndex,5].ToString()==dataset1.Tables["DocumentRow"].Columns[5].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« òœ  ›’Ì·Ì2 —« Ê«—œ ò‰Ìœ");
					dataGrid1[dataGrid1.CurrentRowIndex,5]=0;
				}
				
				if(ob.get_ID("DetailedCode2.DetailedCode2","DetailedCode2 INNER JOIN DetailedCode3 ON DetailedCode3.DetailedCode2=DetailedCode2.DetailedCode2"," DetailedCode2.DetailedCode2='"+dataGrid1[dataGrid1.CurrentRowIndex,5]+"'")==0)
				{
					MessageBox.Show(" òœ Ê—ÊœÌ „⁄ »— ‰„Ì»«‘œ");
					dataGrid1[dataGrid1.CurrentRowIndex,5]=0;
				}
			}
			if(dataGrid1.CurrentCell.ColumnNumber==8)
			{
				if(dataGrid1[dataGrid1.CurrentRowIndex,9].ToString()!=dataset1.Tables["DocumentRow"].Columns[6].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« ÌòÌ «“ ” Ê‰ »œÂò«— Ì« »” «‰ò«—  —« Ê«—œ ò‰Ìœ");
					dataGrid1[dataGrid1.CurrentRowIndex,8]=0;
				}
			}
			if(dataGrid1.CurrentCell.ColumnNumber==9)
			{
				if(dataGrid1[dataGrid1.CurrentRowIndex,8].ToString()!=dataset1.Tables["DocumentRow"].Columns[7].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« ÌòÌ «“ ” Ê‰ »œÂò«— Ì« »” «‰ò«—  —« Ê«—œ ò‰Ìœ");
					dataGrid1[dataGrid1.CurrentRowIndex,9]=0;
				}
			}
				creditlbl.Text="0";
			    debitlbl.Text="0";
			for(int i=0;i<=dataGrid1.CurrentRowIndex;i++)
			{
				if(dataGrid1[i,8].ToString()!=dataset1.Tables["DocumentRow"].Columns[7].DefaultValue.ToString())
					creditlbl.Text=""+(int.Parse(creditlbl.Text)+int.Parse(dataGrid1[i,8].ToString()));
				if(dataGrid1[i,9].ToString()!=dataset1.Tables["DocumentRow"].Columns[6].DefaultValue.ToString())
					debitlbl.Text=""+(int.Parse(debitlbl.Text)+int.Parse(dataGrid1[i,9].ToString()));
			}
		}

		private void subsidiaryitem_Click(object sender, System.EventArgs e)
		{
			if(dataGrid1.CurrentRowIndex!=-1)
				ob.get_Info("*","Subsidiary","GeneralCode='"+dataGrid1[dataGrid1.CurrentRowIndex,2]+"'",dataset,"Subsidiary");
			else
				ob.get_Info("*","Subsidiary","SubsidiaryCode is not null",dataset,"Subsidiary");
			dataGrid2.DataSource=dataset;
			dataGrid2.DataMember="Subsidiary";
			dataGrid2.CaptionText="Õ”«» „⁄Ì‰";
			groupBox1.Visible=true;
		}
		private void eceriteria(){
			if(nr1==0)
			{
				ceriteria="DocumentRow.DocumentNr is null";
				int id=ob.get_ID("MAX(DocumentNr)","Document","DocumentNr is not null");
				id+=1;
				label1.Text=" ”‰œ „Êﬁ  ‘„«—Â"+id;
				if(type1==2)
				{
					this.Text=" «ÌÃ«œ”‰œ «›  «ÕÌÂ";
						label1.Text=" ”‰œ «›  «ÕÌÂ";
				}
				if(type1==3)
				{
					this.Text=" «ÌÃ«œ”‰œ «Œ  «„ÌÂ";
						label1.Text=" ”‰œ «Œ  «„ÌÂ";
				}
				documentnumbertxt.Text=id.ToString();
				datetxt.Text=Persia.Calendar.ConvertToPersian(System.DateTime.Today.Date).Simple.ToString();
			}
			else
			{
				try
				{
					datareader=ob.get_UserInfo("DocumentDate,DocumentDescription","Document","DocumentNr='"+nr1+"'");
					while(datareader.Read())
					{
						datetxt.Text=Persia.Calendar.ConvertToPersian(System.DateTime.Parse(datareader.GetValue(0).ToString())).Simple.ToString();
						descriptiontxt.Text=datareader.GetValue(1).ToString();
					}
				}
				finally{
					datareader.Close();
					}
				documentnumbertxt.Text=nr1.ToString();
				documentnumbertxt.Enabled=false;
				this.Text="ÊÌ—«Ì‘ ”‰œ";
				label1.Text+=" ”‰œ „Êﬁ  ‘„«—Â"+nr1;
				if(type1==1 || type1==5 || type1==3)
				{
					label8.Text="«’·«Õ ò‰‰œÂ :   1";
					datetxt.Enabled=false;
					descriptiontxt.Enabled=false;
					this.Text="»«“»Ì‰Ì ”‰œ";
				}
				if(type1==4)
					label7.Text="«‰ ﬁ«· œÂ‰œÂ :   1";
				if(type1==4 || type1==1)
					label1.Text="”‰œ œ«∆„ ‘„«—Â "+nr1;
				if(type1==2)
					label1.Text="”‰œ «›  «ÕÌÂ";
				if(type1==3)
					label1.Text="”‰œ «Œ  «„ÌÂ";
				ceriteria="DocumentRow.DocumentNr='"+nr1+"'";
			}
		}

		private void detaileditem1_Click(object sender, System.EventArgs e)
		{
			if(dataGrid1.CurrentRowIndex!=-1)
				ob.get_Info("*","DetailedCode1","SubsidiaryCode='"+dataGrid1[dataGrid1.CurrentRowIndex,3]+"'",dataset,"DetailedCode1");
			else
				ob.get_Info("*","DetailedCode1","DetailedCode1 is not null",dataset,"DetailedCode1");
			dataGrid2.DataSource=dataset;
			dataGrid2.DataMember="DetailedCode1";
			dataGrid2.CaptionText="Õ”«»  ›’Ì·Ì1";
			groupBox1.Visible=true;
		}

		private void detaileditem2_Click(object sender, System.EventArgs e)
		{
			if(dataGrid1.CurrentRowIndex!=-1)
			ob.get_Info("*","DetailedCode2","DetailedCode1='"+dataGrid1[dataGrid1.CurrentRowIndex,4]+"'",dataset,"DetailedCode2");
			else
				ob.get_Info("*","DetailedCode2","DetailedCode2 is not null",dataset,"DetailedCode2");
			dataGrid2.DataSource=dataset;
			dataGrid2.DataMember="DetailedCode2";
			dataGrid2.CaptionText="Õ”«»  ›’Ì·Ì2";
			groupBox1.Visible=true;
		}

		private void detaileditem3_Click(object sender, System.EventArgs e)
		{
			if(dataGrid1.CurrentRowIndex!=-1)
				ob.get_Info("*","DetailedCode3","DetailedCode2='"+dataGrid1[dataGrid1.CurrentRowIndex,5]+"'",dataset,"DetailedCode3");
			else
				ob.get_Info("*","DetailedCode3","DetailedCode3 is not null",dataset,"DetailedCode3");
			dataGrid2.DataSource=dataset;
			dataGrid2.DataMember="DetailedCode3";
			dataGrid2.CaptionText="Õ”«»  ›’Ì·Ì3";
			groupBox1.Visible=true;
		}

		private void exitcmd_Click(object sender, System.EventArgs e)
		{
			dataset.Clear();
			groupBox1.Visible=false;
		}

		private void cancelcmd_Click(object sender, System.EventArgs e)
		{
			dataset1.Dispose();
			this.Close();
		}
		public void date(string date){
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
		private void submitcmd_Click(object sender, System.EventArgs e)
		{
			date(datetxt.Text);
			if(check1()){
			hesab();
				if(creditlbl.Text!=debitlbl.Text)
				{
					MessageBox.Show("” Ê‰ »” «‰ò«— »« »œÂò«—  —«“ ‰Ì” ");
				}
				else
				{ 
					if(type1==1 || type1==5)
					{
						dataset1.Dispose();
						this.Close();
					}
					else if(nr1==0)
					{
						ob.add("Document","DocumentNr,DocumentType,DocumentDate,DocumentRegisterCode","'"+documentnumbertxt.Text+"','"+type1+"','"+Persia.Calendar.ConvertToGregorian(year,month,day).ToShortDateString().ToString()+"',1");
						if(descriptiontxt.Text!="")
							ob.update("Document","DocumentDescription='"+descriptiontxt.Text+"'","DocumentNr='"+documentnumbertxt.Text+"'");
						for(int i=0;i<dataset1.Tables["DocumentRow"].Rows.Count;i++)
						{
							date(dataGrid1[i,1].ToString());
							ob.add("DocumentRow","DocumentRowNr,DocumentNr,RowDebitCost,RowCreditCost,RowDate,SubsidiaryCode,GeneralCode","'"+dataGrid1[i,0]+"','"+documentnumbertxt.Text+"','"+dataGrid1[i,9]+"','"+dataGrid1[i,8]+"','"+Persia.Calendar.ConvertToGregorian(year,month,day).ToShortDateString().ToString()+"','"+dataGrid1[i,3]+"','"+dataGrid1[i,2]+"'");
							if(dataGrid1[i,4].ToString()!=dataset1.Tables["DocumentRow"].Columns[2].DefaultValue.ToString())
								ob.update("DocumentRow","DetailedCode1='"+dataGrid1[i,4]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,5].ToString()!=dataset1.Tables["DocumentRow"].Columns[3].DefaultValue.ToString())
								ob.update("DocumentRow","DetailedCode2='"+dataGrid1[i,5]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,6].ToString()!=dataset1.Tables["DocumentRow"].Columns[4].DefaultValue.ToString())
								ob.update("DocumentRow","DetailedCode3='"+dataGrid1[i,6]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,7].ToString()!=dataset1.Tables["DocumentRow"].Columns[9].DefaultValue.ToString())
								ob.update("DocumentRow","RowDescription='"+dataGrid1[i,7]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
						}
					}
					else
					{
						if(descriptiontxt.Text!="")
							ob.update("Document","DocumentDescription='"+descriptiontxt.Text+"'","DocumentNr='"+documentnumbertxt.Text+"'");
						if(datetxt.Text!="")
							ob.update("Document","DocumentDate='"+Persia.Calendar.ConvertToGregorian(year,month,day).ToShortDateString().ToString()+"'","DocumentNr='"+documentnumbertxt.Text+"'");
						ob.update("Document","DocumentEditorCode=1","DocumentNr='"+documentnumbertxt.Text+"'"); 
							
						for(int i=0;i<dataset1.Tables["DocumentRow"].Rows.Count;i++)
						{
							date(dataGrid1[i,1].ToString());
							descriptiontxt.Text="DetailedCode1=null DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'";
							if(i>=row)
								ob.add("DocumentRow","DocumentRowNr,DocumentNr,RowDebitCost,RowCreditCost,RowDate,SubsidiaryCode,GeneralCode","'"+dataGrid1[i,0]+"','"+documentnumbertxt.Text+"','"+dataGrid1[i,9]+"','"+dataGrid1[i,8]+"','"+Persia.Calendar.ConvertToGregorian(year,month,day).ToShortDateString().ToString()+"','"+dataGrid1[i,3]+"','"+dataGrid1[i,2]+"'");
							else
								ob.update("DocumentRow","RowDebitCost='"+dataGrid1[i,9]+"',RowCreditCost='"+dataGrid1[i,8]+"',RowDate='"+Persia.Calendar.ConvertToGregorian(year,month,day).ToShortDateString().ToString()+"',SubsidiaryCode='"+dataGrid1[i,3]+"',GeneralCode='"+dataGrid1[i,2]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,4].ToString()!="0")
								ob.update("DocumentRow","DetailedCode1='"+dataGrid1[i,4]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							 else
								ob.update("DocumentRow","DetailedCode1=null","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,5].ToString()!="0")
								ob.update("DocumentRow","DetailedCode2='"+dataGrid1[i,5]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							else
								ob.update("DocumentRow","DetailedCode2=null","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,6].ToString()!="0")
								ob.update("DocumentRow","DetailedCode3='"+dataGrid1[i,6]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							else
								ob.update("DocumentRow","DetailedCode3=null","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							if(dataGrid1[i,7].ToString()!=dataset1.Tables["DocumentRow"].Columns[9].DefaultValue.ToString())
								ob.update("DocumentRow","RowDescription='"+dataGrid1[i,7]+"'","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
							else
								ob.update("DocumentRow","RowDescription=null","DocumentRowNr='"+dataGrid1[i,0]+"' AND DocumentNr='"+documentnumbertxt.Text+"'");
								
						}
					}
					
				dataset1.Dispose();
				this.Close();
				}
			}
		
		}
		private void hesab(){
			creditlbl.Text="0";
			debitlbl.Text="0";
			for(int i=0;i<dataset1.Tables["DocumentRow"].Rows.Count;i++)
			{
				if(dataGrid1[i,8].ToString()!=dataset1.Tables["DocumentRow"].Columns[7].DefaultValue.ToString())
					creditlbl.Text=""+(int.Parse(creditlbl.Text)+int.Parse(dataGrid1[i,8].ToString()));
				if(dataGrid1[i,9].ToString()!=dataset1.Tables["DocumentRow"].Columns[6].DefaultValue.ToString())
					debitlbl.Text=""+(int.Parse(debitlbl.Text)+int.Parse(dataGrid1[i,9].ToString()));
			}
		}
		private bool check1(){
			for(int i=0;i<dataset1.Tables["DocumentRow"].Rows.Count;i++)
			{
				if(dataGrid1[i,2].ToString()==dataset1.Tables["DocumentRow"].Columns[9].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« òœ ò· —« Ê«—œ ò‰Ìœ");
					return false;
				}
				if(dataGrid1[i,3].ToString()==dataset1.Tables["DocumentRow"].Columns[1].DefaultValue.ToString())
				{
					MessageBox.Show("·ÿ›« òœ „⁄Ì‰ —« Ê«—œ ò‰Ìœ");
					return false;
				}
			}
			return true;
		}
		public void fillgride()
		{
			ob.get_Info("SubsidiaryCode,sum(RowDebitCost),sum(RowCreditCost),GeneralCode","DocumentRow ","DocumentRowNr is not null Group by SubsidiaryCode,GeneralCode",dataset1,"Document");
			for(int i=0;i<dataset1.Tables["Document"].Rows.Count;i++)
			{
				object[] rowVals = new object[11];
				rowVals[0] =i;
				rowVals[5] =System.DateTime.Today.Date ;
				rowVals[10] =Persia.Calendar.ConvertToPersian(System.DateTime.Today.Date).Simple ;
				rowVals[8] = dataset1.Tables["Document"].Rows[i][3];
				rowVals[1] = dataset1.Tables["Document"].Rows[i][0];
				rowVals[2] =0;
				rowVals[3] =0;
				rowVals[4] =0;
				rowVals[9] ="";
				rowVals[7] = dataset1.Tables["Document"].Rows[i][2];
				rowVals[6] = dataset1.Tables["Document"].Rows[i][1];
				dataset1.Tables["DocumentRow"].Rows.Add(rowVals);		
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
