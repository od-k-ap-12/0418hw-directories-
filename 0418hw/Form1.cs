using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _0418hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] LogicalDrives = Directory.GetLogicalDrives();
            comboBoxDisks.Items.Clear();
            foreach (string disk in LogicalDrives)
                comboBoxDisks.Items.Add(disk);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            string[] Files;
            string path = comboBoxDisks.SelectedItem.ToString();
            if (textBoxFile.Text == string.Empty)
            {
                Files = Directory.GetFiles(path);
                foreach (string File in Files)
                {
                    FileInfo file = new FileInfo(File);
                    string[] subitems = { file.DirectoryName, file.Length.ToString(), file.LastWriteTime.ToString() };
                    listViewFiles.Items.Add(file.Name).SubItems.AddRange(subitems);
                }
            }
            else if (textBoxFile.Text == "*.txt" && textBoxFindByWordOrPhrase.Text!=string.Empty)
            {

                Files = Directory.GetFiles(path, textBoxFile.Text);
                foreach (string File in Files)
                {

                    FileInfo file = new FileInfo(File);
                    string allText = System.IO.File.ReadAllText(file.FullName, Encoding.Default);
                    if (allText.Contains(textBoxFindByWordOrPhrase.Text))
                    {
                        string[] subitems = { file.DirectoryName, file.Length.ToString(), file.LastWriteTime.ToString() };
                        listViewFiles.Items.Add(file.Name).SubItems.AddRange(subitems);
                    }
                }
            }
            else
            {

                if (textBoxFile.Text == "*.txt" && textBoxFindByWordOrPhrase.Enabled == false)
                {
                    textBoxFindByWordOrPhrase.Enabled = true;
                }
                Files = Directory.GetFiles(path, textBoxFile.Text);
                foreach (string File in Files)
                {
                    FileInfo file = new FileInfo(File);
                    string[] subitems = { file.DirectoryName, file.Length.ToString(), file.LastWriteTime.ToString() };
                    listViewFiles.Items.Add(file.Name).SubItems.AddRange(subitems);
                }
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            listViewFiles.Items.Clear();
        }
    }
}
    

