namespace WF
{
	partial class Authorization
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
			this.Username = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.Label();
			this.UsernameTB = new System.Windows.Forms.TextBox();
			this.PasswordTB = new System.Windows.Forms.TextBox();
			this.Login = new System.Windows.Forms.Button();
			this.Guest = new System.Windows.Forms.Button();
			this.Keys = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Keys)).BeginInit();
			this.SuspendLayout();
			// 
			// Username
			// 
			resources.ApplyResources(this.Username, "Username");
			this.Username.Name = "Username";
			// 
			// Password
			// 
			resources.ApplyResources(this.Password, "Password");
			this.Password.Name = "Password";
			// 
			// UsernameTB
			// 
			this.UsernameTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			resources.ApplyResources(this.UsernameTB, "UsernameTB");
			this.UsernameTB.Name = "UsernameTB";
			// 
			// PasswordTB
			// 
			this.PasswordTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			resources.ApplyResources(this.PasswordTB, "PasswordTB");
			this.PasswordTB.Name = "PasswordTB";
			this.PasswordTB.UseSystemPasswordChar = true;
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.Color.Lavender;
			this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			resources.ApplyResources(this.Login, "Login");
			this.Login.Name = "Login";
			this.Login.UseVisualStyleBackColor = false;
			this.Login.Click += new System.EventHandler(this.Login_Click);
			// 
			// Guest
			// 
			this.Guest.BackColor = System.Drawing.Color.Lavender;
			this.Guest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
			resources.ApplyResources(this.Guest, "Guest");
			this.Guest.Name = "Guest";
			this.Guest.UseVisualStyleBackColor = false;
			this.Guest.Click += new System.EventHandler(this.Guest_Click);
			// 
			// Keys
			// 
			resources.ApplyResources(this.Keys, "Keys");
			this.Keys.Name = "Keys";
			this.Keys.TabStop = false;
			// 
			// Authorization
			// 
			this.AcceptButton = this.Login;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.Controls.Add(this.Keys);
			this.Controls.Add(this.Guest);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.PasswordTB);
			this.Controls.Add(this.UsernameTB);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Username);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Authorization";
			((System.ComponentModel.ISupportInitialize)(this.Keys)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.TextBox UsernameTB;
		private System.Windows.Forms.TextBox PasswordTB;
		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.Button Guest;
		private System.Windows.Forms.PictureBox Keys;
	}
}