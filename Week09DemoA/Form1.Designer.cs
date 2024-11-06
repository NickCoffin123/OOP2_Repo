namespace Week09DemoA
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.cbxOperator = new System.Windows.Forms.ComboBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.btnEqu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(12, 283);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(776, 158);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "-";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(407, 224);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(92, 32);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "label2";
            // 
            // cbxOperator
            // 
            this.cbxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOperator.FormattingEnabled = true;
            this.cbxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "x^y",
            "sqrt"});
            this.cbxOperator.Location = new System.Drawing.Point(117, 124);
            this.cbxOperator.Name = "cbxOperator";
            this.cbxOperator.Size = new System.Drawing.Size(121, 39);
            this.cbxOperator.TabIndex = 2;
            // 
            // nud1
            // 
            this.nud1.DecimalPlaces = 3;
            this.nud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud1.Location = new System.Drawing.Point(410, 114);
            this.nud1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 38);
            this.nud1.TabIndex = 3;
            // 
            // nud2
            // 
            this.nud2.DecimalPlaces = 3;
            this.nud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud2.Location = new System.Drawing.Point(410, 162);
            this.nud2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 38);
            this.nud2.TabIndex = 4;
            // 
            // btnEqu
            // 
            this.btnEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqu.Location = new System.Drawing.Point(142, 203);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(96, 53);
            this.btnEqu.TabIndex = 5;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.cbxOperator);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ComboBox cbxOperator;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.Button btnEqu;
    }
}

