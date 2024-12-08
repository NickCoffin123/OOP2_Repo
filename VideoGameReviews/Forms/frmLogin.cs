/* Nick Coffin - 100555045.
* OOP - Assignment 5 VideoGame Review.
* December, 2024.
* Login form.
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
using VideoGameReviews.DBAL;

namespace VideoGameReviews.Forms
{
    /// <summary>
    /// Main method
    /// </summary>
    public partial class frmLogin : Form
    {

        #region Global Variables

        public static string currentUser = string.Empty;

        public static int currentID = 0;
        public User LoggedInUser { get; private set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Main constructor
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();

            this.AcceptButton = btnSignIn;
            this.CancelButton = btnExit;
        }
        #endregion

        #region Control Event Handelers
        /// <summary>
        /// Method to exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Method to load the register form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog(); 
            txtEmail.Text = frmRegister.lastRegistered;
        }

        /// <summary>
        /// Method to check the sign in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            int passkey = (int)nudPasskey.Value;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a valid email.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = User.GetUser(email, passkey);

                if (user != null)
                {
                    currentID = user.UserID;
                    LoggedInUser = user;
                    DialogResult = DialogResult.OK;
                    currentUser = user.FirstName + " " + user.LastName;
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or passkey. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Custom UI Functions and Methods

      

        #endregion



    }
}
