using MySql.Data.MySqlClient;

namespace WF.DataBase
{
	static class DB
	{
		public static MySqlConnection Connection;

		public static string SetTableName(this Common obj)
		{
			switch (obj)
			{
				case Faculty f:
					return "Faculty";
				case Specialty sp:
					return "Specialty";
				case Student st:
					return "Student";
				default:
					return null;
			}
		}
	}
}