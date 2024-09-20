/* Nick Coffin - 100555045
 * ICE - 1
 * Main file for project
 * September 19, 2024
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

namespace ClassExercise1
{
    public partial class frmMain : Form
    {
        #region Startup

        /// <summary>
        /// Method to initialize the component.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to load the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();

        }

        /// <summary>
        /// Method to set the defaults.
        /// </summary>
        private void SetDefaults()
        {
            SetGTNDefaults();
        }

        #endregion

        #region General Events

        /// <summary>
        /// Method to ensure the user wants to exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        #endregion

        #region Random Number Guesser

        /// <summary>
        /// Method to set all the defaults for the random number guesser.
        /// </summary>
        private void SetGTNDefaults()
        {
            SetGTNRandomNumber();

            cboGTNDificulty.SelectedIndex = Settings.DEF_DIFFICULTY;
            nudGTNGuessCount.Value = Settings.DEF_GUESSCOUNT;
            nudGTNGuess.Value = Settings.DEF_GUESSVALUE;
            lblGTNGuessHistory.Text = String.Empty;
            btnGTNGuess.Enabled = true;
            btnGTNPlayAgain.Visible = false;
        }

        /// <summary>
        /// Method to set the random number.
        /// </summary>
        private void SetGTNRandomNumber()
        {
            nudGTNActualNumber.Value = Tools.RandomInt(1, (int)nudGTNGuess.Maximum);
            nudGTNGuessCount.Value = 0;
        }

        /// <summary>
        /// Method to set the visiblity of the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGTN_Click(object sender, EventArgs e)
        {
            panGTN.Visible = !panGTN.Visible;
            panIceCream.Visible = !panGTN.Visible; // Ensure opposite visibility
        }

        /// <summary>
        /// Method to change the difficulty index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGTNDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGTNDifficulty();
        }

        /// <summary>
        /// Method to set the number for the guesser and the label depending on difficulty.
        /// </summary>
        private void SetGTNDifficulty()
        {
            switch (cboGTNDificulty.SelectedIndex)
            {
                case 1:
                    nudGTNGuess.Maximum = 100;
                    lblMaximumGuessNumber.Text = 100.ToString();
                    break;
                case 2:
                    nudGTNGuess.Maximum = 1000;
                    lblMaximumGuessNumber.Text = 1000.ToString();
                    break;
                default:
                    nudGTNGuess.Maximum = 10;
                    lblMaximumGuessNumber.Text = 10.ToString();
                    break;
            }

            SetGTNRandomNumber();

        }

        /// <summary>
        /// Method to validate the guess and compare it with the actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGTNGuess_Click(object sender, EventArgs e)
        {
            nudGTNGuessCount.Value += 1;

            // Compare the guess to the random number.
            if (nudGTNGuess.Value > nudGTNActualNumber.Value)
            {
                lblGTNGuessHistory.Text += "Guess " + nudGTNGuess.Value + " is too high\n";
            }
            else if (nudGTNGuess.Value < nudGTNActualNumber.Value)
            {
                lblGTNGuessHistory.Text += "Guess " + nudGTNGuess.Value + " is too low\n";
            }
            else
            {
                lblGTNGuessHistory.Text += "You got the number correct!! It took you " + nudGTNGuessCount.Value + " guesses.";
                btnGTNGuess.Enabled = false;
                btnGTNPlayAgain.Visible = true;
            }
        }

        /// <summary>
        /// Method to reset the game with the play again button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGTNPlayAgain_Click(object sender, EventArgs e)
        {
            SetGTNDefaults();
        }

        #endregion

        #region Ice Cream

        /// <summary>
        /// Selects the ice cream management system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIceCream_Click(object sender, EventArgs e)
        {
            panIceCream.Visible = !panIceCream.Visible;
            panGTN.Visible = !panIceCream.Visible; // Ensure opposite visibility
        }

        /// <summary>
        /// Adds the ice cream to the list but its not working right because it isn't adding
        /// the total it just adds the new selected price.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String IceCreamChoice = lbxIceCreamSelection.Text;
            lbxIceCreamOrder.Items.Add(IceCreamChoice);

            //Partially obtained from co-piolot reworking what I made initially.


            if (string.IsNullOrEmpty(lblTotalPrice.Text))
            {
                lblTotalPrice.Text = "0.00";
            }

            if (decimal.TryParse(lblTotalPrice.Text, out decimal currentTotal))
            {
                decimal itemPrice = 0m;

                switch (lbxIceCreamSelection.SelectedIndex)
                {
                    case 0:
                        itemPrice = 1m;
                        break;
                    case 1:
                        itemPrice = 2m;
                        break;
                    case 2:
                        itemPrice = 3m;
                        break;
                    case 3:
                        itemPrice = 2.50m;
                        break;
                    case 4:
                        itemPrice = 1.25m;
                        break;
                    case 5:
                        itemPrice = 1.50m;
                        break;
                    default:
                        break;
                }

                currentTotal += itemPrice;
                lblTotalPrice.Text = currentTotal.ToString("0.00");

            }
        }

        /// <summary>
        /// Remove the selected ice cream from the list and decrese the total.
        /// Using what I learned from co-piolot I made this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxIceCreamOrder.SelectedItem != null)
            {
                String IceCreamChoice = lbxIceCreamOrder.SelectedItem.ToString();
                lbxIceCreamOrder.Items.Remove(lbxIceCreamOrder.SelectedItem);

                if (decimal.TryParse(lblTotalPrice.Text, out decimal currentTotal))
                {
                    decimal itemPrice = 0m;

                    switch (IceCreamChoice)
                    {
                        case "Small - $1":
                            itemPrice = 1m;
                            break;
                        case "Medium - $2":
                            itemPrice = 2m;
                            break;
                        case "Lagre - $3":
                            itemPrice = 3m;
                            break;
                        case "Slushie - 2.50":
                            itemPrice = 2.50m;
                            break;
                        case "Popcicle - 1.25":
                            itemPrice = 1.25m;
                            break;
                        case "Fudgecicle - 1.50":
                            itemPrice = 1.50m;
                            break;
                        default:
                            break;
                    }

                    currentTotal -= itemPrice;
                    lblTotalPrice.Text = currentTotal.ToString("0.00");

                }
            }
        }

        #endregion

    }



}
