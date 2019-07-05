using System.Windows.Forms;
using WF.DataBase;
using System;

namespace WF
{
	public partial class AddToStudent : Form
	{
		object Obj { get; set; }
		Tuple<string, int> Table { get; set; }

		public AddToStudent(object obj, Tuple<string, int> table = null)
		{
			InitializeComponent();
			Obj = obj;
			Table = Tuple.Create(table.Item1, table.Item2);
		}

		void Add_Click(object sender, EventArgs e)
		{
			if (Table != null)
			{
				bool result = false;
				string newValue = NameTB.Text.Trim();

				switch (Obj)
				{
					case Faculty f:
						result = f.Update(Table.Item1, newValue, Table.Item2);
						break;
					case Specialty sp:
						result = sp.Update(Table.Item1, newValue, Table.Item2);
						break;
					case Student st:
						result = st.Update(Table.Item1, newValue, Table.Item2);
						break;
				}

				if (result)
				{
					Close();
				}
				else
				{
					MessageBox.Show("An error occured");
				}
			}
			else
			{
				if (NameTB.Text.Trim().Length > 0)
				{
					bool result = false;

					switch (Obj)
					{
						case Faculty f:
							f.Name = NameTB.Text;
							result = f.Insert();
							break;
						case Specialty sp:
							sp.Name = NameTB.Text;
							result = sp.Insert();
							break;
					}

					if (result)
					{
						Close();
					}
					else
					{
						MessageBox.Show("An error occured");
					}
				}
			}
		}
	}
}