/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Edit character form for project.
 */
using CharacterSheet.Classes;
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
    public partial class frmCharacterEdit : Form
    {
        public frmCharacterEdit()
        {
            InitializeComponent();
            LoadfrmCharacterEdit();
        }

        #region Global Variables
        #endregion

        #region Control Event Handlers

        private void LoadfrmCharacterEdit()
        {
            Class.InitializeDefaultClasses();
            Race.InitializeDefaultRaces();
            PopulateClassComboBox();
            PopulateRaceComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Custom UI Functions and Methods

        private void PopulateClassComboBox()
        {
            cbxClass.Items.Clear();
            foreach (Class cls in Class.GetClasses())
            {
                cbxClass.Items.Add(cls.Name);
            }
        }

        private void PopulateRaceComboBox()
        {
            cbxRace.Items.Clear();
            foreach (Race rc in Race.GetRaces())
            {
                cbxRace.Items.Add(rc.Name);
            }
        }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClass.SelectedItem != null)
            {
                string selectedClassName = cbxClass.SelectedItem.ToString();
                Class selectedClass = Class.GetClasses().FirstOrDefault(cls => cls.Name == selectedClassName);

                if (selectedClass != null)
                {
                    rtbClassDescription.Text = selectedClass.Description;
                    txtHealth.Text = selectedClass.BaseHitPoints.ToString();
                }
            }
        }


        private void cbxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRace.SelectedItem != null)
            {
                string selectedRaceName = cbxRace.SelectedItem.ToString();
                Race selectedRace = Race.GetRaces().FirstOrDefault(rc => rc.Name == selectedRaceName);

                if (selectedRace != null)
                {
                    rtbRaceDescription.Text = selectedRace.Description;
                }
            }
        }




        #endregion


    }
}


