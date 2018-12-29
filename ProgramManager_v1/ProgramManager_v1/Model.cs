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
   public class Model
    {
       
        private readonly Form1 f1;

        public Model(Form1 f1)
        {
            this.f1 = f1;
        }

        public string OpenListFile()
        {
            string path = "";
            OpenFileDialog openF = new OpenFileDialog();
            openF.Filter = "Text files (.txt)|*.txt";
            openF.Title = "Open File...";
            if (openF.ShowDialog() == DialogResult.OK)
            {
                path = openF.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                sr.Close();
                return path;
            }


                return null;
        }
        public string OpenExeFile()
        {
            string path = "";
            OpenFileDialog openF = new OpenFileDialog();
            openF.Filter = "Executable Flies (.exe)|*.exe";
            openF.Title = "Open File...";
            if (openF.ShowDialog() == DialogResult.OK)
            {
                path = openF.FileName;
             //   string filenameWithoutPath = Path.GetFileName(path);
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
              //  MessageBox.Show(filenameWithoutPath);
                sr.Close();

                return path;
                //this.Text = openF.FileName; //bar name
                //Process.Start(path);//Starting the software
            }
            return null;
        }

        public string AddToList(string name)
        {
            /*Save list into a file, and then load the file to ListView*/

            //MessageBox.Show("AddToList");
            // label1.Text = name; //ASSÅ VARFÖR FUNKAR DET INTE Vrfr?
           // MessageBox.Show(name);
            //int x = 0;
            List<string> list2 = new List<string>();
            list2.Add(name);





            //
           //GAMMELT DRET BTW
           //

            //    //  ||||
             // //    ||  ||
              //      ||  ||
            //  //    ||  ||
          //     //   ||||


            return null;
        }


        public ListViewItem MainListLoad()
        {

            //Se rad 20
            //I Form1 finns en Get metod på rad 38
            //Som returnerar ListView som modellen kan använda
            //Funkar på samma sätt för allt annat liknande
            //Om modellen behöver komma åt Form1 Gui saker
            //Bara gör en Get metod som returnerar det ez
           
            ListView lw = f1.GetListView;
            lw.Items.Clear();
            StreamReader fileRead = new StreamReader("cfg\\list.txt");
            string line = "";
            while ((line = fileRead.ReadLine()) != null)
            {
                var itemMC = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString() });
                lw.Items.Add(itemMC);

            }

            fileRead.Close();

            return null;
        }


    }
}
