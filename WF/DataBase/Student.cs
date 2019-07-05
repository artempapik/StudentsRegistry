using System;

namespace WF.DataBase
{
	class Student : Common
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }
		public bool Gender { get; set; }
		public DateTime Birthday { get; set; }
		public float Mark { get; set; }
	}
}