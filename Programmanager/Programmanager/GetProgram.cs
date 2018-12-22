using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmanager
{
    public class GetProgram
    {
        private MainWindow mw;
        public GetProgram()
        {
            
        }
       
       
        public void eventHandler(int action)
        {
           mw = new MainWindow(); //Inte bra...
            
            if(action == 1)
            {
                //MessageBox.Show("Test2");
                String fuck = "test2";
               
                mw.ChangeText(fuck);
                
            }
        }
    }
}
