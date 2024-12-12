namespace FinalAssignment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.WorkoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkoutDesctiption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUtilities = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.rabLightDark = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(798, 77);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Workout Log";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWorkouts
            // 
            this.dgvWorkouts.AllowUserToAddRows = false;
            this.dgvWorkouts.AllowUserToDeleteRows = false;
            this.dgvWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkouts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkoutID,
            this.WorkoutDesctiption,
            this.Duration,
            this.Date});
            this.dgvWorkouts.Location = new System.Drawing.Point(388, 82);
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.ReadOnly = true;
            this.dgvWorkouts.Size = new System.Drawing.Size(345, 310);
            this.dgvWorkouts.TabIndex = 2;
            // 
            // WorkoutID
            // 
            this.WorkoutID.DataPropertyName = "WorkoutID";
            this.WorkoutID.HeaderText = "WorkoutID";
            this.WorkoutID.Name = "WorkoutID";
            this.WorkoutID.ReadOnly = true;
            this.WorkoutID.Visible = false;
            // 
            // WorkoutDesctiption
            // 
            this.WorkoutDesctiption.DataPropertyName = "WorkoutDescription";
            this.WorkoutDesctiption.HeaderText = "Desctiption";
            this.WorkoutDesctiption.Name = "WorkoutDesctiption";
            this.WorkoutDesctiption.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "WorkoutDate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(583, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add Workout";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete Workout";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUtilities
            // 
            this.btnUtilities.Location = new System.Drawing.Point(405, 406);
            this.btnUtilities.Name = "btnUtilities";
            this.btnUtilities.Size = new System.Drawing.Size(131, 32);
            this.btnUtilities.TabIndex = 6;
            this.btnUtilities.Text = "&Utilities";
            this.btnUtilities.UseVisualStyleBackColor = true;
            this.btnUtilities.Click += new System.EventHandler(this.btnUtilities_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(37, 144);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 34);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(42, 219);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(140, 34);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(177, 153);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(120, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(177, 229);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(120, 20);
            this.nudDuration.TabIndex = 10;
            // 
            // rabLightDark
            // 
            this.rabLightDark.AutoSize = true;
            this.rabLightDark.Location = new System.Drawing.Point(12, 62);
            this.rabLightDark.Name = "rabLightDark";
            this.rabLightDark.Size = new System.Drawing.Size(82, 17);
            this.rabLightDark.TabIndex = 18;
            this.rabLightDark.TabStop = true;
            this.rabLightDark.Text = "Light / Dark";
            this.rabLightDark.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.rabLightDark);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnUtilities);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvWorkouts);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvWorkouts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUtilities;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.RadioButton rabLightDark;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkoutDesctiption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

