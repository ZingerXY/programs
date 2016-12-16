using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_musicCD
{
	public class Update
	{
		string tablename;
		public List<string[]> pr = new List<string[]>();
		List<Control> tb = new List<Control>();
		string code;
		// Конструктор для получения одного элемента
		public Update(string tablename, string code, string[] pr)
		{
			this.tablename = tablename;
			this.pr.Add(pr);
			this.code = code;
		}
		// Конструктор для получения масива элементов
		public Update(string tablename, string code, List<string[]> pr)
		{
			this.tablename = tablename;
			this.pr = pr;
			this.code = code;
		}
		// Добаление используемых элементов в формы в масив
		public void SetTextBox(int num, Control tb)
		{
			this.tb.Insert(num, tb);
		}
		// Проверка на заполнение элементов формы
		public bool CheckControls()
		{
			for (int i = 0; i < tb.Count; i++)
				if (tb[i].Text == "") return false;
			return true;
		}
		// Получить строку запроса для обновления данных
		public string GetUpdate()
		{
			string str = "UPDATE " + tablename + " SET ";
			for (int i = 0; i < pr.Count; i++)
			{
				string val = "";
				if (tb[i] is TextBox)
					val = tb[i].Text;
				else if (tb[i] is ComboBox)
					val = (((ComboBox)tb[i]).SelectedIndex + 1).ToString(); // << тонкое место
				str += pr[i][0] + " = '" + val + "'" + (i < (pr.Count - 1) ? "," : "");
			}
			str += "WHERE code = " + code;
			return str;
		}
	}
}
