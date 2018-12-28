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
            listView1.View = View.Details;
            Directory.CreateDirectory("cfg");
            
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
            pathP1 = (m.OpenExeFile());
            // MessageBox.Show(pathP1);
            //  string filenameWithoutPath = Path.GetFileName(path);
            if(pathP1 == null){

            }
            else
            {
                label1.Text = Path.GetFileName(pathP1 + " added!");
                AddPic(pathP1);
                AddToListView(pathP1);
            }
                
           
           
            
        }

     
        private void SelRunBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string text = listView1.SelectedItems[0].SubItems[1].Text;
                MessageBox.Show(text);
                Process.Start(text);
            }
            catch (Exception)
            {
                
            }
           
        }

        private void SaveListBtn_Click(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("cfg\\list.txt"))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    tw.WriteLine(item.SubItems[0].Text+";"+item.SubItems[1].Text);
                }
                tw.Close();
            }
        }

        private void LoadListBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader fileRead = new StreamReader("cfg\\list.txt");
            string line = "";
            while ((line = fileRead.ReadLine()) != null)
            {
                var itemMC = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString() });
                listView1.Items.Add(itemMC);

            }

            fileRead.Close();
        }

        private void DelSelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem eachItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(eachItem);
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView1.Items)
            {
                items.Remove();   
            }
        }

        private void RunAllBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView1.Items)
            {
                Process.Start(items.SubItems[1].Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try { 
            listView1.Items.Clear();
            StreamReader fileRead = new StreamReader("cfg\\list.txt");
            string line = "";
            while ((line = fileRead.ReadLine()) != null)
            {
                var itemMC = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString() });
                listView1.Items.Add(itemMC);

            }

            fileRead.Close();
            }
            catch (Exception o) { MessageBox.Show("Error:  " + o); }
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
            }catch(Exception o){
               MessageBox.Show("Error:  " + o);
            }  
        }

        public string AddToListView(string name)
        {
            try
            {
            string filenameWithoutPath = Path.GetFileName(name);
           
            ListView ListView1 = new ListView();
           // MessageBox.Show("AddToList");

            FileInfo fi = new FileInfo(filenameWithoutPath);
            string fis = fi.Name;
            // label1.Text = name; //ASSÅ VARFÖR FUNKAR DET INTE Vrfr?

            //item = new ListViewItem(file.Name, 1);
            // MessageBox.Show(name);

            // List<string> list = new List<string>();
            // list.Insert(x, 5);
            // list.Add(name);
            string[] row = { filenameWithoutPath, name };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
                }
                catch(Exception e){
                //MessageBox.Show("Error: " + e);
            }
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
