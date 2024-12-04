using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13DemoA
{
    public partial class frmSubTwo : Form
    {
        private static frmSubTwo instance;

        public static frmSubTwo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmSubTwo();
                }
                return instance;
            }
        }

        private frmSubTwo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmSubTwo_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
