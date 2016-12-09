using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_musicCD
{
	public class Insert
	{
		string tablename;
		public List<string[]> pr = new List<string[]>();
		List<Control> tb = new List<Control>();
		

		public Insert(string tablename, string[] pr)
		{
			this.tablename = tablename;
			this.pr.Add(pr);
		}

		public Insert(string tablename, List<string[]> pr)
		{
			this.tablename = tablename;
			this.pr = pr;
		}

		public void SetTextBox(int num, Control tb)
		{
			this.tb.Insert(num,tb);
		}

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
					val = (((ComboBox)tb[i]).SelectedIndex + 1).ToString();
				str += "'" + val + "'" + (i < (tb.Count - 1) ? "," : "");
			}				
			str += ")";
			return str;
		}
	}
}
