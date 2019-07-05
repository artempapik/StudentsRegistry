using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Net;
using System;

namespace WF.DataBase
{
	class DBHelper
	{
		public static IEnumerable<StudentInList> GetStudentList()
		{
			try
			{
				DB.Connection.Open();

				string query =
					"SELECT mycursa4_Db.Student.surname 'Surname', mycursa4_Db.Student._name AS 'Name', " +
					"mycursa4_Db.Student.patronymic AS 'Patronymic', mycursa4_Db.Student.gender AS 'Gender', " +
					"mycursa4_Db.Student.birthday AS 'Birthday', mycursa4_Db.Course.course AS 'Course', " +
					"mycursa4_Db.Student.mark AS 'Mark', mycursa4_Db.Faculty._name AS 'Faculty', " +
					"mycursa4_Db.Specialty._name AS 'Specialty' " +
					"FROM mycursa4_Db.showStudent " +
					"JOIN mycursa4_Db.Student " +
					"ON mycursa4_Db.showStudent.student = mycursa4_Db.Student.id " +
					"JOIN mycursa4_Db.Faculty " +
					"ON mycursa4_Db.showStudent.faculty = mycursa4_Db.Faculty.id " +
					"JOIN mycursa4_Db.Specialty " +
					"ON mycursa4_Db.showStudent.specialty = mycursa4_Db.Specialty.id " +
					"JOIN mycursa4_Db.Course " +
					"ON mycursa4_Db.showStudent.course = mycursa4_Db.Course.id " +
					"WHERE mycursa4_Db.showStudent.student = mycursa4_Db.Student.id " +
					"AND mycursa4_Db.showStudent.faculty = mycursa4_Db.Faculty.id " +
					"AND mycursa4_Db.showStudent.specialty = mycursa4_Db.Specialty.id " +
					"AND mycursa4_Db.Course.course = mycursa4_Db.Course.id;";

				var reader = new MySqlCommand(query, DB.Connection).ExecuteReader();

				while (reader.Read())
				{
					yield return new StudentInList
					{
						Surname = $"{reader[0]}",
						Name = $"{reader[1]}",
						Patronymic = $"{reader[2]}",
						Gender = (bool)reader[3],
						Birthday = DateTime.Parse($"{reader[4]}"),
						Course = (int)reader[5],
						Mark = (float)reader[6],
						FacultyName = $"{reader[7]}",
						SpecialtyName = $"{reader[8]}"
					};
				}
			}
			finally
			{
				DB.Connection.Close();
			}
		}

		public static bool CheckForInternetConnection()
		{
			try
			{
				using (new WebClient().OpenRead("http://clients3.google.com/generate_204"))
				{
					return true;
				}
			}
			catch
			{
				return false;
			}
		}
	}
}