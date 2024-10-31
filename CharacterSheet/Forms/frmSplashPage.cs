/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Splash page form for project.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class frmSplashPage : Form
    {
        public frmSplashPage()
        {
            InitializeComponent();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();  
            frm.ShowDialog();  
            this.Show();   
        }
    }
}
