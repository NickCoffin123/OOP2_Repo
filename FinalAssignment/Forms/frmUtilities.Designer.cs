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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblWeightCal = new System.Windows.Forms.Label();
            this.nudWeightCal = new System.Windows.Forms.NumericUpDown();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblCaloriesResult = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnCalories = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rabLightDark = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(798, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Workout Utilities";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(77, 149);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(148, 29);
            this.lblBMI.TabIndex = 1;
            this.lblBMI.Text = "Calculate BMI";
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIResult.Location = new System.Drawing.Point(560, 149);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(148, 29);
            this.lblBMIResult.TabIndex = 2;
            this.lblBMIResult.Text = "-";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(265, 156);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 3;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(419, 156);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 20);
            this.nudWeight.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(419, 111);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(120, 29);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(265, 111);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(120, 29);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height(m)";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(265, 236);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(120, 29);
            this.lblDuration.TabIndex = 12;
            this.lblDuration.Text = "Duration(h)";
            // 
            // lblWeightCal
            // 
            this.lblWeightCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightCal.Location = new System.Drawing.Point(419, 236);
            this.lblWeightCal.Name = "lblWeightCal";
            this.lblWeightCal.Size = new System.Drawing.Size(120, 29);
            this.lblWeightCal.TabIndex = 11;
            this.lblWeightCal.Text = "Weight(kg)";
            // 
            // nudWeightCal
            // 
            this.nudWeightCal.Location = new System.Drawing.Point(419, 281);
            this.nudWeightCal.Name = "nudWeightCal";
            this.nudWeightCal.Size = new System.Drawing.Size(120, 20);
            this.nudWeightCal.TabIndex = 10;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(265, 281);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(120, 20);
            this.nudDuration.TabIndex = 9;
            // 
            // lblCaloriesResult
            // 
            this.lblCaloriesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesResult.Location = new System.Drawing.Point(560, 274);
            this.lblCaloriesResult.Name = "lblCaloriesResult";
            this.lblCaloriesResult.Size = new System.Drawing.Size(148, 29);
            this.lblCaloriesResult.TabIndex = 8;
            this.lblCaloriesResult.Text = "-";
            // 
            // lblCalories
            // 
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(59, 274);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(166, 29);
            this.lblCalories.TabIndex = 7;
            this.lblCalories.Text = "Calories Burned";
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(329, 198);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(139, 23);
            this.btnBMI.TabIndex = 13;
            this.btnBMI.Text = "&Calculate";
            this.btnBMI.UseVisualStyleBackColor = true;
            // 
            // btnCalories
            // 
            this.btnCalories.Location = new System.Drawing.Point(329, 330);
            this.btnCalories.Name = "btnCalories";
            this.btnCalories.Size = new System.Drawing.Size(139, 23);
            this.btnCalories.TabIndex = 14;
            this.btnCalories.Text = "&Calculate";
            this.btnCalories.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "&Workout Log";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "&Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rabLightDark
            // 
            this.rabLightDark.AutoSize = true;
            this.rabLightDark.Location = new System.Drawing.Point(22, 74);
            this.rabLightDark.Name = "rabLightDark";
            this.rabLightDark.Size = new System.Drawing.Size(82, 17);
            this.rabLightDark.TabIndex = 17;
            this.rabLightDark.TabStop = true;
            this.rabLightDark.Text = "Light / Dark";
            this.rabLightDark.UseVisualStyleBackColor = true;
            // 
            // frmUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rabLightDark);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCalories);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblWeightCal);
            this.Controls.Add(this.nudWeightCal);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lblCaloriesResult);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.lblBMIResult);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmUtilities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUtilities";
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
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
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblWeightCal;
        private System.Windows.Forms.NumericUpDown nudWeightCal;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblCaloriesResult;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnCalories;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rabLightDark;
    }
}