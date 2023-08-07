using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for changelogin.
	/// </summary>
	public class changelogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox passwordtxt;
		private System.Windows.Forms.TextBox usernametxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox newpasstxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private codebehind ob= new codebehind();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public changelogin()
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
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.usernametxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.newpasstxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwordtxt
			// 
			this.passwordtxt.Location = new System.Drawing.Point(88, 56);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.PasswordChar = '*';
			this.passwordtxt.TabIndex = 9;
			this.passwordtxt.Text = "";
			// 
			// usernametxt
			// 
			this.usernametxt.Location = new System.Drawing.Point(88, 24);
			this.usernametxt.Name = "usernametxt";
			this.usernametxt.TabIndex = 8;
			this.usernametxt.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label2.Location = new System.Drawing.Point(200, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "—„“ ⁄»Ê— ﬁœÌ„Ì";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(224, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "‰«„ ò«—»—Ì";
			// 
			// newpasstxt
			// 
			this.newpasstxt.Location = new System.Drawing.Point(88, 88);
			this.newpasstxt.Name = "newpasstxt";
			this.newpasstxt.PasswordChar = '*';
			this.newpasstxt.TabIndex = 11;
			this.newpasstxt.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label3.Location = new System.Drawing.Point(208, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "—„“ ⁄»Ê— ÃœÌœ";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.button1.Location = new System.Drawing.Point(184, 152);
			this.button1.Name = "button1";
			this.button1.TabIndex = 12;
			this.button1.Text = " «ÌÌœ";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.button2.Location = new System.Drawing.Point(64, 152);
			this.button2.Name = "button2";
			this.button2.TabIndex = 13;
			this.button2.Text = "«‰’—«›";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(56, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "*";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Crimson;
			this.label5.Location = new System.Drawing.Point(56, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "*";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.Crimson;
			this.label6.Location = new System.Drawing.Point(144, 128);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "›Ì·œ Â«Ì * œ«— —« Õ „« Ê«—œ ‰„«ÌÌœ";
			// 
			// changelogin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 198);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.newpasstxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwordtxt);
			this.Controls.Add(this.usernametxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "changelogin";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = " €ÌÌ— ‘‰«”Â ò«—»—Ì";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(usernametxt.Text=="")
				MessageBox.Show("·ÿ›« ‰«„ ò«—»—Ì —« Ê«—œ ‰„«ÌÌœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else if(passwordtxt.Text=="")
				MessageBox.Show("·ÿ›« —„“ ⁄»Ê— —« Ê«—œ ‰„«ÌÌœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else if(ob.get_ID("LoginID","Login","Password='"+passwordtxt.Text+"'")!=0)
			{
				if(newpasstxt.Text!="")
					ob.update("Login","Password='"+newpasstxt.Text+"',UserName='"+usernametxt.Text+"'","Password='"+passwordtxt.Text+"'");
				this.Close();
			}
			else
				MessageBox.Show(" —„“ ⁄»Ê— ‘„« «‘ »«Â «” ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
