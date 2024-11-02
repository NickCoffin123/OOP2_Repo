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

        private int remainingPoints = 27;

        #endregion

        #region Control Event Handlers

        private void LoadfrmCharacterEdit()
        {
            PopulateClassComboBox();
            PopulateRaceComboBox();
            PopulateAlignmentComboBox();
            NumericUpDownEvents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumericUpDownEvents()
        {
            nudStrength.ValueChanged += Attribute_ValueChanged;
            nudDexterity.ValueChanged += Attribute_ValueChanged;
            nudConstitution.ValueChanged += Attribute_ValueChanged;
            nudIntelligence.ValueChanged += Attribute_ValueChanged;
            nudWisdom.ValueChanged += Attribute_ValueChanged;
            nudCharisma.ValueChanged += Attribute_ValueChanged;
        }

        private void Attribute_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingPoints();
        }

        private void UpdateRemainingPoints()
        {
            int totalCost = 0;

            totalCost += CalculatePointCost((int)nudStrength.Value);
            totalCost += CalculatePointCost((int)nudDexterity.Value);
            totalCost += CalculatePointCost((int)nudConstitution.Value);
            totalCost += CalculatePointCost((int)nudIntelligence.Value);
            totalCost += CalculatePointCost((int)nudWisdom.Value);
            totalCost += CalculatePointCost((int)nudCharisma.Value);

            remainingPoints = 27 - totalCost;
            txtExperience.Text = remainingPoints.ToString();

            ToggleAttributeControls();
        }

        private int CalculatePointCost(int attributeValue)
        {
            if (attributeValue >= 8 && attributeValue <= 13)
                return 1;
            if (attributeValue >= 14 && attributeValue <= 18)
                return 2;
            if (attributeValue >= 19 && attributeValue <= 20)
                return 3;
            
            return 0;
        }

        private void ToggleAttributeControls()
        {
            bool enable = remainingPoints > 0;

            nudStrength.Enabled = enable || nudStrength.Value < 20;
            nudDexterity.Enabled = enable || nudDexterity.Value < 20;
            nudConstitution.Enabled = enable || nudConstitution.Value < 20;
            nudIntelligence.Enabled = enable || nudIntelligence.Value < 20;
            nudWisdom.Enabled = enable || nudWisdom.Value < 20;
            nudCharisma.Enabled = enable || nudCharisma.Value < 20;
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

        private void PopulateAlignmentComboBox()
        {
            cbxAlignment.Items.Clear();
            foreach (Constants.Alignment alignment in Enum.GetValues(typeof(Constants.Alignment)))
            {
                cbxAlignment.Items.Add(alignment.ToString());
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


