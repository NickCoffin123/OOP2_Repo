/* 
 * Nick Coffin - 100555045
 * Final Assignment - AI in programming
 * December 2024
 * Main form
 */
using FinalAssignment.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class frmMain : Form
    {


        #region Global Variables
        #endregion

        #region Control Event Handlers

        /// <summary>
        /// Chat did a pretty good job with this once I fixed the add workout method in the workout class.
        /// Copilot helped too.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a workout description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudDuration.Value <= 0)
            {
                MessageBox.Show("Workout time must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Classes.Workout w = new Classes.Workout();
            w.WorkoutDescription = txtDescription.Text;
            w.Duration = (int)nudDuration.Value;
            w.WorkoutDate = DateTime.Now;

            w.AddWorkout();

            txtDescription.Clear();
            nudDuration.Value = 0;

        }

        private void btnUtilities_Click(object sender, EventArgs e)
        {
            frmUtilities frm = new frmUtilities();
            frm.Show();
            this.Hide();
        }

        #endregion

        #region Custom UI Functions and Methods

        public frmMain()
        {
            InitializeComponent();

            try
            {
                Classes.Workout.PopulateWorkouts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvWorkouts.AutoGenerateColumns = false;
            dgvWorkouts.DataSource = Classes.Workout.workouts;
        }

        #endregion


    }
}
