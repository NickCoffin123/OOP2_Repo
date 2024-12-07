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

        public User() { }

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

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Email})";
        }

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


        #endregion
    }
}
