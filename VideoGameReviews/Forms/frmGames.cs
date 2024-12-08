/* Nick Coffin - 100555045.
* OOP - Assignment 5 VideoGame Review.
* December, 2024.
* Main form.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameReviews.DBAL;
using VideoGameReviews.Forms;

namespace VideoGameReviews
{
    /// <summary>
    /// Main method
    /// </summary>
    public partial class frmGames : Form
    {

        #region Global Variables

        public User loggedInUser;

        public int gameId = 0;

        public int selectedReviewId = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// Main constructor
        /// </summary>
        public frmGames()
        {
            InitializeComponent();
            PlaySound();

            this.AcceptButton = btnPost;
            this.CancelButton = btnDelete;
        }

        #endregion

        #region Control Event Handelers

        /// <summary>
        /// Method to populate the reviews based on the game clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gameId = (int)dgvGames.Rows[e.RowIndex].Cells["GameID"].Value;
                string gameName = (string)dgvGames.Rows[e.RowIndex].Cells["Title"].Value;
                txtGameTitle.Text = gameName;

                try
                {
                    List<Review> filteredReviews = DBAL.Review.PopulateReviews(gameId);
                    dgvReviews.AutoGenerateColumns = false;
                    dgvReviews.DataSource = null;
                    dgvReviews.DataSource = filteredReviews;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Method to retrieve the reviewID of review selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReviewId = (int)dgvReviews.Rows[e.RowIndex].Cells["ReviewID"].Value;
            }
        }

        /// <summary>
        /// Method to post review
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtGameTitle.Text))
                {
                    MessageBox.Show("Please select a game to review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nextReviewId = DBAL.Review.GetNextReviewId();

                int reviewerId = frmLogin.currentID;

                int gameReviewId = gameId;

                Review newReview = new Review
                {
                    ReviewID = nextReviewId,
                    GameID = gameId,
                    ReviewerID = reviewerId,
                    Rating = (int)nudReview.Value,
                    ReviewText = rtbReview.Text.Trim(),
                    ReviewDate = DateTime.Now
                };

                newReview.AddReview();

                RefreshReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while posting the review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to delete a review
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReviewId == 0)
                {
                    MessageBox.Show("Please select a review to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DBAL.Review.DeleteReview(selectedReviewId);
                RefreshReviews();
                selectedReviewId = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to log out in the tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        /// <summary>
        /// Method to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Custom UI Functions and Methods

        /// <summary>
        /// Method to load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void frmGames_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            tslCurrentUser.Text = "Welcome - " + frmLogin.currentUser;

            try
            {
                Game.PopulateGames();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            dgvGames.AutoGenerateColumns = false;
            dgvGames.DataSource = DBAL.Game.games;

           }

        /// <summary>
        /// Method to refresh the reviews
        /// </summary>
        private void RefreshReviews()
        {
            try
            {
                if (gameId <= 0)
                {
                    dgvReviews.DataSource = null;
                    return;
                }

                var reviews = DBAL.Review.PopulateReviews(gameId);

                dgvReviews.DataSource = null;
                dgvReviews.DataSource = reviews;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PlaySound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources._04_The_Moonlighter);
            player.Play();
        }

        #endregion


    }
}
