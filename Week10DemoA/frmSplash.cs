using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10DemoA
{
    public partial class frmSplash : Form
    {
        private FormStudents frms;
        public frmSplash(FormStudents frm)
        {
            InitializeComponent();
            frms = frm;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frms.Show();
            this.Close();
        }
    }
}
