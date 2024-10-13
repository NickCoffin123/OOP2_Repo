namespace Battleship
{
    partial class Battleship
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShipsSunk = new System.Windows.Forms.Label();
            this.lblShipOne = new System.Windows.Forms.Label();
            this.lblShipTwo = new System.Windows.Forms.Label();
            this.lblShipThree = new System.Windows.Forms.Label();
            this.lblShipFour = new System.Windows.Forms.Label();
            this.lblShipFive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudShotCount = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudShotCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-5, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(733, 67);
            this.lblTitle.TabIndex = 110;
            this.lblTitle.Text = "BATTLESHIP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipsSunk
            // 
            this.lblShipsSunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipsSunk.Location = new System.Drawing.Point(442, 85);
            this.lblShipsSunk.Name = "lblShipsSunk";
            this.lblShipsSunk.Size = new System.Drawing.Size(252, 60);
            this.lblShipsSunk.TabIndex = 111;
            this.lblShipsSunk.Text = "Ship Counter";
            this.lblShipsSunk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipOne
            // 
            this.lblShipOne.BackColor = System.Drawing.Color.White;
            this.lblShipOne.Location = new System.Drawing.Point(444, 145);
            this.lblShipOne.Name = "lblShipOne";
            this.lblShipOne.Size = new System.Drawing.Size(36, 60);
            this.lblShipOne.TabIndex = 112;
            // 
            // lblShipTwo
            // 
            this.lblShipTwo.BackColor = System.Drawing.Color.White;
            this.lblShipTwo.Location = new System.Drawing.Point(495, 145);
            this.lblShipTwo.Name = "lblShipTwo";
            this.lblShipTwo.Size = new System.Drawing.Size(36, 60);
            this.lblShipTwo.TabIndex = 114;
            // 
            // lblShipThree
            // 
            this.lblShipThree.BackColor = System.Drawing.Color.White;
            this.lblShipThree.Location = new System.Drawing.Point(546, 145);
            this.lblShipThree.Name = "lblShipThree";
            this.lblShipThree.Size = new System.Drawing.Size(36, 60);
            this.lblShipThree.TabIndex = 115;
            // 
            // lblShipFour
            // 
            this.lblShipFour.BackColor = System.Drawing.Color.White;
            this.lblShipFour.Location = new System.Drawing.Point(597, 145);
            this.lblShipFour.Name = "lblShipFour";
            this.lblShipFour.Size = new System.Drawing.Size(36, 60);
            this.lblShipFour.TabIndex = 116;
            // 
            // lblShipFive
            // 
            this.lblShipFive.BackColor = System.Drawing.Color.White;
            this.lblShipFive.Location = new System.Drawing.Point(648, 145);
            this.lblShipFive.Name = "lblShipFive";
            this.lblShipFive.Size = new System.Drawing.Size(36, 60);
            this.lblShipFive.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 60);
            this.label1.TabIndex = 118;
            this.label1.Text = "Shot counter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudShotCount
            // 
            this.nudShotCount.Enabled = false;
            this.nudShotCount.Location = new System.Drawing.Point(513, 288);
            this.nudShotCount.Name = "nudShotCount";
            this.nudShotCount.Size = new System.Drawing.Size(120, 20);
            this.nudShotCount.TabIndex = 119;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(513, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 44);
            this.btnReset.TabIndex = 120;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(513, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 44);
            this.btnExit.TabIndex = 121;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nudShotCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShipFive);
            this.Controls.Add(this.lblShipFour);
            this.Controls.Add(this.lblShipThree);
            this.Controls.Add(this.lblShipTwo);
            this.Controls.Add(this.lblShipOne);
            this.Controls.Add(this.lblShipsSunk);
            this.Controls.Add(this.lblTitle);
            this.Name = "Battleship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship";
            ((System.ComponentModel.ISupportInitialize)(this.nudShotCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblShipsSunk;
        private System.Windows.Forms.Label lblShipOne;
        private System.Windows.Forms.Label lblShipTwo;
        private System.Windows.Forms.Label lblShipThree;
        private System.Windows.Forms.Label lblShipFour;
        private System.Windows.Forms.Label lblShipFive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudShotCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

