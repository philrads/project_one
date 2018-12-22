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
   public class Control
    {
        private Form1 v;
        private Model m;

        public Control()
        {
           // v = new Form1(); // Funkar inte för någon anledning, hur kopplar man tillbaka till View dÅ?
            m = new Model();
        }
       

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
            
        }
    }
}
