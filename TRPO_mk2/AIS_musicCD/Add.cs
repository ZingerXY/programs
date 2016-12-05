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
				TextBox myText = new TextBox();
				myText.Location = new Point( 110, i * 25 + st);
				apr.SetTextBox(i,myText);
                this.Controls.Add(myText);
			}

			Button myButt = new Button();
			myButt.Text = "Добавить";
			myButt.Location = new Point(110, num * 25 + st);
			this.Controls.Add(myButt);
			myButt.Click += MyButt_Click;
			Height = 39 + (num + 1) * 25 + st;
			Width = 250;
		}

		private void MyButt_Click(object sender, EventArgs e)
		{
			MessageBox.Show(apr.GetInsert());
			//throw new NotImplementedException();
		}

		private void Add_MouseMove(object sender, MouseEventArgs e)
		{
			Text = e.X + ":" + e.Y;
		}
	}
}
