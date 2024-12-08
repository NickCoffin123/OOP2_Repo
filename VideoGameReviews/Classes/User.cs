/* Nick Coffin - 100555045.
* OOP - Assignment 5 VideoGame Review.
* December, 2024.
* User class.
*/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VideoGameReviews.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VideoGameReviews.DBAL
{
    /// <summary>
    /// Main method for class
    /// </summary>
    public class User
    {
        #region Global Variables

        public static List<User> users = new List<User>();

        #endregion

        #region Properties

        public int UserID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public int PassKey { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public User() { }

        /// <summary>
        /// Paramertized constructor
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="passKey"></param>
        public User(int userID, string firstName, string lastName, string email, int passKey)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PassKey = passKey;
        }

        #endregion

        #region Custom Methods

        /// <summary>
        /// To string override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Email})";
        }

        /// <summary>
        /// Method to add user
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void AddUser()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertNewUser", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@PassKey", PassKey);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                users.Add(this);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding user: {ex.Message}");
            }
        }

        /// <summary>
        /// Method to update user
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void UpdateUser()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spUpdateUser", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@PassKey", PassKey);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating user: {ex.Message}");
            }
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to return one user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static User ReturnUser(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserId = @UserId", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@UserId", userId);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                return new User
                                {
                                    UserID = (int)reader["UserID"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PassKey = (int)reader["PassKey"]
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching user: {ex.Message}");
            }
        }


        /// <summary>
        /// Method to populate list of users
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void PopulateUsers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbCon);

                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Users";
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User u = new User();
                    u.UserID = (int)reader["UserID"];
                    u.FirstName = reader["FirstName"].ToString();
                    u.LastName = reader["LastName"].ToString();
                    u.Email = reader["Email"].ToString();
                    u.PassKey = (int)reader["PassKey"];
                    users.Add(u);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        
        /// <summary>
        /// Method to delete user
        /// </summary>
        /// <param name="userId"></param>
        /// <exception cref="Exception"></exception>
        public static void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("spDeleteUser", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting user: {ex.Message}");
            }
        }

        /// <summary>
        /// Method to get one user with a username and passkey
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passkey"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static User GetUser(string email, int passkey)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = @Email AND PassKey = @PassKey", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PassKey", passkey);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserID = (int)reader["UserID"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PassKey = (int)reader["PassKey"]
                                };
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error verifying user: {ex.Message}");
            }
        }

        /// <summary>
        /// Method to check if an email is unique
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool IsEmailUnique(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(UserID) FROM Users WHERE Email = @Email", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Email", email);

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking email uniqueness: {ex.Message}");
            }
        }

        /// <summary>
        /// Method to get the next user id
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetNextUserId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.dbCon))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(UserID), 0) + 1 FROM Users", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        conn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating UserID: {ex.Message}");
            }
        }


        #endregion
    }
}
