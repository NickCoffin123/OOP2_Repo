/* 
 * Nick Coffin - 100555045
 * Final Assignment - AI in programming
 * December 2024
 * Workout file
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment.Properties;

namespace FinalAssignment.Classes
{
    public class Workout
    {
        #region Global Variables

        public static List<Workout> workouts = new List<Workout>();

        #endregion

        #region Properties

        public int WorkoutID { get; set; }
        public string WorkoutDescription { get; set; }
        public int Duration { get; set; }
        public DateTime WorkoutDate { get; set; }

        #endregion

        #region Constructors

        public Workout() { }
        public Workout(string description, int duration, DateTime date)
        {
            WorkoutDescription = description;
            Duration = duration;
            WorkoutDate = date;
        }

        #endregion

        #region Custom Methods

        public void DeleteWorkout(int workoutID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("your_connection_string"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteWorkout", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkoutID", workoutID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Workout deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Workout not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        public void AddWorkout(string description, int duration, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spAddWorkout", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WorkoutDescription", description);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@WorkoutDate", date);

                cmd.ExecuteNonQuery();
            }
        }


        public override string ToString()
        {
            return $"{WorkoutDescription} on {WorkoutDate.ToShortDateString()} for {Duration} minutes.";
        }

        #endregion

        #region Static Methods


        public static void PopulateWorkouts()
        {
            try
            {
                // Establish database connection
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);

                SqlCommand cmd;

                conn.Open();

                // Prepare SQL Command
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Workouts";
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                // Read data and populate the list
                while (reader.Read())
                {
                    Workout w = new Workout
                    {
                        WorkoutID = (int)reader["WorkoutID"],
                        WorkoutDescription = reader["WorkoutDescription"].ToString(),
                        Duration = (int)reader["Duration"],
                        WorkoutDate = (DateTime)reader["WorkoutDate"]
                    };
                    workouts.Add(w);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while populating workouts: " + ex.Message);
            }
        }

        #endregion






    }


}
