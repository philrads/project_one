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
        private Model m;
        private string pathP1, pathP2, pathP3;
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
            m = new Model();
        }

        private void AddBtn_1_Click(object sender, EventArgs e)
        {
            //Add program
            //Bind button to program 1
            // openExeFile();

            //UserAction(1);
            pathP1 = (m.openExeFile());
            MessageBox.Show(pathP1);
          //  string filenameWithoutPath = Path.GetFileName(path);
            label1.Text = Path.GetFileName(pathP1);
            
        }

        private void RunBtn_1_Click(object sender, EventArgs e)
        {
            //Run program
            //Bind button to program 1
            MessageBox.Show("RunBtn");
            Process.Start(pathP1);
        }

        /*private void UserAction(int val)
        {
            if(val == 1)
            {
                c.handleEvent(1);
            }
        }*/

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
        /*
          public void handleEvent(int action)
        {
            v = new Form1();
            switch (action)
            {
                case 1:
                    MessageBox.Show("Switch case 1");
                    v.AddToList(m.openExeFile());
                    
                    
                break;

                default:
                    MessageBox.Show("Unknown error, exiting...");
                    Application.Exit();
                break;
            }
            
        }*/

    }
}
