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
            this.panIceCream = new System.Windows.Forms.Panel();
            this.lblPayHere = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxIceCreamSelection = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbxIceCreamOrder = new System.Windows.Forms.ListBox();
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtProvidedPayment = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblChangeDue = new System.Windows.Forms.Label();
            this.lblTill = new System.Windows.Forms.Label();
            this.lblTillAmount = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.panGTN.SuspendLayout();
            this.panIceCream.SuspendLayout();
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
            this.toolTips.SetToolTip(this.btnIceCream, "Select for ice cream tracker");
            this.btnIceCream.UseVisualStyleBackColor = true;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // btnGTN
            // 
            this.btnGTN.Location = new System.Drawing.Point(4, 79);
            this.btnGTN.Name = "btnGTN";
            this.btnGTN.Size = new System.Drawing.Size(218, 34);
            this.btnGTN.TabIndex = 1;
            this.btnGTN.Text = "Guess the Number";
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
            this.panGTN.Controls.Add(this.panIceCream);
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
            // 
            // panIceCream
            // 
            this.panIceCream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panIceCream.Controls.Add(this.lblTillAmount);
            this.panIceCream.Controls.Add(this.lblTill);
            this.panIceCream.Controls.Add(this.lblChangeDue);
            this.panIceCream.Controls.Add(this.btnPay);
            this.panIceCream.Controls.Add(this.txtProvidedPayment);
            this.panIceCream.Controls.Add(this.lblPayment);
            this.panIceCream.Controls.Add(this.lblPayHere);
            this.panIceCream.Controls.Add(this.lblTotalPrice);
            this.panIceCream.Controls.Add(this.lblTotal);
            this.panIceCream.Controls.Add(this.btnRemove);
            this.panIceCream.Controls.Add(this.btnAdd);
            this.panIceCream.Controls.Add(this.lbxIceCreamSelection);
            this.panIceCream.Controls.Add(this.lblTitle);
            this.panIceCream.Controls.Add(this.lbxIceCreamOrder);
            this.panIceCream.Location = new System.Drawing.Point(0, 0);
            this.panIceCream.Name = "panIceCream";
            this.panIceCream.Size = new System.Drawing.Size(567, 451);
            this.panIceCream.TabIndex = 0;
            this.panIceCream.Visible = false;
            // 
            // lblPayHere
            // 
            this.lblPayHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayHere.Location = new System.Drawing.Point(77, 262);
            this.lblPayHere.Name = "lblPayHere";
            this.lblPayHere.Size = new System.Drawing.Size(101, 23);
            this.lblPayHere.TabIndex = 0;
            this.lblPayHere.Text = "Pay Here";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(423, 55);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(111, 23);
            this.lblTotalPrice.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(383, 55);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(103, 217);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.toolTips.SetToolTip(this.btnRemove, "Remove selected ice cream");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.toolTips.SetToolTip(this.btnAdd, "Add selected ice cream");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxIceCreamSelection
            // 
            this.lbxIceCreamSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxIceCreamSelection.FormattingEnabled = true;
            this.lbxIceCreamSelection.ItemHeight = 20;
            this.lbxIceCreamSelection.Items.AddRange(new object[] {
            "Small - $1",
            "Medium - $2",
            "Large - $3",
            "Slushie - $2.50",
            "Popcicle - $1.25",
            "Fudgecicle - $1.50"});
            this.lbxIceCreamSelection.Location = new System.Drawing.Point(18, 55);
            this.lbxIceCreamSelection.Name = "lbxIceCreamSelection";
            this.lbxIceCreamSelection.Size = new System.Drawing.Size(160, 144);
            this.lbxIceCreamSelection.TabIndex = 3;
            this.toolTips.SetToolTip(this.lbxIceCreamSelection, "Ice cream selection");
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Order Here";
            // 
            // lbxIceCreamOrder
            // 
            this.lbxIceCreamOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxIceCreamOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxIceCreamOrder.FormattingEnabled = true;
            this.lbxIceCreamOrder.ItemHeight = 20;
            this.lbxIceCreamOrder.Location = new System.Drawing.Point(198, 55);
            this.lbxIceCreamOrder.Name = "lbxIceCreamOrder";
            this.lbxIceCreamOrder.Size = new System.Drawing.Size(169, 144);
            this.lbxIceCreamOrder.TabIndex = 6;
            // 
            // btnGTNPlayAgain
            // 
            this.btnGTNPlayAgain.Location = new System.Drawing.Point(329, 296);
            this.btnGTNPlayAgain.Name = "btnGTNPlayAgain";
            this.btnGTNPlayAgain.Size = new System.Drawing.Size(108, 23);
            this.btnGTNPlayAgain.TabIndex = 6;
            this.btnGTNPlayAgain.Text = "Play Again";
            this.toolTips.SetToolTip(this.btnGTNPlayAgain, "Play again");
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
            this.nudGTNGuessCount.TabIndex = 0;
            this.nudGTNGuessCount.Visible = false;
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
            this.nudGTNActualNumber.TabIndex = 0;
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
            this.lblGTNGuessHistory.Size = new System.Drawing.Size(533, 90);
            this.lblGTNGuessHistory.TabIndex = 5;
            // 
            // btnGTNGuess
            // 
            this.btnGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTNGuess.Location = new System.Drawing.Point(165, 262);
            this.btnGTNGuess.Name = "btnGTNGuess";
            this.btnGTNGuess.Size = new System.Drawing.Size(109, 58);
            this.btnGTNGuess.TabIndex = 5;
            this.btnGTNGuess.Text = "&Guess";
            this.toolTips.SetToolTip(this.btnGTNGuess, "Select to enter guess");
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
            this.cboGTNDificulty.TabIndex = 3;
            this.toolTips.SetToolTip(this.cboGTNDificulty, "Difficulty selecter");
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
            this.nudGTNGuess.TabIndex = 4;
            this.toolTips.SetToolTip(this.nudGTNGuess, "Guess entry");
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
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.toolTips.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(84, 296);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(92, 13);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment provided";
            // 
            // txtProvidedPayment
            // 
            this.txtProvidedPayment.Location = new System.Drawing.Point(82, 326);
            this.txtProvidedPayment.Name = "txtProvidedPayment";
            this.txtProvidedPayment.Size = new System.Drawing.Size(87, 20);
            this.txtProvidedPayment.TabIndex = 7;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(82, 376);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay";
            this.toolTips.SetToolTip(this.btnPay, "Add selected ice cream");
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblChangeDue
            // 
            this.lblChangeDue.Location = new System.Drawing.Point(79, 402);
            this.lblChangeDue.Name = "lblChangeDue";
            this.lblChangeDue.Size = new System.Drawing.Size(87, 21);
            this.lblChangeDue.TabIndex = 9;
            this.lblChangeDue.Text = "Change due:";
            // 
            // lblTill
            // 
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.Location = new System.Drawing.Point(245, 262);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(40, 23);
            this.lblTill.TabIndex = 10;
            this.lblTill.Text = "Till";
            // 
            // lblTillAmount
            // 
            this.lblTillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTillAmount.Location = new System.Drawing.Point(246, 311);
            this.lblTillAmount.Name = "lblTillAmount";
            this.lblTillAmount.Size = new System.Drawing.Size(39, 23);
            this.lblTillAmount.TabIndex = 11;
            this.lblTillAmount.Text = "100";
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
            this.panIceCream.ResumeLayout(false);
            this.panIceCream.PerformLayout();
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
        private System.Windows.Forms.Panel panIceCream;
        private System.Windows.Forms.ListBox lbxIceCreamOrder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbxIceCreamSelection;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPayHere;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtProvidedPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.Label lblTillAmount;
    }
}

