using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace Explorer
{
    public partial class Form2 : Form
    {
        public string param;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            DriveInfo drive = new DriveInfo(param);

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Name";
            item1.SubItems.Add(drive.Name);
            listView1.Items.Add(item1);

            if (drive.IsReady)
            {
                ListViewItem item2 = new ListViewItem();
                item2.Text = "File System";
                item2.SubItems.Add(drive.DriveFormat);
                listView1.Items.Add(item2);

                double size = drive.TotalSize;
                string unit = " Bytes";

                string[] units = new string[] { " KB", " MB", " GB", " TB" };

                for (int i = 0; i < units.Length; i++)
                {
                    if (size > 1024)
                    {
                        size /= 1024;
                        unit = units[i];
                    }
                }

                ListViewItem item4 = new ListViewItem();
                item4.Text = "Size";
                item4.SubItems.Add(size.ToString("0.00") + unit);
                listView1.Items.Add(item4);
            }

            ListViewItem item3 = new ListViewItem();
            item3.Text = "type";
            string type = "unknown";
            if (drive.DriveType == DriveType.Removable)
            {
                type = "Removable";
            }
            if (drive.DriveType == DriveType.Fixed)
            {
                type = "Fixed";
            }
            if (drive.DriveType == DriveType.CDRom)
            {
                type = "CDRom";
            }
            item3.SubItems.Add(type);
            listView1.Items.Add(item3);


        }
    }
}
