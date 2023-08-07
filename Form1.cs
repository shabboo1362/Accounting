using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Accounting
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem accountingreportitem;
		private System.Windows.Forms.MenuItem dacumentitem;
		private System.Windows.Forms.MenuItem dafateritem;
		private System.Windows.Forms.MenuItem detaileditem;
		private System.Windows.Forms.MenuItem subsidiaryitem;
		private System.Windows.Forms.MenuItem generalitem;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem detaileditem2;
		private System.Windows.Forms.MenuItem detaileditem3;
		private System.Windows.Forms.MenuItem sodoritem;
		private System.Windows.Forms.MenuItem edititem;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem viewitem;
		private codebehind ob=new codebehind();
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem32 = new System.Windows.Forms.MenuItem();
			this.menuItem33 = new System.Windows.Forms.MenuItem();
			this.accountingreportitem = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.dafateritem = new System.Windows.Forms.MenuItem();
			this.detaileditem = new System.Windows.Forms.MenuItem();
			this.detaileditem2 = new System.Windows.Forms.MenuItem();
			this.detaileditem3 = new System.Windows.Forms.MenuItem();
			this.subsidiaryitem = new System.Windows.Forms.MenuItem();
			this.generalitem = new System.Windows.Forms.MenuItem();
			this.dacumentitem = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.sodoritem = new System.Windows.Forms.MenuItem();
			this.edititem = new System.Windows.Forms.MenuItem();
			this.viewitem = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem13,
																					  this.accountingreportitem,
																					  this.dafateritem,
																					  this.dacumentitem});
			this.mainMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 0;
			this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem14,
																					   this.menuItem17,
																					   this.menuItem20,
																					   this.menuItem22,
																					   this.menuItem23});
			this.menuItem13.Text = "«÷«›Â ò—œ‰ Õ”«»";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem24,
																					   this.menuItem25});
			this.menuItem14.Text = "Õ”«» ò·";
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 0;
			this.menuItem24.Text = "«÷«›Â ò—œ‰ Õ”«»";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 1;
			this.menuItem25.Text = "Õ–› Ì« ÊÌ—«Ì‘ Õ”«»";
			this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 1;
			this.menuItem17.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem26,
																					   this.menuItem27});
			this.menuItem17.Text = "Õ”«» „⁄Ì‰";
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 0;
			this.menuItem26.Text = "«÷«›Â ò—œ‰ Õ”«»";
			this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 1;
			this.menuItem27.Text = "Õ–› Ì« ÊÌ—«Ì‘ Õ”«»";
			this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 2;
			this.menuItem20.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem28,
																					   this.menuItem29});
			this.menuItem20.Text = "Õ”«»  ›’Ì·Ì 1";
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 0;
			this.menuItem28.Text = "«÷«›Â ò—œ‰ Õ”«»";
			this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 1;
			this.menuItem29.Text = "Õ–› Ì« ÊÌ—«Ì‘ Õ”«»";
			this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem30,
																					   this.menuItem31});
			this.menuItem22.Text = "Õ”«»  ›’Ì·Ì 2";
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 0;
			this.menuItem30.Text = "«÷«›Â ò—œ‰ Õ”«»";
			this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 1;
			this.menuItem31.Text = "Õ–› Ì« ÊÌ—«Ì‘ Õ”«»";
			this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 4;
			this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem32,
																					   this.menuItem33});
			this.menuItem23.Text = "Õ”«»  ›’Ì·Ì 3";
			// 
			// menuItem32
			// 
			this.menuItem32.Index = 0;
			this.menuItem32.Text = "«÷«›Â ò—œ‰ Õ”«»";
			this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
			// 
			// menuItem33
			// 
			this.menuItem33.Index = 1;
			this.menuItem33.Text = "Õ–› Ì« ÊÌ—«Ì‘ Õ”«»";
			this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
			// 
			// accountingreportitem
			// 
			this.accountingreportitem.Index = 1;
			this.accountingreportitem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								 this.menuItem3,
																								 this.menuItem12,
																								 this.menuItem19,
																								 this.menuItem15,
																								 this.menuItem16,
																								 this.menuItem18,
																								 this.menuItem21});
			this.accountingreportitem.Text = "ê“«—‘«  Õ”«»œ«—Ì";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "   —«“ ¬“„«Ì‘Ì Õ”«» Â«Ì ò· ";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click_1);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = " —«“ ¬“„«Ì‘Ì Õ”«» Â«Ì „⁄Ì‰";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 2;
			this.menuItem19.Text = "-";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 3;
			this.menuItem15.Text = "ê“«—‘ —Ì“ «”‰«œ";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 4;
			this.menuItem16.Text = "ê“«—‘ ò·ÌÂ Õ”«» Â«Ì  ›’Ì·Ì 1";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 5;
			this.menuItem18.Text = "ê“«—‘ ò·ÌÂ Õ”«» Â«Ì  ›’Ì·Ì 2";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 6;
			this.menuItem21.Text = "ê“«—‘ ò·ÌÂ Õ”«» Â«Ì  ›’Ì·Ì 3";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// dafateritem
			// 
			this.dafateritem.Index = 2;
			this.dafateritem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.detaileditem,
																						this.detaileditem2,
																						this.detaileditem3,
																						this.subsidiaryitem,
																						this.generalitem});
			this.dafateritem.Text = "œ›« —";
			// 
			// detaileditem
			// 
			this.detaileditem.Index = 0;
			this.detaileditem.Text = "œ› —  ›’Ì·Ì 1";
			this.detaileditem.Click += new System.EventHandler(this.detaileditem_Click);
			// 
			// detaileditem2
			// 
			this.detaileditem2.Index = 1;
			this.detaileditem2.Text = "œ› —  ›’Ì·Ì 2";
			this.detaileditem2.Click += new System.EventHandler(this.detaileditem2_Click);
			// 
			// detaileditem3
			// 
			this.detaileditem3.Index = 2;
			this.detaileditem3.Text = "œ› —  ›’Ì·Ì 3";
			this.detaileditem3.Click += new System.EventHandler(this.detaileditem3_Click);
			// 
			// subsidiaryitem
			// 
			this.subsidiaryitem.Index = 3;
			this.subsidiaryitem.Text = "œ› — „⁄Ì‰";
			this.subsidiaryitem.Click += new System.EventHandler(this.subsidiaryitem_Click);
			// 
			// generalitem
			// 
			this.generalitem.Index = 4;
			this.generalitem.Text = "œ› — ò·";
			this.generalitem.Click += new System.EventHandler(this.generalitem_Click);
			// 
			// dacumentitem
			// 
			this.dacumentitem.Index = 3;
			this.dacumentitem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem2,
																						 this.menuItem6,
																						 this.menuItem8,
																						 this.menuItem10});
			this.dacumentitem.Text = "«”‰«œ";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.sodoritem,
																					  this.edititem,
																					  this.viewitem});
			this.menuItem1.Text = "«”‰«œ „Êﬁ ";
			// 
			// sodoritem
			// 
			this.sodoritem.Index = 0;
			this.sodoritem.Text = "’œÊ— ”‰œ";
			this.sodoritem.Click += new System.EventHandler(this.sodoritem_Click);
			// 
			// edititem
			// 
			this.edititem.Index = 1;
			this.edititem.Text = "«’·«Õ ”‰œ";
			this.edititem.Click += new System.EventHandler(this.edititem_Click);
			// 
			// viewitem
			// 
			this.viewitem.Index = 2;
			this.viewitem.Text = "»«“»Ì‰Ì ”‰œ";
			this.viewitem.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem2.Text = "«‰ ﬁ«· «”‰«œ œ«∆„ »Â œ›« — Õ”«»œ«—Ì";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = " «‰ ﬁ«· Ìò ”‰œ »Â œ›« — Õ”«»œ«—Ì";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "›Â—”  «”‰«œ «‰ ﬁ«· Ì«› Â";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7});
			this.menuItem6.Text = "«”‰«œ œ«∆„";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "»«“»Ì‰Ì";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem9});
			this.menuItem8.Text = "”‰œ «›  «ÕÌÂ";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "«ÌÃ«œ Ì« ÊÌ—«Ì‘ ”‰œ «›  «ÕÌÂ";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem11});
			this.menuItem10.Text = "”‰œ «Œ  «„ÌÂ";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "«ÌÃ«œ Ì« ÊÌ—«Ì‘  ”‰œ «Œ  «„ÌÂ";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(492, 445);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Õ”«»œ«—Ì";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
		}

		private void detaileditem_Click(object sender, System.EventArgs e)
		{
			detailedform form=new detailedform();
			form.Visible=true;
		}

		private void subsidiaryitem_Click(object sender, System.EventArgs e)
		{
			subsidiaryform form=new subsidiaryform();
			form.Visible=true;
		}

		private void detaileditem2_Click(object sender, System.EventArgs e)
		{
			detailedform2 form=new detailedform2();
			form.Visible=true;
		}

		private void detaileditem3_Click(object sender, System.EventArgs e)
		{
			detailedform3 form=new detailedform3();
			form.Visible=true;
		}

		private void generalitem_Click(object sender, System.EventArgs e)
		{
			generalform form=new generalform(0);
			form.Visible=true;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void sodoritem_Click(object sender, System.EventArgs e)
		{
			if(check())
				MessageBox.Show("”‰œ «Œ  «„ÌÂ «ÌÃ«œ ‘œÂ ‰„Ì Ê«‰Ìœ ”‰œ ÃœÌœ «ÌÃ«œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				documentform form=new documentform(0,0);
				form.ShowDialog();
			}
		}

		private void edititem_Click(object sender, System.EventArgs e)
		{
			if(check())
				MessageBox.Show("”‰œ «Œ  «„ÌÂ «ÌÃ«œ ‘œÂ ‰„Ì Ê«‰Ìœ ”‰œ ÃœÌœ «ÌÃ«œ ò‰Ìœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				editdocument form=new editdocument(0);
				form.ShowDialog();
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			editdocument form=new editdocument(5);
			form.ShowDialog();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			editdocument form=new editdocument(4);
			form.ShowDialog();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if(ob.get_ID("DocumentNR","Document","DocumentType=2")==0)
				MessageBox.Show("«» œ« »«Ìœ ”‰œ «›  «ÕÌÂ «ÌÃ«œ ‘Êœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				transferform form=new transferform();
				form.ShowDialog();
			}
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			editdocument form=new editdocument(1);
			form.ShowDialog();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if(check())
				MessageBox.Show("”‰œ «Œ  «„ÌÂ «ÌÃ«œ ‘œÂ ‰„Ì Ê«‰Ìœ ”‰œ «›  «ÕÌÂ —« ÊÌ—«Ì‘ ò‰Ìœ ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				int dnr=ob.get_ID("DocumentNr","Document","DocumentType=2");
				documentform form=new documentform(dnr,2);
				form.ShowDialog();
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			if(ob.get_ID("DocumentNr","Document","DocumentType=0")!=0)
				MessageBox.Show("»—«Ì «ÌÃ«œ ”‰œ «Œ  «„ÌÂ »«Ìœ  „«„ «”‰«œ „Êﬁ  »Â œ›« — Õ”«»œ«—Ì „‰ ﬁ· ‘Ê‰œ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else if(ob.get_ID("DocumentNr","Document","DocumentType=2")==0)
				MessageBox.Show("»—«Ì «ÌÃ«œ ”‰œ «Œ  «„ÌÂ »«Ìœ ”‰œ «›  «ÕÌÂ «ÌÃ«œ ‘Êœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				int dnr=ob.get_ID("DocumentNr","Document","DocumentType=3");
				documentform form=new documentform(dnr,3);
				form.ShowDialog();
			}
		
		}
		private bool check(){
		if(ob.get_ID("DocumentNr","Document","DocumentType=3")==0)
			return false;
		else
			return true;

		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			selectform form=new selectform("ght1");
			form.ShowDialog();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			selectform form=new selectform("ra");
			form.ShowDialog();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			selectform form=new selectform("ght2");
			form.ShowDialog();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			selectform form=new selectform("ght3");
			form.ShowDialog();
		}

		private void menuItem3_Click_1(object sender, System.EventArgs e)
		{
			selectform form=new selectform("tak");
			form.ShowDialog();
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			selectform form=new selectform("tam");
			form.ShowDialog();
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			addcode form=new addcode("general");
			form.ShowDialog();
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			addcode form=new addcode("subsidiary");
			form.ShowDialog();
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			addcode form=new addcode("detailed1");
			form.ShowDialog();
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			addcode form=new addcode("detailed2");
			form.ShowDialog();
		}

		private void menuItem32_Click(object sender, System.EventArgs e)
		{
			addcode form=new addcode("detailed3");
			form.ShowDialog();
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			editcode form=new editcode("general");
			form.ShowDialog();
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			editcode form=new editcode("subsidiary");
			form.ShowDialog();
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{
			editcode form=new editcode("detailed1");
			form.ShowDialog();
		}

		private void menuItem31_Click(object sender, System.EventArgs e)
		{
			editcode form=new editcode("detailed2");
			form.ShowDialog();
		}

		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			editcode form=new editcode("detailed3");
			form.ShowDialog();
		}


		
		

		
	}
}
