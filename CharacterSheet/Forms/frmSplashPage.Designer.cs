namespace CharacterSheet
{
    partial class frmSplashPage
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(50, 385);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(134, 43);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Enter");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitMain.Location = new System.Drawing.Point(654, 385);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(134, 43);
            this.btnExitMain.TabIndex = 2;
            this.btnExitMain.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExitMain, "Exit");
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // frmSplashPage
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CharacterSheet.Properties.Resources.dnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnExitMain;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.btnEnter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSplashPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

