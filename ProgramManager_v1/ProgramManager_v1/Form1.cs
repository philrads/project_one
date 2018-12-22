using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Add program
            //Bind button to program 1
            MessageBox.Show("AddBtn");
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            //Run program
            //Bind button to program 2
            MessageBox.Show("RunBtn");
        }
    }
}
