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

namespace Week03DemoA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();

        }

        private void SetDefaults()
        {
            SetGTNDefaults();
        }

        private void SetGTNDefaults()
        {
            cboGTNDificulty.SelectedIndex = 0;
            SetGTNRandomNumber();
            nudGTNGuessCount.Value = 0;
            lblGTNGuessHistory.Text = String.Empty;
            btnGTNPlayAgain.Visible = false;
        }

        private void SetGTNRandomNumber()
        {
            nudGTNActualNumber.Value = Tools.RandomInt(1, (int)nudGTNGuess.Maximum);
            nudGTNGuessCount.Value = 0;
        }

        private void btnGTN_Click(object sender, EventArgs e)
        {
            panGTN.Visible = !panGTN.Visible;
        }

        private void cboGTNDificulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGTNDifficulty();
        }

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
                    lblMaximumGuessNumber.Text= 10.ToString();
                    break;
            }

            SetGTNRandomNumber();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

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
                btnGTNPlayAgain.Visible = true;
            }
        }

        private void btnGTNPlayAgain_Click(object sender, EventArgs e)
        {
            SetGTNDefaults();
        }
    }
}
