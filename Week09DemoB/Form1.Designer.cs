namespace Week09DemoB
{
    partial class Form1
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnsaveas = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(673, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(115, 44);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(673, 369);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(115, 44);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnsaveas
            // 
            this.btnsaveas.Location = new System.Drawing.Point(550, 369);
            this.btnsaveas.Name = "btnsaveas";
            this.btnsaveas.Size = new System.Drawing.Size(115, 44);
            this.btnsaveas.TabIndex = 2;
            this.btnsaveas.Text = "save as";
            this.btnsaveas.UseVisualStyleBackColor = true;
            this.btnsaveas.Click += new System.EventHandler(this.btnsaveas_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(12, 12);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(115, 44);
            this.btnopen.TabIndex = 3;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(13, 76);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(65, 23);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "File Path";
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(85, 76);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(668, 22);
            this.txtfilepath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Content";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(85, 117);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(668, 223);
            this.rtbContent.TabIndex = 7;
            this.rtbContent.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnsaveas);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnexit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnsaveas;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

