using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Text_editor_and_guide
{
    public partial class Conductor : Form
    {
        List<string> listfiels= new List<string>();
        DriveInfo[] drives = DriveInfo.GetDrives();
        public Conductor()
        {
            InitializeComponent();
            foreach (var drive in drives)
                if (drive.DriveType == DriveType.Fixed)
                {
                    listView1.Items.Add(drive.Name);
                    listfiels.Add(drive.Name);
                }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listfiels.Clear();
            listView1.Items.Clear();
            using(FolderBrowserDialog dlg = new FolderBrowserDialog() { Description = "Select you Patch" })
            {
                textBox1.Text = dlg.SelectedPath;
                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    foreach(string item in Directory.GetFileSystemEntries(dlg.SelectedPath))
                    {
                        FileInfo file= new FileInfo(item);
                        listfiels.Add(file.FullName);
                        listView1.Items.Add(file.Name,imageList1.Images.Count-1);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(listfiels[listView1.FocusedItem.Index]))
            {
                textBox1.Text = listfiels[listView1.FocusedItem.Index];
                listfiels.Clear();
                listView1.Items.Clear();
                foreach (string item in Directory.GetFileSystemEntries(textBox1.Text))
                {
                    FileInfo file = new FileInfo(item);
                    listfiels.Add(file.FullName);
                    listView1.Items.Add(file.Name);
                }
            }
            else
            {
                MessageBox.Show("This is not a directory");
            }


        }
    }
}
