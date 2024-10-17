// Nick Coffin - 100555045.
// Oct 17, 2024.
// OOP 2 - InClass 2.
// A class for video games.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace In_Class2
{
    /// <summary>
    /// Main method for the class.
    /// </summary>
    internal class VideoGame
    {

        #region Class Scope Variables

        private const string GAMENAME = "Default name";
        private const int PERSONALRATING = 5;
        private const double PRICEPAID = 0;
        private const string GAMEGENRE = "";
        private const string WHEREPLAYED = "";
        private const bool ISINDIE = false;
        private const bool HAVEBEAT = false;

        private static int _gameCounter = 0;
        private static int gameRatings = 0;

        public static List<VideoGame> games = new List<VideoGame>();

        #endregion

        #region Properties

        private string _gameName;
        /// <summary>
        /// I know I don't need to comment this but the is null or white space is pretty cool and I wanted to mention that.
        /// </summary>
        private string GameName
        {
            get
            {
                return _gameName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _gameName = value;
                }
                else
                {
                    Console.WriteLine("Invalid game name. Please try again");
                }
            }
        }

        private int _personalRating;

        /// <summary>
        /// Validation to ensure the rating is greater or equal to zero or less than or equal to five.
        /// </summary>
        public int PersonalRating
        {
            get
            {
                return _personalRating;
            }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    _personalRating = value;
                }
                else
                {
                    Console.WriteLine("Rating must be between 1 and 5.");
                }
            }
        }

        private int GameNumber { get; set; }
        private double PricePaid { get; set; }
        private string GameGenre { get; set; }
        private string WherePlayed { get; set; }
        private bool IsIndie { get; set; }
        private bool HaveBeat { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        private VideoGame()
        {
        }

        /// <summary>
        /// Paramaterized constructor.
        /// </summary>
        /// <param name="gameName">Game name</param>
        /// <param name="pricePaid">Price paid for game</param>
        /// <param name="gameGenre">Game genre</param>
        /// <param name="wherePlayed">Where you played the game (Console, PC, Mobile)</param>
        /// <param name="isIndie">If the game is developed by an indie developer</param>
        /// <param name="haveBeat">If you have beat the game</param>
        /// <param name="personalRating">Your personal rating of the game</param>
        public VideoGame(string gameName, double pricePaid, string gameGenre, string wherePlayed, bool isIndie, bool haveBeat, int personalRating)
        {
            _gameCounter++;
            GameNumber = _gameCounter;
            GameName = gameName;
            PricePaid = pricePaid;
            GameGenre = gameGenre;
            WherePlayed = wherePlayed;
            IsIndie = isIndie;
            HaveBeat = haveBeat;
            PersonalRating = personalRating;

            gameRatings += personalRating;
        }

        #endregion

        #region Custom Methods

        /// <summary>
        /// A method to set the defaults.
        /// </summary>
        public void SetDefaults()
        {
            GameName = GAMENAME;
            PersonalRating = PERSONALRATING;
            PricePaid = PRICEPAID;
            GameGenre = GAMEGENRE;
            WherePlayed = WHEREPLAYED;
            IsIndie = ISINDIE;
            HaveBeat = HAVEBEAT;
    }

        /// <summary>
        /// A method to display the game info of a selected game.
        /// </summary>
        public void DisplayGameInfo()
        {
            Console.WriteLine($"Game Number: {GameNumber}, Name: {GameName}, Price: {PricePaid}, Played at: {WherePlayed}, Is indie: {IsIndie}," +
                $"Have beat: {HaveBeat}, Personal Rating: {PersonalRating}");
        }

        /// <summary>
        /// A method to change the rating of a selected game.
        /// </summary>
        /// <param name="newRating">A new rating for the game</param>
        public void ChangePersonalRating(int newRating)
        {
            gameRatings -= PersonalRating;
            PersonalRating = newRating;
            gameRatings += newRating;
        }


        #endregion

        #region Static Methods

        /// <summary>
        /// A method to find a game in the list of games.
        /// </summary>
        /// <param name="gameName">Uses the game name to find the intended game.</param>
        /// <returns>Returns the game.</returns>
        public static VideoGame FindGame(String gameName)
        {

            foreach (VideoGame game in games)
            {
                if (game.GameName == gameName) return game;
            }

            return null;
        }

        /// <summary>
        /// A method to get the average rating of all the games in the list.
        /// </summary>
        /// <returns>The average of the games.</returns>
        public static double GetAverageRating()
        {
            if (_gameCounter == 0) return 0;
            return gameRatings / _gameCounter;
        }

        #endregion

    }
}
