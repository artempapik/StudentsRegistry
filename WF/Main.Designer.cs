namespace WF
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.Rating = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.Student = new System.Windows.Forms.Label();
			this.Rate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Rating
			// 
			this.Rating.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.Rating, "Rating");
			this.Rating.FlatAppearance.BorderSize = 0;
			this.Rating.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Rating.Name = "Rating";
			this.Rating.UseVisualStyleBackColor = false;
			this.Rating.Click += new System.EventHandler(this.Rating_Click);
			this.Rating.MouseEnter += new System.EventHandler(this.Rating_MouseEnter);
			this.Rating.MouseLeave += new System.EventHandler(this.Rating_MouseLeave);
			// 
			// Add
			// 
			resources.ApplyResources(this.Add, "Add");
			this.Add.FlatAppearance.BorderSize = 0;
			this.Add.Name = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			this.Add.MouseEnter += new System.EventHandler(this.Add_MouseEnter);
			this.Add.MouseLeave += new System.EventHandler(this.Add_MouseLeave);
			// 
			// Student
			// 
			resources.ApplyResources(this.Student, "Student");
			this.Student.Name = "Student";
			// 
			// Rate
			// 
			resources.ApplyResources(this.Rate, "Rate");
			this.Rate.Name = "Rate";
			// 
			// Main
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Rate);
			this.Controls.Add(this.Student);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.Rating);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Rating;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Label Student;
		private System.Windows.Forms.Label Rate;
	}
}