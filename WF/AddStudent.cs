using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WF.DataBase;
using System;

namespace WF
{
	public partial class AddStudent : Form
	{
		int FacultyId { get; set; }
		int SpecialtyId { get; set; }

		public AddStudent()
		{
			InitializeComponent();
		}

		void AddStudent_Load(object sender, EventArgs e)
		{
			FillFaculties();
		}

		void Add_Click(object sender, EventArgs e)
		{
			if (NameTB.Text.Trim().Length < 1 ||
				SurnameTB.Text.Trim().Length < 1 ||
				PatronymicTB.Text.Trim().Length < 1 ||
				FacultyCB.SelectedIndex == -1 ||
				SpecialtyCB.SelectedIndex == -1 ||
				MarkTB.Text.Trim().Length < 1)
			{
				MessageBox.Show("Fill all data");
				return;
			}

			if (!Single.TryParse(MarkTB.Text.Trim().Replace(',','.'), out var mark) || mark < 50 || mark > 100)
			{
				MessageBox.Show("Enter mark between 50 and 100");
				return;
			}

			var b = BirthdayDT.Value;

			bool result = new Student
			{
				Surname = SurnameTB.Text.Trim(),
				Name = NameTB.Text.Trim(),
				Patronymic = PatronymicTB.Text.Trim(),
				Gender = Male.Checked,
				Birthday = new DateTime(b.Year, b.Month, b.Day),
				Mark = mark
			}.Insert();

			if (!result)
			{
				MessageBox.Show("An error occured");
			}

			DB.Connection.Open();

			string query = 
				"SELECT MAX(id) " +
				"FROM mycursa4_Db.Student;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();
			reader.Read();
			int studentId = (int)reader[0];

			DB.Connection.Close();

			result = new Course
			{
				CourseNum = (int)CourseUD.Value
			}.Insert();

			if (!result)
			{
				MessageBox.Show("An error occured");
			}

			DB.Connection.Open();

			var cmd = DB.Connection.CreateCommand();

			cmd.CommandText =
				"INSERT INTO mycursa4_Db.showStudent (student, faculty, specialty, course) " +
				$"VALUES ('{studentId}','{FacultyId}','{SpecialtyId}', '{(int)CourseUD.Value}');";

			cmd.ExecuteNonQuery();

			DB.Connection.Close();

			NameTB.Text = SurnameTB.Text = PatronymicTB.Text = MarkTB.Text = String.Empty;
			FacultyCB.SelectedItem = SpecialtyCB.SelectedItem = null;
			CourseUD.Value = 1;
			Male.Checked = true;

			SurnameTB.Focus();
		}

		void FacultyCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			DB.Connection.Open();

			string query =
				"SELECT mycursa4_Db.Faculty.id " +
				"FROM mycursa4_Db.Faculty;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();
			var ids = new List<int>();

			while (reader.Read())
			{
				ids.Add((int)reader[0]);
			}

			DB.Connection.Close();

			if (FacultyCB.SelectedIndex > -1)
			{
				FacultyId = ids[FacultyCB.SelectedIndex];
				FillSpecialties(FacultyId);
			}
		}

		void SpecialtyCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			DB.Connection.Open();

			string query =
				"SELECT mycursa4_Db.Specialty.id FROM mycursa4_Db.Specialty " +
				$"WHERE {FacultyId} = mycursa4_Db.Specialty._facultyID;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();
			var ids = new List<int>();

			while (reader.Read())
			{
				ids.Add((int)reader[0]);
			}

			DB.Connection.Close();

			if (SpecialtyCB.SelectedIndex > -1)
			{
				SpecialtyId = ids[SpecialtyCB.SelectedIndex];
			}
		}

		void AddFaculty_Click(object sender, EventArgs e)
		{
			new AddToStudent(new Faculty()).ShowDialog();
			FillFaculties();
		}

		void AddSpecialty_Click(object sender, EventArgs e)
		{
			if (FacultyCB.SelectedIndex == -1)
			{
				MessageBox.Show("Choose faculty first");
				return;
			}

			DB.Connection.Open();

			string query =
				"SELECT mycursa4_Db.Faculty.id " +
				"FROM mycursa4_Db.Faculty;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();
			var ids = new List<int>();

			while (reader.Read())
			{
				ids.Add((int)reader[0]);
			}

			DB.Connection.Close();

			new AddToStudent(new Specialty { FacultyId = FacultyId }).ShowDialog();
			FillSpecialties(FacultyId);
		}

		void FillFaculties()
		{
			FacultyCB.Items.Clear();
			SpecialtyCB.Items.Clear();

			DB.Connection.Open();

			string query = 
				"SELECT mycursa4_Db.Faculty._name " +
				"FROM mycursa4_Db.Faculty;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();

			while (reader.Read())
			{
				FacultyCB.Items.Add(reader[0]);
			}

			DB.Connection.Close();
		}

		void FillSpecialties(int id)
		{
			if (id == -1)
			{
				return;
			}

			SpecialtyCB.Items.Clear();

			DB.Connection.Open();

			string query =
				"SELECT mycursa4_Db.Specialty._name FROM mycursa4_Db.Specialty " +
				$"WHERE {id} = mycursa4_Db.Specialty._facultyID;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();

			while (reader.Read())
			{
				SpecialtyCB.Items.Add(reader[0]);
			}

			DB.Connection.Close();
		}
	}
}