namespace Week02DemoA
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lbxSoccerTeams = new System.Windows.Forms.ListBox();
            this.lblMySoccerTeam = new System.Windows.Forms.Label();
            this.txtMySoccerTeam = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(-2, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(811, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My Soccer Teams";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lbxSoccerTeams
            // 
            this.lbxSoccerTeams.FormattingEnabled = true;
            this.lbxSoccerTeams.ItemHeight = 16;
            this.lbxSoccerTeams.Location = new System.Drawing.Point(12, 133);
            this.lbxSoccerTeams.Name = "lbxSoccerTeams";
            this.lbxSoccerTeams.Size = new System.Drawing.Size(369, 404);
            this.lbxSoccerTeams.TabIndex = 3;
            this.lbxSoccerTeams.SelectedIndexChanged += new System.EventHandler(this.lbxSoccerTeams_SelectedIndexChanged);
            // 
            // lblMySoccerTeam
            // 
            this.lblMySoccerTeam.AutoSize = true;
            this.lblMySoccerTeam.Location = new System.Drawing.Point(428, 95);
            this.lblMySoccerTeam.Name = "lblMySoccerTeam";
            this.lblMySoccerTeam.Size = new System.Drawing.Size(77, 16);
            this.lblMySoccerTeam.TabIndex = 2;
            this.lblMySoccerTeam.Text = "Enter Team";
            // 
            // txtMySoccerTeam
            // 
            this.txtMySoccerTeam.Location = new System.Drawing.Point(511, 92);
            this.txtMySoccerTeam.Name = "txtMySoccerTeam";
            this.txtMySoccerTeam.Size = new System.Drawing.Size(279, 22);
            this.txtMySoccerTeam.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(506, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 58);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(654, 488);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 58);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(12, 88);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(95, 23);
            this.btnDeselect.TabIndex = 2;
            this.btnDeselect.Text = "&Deselect";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(808, 558);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMySoccerTeam);
            this.Controls.Add(this.lblMySoccerTeam);
            this.Controls.Add(this.lbxSoccerTeams);
            this.Controls.Add(this.lblHeader);
            this.MinimumSize = new System.Drawing.Size(826, 605);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Soccer Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lbxSoccerTeams;
        private System.Windows.Forms.Label lblMySoccerTeam;
        private System.Windows.Forms.TextBox txtMySoccerTeam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeselect;
    }
}

