namespace Week02DemoB
{
    partial class fmrMain
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
            this.mcaMonthCalender = new System.Windows.Forms.MonthCalendar();
            this.dtpMyBirthday = new System.Windows.Forms.DateTimePicker();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.cboThemeProg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mcaMonthCalender
            // 
            this.mcaMonthCalender.Location = new System.Drawing.Point(18, 18);
            this.mcaMonthCalender.Name = "mcaMonthCalender";
            this.mcaMonthCalender.TabIndex = 0;
            // 
            // dtpMyBirthday
            // 
            this.dtpMyBirthday.Location = new System.Drawing.Point(328, 18);
            this.dtpMyBirthday.Name = "dtpMyBirthday";
            this.dtpMyBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpMyBirthday.TabIndex = 1;
            // 
            // cboTheme
            // 
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboTheme.Location = new System.Drawing.Point(328, 46);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(200, 24);
            this.cboTheme.TabIndex = 2;
            // 
            // cboThemeProg
            // 
            this.cboThemeProg.FormattingEnabled = true;
            this.cboThemeProg.Location = new System.Drawing.Point(328, 76);
            this.cboThemeProg.Name = "cboThemeProg";
            this.cboThemeProg.Size = new System.Drawing.Size(200, 24);
            this.cboThemeProg.TabIndex = 3;
            this.cboThemeProg.SelectedIndexChanged += new System.EventHandler(this.cboThemeProg_SelectedIndexChanged);
            // 
            // fmrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboThemeProg);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.dtpMyBirthday);
            this.Controls.Add(this.mcaMonthCalender);
            this.Name = "fmrMain";
            this.Text = "My Calendar Picker";
            this.Load += new System.EventHandler(this.fmrMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcaMonthCalender;
        private System.Windows.Forms.DateTimePicker dtpMyBirthday;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.ComboBox cboThemeProg;
    }
}

