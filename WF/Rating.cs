using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using WF.DataBase;
using System;

namespace WF
{
	public partial class Rating : Form
	{
		public Rating()
		{
			InitializeComponent();
		}

		void Rating_Load(object sender, EventArgs e)
		{
			Students.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
			{
				Font = new Font("Verdana", 9, FontStyle.Bold),
				ForeColor = Color.WhiteSmoke,
				BackColor = Color.FromArgb(26, 26, 26)
			};

			ShowTable(DBHelper.GetStudentList());
		}

		public void ShowTable(IEnumerable<StudentInList> students)
		{
			Students.Rows.Clear();

			if (!DBHelper.CheckForInternetConnection())
			{
				MessageBox.Show("Check your connection");
				Close();
				return;
			}

			int i = Students.RowCount - 1;

			foreach (var n in students)
			{
				Students.Rows.Add(new DataGridViewRow());

				Students.Rows[i].Cells["Surname"].Value = n.Surname;
				Students.Rows[i].Cells["Name"].Value = n.Name;
				Students.Rows[i].Cells["Patronymic"].Value = n.Patronymic;

				bool isRus = $"{Thread.CurrentThread.CurrentUICulture}" == "ru-RU";
				Students.Rows[i].Cells["Gender"].Value =
					n.Gender ? isRus ? "Мужской" : "Male" : isRus ? "Женский" : "Female";

				DateTime b = n.Birthday;
				Students.Rows[i].Cells["Birthday"].Value =
					isRus ? $"{b.Day}-{b.Month}-{b.Year}" : $"{b.Month}/{b.Day}/{b.Year}";

				Students.Rows[i].Cells["Course"].Value = n.Course;
				Students.Rows[i].Cells["Mark"].Value = n.Mark;
				Students.Rows[i].Cells["Faculty"].Value = n.FacultyName;
				Students.Rows[i].Cells["Specialty"].Value = n.SpecialtyName;

				i++;
			}
		}

		void Search_Click(object sender, EventArgs e)
		{
			new Search(this).ShowDialog();
		}
	}
}