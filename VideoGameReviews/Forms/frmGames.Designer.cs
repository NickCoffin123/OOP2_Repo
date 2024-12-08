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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.rtbReview = new System.Windows.Forms.RichTextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.nudReview = new System.Windows.Forms.NumericUpDown();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.tsmLogOut.Click += new System.EventHandler(this.tsmLogOut_Click);
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
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1091, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslCurrentUser
            // 
            this.tslCurrentUser.Name = "tslCurrentUser";
            this.tslCurrentUser.Size = new System.Drawing.Size(85, 20);
            this.tslCurrentUser.Text = "Welcome - ";
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
            this.txtGameTitle.Location = new System.Drawing.Point(143, 62);
            this.txtGameTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(200, 22);
            this.txtGameTitle.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtGameTitle, "Game name");
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.BackColor = System.Drawing.Color.Transparent;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(32, 121);
            this.lblReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(104, 31);
            this.lblReview.TabIndex = 15;
            this.lblReview.Text = "Review";
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
            this.rtbReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbReview.Name = "rtbReview";
            this.rtbReview.Size = new System.Drawing.Size(248, 63);
            this.rtbReview.TabIndex = 1;
            this.rtbReview.Text = "";
            this.toolTip1.SetToolTip(this.rtbReview, "Game review");
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.Color.Transparent;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(571, 52);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(93, 31);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Rating";
            // 
            // nudReview
            // 
            this.nudReview.Location = new System.Drawing.Point(697, 62);
            this.nudReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudReview.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudReview.Name = "nudReview";
            this.nudReview.Size = new System.Drawing.Size(109, 22);
            this.nudReview.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nudReview, "Game Rating");
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(577, 117);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(121, 49);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "&Post";
            this.toolTip1.SetToolTip(this.btnPost, "Post Review");
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(749, 117);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Review");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Genre,
            this.ReleaseDate,
            this.GameID});
            this.dgvGames.Location = new System.Drawing.Point(0, 183);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersWidth = 51;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.Size = new System.Drawing.Size(549, 446);
            this.dgvGames.TabIndex = 22;
            this.dgvGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGames_CellContentClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 140;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 125;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 95;
            // 
            // GameID
            // 
            this.GameID.DataPropertyName = "GameID";
            this.GameID.HeaderText = "GameID";
            this.GameID.MinimumWidth = 6;
            this.GameID.Name = "GameID";
            this.GameID.ReadOnly = true;
            this.GameID.Visible = false;
            this.GameID.Width = 125;
            // 
            // dgvReviews
            // 
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rating,
            this.ReviewId,
            this.Review,
            this.ReviewDate});
            this.dgvReviews.Location = new System.Drawing.Point(556, 183);
            this.dgvReviews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.RowHeadersWidth = 51;
            this.dgvReviews.RowTemplate.Height = 24;
            this.dgvReviews.Size = new System.Drawing.Size(533, 446);
            this.dgvReviews.TabIndex = 23;
            this.dgvReviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReviews_CellContentClick);
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 50;
            // 
            // ReviewId
            // 
            this.ReviewId.DataPropertyName = "ReviewID";
            this.ReviewId.HeaderText = "ReviewId";
            this.ReviewId.MinimumWidth = 6;
            this.ReviewId.Name = "ReviewId";
            this.ReviewId.ReadOnly = true;
            this.ReviewId.Visible = false;
            this.ReviewId.Width = 125;
            // 
            // Review
            // 
            this.Review.DataPropertyName = "ReviewText";
            this.Review.HeaderText = "Review";
            this.Review.MinimumWidth = 6;
            this.Review.Name = "Review";
            this.Review.ReadOnly = true;
            this.Review.Width = 175;
            // 
            // ReviewDate
            // 
            this.ReviewDate.DataPropertyName = "ReviewDate";
            this.ReviewDate.HeaderText = "Review Date";
            this.ReviewDate.MinimumWidth = 6;
            this.ReviewDate.Name = "ReviewDate";
            this.ReviewDate.ReadOnly = true;
            this.ReviewDate.Width = 125;
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 658);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.nudReview);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.rtbReview);
            this.Controls.Add(this.txtGameTitle);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.RichTextBox rtbReview;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown nudReview;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Review;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

