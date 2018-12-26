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
             * https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-extract-the-icon-associated-with-a-file-in-windows-forms
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
            AddPic(pathP1);
            addToListView(pathP1);
            
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

        public void AddPic(string name)
        {
            try
            {
                imageList1 = new ImageList();
                Icon iconForFile = SystemIcons.WinLogo;
                Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(name);
                imageList1.Images.Add(icon);

                pictureBox1.Image = imageList1.Images[0];
            }catch(Exception e){
                MessageBox.Show("Error:  " + e); }  
        }

        public string addToListView(string name)
        {
            string filenameWithoutPath = Path.GetFileName(name);
            ListView ListView1 = new ListView();
            MessageBox.Show("AddToList");
            // label1.Text = name; //ASSÅ VARFÖR FUNKAR DET INTE Vrfr?

            //item = new ListViewItem(file.Name, 1);
           // MessageBox.Show(name);
     
           // List<string> list = new List<string>();
            // list.Insert(x, 5);
           // list.Add(name);
            listView1.Items.Add(filenameWithoutPath);

            return null;
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
