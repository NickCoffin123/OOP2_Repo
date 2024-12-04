namespace VideoGameReviews
{
    partial class frmGames
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tslCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.lblReviewDescription = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.rtbReview = new System.Windows.Forms.RichTextBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.nudReview = new System.Windows.Forms.NumericUpDown();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1090, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogOut});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(46, 24);
            this.tsmFile.Text = "File";
            // 
            // tsmLogOut
            // 
            this.tsmLogOut.Name = "tsmLogOut";
            this.tsmLogOut.Size = new System.Drawing.Size(224, 26);
            this.tsmLogOut.Text = "Log Out";
            // 
            // tsmWindow
            // 
            this.tsmWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClose});
            this.tsmWindow.Name = "tsmWindow";
            this.tsmWindow.Size = new System.Drawing.Size(78, 24);
            this.tsmWindow.Text = "Window";
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(224, 26);
            this.tsmClose.Text = "Close";
            // 
            // tslCurrentUser
            // 
            this.tslCurrentUser.Name = "tslCurrentUser";
            this.tslCurrentUser.Size = new System.Drawing.Size(15, 20);
            this.tslCurrentUser.Text = "-";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1090, 150);
            this.label1.TabIndex = 2;
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Enabled = false;
            this.txtGameTitle.Location = new System.Drawing.Point(143, 61);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(200, 22);
            this.txtGameTitle.TabIndex = 16;
            // 
            // lblReviewDescription
            // 
            this.lblReviewDescription.AutoSize = true;
            this.lblReviewDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewDescription.Location = new System.Drawing.Point(32, 121);
            this.lblReviewDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReviewDescription.Name = "lblReviewDescription";
            this.lblReviewDescription.Size = new System.Drawing.Size(104, 31);
            this.lblReviewDescription.TabIndex = 15;
            this.lblReviewDescription.Text = "Review";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(32, 52);
            this.lblGameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(87, 31);
            this.lblGameTitle.TabIndex = 14;
            this.lblGameTitle.Text = "Game";
            // 
            // rtbReview
            // 
            this.rtbReview.Location = new System.Drawing.Point(143, 105);
            this.rtbReview.Name = "rtbReview";
            this.rtbReview.Size = new System.Drawing.Size(248, 63);
            this.rtbReview.TabIndex = 17;
            this.rtbReview.Text = "";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.BackColor = System.Drawing.Color.Transparent;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(571, 52);
            this.lblReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(104, 31);
            this.lblReview.TabIndex = 18;
            this.lblReview.Text = "Review";
            // 
            // nudReview
            // 
            this.nudReview.Location = new System.Drawing.Point(697, 62);
            this.nudReview.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudReview.Name = "nudReview";
            this.nudReview.Size = new System.Drawing.Size(109, 22);
            this.nudReview.TabIndex = 19;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(577, 117);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(121, 49);
            this.btnPost.TabIndex = 20;
            this.btnPost.Text = "&Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(750, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 49);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvGames
            // 
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(0, 183);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.RowHeadersWidth = 51;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.Size = new System.Drawing.Size(550, 446);
            this.dgvGames.TabIndex = 22;
            // 
            // dgvReviews
            // 
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(556, 183);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.RowHeadersWidth = 51;
            this.dgvReviews.RowTemplate.Height = 24;
            this.dgvReviews.Size = new System.Drawing.Size(534, 446);
            this.dgvReviews.TabIndex = 23;
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 658);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.nudReview);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.rtbReview);
            this.Controls.Add(this.txtGameTitle);
            this.Controls.Add(this.lblReviewDescription);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.Load += new System.EventHandler(this.frmGames_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripStatusLabel tslCurrentUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Label lblReviewDescription;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.RichTextBox rtbReview;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.NumericUpDown nudReview;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.DataGridView dgvReviews;
    }
}

