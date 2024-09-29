namespace TicTacToe
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPlayer0 = new System.Windows.Forms.Label();
            this.txtPlayerX = new System.Windows.Forms.TextBox();
            this.txtPlayer0 = new System.Windows.Forms.TextBox();
            this.lblTicTacOne = new System.Windows.Forms.Label();
            this.lblTicTacTwo = new System.Windows.Forms.Label();
            this.lblTicTacThree = new System.Windows.Forms.Label();
            this.lblTicTacSix = new System.Windows.Forms.Label();
            this.lblTicTacNine = new System.Windows.Forms.Label();
            this.lblTicTacFour = new System.Windows.Forms.Label();
            this.lblTicTacFive = new System.Windows.Forms.Label();
            this.lblTicTacSeven = new System.Windows.Forms.Label();
            this.lblTicTacEight = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWins = new System.Windows.Forms.Label();
            this.txtXWins = new System.Windows.Forms.TextBox();
            this.lblXWins = new System.Windows.Forms.Label();
            this.txt0Wins = new System.Windows.Forms.TextBox();
            this.lbl0Wins = new System.Windows.Forms.Label();
            this.txtDraws = new System.Windows.Forms.TextBox();
            this.lblDraws = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudTurnDecider = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnDecider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(-6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 88);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic Tac Toe";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(26, 114);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(31, 23);
            this.lblPlayerX.TabIndex = 1;
            this.lblPlayerX.Text = "X:";
            // 
            // lblPlayer0
            // 
            this.lblPlayer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer0.Location = new System.Drawing.Point(166, 114);
            this.lblPlayer0.Name = "lblPlayer0";
            this.lblPlayer0.Size = new System.Drawing.Size(25, 23);
            this.lblPlayer0.TabIndex = 2;
            this.lblPlayer0.Text = "0:";
            // 
            // txtPlayerX
            // 
            this.txtPlayerX.Location = new System.Drawing.Point(52, 114);
            this.txtPlayerX.Name = "txtPlayerX";
            this.txtPlayerX.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerX.TabIndex = 1;
            this.txtPlayerX.Text = "Player 1";
            this.toolTip1.SetToolTip(this.txtPlayerX, "Player X name");
            // 
            // txtPlayer0
            // 
            this.txtPlayer0.Location = new System.Drawing.Point(188, 114);
            this.txtPlayer0.Name = "txtPlayer0";
            this.txtPlayer0.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer0.TabIndex = 2;
            this.txtPlayer0.Text = "Player 2";
            this.toolTip1.SetToolTip(this.txtPlayer0, "Player O name");
            // 
            // lblTicTacOne
            // 
            this.lblTicTacOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacOne.Enabled = false;
            this.lblTicTacOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTicTacOne.Location = new System.Drawing.Point(27, 161);
            this.lblTicTacOne.Name = "lblTicTacOne";
            this.lblTicTacOne.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacOne.TabIndex = 7;
            this.lblTicTacOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTicTacOne.Click += new System.EventHandler(this.ClickEvent);
            // 
            // lblTicTacTwo
            // 
            this.lblTicTacTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacTwo.Enabled = false;
            this.lblTicTacTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacTwo.Location = new System.Drawing.Point(144, 161);
            this.lblTicTacTwo.Name = "lblTicTacTwo";
            this.lblTicTacTwo.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacTwo.TabIndex = 8;
            this.lblTicTacTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacThree
            // 
            this.lblTicTacThree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacThree.Enabled = false;
            this.lblTicTacThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacThree.Location = new System.Drawing.Point(264, 161);
            this.lblTicTacThree.Name = "lblTicTacThree";
            this.lblTicTacThree.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacThree.TabIndex = 9;
            this.lblTicTacThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacSix
            // 
            this.lblTicTacSix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacSix.Enabled = false;
            this.lblTicTacSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacSix.Location = new System.Drawing.Point(264, 263);
            this.lblTicTacSix.Name = "lblTicTacSix";
            this.lblTicTacSix.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacSix.TabIndex = 12;
            this.lblTicTacSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacNine
            // 
            this.lblTicTacNine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacNine.Enabled = false;
            this.lblTicTacNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacNine.Location = new System.Drawing.Point(264, 365);
            this.lblTicTacNine.Name = "lblTicTacNine";
            this.lblTicTacNine.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacNine.TabIndex = 15;
            this.lblTicTacNine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacFour
            // 
            this.lblTicTacFour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacFour.Enabled = false;
            this.lblTicTacFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacFour.Location = new System.Drawing.Point(27, 263);
            this.lblTicTacFour.Name = "lblTicTacFour";
            this.lblTicTacFour.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacFour.TabIndex = 10;
            this.lblTicTacFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacFive
            // 
            this.lblTicTacFive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacFive.Enabled = false;
            this.lblTicTacFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacFive.Location = new System.Drawing.Point(144, 263);
            this.lblTicTacFive.Name = "lblTicTacFive";
            this.lblTicTacFive.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacFive.TabIndex = 11;
            this.lblTicTacFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacSeven
            // 
            this.lblTicTacSeven.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacSeven.Enabled = false;
            this.lblTicTacSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacSeven.Location = new System.Drawing.Point(27, 365);
            this.lblTicTacSeven.Name = "lblTicTacSeven";
            this.lblTicTacSeven.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacSeven.TabIndex = 13;
            this.lblTicTacSeven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacEight
            // 
            this.lblTicTacEight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTicTacEight.Enabled = false;
            this.lblTicTacEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacEight.Location = new System.Drawing.Point(144, 365);
            this.lblTicTacEight.Name = "lblTicTacEight";
            this.lblTicTacEight.Size = new System.Drawing.Size(99, 89);
            this.lblTicTacEight.TabIndex = 14;
            this.lblTicTacEight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.Location = new System.Drawing.Point(402, 365);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(123, 41);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "&Play Again";
            this.toolTip1.SetToolTip(this.btnPlayAgain, "Play again button");
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit button");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWins
            // 
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(402, 161);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(123, 23);
            this.lblWins.TabIndex = 16;
            this.lblWins.Text = "Wins";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtXWins
            // 
            this.txtXWins.Enabled = false;
            this.txtXWins.Location = new System.Drawing.Point(455, 204);
            this.txtXWins.Name = "txtXWins";
            this.txtXWins.Size = new System.Drawing.Size(35, 20);
            this.txtXWins.TabIndex = 18;
            this.txtXWins.Text = "0";
            this.toolTip1.SetToolTip(this.txtXWins, "Player X wins");
            // 
            // lblXWins
            // 
            this.lblXWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXWins.Location = new System.Drawing.Point(429, 204);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(31, 23);
            this.lblXWins.TabIndex = 17;
            this.lblXWins.Text = "X:";
            // 
            // txt0Wins
            // 
            this.txt0Wins.Enabled = false;
            this.txt0Wins.Location = new System.Drawing.Point(455, 230);
            this.txt0Wins.Name = "txt0Wins";
            this.txt0Wins.Size = new System.Drawing.Size(35, 20);
            this.txt0Wins.TabIndex = 20;
            this.txt0Wins.Text = "0";
            this.toolTip1.SetToolTip(this.txt0Wins, "Player O wins");
            // 
            // lbl0Wins
            // 
            this.lbl0Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Wins.Location = new System.Drawing.Point(429, 230);
            this.lbl0Wins.Name = "lbl0Wins";
            this.lbl0Wins.Size = new System.Drawing.Size(31, 23);
            this.lbl0Wins.TabIndex = 19;
            this.lbl0Wins.Text = "0:";
            // 
            // txtDraws
            // 
            this.txtDraws.Enabled = false;
            this.txtDraws.Location = new System.Drawing.Point(455, 257);
            this.txtDraws.Name = "txtDraws";
            this.txtDraws.Size = new System.Drawing.Size(35, 20);
            this.txtDraws.TabIndex = 22;
            this.txtDraws.Text = "0";
            this.toolTip1.SetToolTip(this.txtDraws, "Draws");
            // 
            // lblDraws
            // 
            this.lblDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraws.Location = new System.Drawing.Point(393, 255);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(59, 23);
            this.lblDraws.TabIndex = 21;
            this.lblDraws.Text = "Draws:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(402, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 41);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.toolTip1.SetToolTip(this.btnStart, "Start button");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudTurnDecider
            // 
            this.nudTurnDecider.Location = new System.Drawing.Point(407, 283);
            this.nudTurnDecider.Name = "nudTurnDecider";
            this.nudTurnDecider.Size = new System.Drawing.Size(120, 20);
            this.nudTurnDecider.TabIndex = 24;
            this.nudTurnDecider.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(402, 318);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 41);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset button");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 481);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nudTurnDecider);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDraws);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.txt0Wins);
            this.Controls.Add(this.lbl0Wins);
            this.Controls.Add(this.txtXWins);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblTicTacEight);
            this.Controls.Add(this.lblTicTacSeven);
            this.Controls.Add(this.lblTicTacFive);
            this.Controls.Add(this.lblTicTacFour);
            this.Controls.Add(this.lblTicTacNine);
            this.Controls.Add(this.lblTicTacSix);
            this.Controls.Add(this.lblTicTacThree);
            this.Controls.Add(this.lblTicTacTwo);
            this.Controls.Add(this.lblTicTacOne);
            this.Controls.Add(this.txtPlayer0);
            this.Controls.Add(this.txtPlayerX);
            this.Controls.Add(this.lblPlayer0);
            this.Controls.Add(this.lblPlayerX);
            this.Controls.Add(this.lblTitle);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnDecider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblPlayer0;
        private System.Windows.Forms.TextBox txtPlayerX;
        private System.Windows.Forms.TextBox txtPlayer0;
        private System.Windows.Forms.Label lblTicTacOne;
        private System.Windows.Forms.Label lblTicTacTwo;
        private System.Windows.Forms.Label lblTicTacThree;
        private System.Windows.Forms.Label lblTicTacSix;
        private System.Windows.Forms.Label lblTicTacNine;
        private System.Windows.Forms.Label lblTicTacFour;
        private System.Windows.Forms.Label lblTicTacFive;
        private System.Windows.Forms.Label lblTicTacSeven;
        private System.Windows.Forms.Label lblTicTacEight;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.TextBox txtXWins;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.TextBox txt0Wins;
        private System.Windows.Forms.Label lbl0Wins;
        private System.Windows.Forms.TextBox txtDraws;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudTurnDecider;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

