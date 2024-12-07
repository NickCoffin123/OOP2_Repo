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
    public partial class frmLogin : Form
    {

        #region Global Variables

        public User LoggedInUser { get; private set; }

        #endregion

        #region Constructors
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Event Handelers
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

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
                // Call the GetUser method to verify login credentials
                User user = User.GetUser(email, passkey);

                if (user != null)
                {
                    LoggedInUser = user; // Set the logged-in user
                    DialogResult = DialogResult.OK; // Set the dialog result to OK
                    Close(); // Close the login form
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
