/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Main form for project.
 */
using CharacterSheet.Classes;
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
            LoadfrmMain();
            this.Activated += frmMain_Activated;
        }

        #region GLOBAL VARIABLES



        #endregion

        #region Control Event Handlers

        private void LoadfrmMain()
        {
            Class.InitializeDefaultClasses();
            Race.InitializeDefaultRaces();
            Character.DefaultCharacter();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            PopulateListBoxCharacters();
        }

        private void PopulateListBoxCharacters()
        {
            lbxCharacters.Items.Clear();
            foreach (Character chr in Character.GetCharacters())
            {
                lbxCharacters.Items.Add(chr.Name);
            }
        }

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

            //private void btnEditDroid_Click(object sender, EventArgs e)
            //{
            //    if (lboxDroids.SelectedIndex > -1)
            //    {
            //        frmDroidEditor frm = new frmDroidEditor(lboxDroids.SelectedItem.ToString());
            //        frm.ShowDialog();
            //        PopulateDroidList();
            //        PopulateDroidDetails(null);
            //    }
        
        }



        private void btnExitCharacter_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #endregion

        #region Custom UI Functions and Methods


        #endregion

    }
}
