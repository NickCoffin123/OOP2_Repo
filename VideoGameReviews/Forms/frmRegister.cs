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
    public partial class frmRegister : Form
    {

        #region Global Variables

        public static string lastRegistered = string.Empty;

        #endregion

        #region Constructors
        public frmRegister()
        {
            InitializeComponent();
        }

        #endregion

        #region Control Event Handelers
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                int passkey = (int)nudPassKey.Value;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!User.IsEmailUnique(email))
                {
                    MessageBox.Show("This email is already registered.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int newUserId = User.GetNextUserId();

                User newUser = new User
                {
                    UserID = newUserId,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PassKey = passkey
                };

                newUser.AddUser();

                lastRegistered = email;

                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Custom UI Functions and Methods
        #endregion

        
    }
}
