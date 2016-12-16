using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_musicCD
{
	public partial class Up : Form
	{
		OleDbConnection DBC;
		Update apr;
		Action foo;
		
		public Up(OleDbConnection DBC, Update apr, Action foo)
		{
			this.DBC = DBC;
			this.apr = apr;
			this.foo = foo;
			InitializeComponent();
		}

		private void Add_Load(object sender, EventArgs e)
		{
			var num = apr.pr.Count; // количество элементов
			var st = 10; // начальная позиция по вертикали
			var dict = 0;

			for (int i = 0; i < num; i++)
			{
				Label myLabel = new Label();
				myLabel.Location = new Point(10, i * 35 + st + 2);
				myLabel.Text = apr.pr[i][1];
				this.Controls.Add(myLabel);

				if (apr.pr[i].Length > 3)
				{
					ComboBox myCbox = new ComboBox();
					myCbox.Size = new Size(140, 28);
					myCbox.DropDownStyle = ComboBoxStyle.DropDownList;
					myCbox.Location = new Point(110, i * 35 + st);
					DataTable dt = SQL.query(DBC, "SELECT * FROM " + apr.pr[i][2]);
					apr.record.Add(new Dictionary<int, string>());
					for (int j = 0; j < dt.Rows.Count; j++)
					{
						string code = dt.Rows[j][0].ToString();
						string name = dt.Rows[j][1].ToString();
						int index = myCbox.Items.Add(name);
                        apr.record[dict].Add(index, code);
						if (code == apr.pr[i][3])
							myCbox.SelectedIndex = index;
                    }
					dict++;
                    apr.SetTextBox(i, myCbox);
					this.Controls.Add(myCbox);
				}
				else
				{
					TextBox myText = new TextBox();
					myText.Size = new Size(140, 26);
					myText.Location = new Point(110, i * 35 + st);
					myText.Text = apr.pr[i][2];
                    apr.SetTextBox(i, myText);
					this.Controls.Add(myText);
				}

			}

			Button myButt = new Button();
			myButt.Text = "Обновить";
			myButt.Location = new Point(110, num * 35 + st);
			myButt.Size = new Size(140, 35);
			myButt.FlatStyle = FlatStyle.Flat;
			myButt.BackColor = Color.FromName("ButtonHighlight");
			this.Controls.Add(myButt);
			myButt.Click += MyButt_Click;
			Height = 49 + (num + 1) * 35 + st;
			Width = 280;
		}

		private void MyButt_Click(object sender, EventArgs e)
		{
			if (!apr.CheckControls())
			{
				MessageBox.Show("Не все поля заполненны.");
				return;
			}
			if (SQL.query(DBC, apr.GetUpdate(), "add") > 0)
			{
				foo();
				MessageBox.Show("Запись успешно обновлена.");
			}		
			Close();
		}
	}
}
