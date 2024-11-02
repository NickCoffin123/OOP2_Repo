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
    /// <summary>
    /// Main method.
    /// </summary>
    public partial class frmSplashPage : Form
    {
        /// <summary>
        /// Main constructor.
        /// </summary>
        public frmSplashPage()
        {
            InitializeComponent();
        }

        #region Control Event Handlers

        /// <summary>
        /// Method to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method to progress to the next page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();  
            frm.ShowDialog();  
            this.Show();   
        }

        #endregion
    }
}
