﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsChangeSample
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = true;
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            Form1.ctr1.Visible = false;
            //Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = true;
        }
    }
}
