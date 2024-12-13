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

        public static int workoutID = 0;

        private bool isDarkMode = false; // Flag to track the current mode

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Had to update it but it still doesn't work right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Check if a row is selected
            //    if (dgvWorkouts.SelectedRows.Count > 0)
            //    {
            //        // Get the workoutID from the selected row
            //        //int selectedRowIndex = dgvWorkouts.SelectedRows[0].Index;
            //        //int workoutID = Convert.ToInt32(dgvWorkouts.Rows[selectedRowIndex].Cells["WorkoutID"].Value);



            //        // Confirm deletion
            //        DialogResult result = MessageBox.Show("Are you sure you want to delete this workout?",
            //                                              "Confirm Deletion",
            //                                              MessageBoxButtons.YesNo,
            //                                              MessageBoxIcon.Warning);

            //        if (result == DialogResult.Yes)
            //        {
            //            // Call your DeleteWorkout method
            //            Classes.Workout.DeleteWorkout(workoutID);

            //            // Remove the row from the DataGridView
            //            //dgvWorkouts.Rows.RemoveAt(selectedRowIndex);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select a workout to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                if (workoutID == 0)
                {
                    MessageBox.Show("Please select a workout to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Classes.Workout.DeleteWorkout(workoutID);
             
                workoutID = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        #region Custom UI Functions and Methods

        public frmMain()
        {
            InitializeComponent();
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
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

        private void dgvWorkouts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int workoutID = (int)dgvWorkouts.Rows[e.RowIndex].Cells["WorkoutID"].Value;
        }


        //private void frmMain_Load(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmSplash splash = new frmSplash();
        //    splash.ShowDialog();
        //}

        #endregion


    }
}
