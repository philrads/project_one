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
        private Control c;

        public Model()
        {

        }

        public string openExeFile()
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

                return filenameWithoutPath;
                //this.Text = openF.FileName; //bar name
                //Process.Start(path);//Starting the software
            }
            return null;
        }
    }
}
