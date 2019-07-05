namespace WF
{
	partial class AddStudent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
			this.Name = new System.Windows.Forms.Label();
			this.NameTB = new System.Windows.Forms.TextBox();
			this.Surname = new System.Windows.Forms.Label();
			this.Birthday = new System.Windows.Forms.Label();
			this.Gender = new System.Windows.Forms.Label();
			this.Male = new System.Windows.Forms.RadioButton();
			this.Female = new System.Windows.Forms.RadioButton();
			this.SurnameTB = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.BirthdayDT = new System.Windows.Forms.DateTimePicker();
			this.Course = new System.Windows.Forms.Label();
			this.CourseUD = new System.Windows.Forms.NumericUpDown();
			this.Faculty = new System.Windows.Forms.Label();
			this.FacultyCB = new System.Windows.Forms.ComboBox();
			this.AddFaculty = new System.Windows.Forms.Label();
			this.Specialty = new System.Windows.Forms.Label();
			this.SpecialtyCB = new System.Windows.Forms.ComboBox();
			this.AddSpecialty = new System.Windows.Forms.Label();
			this.PatronymicTB = new System.Windows.Forms.TextBox();
			this.Patronymic = new System.Windows.Forms.Label();
			this.Extra = new System.Windows.Forms.Label();
			this.MarkTB = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.CourseUD)).BeginInit();
			this.SuspendLayout();
			// 
			// Name
			// 
			resources.ApplyResources(this.Name, "Name");
			this.Name.Name = "Name";
			// 
			// NameTB
			// 
			resources.ApplyResources(this.NameTB, "NameTB");
			this.NameTB.Name = "NameTB";
			// 
			// Surname
			// 
			resources.ApplyResources(this.Surname, "Surname");
			this.Surname.Name = "Surname";
			// 
			// Birthday
			// 
			resources.ApplyResources(this.Birthday, "Birthday");
			this.Birthday.Name = "Birthday";
			// 
			// Gender
			// 
			resources.ApplyResources(this.Gender, "Gender");
			this.Gender.Name = "Gender";
			// 
			// Male
			// 
			resources.ApplyResources(this.Male, "Male");
			this.Male.Checked = true;
			this.Male.Name = "Male";
			this.Male.TabStop = true;
			this.Male.UseVisualStyleBackColor = true;
			// 
			// Female
			// 
			resources.ApplyResources(this.Female, "Female");
			this.Female.Name = "Female";
			this.Female.UseVisualStyleBackColor = true;
			// 
			// SurnameTB
			// 
			resources.ApplyResources(this.SurnameTB, "SurnameTB");
			this.SurnameTB.Name = "SurnameTB";
			// 
			// Add
			// 
			resources.ApplyResources(this.Add, "Add");
			this.Add.Name = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// BirthdayDT
			// 
			resources.ApplyResources(this.BirthdayDT, "BirthdayDT");
			this.BirthdayDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.BirthdayDT.Name = "BirthdayDT";
			this.BirthdayDT.ShowUpDown = true;
			this.BirthdayDT.Value = new System.DateTime(2018, 5, 8, 0, 0, 0, 0);
			// 
			// Course
			// 
			resources.ApplyResources(this.Course, "Course");
			this.Course.Name = "Course";
			// 
			// CourseUD
			// 
			resources.ApplyResources(this.CourseUD, "CourseUD");
			this.CourseUD.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.CourseUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.CourseUD.Name = "CourseUD";
			this.CourseUD.ReadOnly = true;
			this.CourseUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Faculty
			// 
			resources.ApplyResources(this.Faculty, "Faculty");
			this.Faculty.Name = "Faculty";
			// 
			// FacultyCB
			// 
			this.FacultyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.FacultyCB, "FacultyCB");
			this.FacultyCB.FormattingEnabled = true;
			this.FacultyCB.Name = "FacultyCB";
			this.FacultyCB.SelectedIndexChanged += new System.EventHandler(this.FacultyCB_SelectedIndexChanged);
			// 
			// AddFaculty
			// 
			resources.ApplyResources(this.AddFaculty, "AddFaculty");
			this.AddFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddFaculty.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.AddFaculty.Name = "AddFaculty";
			this.AddFaculty.Click += new System.EventHandler(this.AddFaculty_Click);
			// 
			// Specialty
			// 
			resources.ApplyResources(this.Specialty, "Specialty");
			this.Specialty.Name = "Specialty";
			// 
			// SpecialtyCB
			// 
			this.SpecialtyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.SpecialtyCB, "SpecialtyCB");
			this.SpecialtyCB.FormattingEnabled = true;
			this.SpecialtyCB.Name = "SpecialtyCB";
			this.SpecialtyCB.SelectedIndexChanged += new System.EventHandler(this.SpecialtyCB_SelectedIndexChanged);
			// 
			// AddSpecialty
			// 
			resources.ApplyResources(this.AddSpecialty, "AddSpecialty");
			this.AddSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddSpecialty.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.AddSpecialty.Name = "AddSpecialty";
			this.AddSpecialty.Click += new System.EventHandler(this.AddSpecialty_Click);
			// 
			// PatronymicTB
			// 
			resources.ApplyResources(this.PatronymicTB, "PatronymicTB");
			this.PatronymicTB.Name = "PatronymicTB";
			// 
			// Patronymic
			// 
			resources.ApplyResources(this.Patronymic, "Patronymic");
			this.Patronymic.Name = "Patronymic";
			// 
			// Extra
			// 
			resources.ApplyResources(this.Extra, "Extra");
			this.Extra.Name = "Extra";
			// 
			// MarkTB
			// 
			resources.ApplyResources(this.MarkTB, "MarkTB");
			this.MarkTB.Name = "MarkTB";
			// 
			// AddStudent
			// 
			this.AcceptButton = this.Add;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MarkTB);
			this.Controls.Add(this.Extra);
			this.Controls.Add(this.PatronymicTB);
			this.Controls.Add(this.Patronymic);
			this.Controls.Add(this.AddSpecialty);
			this.Controls.Add(this.SpecialtyCB);
			this.Controls.Add(this.Specialty);
			this.Controls.Add(this.AddFaculty);
			this.Controls.Add(this.FacultyCB);
			this.Controls.Add(this.Faculty);
			this.Controls.Add(this.CourseUD);
			this.Controls.Add(this.Course);
			this.Controls.Add(this.BirthdayDT);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.SurnameTB);
			this.Controls.Add(this.Female);
			this.Controls.Add(this.Male);
			this.Controls.Add(this.Gender);
			this.Controls.Add(this.Birthday);
			this.Controls.Add(this.Surname);
			this.Controls.Add(this.NameTB);
			this.Controls.Add(this.Name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Load += new System.EventHandler(this.AddStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.CourseUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private new System.Windows.Forms.Label Name;
		private System.Windows.Forms.TextBox NameTB;
		private System.Windows.Forms.Label Surname;
		private System.Windows.Forms.Label Birthday;
		private System.Windows.Forms.Label Gender;
		private System.Windows.Forms.RadioButton Male;
		private System.Windows.Forms.RadioButton Female;
		private System.Windows.Forms.TextBox SurnameTB;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.DateTimePicker BirthdayDT;
		private System.Windows.Forms.Label Course;
		private System.Windows.Forms.NumericUpDown CourseUD;
		private System.Windows.Forms.Label Faculty;
		private System.Windows.Forms.ComboBox FacultyCB;
		private System.Windows.Forms.Label AddFaculty;
		private System.Windows.Forms.Label Specialty;
		private System.Windows.Forms.ComboBox SpecialtyCB;
		private System.Windows.Forms.Label AddSpecialty;
		private System.Windows.Forms.TextBox PatronymicTB;
		private System.Windows.Forms.Label Patronymic;
		private System.Windows.Forms.Label Extra;
		private System.Windows.Forms.TextBox MarkTB;
	}
}