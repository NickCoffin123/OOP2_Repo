using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    /// <summary>
    /// Main method for the form.
    /// </summary>
    public partial class Battleship : Form
    {
        private Button[,] buttons;
        private int selectedRow = 0;
        private int selectedCol = 0;
        private int turnCount = 0;
        private Label turnLabel;

        /// <summary>
        /// Main constructor for the form.
        /// </summary>
        public Battleship()
        {
            InitializeComponent();
            CreateGrid();
            BS.RandomizeBoats();

            this.BackColor = ColorTranslator.FromHtml("#F0C808");
            lblTitle.BackColor = ColorTranslator.FromHtml("#086788");

            this.CancelButton = btnExit;

        }


        #region General Events
        

        /// <summary>
        /// A method to create the labels and handle the click event.
        /// </summary>
        private void CreateGrid()
        {
            int gridSize = BS.MAX_BOARD_SIZE;
            buttons = new Button[gridSize, gridSize];
            int buttonSize = 40;
            int yOffset = 80;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    buttons[row, col] = new Button();
                    buttons[row, col].Size = new Size(buttonSize, buttonSize);
                    buttons[row, col].Location = new Point(col * buttonSize, (row * buttonSize) + yOffset);
                    buttons[row, col].Name = $"btn_{row}_{col}";
                    buttons[row, col].BackColor = ColorTranslator.FromHtml("#07A0C3");
                    buttons[row, col].Click += new EventHandler(Button_Click);

                    this.Controls.Add(buttons[row, col]);
                }
            }
        }

        /// <summary>
        /// A method to tell the user how to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can play by clicking on the intended square or using the arrow keys.",
                            "How to Play",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        /// <summary>
        /// A method to exit the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        #endregion


        #region Battleship Gameplay

        /// <summary>
        /// A method to highlight the selected button.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void SelectButton(int row, int col)
        {
            if (selectedRow >= 0 && selectedCol >= 0)
            {
                buttons[selectedRow, selectedCol].BackColor = ColorTranslator.FromHtml("#07A0C3");
            }

        }

        /// <summary>
        /// A method for the arrowkeys. It only kind of works.
        /// </summary>
        /// <param name="e"></param>
        private void HandleKeyPress(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (selectedCol > 0)
                        selectedCol--;
                    break;
                case Keys.Right:
                    if (selectedCol < BS.MAX_BOARD_SIZE - 1)
                        selectedCol++;
                    break;
                case Keys.Up:
                    if (selectedRow > 0)
                        selectedRow--;
                    break;
                case Keys.Down:
                    if (selectedRow < BS.MAX_BOARD_SIZE - 1)
                        selectedRow++;
                    break;
                case Keys.Enter:
                    buttons[selectedRow, selectedCol].PerformClick();
                    break;
            }

            SelectButton(selectedRow, selectedCol);
        }

        /// <summary>
        /// The method to handle the button clicks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string[] coordinates = clickedButton.Name.Split('_');
                int x = int.Parse(coordinates[1]);
                int y = int.Parse(coordinates[2]);

                ProcessTurn(x, y);
            }
        }

        /// <summary>
        /// A method to process what happens on each click.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void ProcessTurn(int x, int y)
        {
            bool isHit = BS.CheckHit(x + 1, y + 1);

            if (isHit)
            {
                buttons[x, y].BackColor = ColorTranslator.FromHtml("#DD1C1A");
            }
            else
            {
                buttons[x, y].BackColor = ColorTranslator.FromHtml("#F0C808");
            }

            UpdateShipStatus();
            UpdateTurnCount();
        }

        /// <summary>
        /// A method to update the labels on the side and make the you win label visible.
        /// </summary>
        private void UpdateShipStatus()
        {
            
            if (BS.IsShipSunk(BS.Boats.Destroyer))
            {
                lblShipOne.BackColor = Color.Black;
            }
            if (BS.IsShipSunk(BS.Boats.Submarine))
            {
                lblShipTwo.BackColor = Color.Black;
            }
            if (BS.IsShipSunk(BS.Boats.Cruiser))
            {
                lblShipFive.BackColor = Color.Black;
            }
            if (BS.IsShipSunk(BS.Boats.Battleship))
            {
                lblShipFour.BackColor = Color.Black;
            }
            if (BS.IsShipSunk(BS.Boats.Carrier))
            {
                lblShipFive.BackColor = Color.Black;
            }

            CheckWin();
            
        }

        /// <summary>
        /// A method to update the turn count.
        /// </summary>
        private void UpdateTurnCount()
        {
            nudShotCount.Value++;
        }

        /// <summary>
        /// A method to reset the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            BS.board = new BS.BoardStatus[BS.MAX_BOARD_SIZE + 1, BS.MAX_BOARD_SIZE + 1];
            BS.boatPositions = new BS.Boats[BS.MAX_BOARD_SIZE + 1, BS.MAX_BOARD_SIZE + 1];

            for (int row = 0; row < BS.MAX_BOARD_SIZE; row++)
            {
                for (int col = 0; col < BS.MAX_BOARD_SIZE; col++)
                {
                    buttons[row, col].BackColor = ColorTranslator.FromHtml("#07A0C3");
                }
            }

            lblShipOne.BackColor = Color.White;
            lblShipTwo.BackColor = Color.White;
            lblShipThree.BackColor = Color.White;
            lblShipFour.BackColor = Color.White;
            lblShipFive.BackColor = Color.White;

            turnCount = 0;
            if (nudShotCount != null)
            {
                nudShotCount.Value = 0;
            }

            lblWin.Visible = false;
            BS.RandomizeBoats();
        }

        private void CheckWin()
        {
            if (BS.IsShipSunk(BS.Boats.Carrier) && BS.IsShipSunk(BS.Boats.Battleship) && BS.IsShipSunk(BS.Boats.Cruiser)
                && BS.IsShipSunk(BS.Boats.Submarine) && BS.IsShipSunk(BS.Boats.Destroyer))
            {
                lblWin.Visible = true;
            }
        }

        #endregion







    }
}
