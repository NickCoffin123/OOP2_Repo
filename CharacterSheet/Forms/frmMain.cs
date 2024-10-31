/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Main form for project.
 */
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

namespace CharacterSheet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
        #endregion

        #region Control Event Handlers

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCharacterEdit frm = new frmCharacterEdit();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedIndex > -1)
            {
                frmCharacterEdit frm = new frmCharacterEdit();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }


        #endregion

        #region Custom UI Functions and Methods


        #endregion


    }
}
