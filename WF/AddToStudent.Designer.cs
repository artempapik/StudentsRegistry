namespace WF
{
	partial class AddToStudent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToStudent));
			this.NameTB = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NameTB
			// 
			resources.ApplyResources(this.NameTB, "NameTB");
			this.NameTB.Name = "NameTB";
			// 
			// Add
			// 
			resources.ApplyResources(this.Add, "Add");
			this.Add.Name = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// AddToStudent
			// 
			this.AcceptButton = this.Add;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Add);
			this.Controls.Add(this.NameTB);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddToStudent";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox NameTB;
		private System.Windows.Forms.Button Add;
	}
}