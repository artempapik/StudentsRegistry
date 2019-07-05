using MySql.Data.MySqlClient;
using WF.DataBase;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace WF
{
	public partial class Authorization : Form
	{
		public Authorization()
		{
			InitializeComponent();
		}

		void Login_Click(object sender, EventArgs e)
		{
			UsernameTB.Text = UsernameTB.Text.Trim();
			PasswordTB.Text = PasswordTB.Text.Trim();

			if (UsernameTB.Text.Length < 1 ||
				PasswordTB.Text.Length < 1)
			{
				return;
			}

			for (int i = 0; i < Program.Users.GetLength(0); i++)
			{
				if (UsernameTB.Text == Program.Users[i, 0] && PasswordTB.Text == Program.Users[i, 1])
				{
					DB.Connection = new MySqlConnection(new MySqlConnectionStringBuilder
					{
						Server = "91.221.70.206",
						UserID = UsernameTB.Text,
						Password = PasswordTB.Text,
						ConvertZeroDateTime = true,
						SslMode = MySqlSslMode.None
					}.ToString());

					Program.IsGuest = false;
					LeaveForm();
					Hide();
					new Main().ShowDialog();
					Show();
					UsernameTB.Focus();

					return;
				}
			}

			UsernameTB.BackColor = Color.Red;
			PasswordTB.BackColor = Color.Red;

			UsernameTB.ForeColor = Color.WhiteSmoke;
			PasswordTB.ForeColor = Color.WhiteSmoke;
		}

		void Guest_Click(object sender, EventArgs e)
		{
			DB.Connection = new MySqlConnection(new MySqlConnectionStringBuilder
			{
				Server = "91.221.70.206",
				UserID = "mycursa4_Guest",
				Password = "147",
				ConvertZeroDateTime = true,
				SslMode = MySqlSslMode.None
			}.ToString());

			Program.IsGuest = true;
			LeaveForm();
			Hide();
			new Rating().ShowDialog();
			Show();
			UsernameTB.Focus();
		}

		void LeaveForm()
		{
			UsernameTB.Text = String.Empty;
			PasswordTB.Text = String.Empty;

			UsernameTB.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
			PasswordTB.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);

			UsernameTB.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
			PasswordTB.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
		}

		void LocalDB_CheckedChanged(object sender, EventArgs e)
		{
			UsernameTB.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
			PasswordTB.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);

			UsernameTB.Enabled = true;
			PasswordTB.Enabled = true;

			Guest.Enabled = true;
		}
	}
}