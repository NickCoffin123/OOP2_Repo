﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12DemoB
{
    public partial class frmSub : Form
    {
        public frmSub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBrother frm = new frmBrother();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.myString = textBox1.Text;
        }
    }
}
