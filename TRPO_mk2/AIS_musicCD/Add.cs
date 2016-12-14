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
	public partial class Add : Form
	{
		OleDbConnection DBC;
		Insert apr;

		public Add(OleDbConnection DBC, Insert pr)
		{
			this.DBC = DBC;
			apr = pr;
			InitializeComponent();
		}

		private void Add_Load(object sender, EventArgs e)
		{
			var num = apr.pr.Count; // количество элементов
			var st = 10; // начальная позиция по вертикали

			for(int i = 0; i < num; i++)
			{
				Label myLabel = new Label();
				myLabel.Location = new Point( 10, i * 25 + st + 2);
				myLabel.Text = apr.pr[i][1];
				//myLabel.BackColor = Color.Red;
				this.Controls.Add(myLabel);

				if(apr.pr[i].Length > 2)
				{
					ComboBox myCbox = new ComboBox();
					myCbox.Location = new Point(110, i * 25 + st);
					DataTable dt = SQL.query(DBC, "SELECT * FROM " + apr.pr[i][2]);
					for (int j = 0; j < dt.Rows.Count; j++)
					{
						//int n = int.Parse(dt.Rows[j][0].ToString());
                        myCbox.Items.Add(dt.Rows[j][1].ToString());
					}					
					apr.SetTextBox(i, myCbox);
					this.Controls.Add(myCbox);
				}
				else
				{
					TextBox myText = new TextBox();
					myText.Location = new Point(110, i * 25 + st);
					apr.SetTextBox(i, myText);
					this.Controls.Add(myText);
				}
				
			}

			Button myButt = new Button();
			myButt.Text = "Добавить";
			myButt.Location = new Point(110, num * 25 + st);
			this.Controls.Add(myButt);
			myButt.Click += MyButt_Click;
			Height = 49 + (num + 1) * 25 + st;
			Width = 260;
		}

		private void MyButt_Click(object sender, EventArgs e)
		{
			if(!apr.CheckControls())
			{
				MessageBox.Show("Не все поля заполненны.");
				return;
			}
				
			/*MessageBox.Show(apr.GetInsert());
			return;*/
			if (SQL.query(DBC, apr.GetInsert(), "add") > 0)
				MessageBox.Show("Запись успешно добавлена.");
			Close();
			//throw new NotImplementedException();
		}

		private void Add_MouseMove(object sender, MouseEventArgs e)
		{
			//Text = e.X + ":" + e.Y;
		}
	}
}
