using System.Windows.Forms;
using System.Drawing;
using System;

namespace WF
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		void Add_Click(object sender, EventArgs e) => new AddStudent().ShowDialog();
		void Rating_Click(object sender, EventArgs e) => new Rating().ShowDialog();

		void Add_MouseEnter(object sender, EventArgs e) => EnterB(Student);
		void Add_MouseLeave(object sender, EventArgs e) => LeaveB(Student);

		void Rating_MouseEnter(object sender, EventArgs e) => EnterB(Rate);
		void Rating_MouseLeave(object sender, EventArgs e) => LeaveB(Rate);

		void EnterB(Label l)
		{
			l.Font = new Font("Verdana", 12, FontStyle.Bold);
			l.ForeColor = Color.Navy;
		}

		void LeaveB(Label l)
		{
			l.Font = new Font("Verdana", 11, FontStyle.Bold);
			l.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
		}
	}
}