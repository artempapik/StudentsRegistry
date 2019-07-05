using MySql.Data.MySqlClient;

namespace WF.DataBase
{
	static class UpdateDB
	{
		static MySqlCommand cmd = DB.Connection.CreateCommand();

		public static bool Update(this Common obj, string oldValue, string newValue, int id)
		{
			DB.Connection.Open();
			cmd.CommandText =
				$"UPDATE mycursa4_Db.{obj.SetTableName()} " +
				$"SET mycursa4_Db.{obj.SetTableName()}.{oldValue} = '{newValue}' WHERE id = {id};";
			bool result = cmd.ExecuteNonQuery() > 0;
			DB.Connection.Close();

			return result;
		}
	}
}