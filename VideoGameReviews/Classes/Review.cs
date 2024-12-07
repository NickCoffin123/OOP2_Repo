using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VideoGameReviews.Properties;

namespace VideoGameReviews.DBAL
{
    internal class Review
    {
        #region Global Variables

        public static List<Review> reviews = new List<Review>();

        #endregion

        #region Properties

        public int ReviewID { get; set; }
        public int GameID { get; set; }
        public int ReviewerID { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        #endregion

        #region Constructors

        public Review() { }

        public Review(int reviewID, int gameID, int reviewerID, int rating, string reviewText, DateTime reviewDate)
        {
            ReviewID = reviewID;
            GameID = gameID;
            ReviewerID = reviewerID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }

        #endregion

        #region Custom Methods

        public void AddReview()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertNewReview", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ReviewID", ReviewID);
                        cmd.Parameters.AddWithValue("@GameID", GameID);
                        cmd.Parameters.AddWithValue("@ReviewerID", ReviewerID);
                        cmd.Parameters.AddWithValue("@Rating", Rating);
                        cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                        cmd.Parameters.AddWithValue("@ReviewDate", ReviewDate);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                reviews.Add(this);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding review: {ex.Message}");
            }
        }

        public void UpdateReview()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spUpdateReview", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ReviewID", ReviewID);
                        cmd.Parameters.AddWithValue("@GameID", GameID);
                        cmd.Parameters.AddWithValue("@ReviewerID", ReviewerID);
                        cmd.Parameters.AddWithValue("@Rating", Rating);
                        cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                        cmd.Parameters.AddWithValue("@ReviewDate", ReviewDate);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating review: {ex.Message}");
            }
        }

        #endregion

        #region Static Methods

        public static Review ReturnReview(int reviewId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Reviews WHERE ReviewId = @ReviewId", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@ReviewId", reviewId);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                return new Review
                                {
                                    ReviewID = (int)reader["ReviewID"],
                                    GameID = (int)reader["GameId"],
                                    ReviewerID = (int)reader["ReviewerId"],
                                    Rating = (int)reader["Rating"],
                                    ReviewText = reader["ReviewText"].ToString(),
                                    ReviewDate = (DateTime)reader["ReviewDate"]
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching review: {ex.Message}");
            }
        }


        public static List<Review> PopulateReviews(int gameId)
        {
            List<Review> filteredReviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Reviews WHERE GameID = @GameID", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@GameID", gameId);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Review r = new Review
                                {
                                    ReviewID = (int)reader["ReviewID"],
                                    GameID = (int)reader["GameID"],
                                    ReviewerID = (int)reader["ReviewerID"],
                                    Rating = (int)reader["Rating"],
                                    ReviewText = reader["ReviewText"].ToString(),
                                    ReviewDate = (DateTime)reader["ReviewDate"]
                                };

                                filteredReviews.Add(r);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching reviews: {ex.Message}");
            }

            return filteredReviews;
        }


        public static void DeleteReview(int reviewId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spDeleteReview", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ReviewID", reviewId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting review: {ex.Message}");
            }
        }


        #endregion
    }
}
