using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace SaveSettings
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox lbSettings;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MainMenu mainMenu1;

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
			this.button1 = new System.Windows.Forms.Button();
			this.lbSettings = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(4, 220);
			this.button1.Size = new System.Drawing.Size(92, 40);
			this.button1.Text = "Load Settings";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbSettings
			// 
			this.lbSettings.Location = new System.Drawing.Point(4, 4);
			this.lbSettings.Size = new System.Drawing.Size(232, 212);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(144, 220);
			this.button2.Size = new System.Drawing.Size(92, 40);
			this.button2.Text = "Alter Settings";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lbSettings);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Text = "AppSettings";
			this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			lbSettings.Items.Clear();
			lbSettings.Items.Add("DatabasePath=" + Settings.DatabasePath);
			lbSettings.Items.Add("LastTransmit=" + Settings.LastTransmit);
			lbSettings.Items.Add("Password=" + Settings.Password);
			lbSettings.Items.Add("PhoneNumber=" + Settings.PhoneNumber);
			lbSettings.Items.Add("ServerIP=" + Settings.ServerIP);
			lbSettings.Items.Add("TimeOut=" + Settings.TimeOut);
			lbSettings.Items.Add("UserName=" + Settings.UserName);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Settings.DatabasePath = @"\Test\test.sdf";
			Settings.LastTransmit = System.DateTime.Now.ToString();
			Settings.Password = "etwkdf**";
			Settings.PhoneNumber = "1111111111";
			Settings.ServerIP = "192.168.1.1";
			Settings.TimeOut = "30";
			Settings.UserName = "user2";
			Settings.Update();
		}

	}
}
