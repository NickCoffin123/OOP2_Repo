namespace CharacterSheet
{
    partial class frmCharacterEdit
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.cbxRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.cbxAlignment = new System.Windows.Forms.ComboBox();
            this.lblAlignment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.nudDexterity = new System.Windows.Forms.NumericUpDown();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.nudConstitution = new System.Windows.Forms.NumericUpDown();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.nudWisdom = new System.Windows.Forms.NumericUpDown();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.nudCharisma = new System.Windows.Forms.NumericUpDown();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblArmourClass = new System.Windows.Forms.Label();
            this.txtArmourClass = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.lblInitiative = new System.Windows.Forms.Label();
            this.txtInitative = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.lblRaceDescription = new System.Windows.Forms.Label();
            this.rtbClassDescription = new System.Windows.Forms.RichTextBox();
            this.rtbRaceDescription = new System.Windows.Forms.RichTextBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(60, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(60, 57);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 23);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class";
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(110, 53);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(121, 21);
            this.cbxClass.TabIndex = 4;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // cbxRace
            // 
            this.cbxRace.FormattingEnabled = true;
            this.cbxRace.Location = new System.Drawing.Point(110, 97);
            this.cbxRace.Name = "cbxRace";
            this.cbxRace.Size = new System.Drawing.Size(121, 21);
            this.cbxRace.TabIndex = 6;
            this.cbxRace.SelectedIndexChanged += new System.EventHandler(this.cbxRace_SelectedIndexChanged);
            // 
            // lblRace
            // 
            this.lblRace.Location = new System.Drawing.Point(60, 101);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(44, 23);
            this.lblRace.TabIndex = 5;
            this.lblRace.Text = "Race";
            // 
            // cbxAlignment
            // 
            this.cbxAlignment.FormattingEnabled = true;
            this.cbxAlignment.Location = new System.Drawing.Point(110, 141);
            this.cbxAlignment.Name = "cbxAlignment";
            this.cbxAlignment.Size = new System.Drawing.Size(121, 21);
            this.cbxAlignment.TabIndex = 8;
            // 
            // lblAlignment
            // 
            this.lblAlignment.Location = new System.Drawing.Point(44, 145);
            this.lblAlignment.Name = "lblAlignment";
            this.lblAlignment.Size = new System.Drawing.Size(60, 23);
            this.lblAlignment.TabIndex = 7;
            this.lblAlignment.Text = "Alignment";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(60, 188);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(44, 23);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblStrength
            // 
            this.lblStrength.Location = new System.Drawing.Point(347, 25);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(65, 23);
            this.lblStrength.TabIndex = 11;
            this.lblStrength.Text = "Strength";
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(350, 51);
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(41, 20);
            this.nudStrength.TabIndex = 12;
            this.nudStrength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nudDexterity
            // 
            this.nudDexterity.Location = new System.Drawing.Point(350, 119);
            this.nudDexterity.Name = "nudDexterity";
            this.nudDexterity.Size = new System.Drawing.Size(41, 20);
            this.nudDexterity.TabIndex = 14;
            this.nudDexterity.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblDexterity
            // 
            this.lblDexterity.Location = new System.Drawing.Point(347, 93);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(65, 23);
            this.lblDexterity.TabIndex = 13;
            this.lblDexterity.Text = "Dexterity";
            // 
            // nudConstitution
            // 
            this.nudConstitution.Location = new System.Drawing.Point(350, 190);
            this.nudConstitution.Name = "nudConstitution";
            this.nudConstitution.Size = new System.Drawing.Size(41, 20);
            this.nudConstitution.TabIndex = 16;
            this.nudConstitution.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblConstitution
            // 
            this.lblConstitution.Location = new System.Drawing.Point(347, 164);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(65, 23);
            this.lblConstitution.TabIndex = 15;
            this.lblConstitution.Text = "Constitution";
            // 
            // nudIntelligence
            // 
            this.nudIntelligence.Location = new System.Drawing.Point(350, 264);
            this.nudIntelligence.Name = "nudIntelligence";
            this.nudIntelligence.Size = new System.Drawing.Size(41, 20);
            this.nudIntelligence.TabIndex = 18;
            this.nudIntelligence.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.Location = new System.Drawing.Point(347, 238);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(65, 23);
            this.lblIntelligence.TabIndex = 17;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // nudWisdom
            // 
            this.nudWisdom.Location = new System.Drawing.Point(350, 338);
            this.nudWisdom.Name = "nudWisdom";
            this.nudWisdom.Size = new System.Drawing.Size(41, 20);
            this.nudWisdom.TabIndex = 20;
            this.nudWisdom.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblWisdom
            // 
            this.lblWisdom.Location = new System.Drawing.Point(347, 312);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(65, 23);
            this.lblWisdom.TabIndex = 19;
            this.lblWisdom.Text = "Wisdom";
            // 
            // nudCharisma
            // 
            this.nudCharisma.Location = new System.Drawing.Point(350, 405);
            this.nudCharisma.Name = "nudCharisma";
            this.nudCharisma.Size = new System.Drawing.Size(41, 20);
            this.nudCharisma.TabIndex = 22;
            this.nudCharisma.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblCharisma
            // 
            this.lblCharisma.Location = new System.Drawing.Point(347, 379);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(65, 23);
            this.lblCharisma.TabIndex = 21;
            this.lblCharisma.Text = "Charisma";
            // 
            // lblExperience
            // 
            this.lblExperience.Location = new System.Drawing.Point(489, 35);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(96, 23);
            this.lblExperience.TabIndex = 24;
            this.lblExperience.Text = "Experience points";
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(591, 32);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.ReadOnly = true;
            this.txtExperience.Size = new System.Drawing.Size(121, 20);
            this.txtExperience.TabIndex = 23;
            this.txtExperience.Text = "27";
            // 
            // lblArmourClass
            // 
            this.lblArmourClass.Location = new System.Drawing.Point(489, 86);
            this.lblArmourClass.Name = "lblArmourClass";
            this.lblArmourClass.Size = new System.Drawing.Size(96, 23);
            this.lblArmourClass.TabIndex = 26;
            this.lblArmourClass.Text = "Armour Class";
            // 
            // txtArmourClass
            // 
            this.txtArmourClass.Location = new System.Drawing.Point(591, 83);
            this.txtArmourClass.Name = "txtArmourClass";
            this.txtArmourClass.Size = new System.Drawing.Size(121, 20);
            this.txtArmourClass.TabIndex = 25;
            this.txtArmourClass.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Location = new System.Drawing.Point(489, 132);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(96, 23);
            this.lblSpeed.TabIndex = 28;
            this.lblSpeed.Text = "Speed";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(591, 129);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(121, 20);
            this.txtSpeed.TabIndex = 0;
            this.txtSpeed.Text = "0";
            // 
            // lblHealth
            // 
            this.lblHealth.Location = new System.Drawing.Point(489, 185);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(96, 23);
            this.lblHealth.TabIndex = 30;
            this.lblHealth.Text = "Health points";
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(591, 182);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(121, 20);
            this.txtHealth.TabIndex = 29;
            this.txtHealth.Text = "0";
            // 
            // lblInitiative
            // 
            this.lblInitiative.Location = new System.Drawing.Point(489, 237);
            this.lblInitiative.Name = "lblInitiative";
            this.lblInitiative.Size = new System.Drawing.Size(96, 23);
            this.lblInitiative.TabIndex = 32;
            this.lblInitiative.Text = "Initiative";
            // 
            // txtInitative
            // 
            this.txtInitative.Location = new System.Drawing.Point(591, 234);
            this.txtInitative.Name = "txtInitative";
            this.txtInitative.Size = new System.Drawing.Size(121, 20);
            this.txtInitative.TabIndex = 31;
            this.txtInitative.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(578, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 43);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(97, 379);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(134, 43);
            this.btnAccept.TabIndex = 34;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.Location = new System.Drawing.Point(107, 266);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(89, 23);
            this.lblClassDescription.TabIndex = 35;
            this.lblClassDescription.Text = "Class Description";
            // 
            // lblRaceDescription
            // 
            this.lblRaceDescription.Location = new System.Drawing.Point(588, 266);
            this.lblRaceDescription.Name = "lblRaceDescription";
            this.lblRaceDescription.Size = new System.Drawing.Size(89, 23);
            this.lblRaceDescription.TabIndex = 36;
            this.lblRaceDescription.Text = "Race Description";
            // 
            // rtbClassDescription
            // 
            this.rtbClassDescription.Location = new System.Drawing.Point(63, 297);
            this.rtbClassDescription.Name = "rtbClassDescription";
            this.rtbClassDescription.Size = new System.Drawing.Size(168, 61);
            this.rtbClassDescription.TabIndex = 37;
            this.rtbClassDescription.Text = "";
            // 
            // rtbRaceDescription
            // 
            this.rtbRaceDescription.Location = new System.Drawing.Point(544, 297);
            this.rtbRaceDescription.Name = "rtbRaceDescription";
            this.rtbRaceDescription.Size = new System.Drawing.Size(168, 61);
            this.rtbRaceDescription.TabIndex = 38;
            this.rtbRaceDescription.Text = "";
            // 
            // cboLevel
            // 
            this.cboLevel.DisplayMember = "(";
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboLevel.Location = new System.Drawing.Point(110, 228);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 21);
            this.cboLevel.TabIndex = 40;
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(60, 231);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 23);
            this.lblLevel.TabIndex = 39;
            this.lblLevel.Text = "Level";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(110, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // frmCharacterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.rtbRaceDescription);
            this.Controls.Add(this.rtbClassDescription);
            this.Controls.Add(this.lblRaceDescription);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInitiative);
            this.Controls.Add(this.txtInitative);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblArmourClass);
            this.Controls.Add(this.txtArmourClass);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.nudCharisma);
            this.Controls.Add(this.lblCharisma);
            this.Controls.Add(this.nudWisdom);
            this.Controls.Add(this.lblWisdom);
            this.Controls.Add(this.nudIntelligence);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.nudConstitution);
            this.Controls.Add(this.lblConstitution);
            this.Controls.Add(this.nudDexterity);
            this.Controls.Add(this.lblDexterity);
            this.Controls.Add(this.nudStrength);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbxAlignment);
            this.Controls.Add(this.lblAlignment);
            this.Controls.Add(this.cbxRace);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "frmCharacterEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Character";
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.ComboBox cbxRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox cbxAlignment;
        private System.Windows.Forms.Label lblAlignment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.NumericUpDown nudDexterity;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.NumericUpDown nudConstitution;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.NumericUpDown nudIntelligence;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.NumericUpDown nudWisdom;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.NumericUpDown nudCharisma;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label lblArmourClass;
        private System.Windows.Forms.TextBox txtArmourClass;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Label lblInitiative;
        private System.Windows.Forms.TextBox txtInitative;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.Label lblRaceDescription;
        private System.Windows.Forms.RichTextBox rtbClassDescription;
        private System.Windows.Forms.RichTextBox rtbRaceDescription;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}