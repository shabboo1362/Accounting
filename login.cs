using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Accounting
{
	/// <summary>
	/// Summary description for login.
	/// </summary>
	public class login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button logincmd;
		private System.Windows.Forms.Button changecmd;
		private System.Windows.Forms.TextBox usernametxt;
		private System.Windows.Forms.TextBox passwordtxt;
		private codebehind ob=new codebehind();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public login()
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
		[STAThread]
		static void Main() 
		{
			Application.Run(new login());
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
			this.logincmd = new System.Windows.Forms.Button();
			this.changecmd = new System.Windows.Forms.Button();
			this.usernametxt = new System.Windows.Forms.TextBox();
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(208, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "‰«„ ò«—»—Ì";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label2.Location = new System.Drawing.Point(208, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "—„“ ⁄»Ê—";
			// 
			// logincmd
			// 
			this.logincmd.BackColor = System.Drawing.Color.Lavender;
			this.logincmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.logincmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.logincmd.Location = new System.Drawing.Point(152, 112);
			this.logincmd.Name = "logincmd";
			this.logincmd.TabIndex = 2;
			this.logincmd.Text = "Ê—Êœ";
			this.logincmd.Click += new System.EventHandler(this.logincmd_Click);
			// 
			// changecmd
			// 
			this.changecmd.BackColor = System.Drawing.Color.Lavender;
			this.changecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.changecmd.ForeColor = System.Drawing.Color.RoyalBlue;
			this.changecmd.Location = new System.Drawing.Point(16, 112);
			this.changecmd.Name = "changecmd";
			this.changecmd.Size = new System.Drawing.Size(112, 23);
			this.changecmd.TabIndex = 3;
			this.changecmd.Text = " €ÌÌ— ‘‰«”Â ò«—»—Ì";
			this.changecmd.Click += new System.EventHandler(this.changecmd_Click);
			// 
			// usernametxt
			// 
			this.usernametxt.Location = new System.Drawing.Point(88, 24);
			this.usernametxt.Name = "usernametxt";
			this.usernametxt.TabIndex = 4;
			this.usernametxt.Text = "";
			// 
			// passwordtxt
			// 
			this.passwordtxt.Location = new System.Drawing.Point(88, 56);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.PasswordChar = '*';
			this.passwordtxt.TabIndex = 5;
			this.passwordtxt.Text = "";
			// login
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 166);
			this.Controls.Add(this.passwordtxt);
			this.Controls.Add(this.usernametxt);
			this.Controls.Add(this.changecmd);
			this.Controls.Add(this.logincmd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "login";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Ê—Êœ";
			this.ResumeLayout(false);

		}
		#endregion

		private void changecmd_Click(object sender, System.EventArgs e)
		{
			changelogin form=new changelogin();
			form.ShowDialog();
		}

		private void logincmd_Click(object sender, System.EventArgs e)
		{
			if(usernametxt.Text=="")
				MessageBox.Show(".·ÿ›« ‰«„ ò«—»—Ì —« Ê«—œ ‰„«ÌÌœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else if(passwordtxt.Text=="")
				MessageBox.Show(".·ÿ›« —„“ ⁄»Ê— —« Ê«—œ ‰„«ÌÌœ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else if(ob.get_ID("LoginID","Login","Password='"+passwordtxt.Text+"' And UserName='"+usernametxt.Text+"'")!=0)
			{
				Form1 form=new Form1();
				form.ShowDialog();
				this.Close();
			}
			else
			MessageBox.Show(".‰«„ ò«—»—Ì Ì« —„“ ⁄»Ê— ‘„« «‘ »«Â «” ","Œÿ«",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
	}
}
