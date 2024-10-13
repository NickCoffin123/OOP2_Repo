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

            // Enable KeyPreview
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            // Select the first button initially
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
                    buttons[row, col].BackColor = ColorTranslator.FromHtml("#07A0C3"); // Default button color
                    buttons[row, col].Click += new EventHandler(Button_Click);

                    this.Controls.Add(buttons[row, col]);
                }
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key pressed: " + e.KeyCode.ToString()); // Debug check to see if keypresses are captured
            HandleKeyPress(e);
        }

        // Selects and highlights the current button
        private void SelectButton(int row, int col)
        {
            // Deselect the previously selected button
            if (selectedRow >= 0 && selectedCol >= 0)
            {
                buttons[selectedRow, selectedCol].BackColor = ColorTranslator.FromHtml("#07A0C3"); // Reset the previous button color
            }

        }

        private void HandleKeyPress(KeyEventArgs e)
{
    switch (e.KeyCode)
    {
        case Keys.Left:
            if (selectedCol > 0) // Move left
                selectedCol--;
            break;
        case Keys.Right:
            if (selectedCol < BS.MAX_BOARD_SIZE - 1) // Move right
                selectedCol++;
            break;
        case Keys.Up:
            if (selectedRow > 0) // Move up
                selectedRow--;
            break;
        case Keys.Down:
            if (selectedRow < BS.MAX_BOARD_SIZE - 1) // Move down
                selectedRow++;
            break;
        case Keys.Enter:
            // Simulate a button click at the current position
            buttons[selectedRow, selectedCol].PerformClick();
            break;
    }

    // Highlight the current button to show the active selection
    SelectButton(selectedRow, selectedCol);
}


        // Handles mouse clicks on buttons
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Get coordinates from the clicked button's name
                string[] coordinates = clickedButton.Name.Split('_');
                int x = int.Parse(coordinates[1]);
                int y = int.Parse(coordinates[2]);

                // Process the turn
                ProcessTurn(x, y);
            }
        }

        private void ProcessTurn(int x, int y)
        {
            // Adjust coordinates for 1-based indexing
            bool isHit = BS.CheckHit(x + 1, y + 1);

            if (isHit)
            {
                buttons[x, y].BackColor = ColorTranslator.FromHtml("#DD1C1A"); 
            }
            else
            {
                buttons[x, y].BackColor = ColorTranslator.FromHtml("#F0C808"); 
            }

            UpdateTurnCount();
        }



        private void UpdateTurnCount()
        {
            nudShotCount.Value++;
        }    
    }
}
