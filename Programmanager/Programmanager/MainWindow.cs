﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmanager
{
    public partial class MainWindow : Form
    {
        private GetProgram gp = new GetProgram();
      
        public MainWindow()
        {
            InitializeComponent();
           
        }
        
        public void ChangeText(string labelName)
        {
            label1.Text = labelName;
            Console.WriteLine(labelName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Test1");
            //label1.Text = "FFF";
            gp.eventHandler(1);
        }
    }
}