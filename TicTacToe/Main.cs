/* 
 * Nick Coffin - 100555045.
 * OOP - Assignment 1 Tic Tac Toe.
 * Sept 29, 2024.
 * Main file for project.
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

namespace TicTacToe
{
    /// <summary>
    /// Constructor method for the form.
    /// </summary>
    public partial class Main : Form
    {
        
        /// <summary>
        /// Main method.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            DefaultColours();
            CreateClickEvents();
  
        }

        #region Colour defaults

        /// <summary>
        /// A method to set the colour defaults.
        /// </summary>
        public void DefaultColours()
        {
            // Form colour.
            this.BackColor = ColorTranslator.FromHtml("#780000");
            
            // Title colours.
            lblTitle.BackColor = ColorTranslator.FromHtml("#FDF0D5");
            lblTitle.ForeColor = ColorTranslator.FromHtml("#003049");

            // Label colours.
            lblPlayerX.ForeColor = ColorTranslator.FromHtml("#FDF0D5");
            lblPlayer0.ForeColor = ColorTranslator.FromHtml("#FDF0D5");
            lblWins.ForeColor = ColorTranslator.FromHtml("#FDF0D5");
            lblXWins.ForeColor = ColorTranslator.FromHtml("#FDF0D5");
            lbl0Wins.ForeColor = ColorTranslator.FromHtml("#FDF0D5");
            lblDraws.ForeColor = ColorTranslator.FromHtml("#FDF0D5");

            // Button colours. 
            btnExit.BackColor = ColorTranslator.FromHtml("#FDF0D5");
            btnPlayAgain.BackColor = ColorTranslator.FromHtml("#FDF0D5");
            btnStart.BackColor = ColorTranslator.FromHtml("#FDF0D5");
            btnReset.BackColor = ColorTranslator.FromHtml("#FDF0D5");

            // Tic Tac Toe background label colours.
            Color backcolor = ColorTranslator.FromHtml("#FDF0D5");
            Label[] backlabels = { lblTitle, lblTicTacOne, lblTicTacTwo, lblTicTacThree, lblTicTacFour, 
                lblTicTacFive, lblTicTacSix, lblTicTacSeven, lblTicTacEight, lblTicTacNine };

            foreach (Label lbl in backlabels)
            {
                lbl.BackColor = backcolor;
            }

            //Couldn't get text colour to work.
            // Tic Tac Toe foreground label colours.
        //    Color color = ColorTranslator.FromHtml("#669BBC");
        //    Label[] labels = {lblTicTacOne, lblTicTacTwo, lblTicTacThree, lblTicTacFour,
        //        lblTicTacFive, lblTicTacSix, lblTicTacSeven, lblTicTacEight, lblTicTacNine };

        //    foreach (Label lbl in labels)
        //    {
        //        lbl.ForeColor = color;
        //    }

        }

        #endregion

        #region General Events

        /// <summary>
        /// A variable to determine who goes first.
        /// </summary>
        public int whoGoesFirst = Tools.RandomInt(1, 2);

        /// <summary>
        /// A method to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// A Method to create click events for the labels.
        /// My way was stupid so chatGPT fixed this.
        /// </summary>
        private void CreateClickEvents()
        {
            Label[] labels = { lblTicTacOne, lblTicTacTwo, lblTicTacThree, lblTicTacFour,
        lblTicTacFive, lblTicTacSix, lblTicTacSeven, lblTicTacEight, lblTicTacNine };

            foreach (Label lbl in labels)
            {
                lbl.Click -= ClickEvent;
                lbl.Click += ClickEvent; 
            }
        }


        #endregion

        #region Tic Tac Toe Gameplay

        /// <summary>
        /// A method to decide who goes first.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTicTacOne.Enabled = true;
            lblTicTacTwo.Enabled = true;
            lblTicTacThree.Enabled = true;
            lblTicTacFour.Enabled = true;
            lblTicTacFive.Enabled = true;
            lblTicTacSix.Enabled = true;
            lblTicTacSeven.Enabled = true;
            lblTicTacEight.Enabled = true;
            lblTicTacNine.Enabled = true;

            if (whoGoesFirst == 1)
            {
                MessageBox.Show(txtPlayerX.Text + " (X) goes first");
                nudTurnDecider.Value = 1;
            }
            else
            {
                MessageBox.Show(txtPlayer0.Text + " (O) goes first");
                nudTurnDecider.Value = 2;
            }
        }

        /// <summary>
        /// A method to set the label to an X or O depending on the player who selected.
        /// </summary>
        /// <param name="lbl">the label being clicked</param>
        private void CheckPlayer(Label lbl)
        {
            {
                if (nudTurnDecider.Value % 2 == 0)
                {
                    lbl.Text = "0";
                }
                else
                {
                    lbl.Text = "X";
                }

                nudTurnDecider.Value++;
            }

        }

        /// <summary>
        /// The click event for the actual click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickEvent(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            CheckPlayer(lbl);
            // Couldn't get text colour to work.
            lbl.ForeColor = ColorTranslator.FromHtml("#669BBC");
            lbl.Enabled = false;
            CheckWinner();
        }

        /// <summary>
        /// A method to update the score for the winner.
        /// </summary>
        /// <param name="winner">Name of the winner.</param>
        private void UpdateScore(string winner)
        {
            MessageBox.Show(winner + " is the winner");
            if (winner == "X")
            {
                txtXWins.Text = (int.Parse(txtXWins.Text) + 1).ToString();
            }
            else if (winner == "O")
            {
                txt0Wins.Text = (int.Parse(txt0Wins.Text) + 1).ToString();
            }
        }

        /// <summary>
        /// A method to check for the winner.
        /// </summary>
        private void CheckWinner()
        {
            string winner = "";
            Label[] winningLabels = null;

            // Check rows.
            if (lblTicTacOne.Text == lblTicTacTwo.Text && lblTicTacTwo.Text == lblTicTacThree.Text && lblTicTacOne.Text != "")
            {
                winner = lblTicTacOne.Text;
                winningLabels = new Label[] { lblTicTacOne, lblTicTacTwo, lblTicTacThree };
            }
            else if (lblTicTacFour.Text == lblTicTacFive.Text && lblTicTacFive.Text == lblTicTacSix.Text && lblTicTacFour.Text != "")
            {
                winner = lblTicTacFour.Text;
                winningLabels = new Label[] { lblTicTacFour, lblTicTacFive, lblTicTacSix };
            }
            else if (lblTicTacSeven.Text == lblTicTacEight.Text && lblTicTacEight.Text == lblTicTacNine.Text && lblTicTacSeven.Text != "")
            {
                winner = lblTicTacSeven.Text;
                winningLabels = new Label[] { lblTicTacSeven, lblTicTacEight, lblTicTacNine };
            }
            // Check columns.
            else if (lblTicTacOne.Text == lblTicTacFour.Text && lblTicTacFour.Text == lblTicTacSeven.Text && lblTicTacOne.Text != "")
            {
                winner = lblTicTacOne.Text;
                winningLabels = new Label[] { lblTicTacOne, lblTicTacFour, lblTicTacSeven };
            }
            else if (lblTicTacTwo.Text == lblTicTacFive.Text && lblTicTacFive.Text == lblTicTacEight.Text && lblTicTacTwo.Text != "")
            {
                winner = lblTicTacTwo.Text;
                winningLabels = new Label[] { lblTicTacTwo, lblTicTacFive, lblTicTacEight };
            }
            else if (lblTicTacThree.Text == lblTicTacSix.Text && lblTicTacSix.Text == lblTicTacNine.Text && lblTicTacThree.Text != "")
            {
                winner = lblTicTacThree.Text;
                winningLabels = new Label[] { lblTicTacThree, lblTicTacSix, lblTicTacNine };
            }
            // Check diagonals.
            else if (lblTicTacOne.Text == lblTicTacFive.Text && lblTicTacFive.Text == lblTicTacNine.Text && lblTicTacOne.Text != "")
            {
                winner = lblTicTacOne.Text;
                winningLabels = new Label[] { lblTicTacOne, lblTicTacFive, lblTicTacNine };
            }
            else if (lblTicTacThree.Text == lblTicTacFive.Text && lblTicTacFive.Text == lblTicTacSeven.Text && lblTicTacThree.Text != "")
            {
                winner = lblTicTacThree.Text;
                winningLabels = new Label[] { lblTicTacThree, lblTicTacFive, lblTicTacSeven };
            }

            if (winner != "")
            {
                UpdateScore(winner);
                HighlightWinningLine(winningLabels);
                btnPlayAgain.Enabled = true;
            } else
            {
                CheckDraw();
            }
        }

        /// <summary>
        /// A method to check for a draw.
        /// </summary>
        private void CheckDraw()
        {
            Label[] allLabels = { lblTicTacOne, lblTicTacTwo, lblTicTacThree, lblTicTacFour, lblTicTacFive,
                          lblTicTacSix, lblTicTacSeven, lblTicTacEight, lblTicTacNine };

            bool isDraw = true;

            foreach (Label lbl in allLabels)
            {
                if (lbl.Text == "")
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw && txtXWins.Text == txt0Wins.Text) 
            {
                MessageBox.Show("It's a draw!");
                txtDraws.Text = (int.Parse(txtDraws.Text) + 1).ToString();
                btnPlayAgain.Enabled = true;
            }
        }

        /// <summary>
        /// A method to reset the gameboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Label[] clearLabels = { lblTicTacOne, lblTicTacTwo, lblTicTacThree, lblTicTacFour,
        lblTicTacFive, lblTicTacSix, lblTicTacSeven, lblTicTacEight, lblTicTacNine };

                foreach (Label lbl in clearLabels)
                {
                    lbl.Text = "";
                    lbl.Enabled = true;
                    lbl.Click -= ClickEvent;
                    lbl.Click += ClickEvent;

                    txt0Wins.Text = "0";
                    txtXWins.Text = "0";
                    txtDraws.Text = "0";

                    nudTurnDecider.Value = 0;

                    whoGoesFirst = Tools.RandomInt(1, 2);
                }
                DefaultColours();
                CreateClickEvents();
            }
        }

        /// <summary>
        /// A method to play the game again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Label[] clearLabels = { lblTicTacOne, lblTicTacTwo, lblTicTacThree, lblTicTacFour,
        lblTicTacFive, lblTicTacSix, lblTicTacSeven, lblTicTacEight, lblTicTacNine };

            foreach (Label lbl in clearLabels)
            {
                DefaultColours();
                lbl.Text = "";
                lbl.Enabled = true;
                lbl.Click -= ClickEvent;
                lbl.Click += ClickEvent;
            }
        }

        /// <summary>
        /// A method to highlight the winning line by changing label colors.
        /// </summary>
        /// <param name="winningLabels">The labels in the winning line.</param>
        private void HighlightWinningLine(Label[] winningLabels)
        {
            Color highlightColor = ColorTranslator.FromHtml("#669BBC");

            foreach (Label lbl in winningLabels)
            {
                lbl.BackColor = highlightColor;
                lbl.ForeColor = Color.White;
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            }
        }

        #endregion


    }
    }
