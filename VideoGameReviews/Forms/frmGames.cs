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
using VideoGameReviews.Forms;

namespace VideoGameReviews
{
    public partial class frmGames : Form
    {

        #region Global Variables

        public User loggedInUser;

        #endregion

        #region Constructors
        public frmGames()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Event Handelers

        #endregion

        #region Custom UI Functions and Methods
        private void frmGames_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

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


        #endregion

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int gameId = (int)dgvGames.Rows[e.RowIndex].Cells["GameID"].Value;

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

        //private void dgvReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        try
        //        {
        //            // Get the ReviewID from the clicked row
        //            int reviewId = (int)dgvReviews.Rows[e.RowIndex].Cells["ReviewID"].Value;

        //            // Find the selected review in the data source
        //            Review selectedReview = ((List<Review>)dgvReviews.DataSource).FirstOrDefault(r => r.ReviewID == reviewId);

        //            if (selectedReview != null)
        //            {
        //                // Populate the UI controls with review details
        //                //txtGameTitle.Text = GetGameTitle(selectedReview.GameID); // Fetch the game title based on GameID
        //                nudReview.Value = selectedReview.Rating;
        //                rtbReview.Text = selectedReview.ReviewText;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Selected review not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error loading review details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

    }
}
