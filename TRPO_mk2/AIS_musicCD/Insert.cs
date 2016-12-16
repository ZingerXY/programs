using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_musicCD
{
	// Примеры создания формы
	// Создание формы на добавление с множеством полей
	/*List<string[]> ls = new List<string[]>();
	ls.Add("group_name,Название группы".Split(',')); // TextBox
	ls.Add("style,Стиль,style".Split(',')); // ComboBox
	ls.Add("country,Страна,country".Split(','));
	Insert ins = new Insert("authors", ls);
	Add add = new Add(DBC, ins);
	add.Show();*/
	// Создание формы на добавление с 1 полем
	/*string[]  str = new string[2];
	str = "style_name Стиль".Split(' ');
	Insert ins = new Insert("style", str);
	Add add = new Add(DBC, ins);
	add.Show();*/
	public class Insert
	{
		string tablename;
		public List<string[]> pr = new List<string[]>();
		List<Control> tb = new List<Control>();
		// Конструктор для получения одного элемента
		public Insert(string tablename, string[] pr)
		{
			this.tablename = tablename;
			this.pr.Add(pr);
		}
		// Конструктор для получения масива элементов
		public Insert(string tablename, List<string[]> pr)
		{
			this.tablename = tablename;
			this.pr = pr;
		}
		// Добаление используемых элементов в формы в масив
		public void SetTextBox(int num, Control tb)
		{
			this.tb.Insert(num,tb);
		}
		// Проверка на заполнение элементов формы
		public bool CheckControls()
		{
			for (int i = 0; i < tb.Count; i++)
				if (tb[i].Text == "") return false;
			return true;
		}
		// Получить строку запроса для добавления данных
		public string GetInsert()
		{
			string str = "INSERT INTO " + tablename + "(";
            for (int i = 0; i < pr.Count; i++)
				str += pr[i][0] + (i < (pr.Count - 1) ? "," : "");
			str += ") VALUES(";
			for (int i = 0; i < tb.Count; i++)
			{
				string val = "";
				if (tb[i] is TextBox)
					val = tb[i].Text;
				else if (tb[i] is ComboBox)
					val = (((ComboBox)tb[i]).SelectedIndex + 1).ToString(); // << тонкое место
				str += "'" + val + "'" + (i < (tb.Count - 1) ? "," : "");
			}				
			str += ")";
			return str;
		}
	}
}
