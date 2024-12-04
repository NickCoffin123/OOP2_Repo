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



        #endregion

        #region Static Methods

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

        #endregion


    }
}
