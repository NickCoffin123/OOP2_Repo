using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week06_Demo_DroidFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
       

        #endregion

        #region Control Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
          


            
        }

        private void btnSellDroid_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
           
        }

        private void lboxDroids_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region Custom UI Functions and Methods
    
        #endregion

       
    }
}
