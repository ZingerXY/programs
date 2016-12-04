using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_musicCD
{
	static public class SQL
	{
		static public DataTable query(OleDbConnection c, string query)
		{
			DataTable dt = new DataTable();
			OleDbCommand mc = new OleDbCommand();
			OleDbDataAdapter da = new OleDbDataAdapter();
			c.Open();
			mc.Connection = c;
			mc.CommandText = query;
			da.SelectCommand = mc;
			try
			{
				da.Fill(dt);
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
			c.Close();
			return dt;
		}

		static public void query(OleDbConnection c, string query, out object t)
		{
			DataTable dt = new DataTable();
			OleDbCommand mc = new OleDbCommand();
			OleDbDataAdapter da = new OleDbDataAdapter();
			c.Open();
			mc.Connection = c;
			mc.CommandText = query;
			da.SelectCommand = mc;
			try
			{
				da.Fill(dt);
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
			c.Close();
			t = (object)dt.Rows[0][0];
		}

		static public int query(OleDbConnection c, string query, string simg = null, byte[] img = null)
		{
			int n = 0;
			DataTable dt = new DataTable();
			OleDbCommand mc = new OleDbCommand();
			OleDbDataAdapter da = new OleDbDataAdapter();
			c.Open();
			mc.Connection = c;
			mc.CommandText = query;
			if (simg != null && img != null || simg != "add")
				mc.Parameters.AddWithValue(simg, img);
			try
			{
				n = mc.ExecuteNonQuery();
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
			c.Close();
			return n;
		}
	}
}
