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
    public partial class Battleship : Form
    {
        private Button[,] buttons;
        private int selectedRow = 0;
        private int selectedCol = 0;
        private int turnCount = 0;
        private Label turnLabel;

        public Battleship()
        {
            InitializeComponent();
            CreateGrid();
            BS.RandomizeBoats();

            this.KeyPreview = true;

            SelectButton(0, 0);

            this.BackColor = ColorTranslator.FromHtml("#F0C808");
            lblTitle.BackColor = ColorTranslator.FromHtml("#086788");

        }

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

        private void SelectButton(int row, int col)
        {
            if (selectedRow >= 0 && selectedCol >= 0)
            {
                buttons[selectedRow, selectedCol].BackColor = ColorTranslator.FromHtml("#07A0C3");
            }

        }

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
        }


        private void UpdateTurnCount()
        {
            nudShotCount.Value++;
        }    
    }
}
