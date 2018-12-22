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

namespace ProgramManager_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MVP pattern maybe?
            /**
             * Pattern and modular design
             * List with all program 0-X
             * Remove from List
             * Thumbnails
             * Responsive
             * 
             * **/
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            //Add program
            //Bind button to program 1
            openExeFile();

        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            //Run program
            //Bind button to program 2
            MessageBox.Show("RunBtn");
        }

        public void openExeFile()
        {
            string path = "";
            OpenFileDialog openF = new OpenFileDialog();
            openF.Filter = "Executable Flies (.exe)|*.exe";
            openF.Title = "Open File...";
            if (openF.ShowDialog() == DialogResult.OK)
            {
                path = openF.FileName;
                string filenameWithoutPath = Path.GetFileName(path);
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                MessageBox.Show(filenameWithoutPath);
                sr.Close();
                this.Text = openF.FileName;
                Process.Start(path);//Starting the software
            }
        }

        public void addToList()
        {
            //int x = 0;
            List<int> list = new List<int>();
            // list.Insert(x, 5);
            // list.Add(5);
        }


    }
}
