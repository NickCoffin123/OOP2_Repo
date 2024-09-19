namespace ClassExercise1
{
    partial class frmMain
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnGTN = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panGTN = new System.Windows.Forms.Panel();
            this.btnGTNPlayAgain = new System.Windows.Forms.Button();
            this.nudGTNGuessCount = new System.Windows.Forms.NumericUpDown();
            this.nudGTNActualNumber = new System.Windows.Forms.NumericUpDown();
            this.lblGTNGuessHistory = new System.Windows.Forms.Label();
            this.btnGTNGuess = new System.Windows.Forms.Button();
            this.gbxGTNSettings = new System.Windows.Forms.GroupBox();
            this.cboGTNDificulty = new System.Windows.Forms.ComboBox();
            this.lblMaximumGuessNumber = new System.Windows.Forms.Label();
            this.lblMinimumGuessNumber = new System.Windows.Forms.Label();
            this.lblGTNGuessMaximum = new System.Windows.Forms.Label();
            this.lblGTNGuessMinimum = new System.Windows.Forms.Label();
            this.lblGTNSettingsDifficulty = new System.Windows.Forms.Label();
            this.nudGTNGuess = new System.Windows.Forms.NumericUpDown();
            this.lblGTNGuess = new System.Windows.Forms.Label();
            this.lblGTNTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.panMenu.SuspendLayout();
            this.panGTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuessCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNActualNumber)).BeginInit();
            this.gbxGTNSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.Maroon;
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Controls.Add(this.btnGTN);
            this.panMenu.Controls.Add(this.lblMenuTitle);
            this.panMenu.Location = new System.Drawing.Point(-9, -25);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(221, 598);
            this.panMenu.TabIndex = 0;
            // 
            // btnIceCream
            // 
            this.btnIceCream.Location = new System.Drawing.Point(4, 131);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(218, 34);
            this.btnIceCream.TabIndex = 2;
            this.btnIceCream.Text = "Ice Cream";
            this.btnIceCream.UseVisualStyleBackColor = true;
            // 
            // btnGTN
            // 
            this.btnGTN.Location = new System.Drawing.Point(4, 79);
            this.btnGTN.Name = "btnGTN";
            this.btnGTN.Size = new System.Drawing.Size(218, 34);
            this.btnGTN.TabIndex = 1;
            this.btnGTN.Text = "Guess the Numer";
            this.toolTips.SetToolTip(this.btnGTN, "Select to play guess the number");
            this.btnGTN.UseVisualStyleBackColor = true;
            this.btnGTN.Click += new System.EventHandler(this.btnGTN_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMenuTitle.Location = new System.Drawing.Point(3, 24);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(218, 37);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "My Little Games";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGTN
            // 
            this.panGTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGTN.Controls.Add(this.btnGTNPlayAgain);
            this.panGTN.Controls.Add(this.nudGTNGuessCount);
            this.panGTN.Controls.Add(this.nudGTNActualNumber);
            this.panGTN.Controls.Add(this.lblGTNGuessHistory);
            this.panGTN.Controls.Add(this.btnGTNGuess);
            this.panGTN.Controls.Add(this.gbxGTNSettings);
            this.panGTN.Controls.Add(this.nudGTNGuess);
            this.panGTN.Controls.Add(this.lblGTNGuess);
            this.panGTN.Controls.Add(this.lblGTNTitle);
            this.panGTN.Location = new System.Drawing.Point(218, -1);
            this.panGTN.Name = "panGTN";
            this.panGTN.Size = new System.Drawing.Size(567, 451);
            this.panGTN.TabIndex = 1;
            this.panGTN.Visible = false;
            this.panGTN.Paint += new System.Windows.Forms.PaintEventHandler(this.panGTN_Paint);
            // 
            // btnGTNPlayAgain
            // 
            this.btnGTNPlayAgain.Location = new System.Drawing.Point(329, 296);
            this.btnGTNPlayAgain.Name = "btnGTNPlayAgain";
            this.btnGTNPlayAgain.Size = new System.Drawing.Size(108, 23);
            this.btnGTNPlayAgain.TabIndex = 8;
            this.btnGTNPlayAgain.Text = "Play Again";
            this.btnGTNPlayAgain.UseVisualStyleBackColor = true;
            this.btnGTNPlayAgain.Visible = false;
            this.btnGTNPlayAgain.Click += new System.EventHandler(this.btnGTNPlayAgain_Click);
            // 
            // nudGTNGuessCount
            // 
            this.nudGTNGuessCount.Enabled = false;
            this.nudGTNGuessCount.Location = new System.Drawing.Point(426, 220);
            this.nudGTNGuessCount.Name = "nudGTNGuessCount";
            this.nudGTNGuessCount.Size = new System.Drawing.Size(120, 20);
            this.nudGTNGuessCount.TabIndex = 7;
            // 
            // nudGTNActualNumber
            // 
            this.nudGTNActualNumber.Enabled = false;
            this.nudGTNActualNumber.Location = new System.Drawing.Point(426, 196);
            this.nudGTNActualNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGTNActualNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNActualNumber.Name = "nudGTNActualNumber";
            this.nudGTNActualNumber.Size = new System.Drawing.Size(120, 20);
            this.nudGTNActualNumber.TabIndex = 6;
            this.nudGTNActualNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGTNGuessHistory
            // 
            this.lblGTNGuessHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGTNGuessHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGTNGuessHistory.Location = new System.Drawing.Point(13, 350);
            this.lblGTNGuessHistory.Name = "lblGTNGuessHistory";
            this.lblGTNGuessHistory.Size = new System.Drawing.Size(544, 89);
            this.lblGTNGuessHistory.TabIndex = 5;
            // 
            // btnGTNGuess
            // 
            this.btnGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTNGuess.Location = new System.Drawing.Point(165, 262);
            this.btnGTNGuess.Name = "btnGTNGuess";
            this.btnGTNGuess.Size = new System.Drawing.Size(109, 58);
            this.btnGTNGuess.TabIndex = 4;
            this.btnGTNGuess.Text = "&Guess";
            this.btnGTNGuess.UseVisualStyleBackColor = true;
            this.btnGTNGuess.Click += new System.EventHandler(this.btnGTNGuess_Click);
            // 
            // gbxGTNSettings
            // 
            this.gbxGTNSettings.Controls.Add(this.cboGTNDificulty);
            this.gbxGTNSettings.Controls.Add(this.lblMaximumGuessNumber);
            this.gbxGTNSettings.Controls.Add(this.lblMinimumGuessNumber);
            this.gbxGTNSettings.Controls.Add(this.lblGTNGuessMaximum);
            this.gbxGTNSettings.Controls.Add(this.lblGTNGuessMinimum);
            this.gbxGTNSettings.Controls.Add(this.lblGTNSettingsDifficulty);
            this.gbxGTNSettings.Location = new System.Drawing.Point(13, 55);
            this.gbxGTNSettings.Name = "gbxGTNSettings";
            this.gbxGTNSettings.Size = new System.Drawing.Size(533, 115);
            this.gbxGTNSettings.TabIndex = 3;
            this.gbxGTNSettings.TabStop = false;
            this.gbxGTNSettings.Text = "Settings";
            // 
            // cboGTNDificulty
            // 
            this.cboGTNDificulty.FormattingEnabled = true;
            this.cboGTNDificulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cboGTNDificulty.Location = new System.Drawing.Point(75, 26);
            this.cboGTNDificulty.Name = "cboGTNDificulty";
            this.cboGTNDificulty.Size = new System.Drawing.Size(121, 21);
            this.cboGTNDificulty.TabIndex = 5;
            this.cboGTNDificulty.SelectedIndexChanged += new System.EventHandler(this.cboGTNDificulty_SelectedIndexChanged);
            // 
            // lblMaximumGuessNumber
            // 
            this.lblMaximumGuessNumber.AutoSize = true;
            this.lblMaximumGuessNumber.Location = new System.Drawing.Point(370, 63);
            this.lblMaximumGuessNumber.Name = "lblMaximumGuessNumber";
            this.lblMaximumGuessNumber.Size = new System.Drawing.Size(19, 13);
            this.lblMaximumGuessNumber.TabIndex = 4;
            this.lblMaximumGuessNumber.Text = "10";
            // 
            // lblMinimumGuessNumber
            // 
            this.lblMinimumGuessNumber.AutoSize = true;
            this.lblMinimumGuessNumber.Location = new System.Drawing.Point(370, 26);
            this.lblMinimumGuessNumber.Name = "lblMinimumGuessNumber";
            this.lblMinimumGuessNumber.Size = new System.Drawing.Size(13, 13);
            this.lblMinimumGuessNumber.TabIndex = 3;
            this.lblMinimumGuessNumber.Text = "1";
            // 
            // lblGTNGuessMaximum
            // 
            this.lblGTNGuessMaximum.AutoSize = true;
            this.lblGTNGuessMaximum.Location = new System.Drawing.Point(310, 63);
            this.lblGTNGuessMaximum.Name = "lblGTNGuessMaximum";
            this.lblGTNGuessMaximum.Size = new System.Drawing.Size(54, 13);
            this.lblGTNGuessMaximum.TabIndex = 2;
            this.lblGTNGuessMaximum.Text = "Maximum:";
            // 
            // lblGTNGuessMinimum
            // 
            this.lblGTNGuessMinimum.AutoSize = true;
            this.lblGTNGuessMinimum.Location = new System.Drawing.Point(313, 26);
            this.lblGTNGuessMinimum.Name = "lblGTNGuessMinimum";
            this.lblGTNGuessMinimum.Size = new System.Drawing.Size(51, 13);
            this.lblGTNGuessMinimum.TabIndex = 1;
            this.lblGTNGuessMinimum.Text = "Minimum:";
            // 
            // lblGTNSettingsDifficulty
            // 
            this.lblGTNSettingsDifficulty.AutoSize = true;
            this.lblGTNSettingsDifficulty.Location = new System.Drawing.Point(18, 29);
            this.lblGTNSettingsDifficulty.Name = "lblGTNSettingsDifficulty";
            this.lblGTNSettingsDifficulty.Size = new System.Drawing.Size(47, 13);
            this.lblGTNSettingsDifficulty.TabIndex = 0;
            this.lblGTNSettingsDifficulty.Text = "Difficulty";
            // 
            // nudGTNGuess
            // 
            this.nudGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGTNGuess.Location = new System.Drawing.Point(165, 196);
            this.nudGTNGuess.Name = "nudGTNGuess";
            this.nudGTNGuess.Size = new System.Drawing.Size(109, 44);
            this.nudGTNGuess.TabIndex = 2;
            // 
            // lblGTNGuess
            // 
            this.lblGTNGuess.AutoSize = true;
            this.lblGTNGuess.Location = new System.Drawing.Point(85, 216);
            this.lblGTNGuess.Name = "lblGTNGuess";
            this.lblGTNGuess.Size = new System.Drawing.Size(74, 13);
            this.lblGTNGuess.TabIndex = 1;
            this.lblGTNGuess.Text = "Enter a Guess";
            // 
            // lblGTNTitle
            // 
            this.lblGTNTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTNTitle.Location = new System.Drawing.Point(9, 14);
            this.lblGTNTitle.Name = "lblGTNTitle";
            this.lblGTNTitle.Size = new System.Drawing.Size(183, 52);
            this.lblGTNTitle.TabIndex = 0;
            this.lblGTNTitle.Text = "Guess the Number";
            this.lblGTNTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(679, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 510);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panGTN);
            this.Controls.Add(this.panMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guesser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panGTN.ResumeLayout(false);
            this.panGTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuessCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNActualNumber)).EndInit();
            this.gbxGTNSettings.ResumeLayout(false);
            this.gbxGTNSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Button btnGTN;
        private System.Windows.Forms.Panel panGTN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGTNGuess;
        private System.Windows.Forms.Label lblGTNTitle;
        private System.Windows.Forms.GroupBox gbxGTNSettings;
        private System.Windows.Forms.NumericUpDown nudGTNGuess;
        private System.Windows.Forms.ComboBox cboGTNDificulty;
        private System.Windows.Forms.Label lblMaximumGuessNumber;
        private System.Windows.Forms.Label lblMinimumGuessNumber;
        private System.Windows.Forms.Label lblGTNGuessMaximum;
        private System.Windows.Forms.Label lblGTNGuessMinimum;
        private System.Windows.Forms.Label lblGTNSettingsDifficulty;
        private System.Windows.Forms.Button btnGTNGuess;
        private System.Windows.Forms.NumericUpDown nudGTNGuessCount;
        private System.Windows.Forms.NumericUpDown nudGTNActualNumber;
        private System.Windows.Forms.Label lblGTNGuessHistory;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnGTNPlayAgain;
    }
}

