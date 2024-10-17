namespace Week06DemoA
{
    partial class frmDroidEditor
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpCreator = new System.Windows.Forms.GroupBox();
            this.btnResetDroid = new System.Windows.Forms.Button();
            this.btnSaveDroid = new System.Windows.Forms.Button();
            this.btnSecondaryColour = new System.Windows.Forms.Button();
            this.lblSecondaryColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetPrimaryColour = new System.Windows.Forms.Button();
            this.lblPrimaryColour = new System.Windows.Forms.Label();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.chkInService = new System.Windows.Forms.CheckBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignationLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDroid = new System.Windows.Forms.Label();
            this.lblDroidDesignation = new System.Windows.Forms.Label();
            this.grpCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreator
            // 
            this.grpCreator.BackColor = System.Drawing.Color.Transparent;
            this.grpCreator.Controls.Add(this.btnClose);
            this.grpCreator.Controls.Add(this.btnResetDroid);
            this.grpCreator.Controls.Add(this.btnSaveDroid);
            this.grpCreator.Controls.Add(this.btnSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondaryColour);
            this.grpCreator.Controls.Add(this.lblSecondColourLabel);
            this.grpCreator.Controls.Add(this.btnSetPrimaryColour);
            this.grpCreator.Controls.Add(this.lblPrimaryColour);
            this.grpCreator.Controls.Add(this.lblColour1Label);
            this.grpCreator.Controls.Add(this.txtOwner);
            this.grpCreator.Controls.Add(this.lblOwner);
            this.grpCreator.Controls.Add(this.chkInService);
            this.grpCreator.Controls.Add(this.txtDesignation);
            this.grpCreator.Controls.Add(this.lblDesignationLabel);
            this.grpCreator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpCreator.Location = new System.Drawing.Point(12, 46);
            this.grpCreator.Name = "grpCreator";
            this.grpCreator.Size = new System.Drawing.Size(397, 230);
            this.grpCreator.TabIndex = 6;
            this.grpCreator.TabStop = false;
            this.grpCreator.Text = "Droid Creator";
            // 
            // btnResetDroid
            // 
            this.btnResetDroid.Location = new System.Drawing.Point(15, 175);
            this.btnResetDroid.Name = "btnResetDroid";
            this.btnResetDroid.Size = new System.Drawing.Size(64, 33);
            this.btnResetDroid.TabIndex = 12;
            this.btnResetDroid.Text = "&Reset";
            this.btnResetDroid.UseVisualStyleBackColor = true;
            this.btnResetDroid.Click += new System.EventHandler(this.btnResetDroid_Click);
            // 
            // btnSaveDroid
            // 
            this.btnSaveDroid.Location = new System.Drawing.Point(285, 175);
            this.btnSaveDroid.Name = "btnSaveDroid";
            this.btnSaveDroid.Size = new System.Drawing.Size(91, 34);
            this.btnSaveDroid.TabIndex = 11;
            this.btnSaveDroid.Text = "&Save Droid";
            this.btnSaveDroid.UseVisualStyleBackColor = true;
            this.btnSaveDroid.Click += new System.EventHandler(this.btnSaveDroid_Click);
            // 
            // btnSecondaryColour
            // 
            this.btnSecondaryColour.Location = new System.Drawing.Point(315, 120);
            this.btnSecondaryColour.Name = "btnSecondaryColour";
            this.btnSecondaryColour.Size = new System.Drawing.Size(39, 33);
            this.btnSecondaryColour.TabIndex = 10;
            this.btnSecondaryColour.Text = "Set";
            this.btnSecondaryColour.UseVisualStyleBackColor = true;
            this.btnSecondaryColour.Click += new System.EventHandler(this.btnSecondaryColour_Click);
            // 
            // lblSecondaryColour
            // 
            this.lblSecondaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblSecondaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondaryColour.Location = new System.Drawing.Point(272, 120);
            this.lblSecondaryColour.Name = "lblSecondaryColour";
            this.lblSecondaryColour.Size = new System.Drawing.Size(37, 33);
            this.lblSecondaryColour.TabIndex = 9;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(200, 120);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(75, 45);
            this.lblSecondColourLabel.TabIndex = 8;
            this.lblSecondColourLabel.Text = "Secondary Colour";
            // 
            // btnSetPrimaryColour
            // 
            this.btnSetPrimaryColour.Location = new System.Drawing.Point(118, 120);
            this.btnSetPrimaryColour.Name = "btnSetPrimaryColour";
            this.btnSetPrimaryColour.Size = new System.Drawing.Size(39, 33);
            this.btnSetPrimaryColour.TabIndex = 7;
            this.btnSetPrimaryColour.Text = "Set";
            this.btnSetPrimaryColour.UseVisualStyleBackColor = true;
            this.btnSetPrimaryColour.Click += new System.EventHandler(this.btnSetPrimaryColour_Click);
            // 
            // lblPrimaryColour
            // 
            this.lblPrimaryColour.BackColor = System.Drawing.Color.Gray;
            this.lblPrimaryColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimaryColour.Location = new System.Drawing.Point(75, 120);
            this.lblPrimaryColour.Name = "lblPrimaryColour";
            this.lblPrimaryColour.Size = new System.Drawing.Size(37, 33);
            this.lblPrimaryColour.TabIndex = 6;
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColour1Label.Location = new System.Drawing.Point(15, 120);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(65, 45);
            this.lblColour1Label.TabIndex = 5;
            this.lblColour1Label.Text = "Primary Colour";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(108, 71);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(267, 27);
            this.txtOwner.TabIndex = 4;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOwner.Location = new System.Drawing.Point(15, 75);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(42, 15);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "Owner";
            // 
            // chkInService
            // 
            this.chkInService.AutoSize = true;
            this.chkInService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkInService.Location = new System.Drawing.Point(267, 40);
            this.chkInService.Name = "chkInService";
            this.chkInService.Size = new System.Drawing.Size(76, 19);
            this.chkInService.TabIndex = 2;
            this.chkInService.Text = "In Service";
            this.chkInService.UseVisualStyleBackColor = true;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(108, 36);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(139, 27);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignationLabel
            // 
            this.lblDesignationLabel.AutoSize = true;
            this.lblDesignationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesignationLabel.Location = new System.Drawing.Point(15, 39);
            this.lblDesignationLabel.Name = "lblDesignationLabel";
            this.lblDesignationLabel.Size = new System.Drawing.Size(70, 15);
            this.lblDesignationLabel.TabIndex = 0;
            this.lblDesignationLabel.Text = "Designation";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDroid
            // 
            this.lblDroid.AutoSize = true;
            this.lblDroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroid.Location = new System.Drawing.Point(33, 13);
            this.lblDroid.Name = "lblDroid";
            this.lblDroid.Size = new System.Drawing.Size(47, 20);
            this.lblDroid.TabIndex = 7;
            this.lblDroid.Text = "Droid";
            // 
            // lblDroidDesignation
            // 
            this.lblDroidDesignation.AutoSize = true;
            this.lblDroidDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroidDesignation.Location = new System.Drawing.Point(86, 13);
            this.lblDroidDesignation.Name = "lblDroidDesignation";
            this.lblDroidDesignation.Size = new System.Drawing.Size(14, 20);
            this.lblDroidDesignation.TabIndex = 8;
            this.lblDroidDesignation.Text = "-";
            // 
            // frmDroidEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 279);
            this.Controls.Add(this.lblDroidDesignation);
            this.Controls.Add(this.lblDroid);
            this.Controls.Add(this.grpCreator);
            this.Name = "frmDroidEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droid Editor";
            this.grpCreator.ResumeLayout(false);
            this.grpCreator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox grpCreator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnResetDroid;
        private System.Windows.Forms.Button btnSaveDroid;
        private System.Windows.Forms.Button btnSecondaryColour;
        private System.Windows.Forms.Label lblSecondaryColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetPrimaryColour;
        private System.Windows.Forms.Label lblPrimaryColour;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.CheckBox chkInService;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignationLabel;
        private System.Windows.Forms.Label lblDroid;
        private System.Windows.Forms.Label lblDroidDesignation;
    }
}