﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//cpu
            cpbCPU.Value = (int)pfcCPU.NextValue();
            lblCPU.Text = "CPU: " + " " + cpbCPU.Value.ToString() + " " + "%";

         //RAM
            cpbRAM.Value = (int)pfcRAM.NextValue();
            lblRAM.Text = "RAM USED: " + " " + cpbRAM.Value.ToString() + " " + "MB";
        
            
         //HD
            cpbHD.Value = (int)pfcHD.NextValue();
            lblHD.Text = "HD USED: " + " " + cpbHD.Value.ToString() + " " + "GB";
        }
    }
}
