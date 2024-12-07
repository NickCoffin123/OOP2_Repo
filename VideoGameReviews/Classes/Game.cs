using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameReviews.Properties;

namespace VideoGameReviews.DBAL
{
    /// <summary>
    /// Main method for class.
    /// </summary>
    internal class Game
    {
        #region Global Variables

        public static List<Game> games = new List<Game>();

        #endregion

        #region Properties

        public int GameId { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        #endregion

        #region Constructors

        public Game() { }

        public Game(int gameId, string title, string genre, DateTime releaseDate)
        {
            GameId = gameId;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

        #endregion

        #region Custom Methods

        public void AddGame()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertNewGame", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@GameID", GameId);
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Genre", Genre);
                        cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                games.Add(this);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding game: {ex.Message}");
            }
        }

        public void UpdateGame()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spUpdateGame", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@GameID", GameId);
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Genre", Genre);
                        cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating game: {ex.Message}");
            }
        }


        #endregion

        #region Static Methods

        public static Game ReturnGame(int gameId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Games WHERE GameId = @GameId", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@GameId", gameId);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                return new Game
                                {
                                    GameId = (int)reader["GameId"],
                                    Title = reader["Title"].ToString(),
                                    Genre = reader["Genre"].ToString(),
                                    ReleaseDate = (DateTime)reader["ReleaseDate"]
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching game: {ex.Message}");
            }
        }



        public static void PopulateGames()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbCon);

                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Games";
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Game g = new Game();
                    g.GameId = (int)reader["GameId"];
                    g.Title = reader["Title"].ToString();
                    g.Genre = reader["Genre"].ToString();
                    g.ReleaseDate = (DateTime)reader["ReleaseDate"];
                    games.Add(g);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void DeleteGame(int gameId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spDeleteGame", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@GameID", gameId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting game: {ex.Message}");
            }
        }


        #endregion


    }
}
