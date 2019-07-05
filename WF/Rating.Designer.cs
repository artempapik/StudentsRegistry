namespace WF
{
	partial class Rating
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rating));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Students = new System.Windows.Forms.DataGridView();
			this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Search = new System.Windows.Forms.Button();
			this.DeleteUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.Update = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
			this.DeleteUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// Students
			// 
			this.Students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.Students.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			resources.ApplyResources(this.Students, "Students");
			this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Name,
            this.Patronymic,
            this.Gender,
            this.Birthday,
            this.Course,
            this.Mark,
            this.Faculty,
            this.Specialty});
			this.Students.ContextMenuStrip = this.DeleteUpdate;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Students.DefaultCellStyle = dataGridViewCellStyle2;
			this.Students.EnableHeadersVisualStyles = false;
			this.Students.GridColor = System.Drawing.Color.DarkGray;
			this.Students.Name = "Students";
			this.Students.ReadOnly = true;
			this.Students.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.Students.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.Students.ShowCellErrors = false;
			this.Students.ShowCellToolTips = false;
			this.Students.ShowEditingIcon = false;
			this.Students.ShowRowErrors = false;
			// 
			// Surname
			// 
			resources.ApplyResources(this.Surname, "Surname");
			this.Surname.Name = "Surname";
			this.Surname.ReadOnly = true;
			// 
			// Name
			// 
			resources.ApplyResources(this.Name, "Name");
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// Patronymic
			// 
			resources.ApplyResources(this.Patronymic, "Patronymic");
			this.Patronymic.Name = "Patronymic";
			this.Patronymic.ReadOnly = true;
			// 
			// Gender
			// 
			resources.ApplyResources(this.Gender, "Gender");
			this.Gender.Name = "Gender";
			this.Gender.ReadOnly = true;
			// 
			// Birthday
			// 
			resources.ApplyResources(this.Birthday, "Birthday");
			this.Birthday.Name = "Birthday";
			this.Birthday.ReadOnly = true;
			// 
			// Course
			// 
			resources.ApplyResources(this.Course, "Course");
			this.Course.Name = "Course";
			this.Course.ReadOnly = true;
			// 
			// Mark
			// 
			resources.ApplyResources(this.Mark, "Mark");
			this.Mark.Name = "Mark";
			this.Mark.ReadOnly = true;
			// 
			// Faculty
			// 
			resources.ApplyResources(this.Faculty, "Faculty");
			this.Faculty.Name = "Faculty";
			this.Faculty.ReadOnly = true;
			// 
			// Specialty
			// 
			resources.ApplyResources(this.Specialty, "Specialty");
			this.Specialty.Name = "Specialty";
			this.Specialty.ReadOnly = true;
			// 
			// Search
			// 
			resources.ApplyResources(this.Search, "Search");
			this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
			this.Search.Name = "Search";
			this.Search.TabStop = false;
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// DeleteUpdate
			// 
			this.DeleteUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete,
            this.Update});
			this.DeleteUpdate.Name = "contextMenuStrip1";
			resources.ApplyResources(this.DeleteUpdate, "DeleteUpdate");
			// 
			// Delete
			// 
			resources.ApplyResources(this.Delete, "Delete");
			this.Delete.Name = "Delete";
			// 
			// Update
			// 
			resources.ApplyResources(this.Update, "Update");
			this.Update.Name = "Update";
			// 
			// Rating
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.Search);
			this.Controls.Add(this.Students);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Load += new System.EventHandler(this.Rating_Load);
			((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
			this.DeleteUpdate.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
		private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Course;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
		private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
		public System.Windows.Forms.DataGridView Students;
		private System.Windows.Forms.ContextMenuStrip DeleteUpdate;
		private System.Windows.Forms.ToolStripMenuItem Delete;
		private new System.Windows.Forms.ToolStripMenuItem Update;
	}
}