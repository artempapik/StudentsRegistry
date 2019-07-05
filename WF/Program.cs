using System.Windows.Forms;
using System;

namespace WF
{
	static class Program
	{
		public static bool IsGuest { get; set; }

		public static string[,] Users =
		{
			{ "mycursa4_DbAdmin", "123" },
			{ "mycursa4_Tema", "456" },
		};

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Authorization());
		}
	}
}