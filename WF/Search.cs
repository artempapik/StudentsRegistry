using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WF.DataBase;
using System.Linq;
using System;

namespace WF
{
	public partial class Search : Form
	{
		Rating Rating { get; set; }
		List<StudentInList> Courses = new List<StudentInList>();
		List<StudentInList> Students = DBHelper.GetStudentList().ToList();

		public Search(Rating rating)
		{
			InitializeComponent();
			Rating = rating;
		}

		void Search_Load(object sender, EventArgs e)
		{
			DB.Connection.Open();

			string query = 
				"SELECT mycursa4_Db.Faculty._name " +
				"FROM mycursa4_Db.Faculty;";

			var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();

			while (reader.Read())
			{
				FacultyLV.Items.Add($"{reader[0]}");
			}

			DB.Connection.Close();
		}

		void SearchB_Click(object sender, EventArgs e)
		{
			string surname = SurnameTB.Text.Trim();
			string name = NameTB.Text.Trim();
			string patronymic = PatronymicTB.Text.Trim();

			bool f1 = surname.Length > 0;
			bool f2 = name.Length > 0;
			bool f3 = patronymic.Length > 0;

			if (f1 && !f2 && !f3)
			{
				Students = Students.Where(n => n.Surname == surname).ToList();
			}
			else if (!f1 && f2 && !f3)
			{
				Students = Students.Where(n => n.Name == name).ToList();
			}
			else if (!f1 && !f2 && f3)
			{
				Students = Students.Where(n => n.Patronymic == patronymic).ToList();
			}
			else if (f1 && f2 && !f3)
			{
				Students = Students.Where(n => n.Surname == surname && n.Name == name).ToList();
			}
			else if (f1 && !f2 && f3)
			{
				Students = Students.Where(n => n.Surname == surname && n.Patronymic == patronymic).ToList();
			}
			else if (!f1 && f2 && f3)
			{
				Students = Students.Where(n => n.Name == name && n.Patronymic == patronymic).ToList();
			}
			else if (f1 && f2 && f3)
			{
				Students = Students.Where(n => n.Surname == surname && 
				n.Name == name && n.Patronymic == patronymic).ToList();
			}

			if (MoreB.Checked)
			{
				Students = Students.Where(n => n.Birthday >= BirthdayDT.Value).ToList();
			}
			else if (LessB.Checked)
			{
				Students = Students.Where(n => n.Birthday <= BirthdayDT.Value).ToList();
			}

			AddCourse(Course1, 1);
			AddCourse(Course2, 2);
			AddCourse(Course3, 3);
			AddCourse(Course4, 4);
			AddCourse(Course5, 5);
			AddCourse(Course6, 6);

			void AddCourse(CheckBox cb, int course)
			{
				if (cb.Checked)
				{
					Courses.AddRange(Students.Where(n => n.Course == course));
				}
			}

			if (Course1.Checked || Course2.Checked || Course3.Checked ||
				Course4.Checked || Course5.Checked || Course6.Checked)
			{
				Students.Clear();
				Students.AddRange(Courses);
			}

			MarkTB.Text = MarkTB.Text.Trim().Replace(',', '.');

			if (MarkTB.Text.Length > 0)
			{
				if (Single.TryParse(MarkTB.Text, out var mark))
				{
					if (MoreM.Checked)
					{
						Students = Students.Where(n => n.Mark >= mark).ToList();
					}
					else if (LessM.Checked)
					{
						Students = Students.Where(n => n.Mark <= mark).ToList();
					}
				}
			}

			Courses.Clear();
			bool tryAdd = false;

			if (SpecialtyLV.CheckedItems.Count > 0)
			{
				for (int i = 0; i < SpecialtyLV.Items.Count; i++)
				{
					if (SpecialtyLV.Items[i].Checked)
					{
						Courses.AddRange(Students.Where(n => n.SpecialtyName == SpecialtyLV.Items[i].Text));
					}
				}

				tryAdd = true;
			}
			else if (FacultyLV.CheckedItems.Count > 0)
			{
				for (int i = 0; i < FacultyLV.Items.Count; i++)
				{
					if (FacultyLV.Items[i].Checked)
					{
						Courses.AddRange(Students.Where(n => n.FacultyName == FacultyLV.Items[i].Text));
					}
				}

				tryAdd = true;
			}

			Close();

			if (Courses.Count > 0 || tryAdd)
			{
				Rating.ShowTable(Courses);
			}
			else
			{
				Rating.ShowTable(Students);
			}
		}

		void FacultyLV_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			SpecialtyLV.Items.Clear();

			if (FacultyLV.CheckedIndices.Count == 0)
			{
				return;
			}

			DB.Connection.Open();

			string query =
				"SELECT mycursa4_Db.Faculty.id " +
				"FROM mycursa4_Db.Faculty;";

			var reader1 = new MySqlCommand(query, DB.Connection).ExecuteReader();
			var ids = new List<int>();

			while (reader1.Read())
			{
				ids.Add((int)reader1[0]);
			}

			DB.Connection.Close();

			var selecting = new List<int>();

			var indexes = FacultyLV.CheckedIndices;

			foreach (int n in indexes)
			{
				selecting.Add(ids[n]);
			}

			foreach (var n in selecting)
			{
				DB.Connection.Open();

				query =
					"SELECT mycursa4_Db.Specialty._name FROM mycursa4_Db.Specialty " +
					$"WHERE {n} = mycursa4_Db.Specialty._facultyID;";

				var reader2 = new MySqlCommand(query, DB.Connection).ExecuteReader();

				while (reader2.Read())
				{
					SpecialtyLV.Items.Add($"{reader2[0]}");
				}

				DB.Connection.Close();
			}
		}
	}
}