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

    }
}
