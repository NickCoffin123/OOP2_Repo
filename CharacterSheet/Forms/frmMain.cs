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
    /// <summary>
    /// Main method.
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Main constructor.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            LoadfrmMain();
            this.Activated += frmMain_Activated;
        }

        #region GLOBAL VARIABLES



        #endregion

        #region Control Event Handlers

        /// <summary>
        /// Load event for form.
        /// </summary>
        private void LoadfrmMain()
        {
            lbxCharacters.DisplayMember = "Name";
            Class.InitializeDefaultClasses();
            Race.InitializeDefaultRaces();
            Character.DefaultCharacter();
        }

        /// <summary>
        /// Method to update the list box after the page is being re opened.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Activated(object sender, EventArgs e)
        {
            PopulateListBoxCharacters();
        }

        /// <summary>
        /// A method to create a character.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCharacterEdit frm = new frmCharacterEdit();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// A method to update a selected character.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedItem is Character selectedCharacter)
            {
                frmCharacterEdit editForm = new frmCharacterEdit(selectedCharacter);
                editForm.ShowDialog();
                PopulateListBoxCharacters();
            }
        }

        /// <summary>
        /// A method to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitCharacter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Custom UI Functions and Methods

        /// <summary>
        /// A method to populate the character list box.
        /// </summary>
        private void PopulateListBoxCharacters()
        {
            lbxCharacters.Items.Clear();
            foreach (Character chr in Character.GetCharacters())
            {
                lbxCharacters.Items.Add(chr);
            }
        }


        #endregion

    }
}
