using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09DemoB
{
    public partial class Form1 : Form
    {

        String saveContent = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
            openFileDialog1.Title = "Open a file";
            openFileDialog1.FileName = txtfilepath.Text;
            openFileDialog1.ShowDialog();
            txtfilepath.Text = openFileDialog1.FileName;

            try
            {
                rtbContent.Text = MyFiles.ReadFromFile(txtfilepath.Text);
                saveContent = rtbContent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error reading file");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                MyFiles.WriteToFile(txtfilepath.Text, rtbContent.Text);
                saveContent = rtbContent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error writing file");
            }
            
        }

        private void btnsaveas_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv";
            saveFileDialog1.Title = "Save a file";
            saveFileDialog1.FileName = txtfilepath.Text;
            saveFileDialog1.ShowDialog();
            txtfilepath.Text = saveFileDialog1.FileName;

            btnsave_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtbContent.Text != saveContent) {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "save changes",
                    MessageBoxButtons.YesNoCancel);

        }
    }
}
