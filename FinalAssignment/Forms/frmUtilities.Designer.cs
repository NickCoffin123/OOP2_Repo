namespace FinalAssignment.Forms
{
    partial class frmUtilities
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
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rabLightDark = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1064, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Workout Utilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(107, 240);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(197, 36);
            this.lblBMI.TabIndex = 1;
            this.lblBMI.Text = "Calculate BMI";
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIResult.Location = new System.Drawing.Point(751, 240);
            this.lblBMIResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(197, 36);
            this.lblBMIResult.TabIndex = 2;
            this.lblBMIResult.Text = "-";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(357, 249);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(160, 22);
            this.nudHeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nudHeight, "Height");
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(563, 249);
            this.nudWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(160, 22);
            this.nudWeight.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nudWeight, "Weight");
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(563, 193);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(160, 36);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(357, 193);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(160, 36);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height(m)";
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(443, 300);
            this.btnBMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(185, 28);
            this.btnBMI.TabIndex = 3;
            this.btnBMI.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.btnBMI, "Calculate BMI");
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 480);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Workout Log";
            this.toolTip1.SetToolTip(this.button3, "Workout Page");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(631, 480);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "&Exit";
            this.toolTip1.SetToolTip(this.button4, "Exit");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rabLightDark
            // 
            this.rabLightDark.AutoSize = true;
            this.rabLightDark.Location = new System.Drawing.Point(52, 112);
            this.rabLightDark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rabLightDark.Name = "rabLightDark";
            this.rabLightDark.Size = new System.Drawing.Size(95, 20);
            this.rabLightDark.TabIndex = 17;
            this.rabLightDark.TabStop = true;
            this.rabLightDark.Text = "Light / Dark";
            this.rabLightDark.UseVisualStyleBackColor = true;
            // 
            // frmUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rabLightDark);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.lblBMIResult);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUtilities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUtilities";
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBMIResult;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rabLightDark;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}