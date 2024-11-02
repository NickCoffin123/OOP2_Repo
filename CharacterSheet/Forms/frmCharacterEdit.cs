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
        #region Global Variables
        private int remainingPoints = 27;
        private Character characterToEdit;
        #endregion

        #region Constructors
        // Default constructor for creating a new character
        public frmCharacterEdit()
        {
            InitializeComponent();
            LoadfrmCharacterEdit();
        }

        // Overloaded constructor for editing an existing character
        public frmCharacterEdit(Character character)
        {
            InitializeComponent();
            characterToEdit = character;
            LoadfrmCharacterEdit();

            if (characterToEdit != null)
            {
                // Populate fields with existing character data
                txtName.Text = characterToEdit.Name;
                cboGender.SelectedItem = characterToEdit.Gender;
                cbxClass.SelectedItem = characterToEdit.CharacterClass.Name;
                cbxRace.SelectedItem = characterToEdit.CharacterRace.Name;
                cbxAlignment.SelectedItem = characterToEdit.CharacterAlignment.ToString();
                nudStrength.Value = characterToEdit.Strength;
                nudDexterity.Value = characterToEdit.Dexterity;
                nudConstitution.Value = characterToEdit.Constitution;
                nudIntelligence.Value = characterToEdit.Intelligence;
                nudWisdom.Value = characterToEdit.Wisdom;
                nudCharisma.Value = characterToEdit.Charisma;
                txtHealth.Text = characterToEdit.HitPoints.ToString();

                // Disable fields that shouldn’t be editable
                txtName.Enabled = false;
                cbxClass.Enabled = false;
                cbxRace.Enabled = false;
            }
        }
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = cboGender.SelectedItem?.ToString();

            Class selectedClass = Class.GetClasses().FirstOrDefault(c => c.Name == cbxClass.SelectedItem.ToString());
            Race selectedRace = Race.GetRaces().FirstOrDefault(r => r.Name == cbxRace.SelectedItem.ToString());
            Constants.Alignment alignment = (Constants.Alignment)Enum.Parse(typeof(Constants.Alignment), cbxAlignment.SelectedItem.ToString());

            int strength = (int)nudStrength.Value;
            int dexterity = (int)nudDexterity.Value;
            int constitution = (int)nudConstitution.Value;
            int intelligence = (int)nudIntelligence.Value;
            int wisdom = (int)nudWisdom.Value;
            int charisma = (int)nudCharisma.Value;

            if (characterToEdit != null)
            {
                // Update existing character
                characterToEdit.Gender = gender;
                characterToEdit.CharacterAlignment = alignment;
                characterToEdit.Strength = strength;
                characterToEdit.Dexterity = dexterity;
                characterToEdit.Constitution = constitution;
                characterToEdit.Intelligence = intelligence;
                characterToEdit.Wisdom = wisdom;
                characterToEdit.Charisma = charisma;
            }
            else
            {
                // Create a new character and add to the list
                Character newCharacter = new Character(
                    name,
                    selectedClass,
                    selectedRace,
                    alignment,
                    gender,
                    level: 1,
                    strength,
                    dexterity,
                    constitution,
                    intelligence,
                    wisdom,
                    charisma,
                    armourClass: 10,
                    hitPoints: selectedClass.BaseHitPoints
                );
                Character.characters.Add(newCharacter);
            }

            this.Close();
        }

        private void Attribute_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingPoints();
        }
        #endregion

        #region Custom UI Functions and Methods

        private void NumericUpDownEvents()
        {
            nudStrength.ValueChanged += Attribute_ValueChanged;
            nudDexterity.ValueChanged += Attribute_ValueChanged;
            nudConstitution.ValueChanged += Attribute_ValueChanged;
            nudIntelligence.ValueChanged += Attribute_ValueChanged;
            nudWisdom.ValueChanged += Attribute_ValueChanged;
            nudCharisma.ValueChanged += Attribute_ValueChanged;
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