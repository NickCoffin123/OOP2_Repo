namespace FinalAssignment.Forms
{
    partial class frmSplash
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
            this.timer1 = new System.Windows.Forms.Timer();
            this.lblTitleInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleInfo
            // 
            this.lblTitleInfo.Location = new System.Drawing.Point(27, 116);
            this.lblTitleInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleInfo.Name = "lblTitleInfo";
            this.lblTitleInfo.Size = new System.Drawing.Size(75, 41);
            this.lblTitleInfo.TabIndex = 4;
            this.lblTitleInfo.Text = "Nick Coffin\r\nOOP - 2\r\nOctober, 31";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalAssignment.Properties.Resources.Workout_Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 229);
            this.Controls.Add(this.lblTitleInfo);
            this.DoubleBuffered = true;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitleInfo;
    }
}