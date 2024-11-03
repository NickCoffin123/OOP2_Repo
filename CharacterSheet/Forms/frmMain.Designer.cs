namespace CharacterSheet
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
            this.lblCharacters = new System.Windows.Forms.Label();
            this.lbxCharacters = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExitCharacter = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCharacters
            // 
            this.lblCharacters.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacters.Location = new System.Drawing.Point(177, 32);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(239, 38);
            this.lblCharacters.TabIndex = 0;
            this.lblCharacters.Text = "Character List";
            // 
            // lbxCharacters
            // 
            this.lbxCharacters.FormattingEnabled = true;
            this.lbxCharacters.Location = new System.Drawing.Point(202, 73);
            this.lbxCharacters.Name = "lbxCharacters";
            this.lbxCharacters.Size = new System.Drawing.Size(172, 316);
            this.lbxCharacters.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lbxCharacters, "Character list");
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(450, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "&Create Character";
            this.toolTip1.SetToolTip(this.btnCreate, "Create character");
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(450, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 48);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit Character";
            this.toolTip1.SetToolTip(this.btnEdit, "Edit character");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExitCharacter
            // 
            this.btnExitCharacter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitCharacter.Location = new System.Drawing.Point(450, 305);
            this.btnExitCharacter.Name = "btnExitCharacter";
            this.btnExitCharacter.Size = new System.Drawing.Size(130, 48);
            this.btnExitCharacter.TabIndex = 3;
            this.btnExitCharacter.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExitCharacter, "Exit");
            this.btnExitCharacter.UseVisualStyleBackColor = true;
            this.btnExitCharacter.Click += new System.EventHandler(this.btnExitCharacter_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitCharacter;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitCharacter);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbxCharacters);
            this.Controls.Add(this.lblCharacters);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCharacters;
        private System.Windows.Forms.ListBox lbxCharacters;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExitCharacter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}