/* 
 * Nick Coffin - 100555045
 * Final Assignment - AI in programming
 * December 2024
 * Utilities form
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment.Forms
{
    public partial class frmUtilities : Form
    {

        private bool isDarkMode = false; // Flag to track the current mode

        public frmUtilities()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double height = (double)nudHeight.Value;
            double weight = (double)nudWeight.Value;
            try
            {
                lblBMIResult.Text = Classes.Utilities.CalculateBMI(weight, height).ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The apply light / dark mode works well enough. Its not pretty but it works.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rabLightDark_CheckedChanged(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode; // Toggle the mode

            if (isDarkMode)
            {
                ApplyDarkMode();
            }
            else
            {
                ApplyLightMode();
            }
        }

        private void ApplyLightMode()
        {
            // Change form and control colors for light mode
            this.BackColor = Color.White; // Form background
            this.ForeColor = Color.Black; // Form text color

            // Update all controls on the form
            foreach (Control control in this.Controls)
            {
                if (control is Label || control is Button || control is TextBox)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }


        }

        private void ApplyDarkMode()
        {
            // Change form and control colors for dark mode
            this.BackColor = Color.Black; // Form background
            this.ForeColor = Color.White; // Form text color

            // Update all controls on the form
            foreach (Control control in this.Controls)
            {
                if (control is Label || control is Button || control is TextBox)
                {
                    control.BackColor = Color.Gray;
                    control.ForeColor = Color.White;
                }
            }


        }

    }
}
