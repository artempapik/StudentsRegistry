using MySql.Data.MySqlClient;

namespace WF.DataBase
{
	static class DeleteDB
	{
		static MySqlCommand cmd = DB.Connection.CreateCommand();

		public static bool Delete(this Common obj, int id)
		{
			DB.Connection.Open();
			cmd.CommandText = 
				"DELETE FROM mycursa4_Db.showStudent " +
				$"WHERE mycursa4_Db.showStudent.{obj.SetTableName().ToLower()} = {id};";
			bool result1 = cmd.ExecuteNonQuery() > 0;
			DB.Connection.Close();

			DB.Connection.Open();
			cmd.CommandText = $"DELETE FROM mycursa4_Db.{obj.SetTableName()} WHERE id = {id};";
			bool result2 = cmd.ExecuteNonQuery() > 0;
			DB.Connection.Close();

			return result1 && result2;
		}
	}
}