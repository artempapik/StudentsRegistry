using MySql.Data.MySqlClient;

namespace WF.DataBase
{
	static class InsertDB
	{
		static MySqlCommand cmd = DB.Connection.CreateCommand();

		public static bool Insert(this Faculty f)
		{
			DB.Connection.Open();

			cmd.CommandText = $"INSERT INTO mycursa4_Db.Faculty (_name) VALUES ('{f.Name}');";

			bool result = cmd.ExecuteNonQuery() > 0;

			DB.Connection.Close();

			return result;
		}

		public static bool Insert(this Specialty sp)
		{
			DB.Connection.Open();

			cmd.CommandText = 
				"INSERT INTO mycursa4_Db.Specialty (_name, _facultyID) " +
				$"VALUES ('{sp.Name}', '{sp.FacultyId}');";

			bool result = cmd.ExecuteNonQuery() > 0;

			DB.Connection.Close();

			return result;
		}

		public static bool Insert(this Student st)
		{
			DB.Connection.Open();

			cmd.CommandText =
				"INSERT INTO mycursa4_Db.Student " +
				"(surname, _name, patronymic, gender, birthday, mark) " +
				$"VALUES ('{st.Surname}', '{st.Name}', '{st.Patronymic}', {st.Gender}, " +
				$"'{st.Birthday.Year}-{st.Birthday.Month}-{st.Birthday.Day}', '{st.Mark}');";

			bool result = cmd.ExecuteNonQuery() > 0;

			DB.Connection.Close();

			return result;
		}

		public static bool Insert(this Course c)
		{
			DB.Connection.Open();

			cmd.CommandText = $"INSERT INTO mycursa4_Db.Course (course) VALUES ('{c.CourseNum}');";

			bool result = cmd.ExecuteNonQuery() > 0;

			DB.Connection.Close();

			return result;
		}
	}
}