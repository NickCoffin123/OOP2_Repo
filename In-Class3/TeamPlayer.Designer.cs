namespace In_Class3
{
    partial class TeamPlayer
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
            this.lblPick = new System.Windows.Forms.Label();
            this.cboPick = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSet = new In_Class3.SportleaguesDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new In_Class3.SportleaguesDataSetTableAdapters.playersTableAdapter();
            this.dataTable1TableAdapter = new In_Class3.SportleaguesDataSetTableAdapters.DataTable1TableAdapter();
            this.teamsTableAdapter = new In_Class3.SportleaguesDataSetTableAdapters.teamsTableAdapter();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pibOne = new System.Windows.Forms.PictureBox();
            this.regnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPick
            // 
            this.lblPick.AutoSize = true;
            this.lblPick.Location = new System.Drawing.Point(191, 35);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(70, 13);
            this.lblPick.TabIndex = 0;
            this.lblPick.Text = "Pick a Team:";
            // 
            // cboPick
            // 
            this.cboPick.DataSource = this.teamsBindingSource1;
            this.cboPick.DisplayMember = "teamname";
            this.cboPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPick.FormattingEnabled = true;
            this.cboPick.Location = new System.Drawing.Point(267, 27);
            this.cboPick.Name = "cboPick";
            this.cboPick.Size = new System.Drawing.Size(121, 21);
            this.cboPick.TabIndex = 1;
            this.cboPick.ValueMember = "teamid";
            this.cboPick.SelectedIndexChanged += new System.EventHandler(this.cboPick_SelectedIndexChanged);
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "teams";
            this.teamsBindingSource1.DataSource = this.sportleaguesDataSetBindingSource;
            // 
            // sportleaguesDataSetBindingSource
            // 
            this.sportleaguesDataSetBindingSource.DataSource = this.sportleaguesDataSet;
            this.sportleaguesDataSetBindingSource.Position = 0;
            // 
            // sportleaguesDataSet
            // 
            this.sportleaguesDataSet.DataSetName = "SportleaguesDataSet";
            this.sportleaguesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regnumber,
            this.firstname,
            this.lastnameDataGridViewTextBoxColumn,
            this.jerseynumberDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.dataTable1BindingSource1;
            this.dgvMain.Location = new System.Drawing.Point(0, 71);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.Size = new System.Drawing.Size(816, 294);
            this.dgvMain.TabIndex = 2;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.sportleaguesDataSetBindingSource;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            // 
            // pibOne
            // 
            this.pibOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pibOne.Image = global::In_Class3.Properties.Resources.Hockeyflipped;
            this.pibOne.Location = new System.Drawing.Point(651, 71);
            this.pibOne.Name = "pibOne";
            this.pibOne.Size = new System.Drawing.Size(213, 422);
            this.pibOne.TabIndex = 3;
            this.pibOne.TabStop = false;
            // 
            // regnumber
            // 
            this.regnumber.DataPropertyName = "regnumber";
            this.regnumber.HeaderText = "Registration Number";
            this.regnumber.MinimumWidth = 6;
            this.regnumber.Name = "regnumber";
            this.regnumber.ReadOnly = true;
            this.regnumber.Width = 150;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.HeaderText = "First Name";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jerseynumberDataGridViewTextBoxColumn
            // 
            this.jerseynumberDataGridViewTextBoxColumn.DataPropertyName = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.HeaderText = "Jersey Number";
            this.jerseynumberDataGridViewTextBoxColumn.Name = "jerseynumberDataGridViewTextBoxColumn";
            this.jerseynumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.FalseValue = "0";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "Player Active";
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isactiveDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // TeamPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 364);
            this.Controls.Add(this.pibOne);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.cboPick);
            this.Controls.Add(this.lblPick);
            this.Name = "TeamPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team - Player Info";
            this.Load += new System.EventHandler(this.TeamPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.ComboBox cboPick;
        private System.Windows.Forms.DataGridView dgvMain;
        private SportleaguesDataSet sportleaguesDataSet;
        private SportleaguesDataSetTableAdapters.playersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private SportleaguesDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private SportleaguesDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource sportleaguesDataSetBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private System.Windows.Forms.PictureBox pibOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewTextBoxColumn;
    }
}

