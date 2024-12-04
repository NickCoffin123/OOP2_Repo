using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13DemoA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSub frm = new frmSub();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmSub)
                {
                    f.Show();
                    f.WindowState = FormWindowState.Normal; 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<frmSub> list = new List<frmSub>();
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmSub)
                {
                    list.Add((frmSub)f);
                }
            }

            foreach (frmSub f in list)
            {
                f.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<frmSub> list = new List<frmSub>();
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmSub)
                {
                    list.Add((frmSub)f);
                }
            }

            foreach (frmSub f in list)
            {
                f.UpdateLabel();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSubTwo.Instance.Show();
        }
    }       
}