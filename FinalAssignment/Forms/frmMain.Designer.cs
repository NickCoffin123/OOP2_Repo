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
            this.components = new System.ComponentModel.Container();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1064, 95);
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
            this.dgvWorkouts.Location = new System.Drawing.Point(517, 101);
            this.dgvWorkouts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.ReadOnly = true;
            this.dgvWorkouts.RowHeadersWidth = 51;
            this.dgvWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWorkouts.Size = new System.Drawing.Size(460, 382);
            this.dgvWorkouts.TabIndex = 2;
            this.dgvWorkouts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkouts_CellContentClick);
            // 
            // WorkoutID
            // 
            this.WorkoutID.DataPropertyName = "WorkoutID";
            this.WorkoutID.HeaderText = "WorkoutID";
            this.WorkoutID.MinimumWidth = 6;
            this.WorkoutID.Name = "WorkoutID";
            this.WorkoutID.ReadOnly = true;
            this.WorkoutID.Visible = false;
            this.WorkoutID.Width = 125;
            // 
            // WorkoutDesctiption
            // 
            this.WorkoutDesctiption.DataPropertyName = "WorkoutDescription";
            this.WorkoutDesctiption.HeaderText = "Desctiption";
            this.WorkoutDesctiption.MinimumWidth = 6;
            this.WorkoutDesctiption.Name = "WorkoutDesctiption";
            this.WorkoutDesctiption.ReadOnly = true;
            this.WorkoutDesctiption.Width = 125;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "WorkoutDate";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(777, 500);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 500);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add Workout";
            this.toolTip1.SetToolTip(this.btnAdd, "Add Workout");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 500);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete Workout";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Workout");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUtilities
            // 
            this.btnUtilities.Location = new System.Drawing.Point(540, 500);
            this.btnUtilities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUtilities.Name = "btnUtilities";
            this.btnUtilities.Size = new System.Drawing.Size(175, 39);
            this.btnUtilities.TabIndex = 5;
            this.btnUtilities.Text = "&Utilities";
            this.toolTip1.SetToolTip(this.btnUtilities, "Utilities Page");
            this.btnUtilities.UseVisualStyleBackColor = true;
            this.btnUtilities.Click += new System.EventHandler(this.btnUtilities_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(49, 177);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(193, 42);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(56, 270);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(187, 42);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(236, 188);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(159, 22);
            this.txtDescription.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDescription, "Workout Description");
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(236, 282);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(160, 22);
            this.nudDuration.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nudDuration, "Workout Duration");
            // 
            // rabLightDark
            // 
            this.rabLightDark.AutoSize = true;
            this.rabLightDark.Location = new System.Drawing.Point(16, 76);
            this.rabLightDark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rabLightDark.Name = "rabLightDark";
            this.rabLightDark.Size = new System.Drawing.Size(95, 20);
            this.rabLightDark.TabIndex = 18;
            this.rabLightDark.TabStop = true;
            this.rabLightDark.Text = "Light / Dark";
            this.rabLightDark.UseVisualStyleBackColor = true;
            this.rabLightDark.CheckedChanged += new System.EventHandler(this.rabLightDark_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

