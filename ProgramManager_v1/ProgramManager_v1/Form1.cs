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
        private Control c;
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
            c = new Control();
        }

        private void AddBtn_1_Click(object sender, EventArgs e)
        {
            //Add program
            //Bind button to program 1
           // openExeFile();

           UserAction(1);
        }

        private void RunBtn_1_Click(object sender, EventArgs e)
        {
            //Run program
            //Bind button to program 2
            MessageBox.Show("RunBtn");
        }

        private void UserAction(int val)
        {
            if(val == 1)
            {
                c.handleEvent(1);
            }
        }

        public void AddToList(string name)
        {
            MessageBox.Show("AddToList");
            label1.Text = name; //ASSÅ VARFÖR FUNKAR DET INTE 
            
           
            MessageBox.Show(name);
            //int x = 0;
            List<int> list = new List<int>();
            // list.Insert(x, 5);
            // list.Add(5);
        }


    }
}
