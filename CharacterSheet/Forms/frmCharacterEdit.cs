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
    /// <summary>
    /// Main method.
    /// </summary>
    public partial class frmCharacterEdit : Form
    {
        #region Global Variables

        private int remainingPoints = 27;
        private Character characterToEdit;

        #endregion

        #region Constructors
        /// <summary>
        /// Main constructor.
        /// </summary>
        public frmCharacterEdit()
        {
            InitializeComponent();
            LoadfrmCharacterEdit();

        }

        /// <summary>
        /// Edit character constructor.
        /// </summary>
        /// <param name="character">sends in character from main form.</param>
        public frmCharacterEdit(Character character)
        {
            InitializeComponent();
            characterToEdit = character;
            LoadfrmCharacterEdit();

            if (characterToEdit != null)
            {
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

                txtName.Enabled = false;
                cbxClass.Enabled = false;
                cbxRace.Enabled = false;
            }
        }
        #endregion

        #region Control Event Handlers

        /// <summary>
        /// Load form event.
        /// </summary>
        private void LoadfrmCharacterEdit()
        {
            PopulateClassComboBox();
            PopulateRaceComboBox();
            PopulateAlignmentComboBox();
            SetInitialValues();
            NumericUpDownEvents();
            //UpdateRemainingPoints();
        }

        /// <summary>
        /// Close form method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Accept form creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbxClass.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbxRace.SelectedItem == null)
            {
                MessageBox.Show("Please select a race.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtName.Text;
            string gender = cboGender.SelectedItem?.ToString();

            Class selectedClass = Class.GetClasses().FirstOrDefault(c => c.Name == cbxClass.SelectedItem?.ToString());
            Race selectedRace = Race.GetRaces().FirstOrDefault(r => r.Name == cbxRace.SelectedItem?.ToString());
            Constants.Alignment alignment = (Constants.Alignment)Enum.Parse(typeof(Constants.Alignment), cbxAlignment.SelectedItem?.ToString());

            int strength = (int)nudStrength.Value;
            int dexterity = (int)nudDexterity.Value;
            int constitution = (int)nudConstitution.Value;
            int intelligence = (int)nudIntelligence.Value;
            int wisdom = (int)nudWisdom.Value;
            int charisma = (int)nudCharisma.Value;

            if (characterToEdit != null)
            {
                characterToEdit.Name = name;
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
                    hitPoints: selectedClass?.BaseHitPoints ?? 0
                );
                Character.characters.Add(newCharacter);
            }

            this.Close();
        }



        /// <summary>
        /// Event for changing the nud values
        /// </summary>
        private void NumericUpDownEvents()
        {
            nudStrength.ValueChanged += Attribute_ValueChanged;
            nudDexterity.ValueChanged += Attribute_ValueChanged;
            nudConstitution.ValueChanged += Attribute_ValueChanged;
            nudIntelligence.ValueChanged += Attribute_ValueChanged;
            nudWisdom.ValueChanged += Attribute_ValueChanged;
            nudCharisma.ValueChanged += Attribute_ValueChanged;
        }

        #endregion

        #region Custom UI Functions and Methods

        /// <summary>
        /// Sets initial default values for numeric controls to start at 8.
        /// </summary>
        private void SetInitialValues()
        {
            nudStrength.Value = 8;
            nudDexterity.Value = 8;
            nudConstitution.Value = 8;
            nudIntelligence.Value = 8;
            nudWisdom.Value = 8;
            nudCharisma.Value = 8;
        }

        /// <summary>
        /// Method for taking in the nud changed and updating the remaining points.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attribute_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingPoints();
        }

        /// <summary>
        /// Method to take the decrease the total point cost based on the values changed.
        /// </summary>
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

        /// <summary>
        /// A method to see how many points to take away from the total.
        /// </summary>
        /// <param name="attributeValue">Uses the value of the attribute changed</param>
        /// <returns></returns>
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

        /// <summary>
        /// A method to lock the points after they hit 20.
        /// </summary>
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

        /// <summary>
        /// A method to populate the classes.
        /// </summary>
        private void PopulateClassComboBox()
        {
            cbxClass.Items.Clear();
            foreach (Class cls in Class.GetClasses())
            {
                cbxClass.Items.Add(cls.Name);
            }
        }

        /// <summary>
        /// A method to populate the races.
        /// </summary>
        private void PopulateRaceComboBox()
        {
            cbxRace.Items.Clear();
            foreach (Race rc in Race.GetRaces())
            {
                cbxRace.Items.Add(rc.Name);
            }
        }

        /// <summary>
        /// A method to update the alignments.
        /// </summary>
        private void PopulateAlignmentComboBox()
        {
            cbxAlignment.Items.Clear();
            foreach (Constants.Alignment alignment in Enum.GetValues(typeof(Constants.Alignment)))
            {
                cbxAlignment.Items.Add(alignment.ToString());
            }
        }

        /// <summary>
        /// A method to display the class description and the health based on class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// A method to display the race description.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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