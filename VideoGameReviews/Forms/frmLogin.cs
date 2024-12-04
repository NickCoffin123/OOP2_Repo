using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameReviews.Forms
{
    public partial class frmLogin : Form
    {

        #region Global Variables
        #endregion

        #region Constructors
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Event Handelers
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }
        #endregion

        #region Custom UI Functions and Methods
        #endregion
        

        

        
    }
}
