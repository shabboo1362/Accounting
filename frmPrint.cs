using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for frmPrint.
	/// </summary>
	public class frmPrint : System.Windows.Forms.Form
	{
		public bool bBlackWhite; 
		public bool bTitle; 
		public int Result = 0; 
		public string Title;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txbTitle;
		internal System.Windows.Forms.CheckBox chbBlWh;
		internal System.Windows.Forms.CheckBox chbTitle;
		internal System.Windows.Forms.Button btnPrint;
		internal System.Windows.Forms.Button btnPage;
		internal System.Windows.Forms.Button btnPreview;
		internal System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPrint()
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
			this.Label1 = new System.Windows.Forms.Label();
			this.txbTitle = new System.Windows.Forms.TextBox();
			this.chbBlWh = new System.Windows.Forms.CheckBox();
			this.chbTitle = new System.Windows.Forms.CheckBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnPage = new System.Windows.Forms.Button();
			this.btnPreview = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(17, 39);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(32, 16);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Title:";
			// 
			// txbTitle
			// 
			this.txbTitle.Location = new System.Drawing.Point(52, 37);
			this.txbTitle.Name = "txbTitle";
			this.txbTitle.Size = new System.Drawing.Size(224, 20);
			this.txbTitle.TabIndex = 11;
			this.txbTitle.Text = "";
			// 
			// chbBlWh
			// 
			this.chbBlWh.Location = new System.Drawing.Point(20, 67);
			this.chbBlWh.Name = "chbBlWh";
			this.chbBlWh.Size = new System.Drawing.Size(192, 16);
			this.chbBlWh.TabIndex = 12;
			this.chbBlWh.Text = "Use \'Black and White\' printing";
			this.chbBlWh.CheckedChanged += new System.EventHandler(this.chbBlWh_CheckedChanged);
			// 
			// chbTitle
			// 
			this.chbTitle.Location = new System.Drawing.Point(20, 12);
			this.chbTitle.Name = "chbTitle";
			this.chbTitle.Size = new System.Drawing.Size(160, 19);
			this.chbTitle.TabIndex = 10;
			this.chbTitle.Text = "Print Title";
			this.chbTitle.CheckedChanged += new System.EventHandler(this.chbTitle_CheckedChanged);
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.SystemColors.Window;
			this.btnPrint.Location = new System.Drawing.Point(20, 92);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(60, 30);
			this.btnPrint.TabIndex = 13;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new System.EventHandler(this.btnClick);
			// 
			// btnPage
			// 
			this.btnPage.BackColor = System.Drawing.SystemColors.Window;
			this.btnPage.Location = new System.Drawing.Point(82, 92);
			this.btnPage.Name = "btnPage";
			this.btnPage.Size = new System.Drawing.Size(70, 30);
			this.btnPage.TabIndex = 14;
			this.btnPage.Text = "Page Setup";
			this.btnPage.Click += new System.EventHandler(this.btnClick);
			// 
			// btnPreview
			// 
			this.btnPreview.BackColor = System.Drawing.SystemColors.Window;
			this.btnPreview.Location = new System.Drawing.Point(154, 92);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(60, 30);
			this.btnPreview.TabIndex = 15;
			this.btnPreview.Text = "Preview";
			this.btnPreview.Click += new System.EventHandler(this.btnClick);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.Window;
			this.btnClose.Location = new System.Drawing.Point(216, 92);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(60, 30);
			this.btnClose.TabIndex = 16;
			this.btnClose.Text = "Cancel";
			this.btnClose.Click += new System.EventHandler(this.btnClick);
			// 
			// frmPrint
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 134);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txbTitle);
			this.Controls.Add(this.chbBlWh);
			this.Controls.Add(this.chbTitle);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnPage);
			this.Controls.Add(this.btnPreview);
			this.Controls.Add(this.btnClose);
			this.Name = "frmPrint";
			this.Text = "frmPrint";
			this.Load += new System.EventHandler(this.frmPrint_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmPrint_Load(object sender, System.EventArgs e)
		{
			bBlackWhite = false; 
			chbTitle.Checked = bTitle; 
			chbBlWh.Checked = bBlackWhite; 
			txbTitle.Enabled = bTitle; 
			txbTitle.Text = Title; 
		}
		private void btnClick(object sender, System.EventArgs e)
		{
			Button btn = ((Button)(sender)); 
			Title = txbTitle.Text; 
			if (btn.Name == "btnPrint") 
			{ 
				Result = 1; 
			} 
			else if (btn.Name == "btnPage") 
			{ 
				Result = 2; 
			} 
			else if (btn.Name == "btnPreview") 
			{ 
				Result = 3; 
			} 
			this.Close();
		}

		private void chbTitle_CheckedChanged(object sender, System.EventArgs e)
		{
			
			bTitle = chbTitle.Checked; 
			txbTitle.Enabled = chbTitle.Checked;
		}

		private void chbBlWh_CheckedChanged(object sender, System.EventArgs e)
		{
			bBlackWhite = chbBlWh.Checked;
		}

	}
}
