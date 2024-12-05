using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Week13DemoB.Properties;

namespace Week13DemoB
{
    public class Trainer
    {
        public static List<Trainer> trainers = new List<Trainer>();

        public int TrainerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }
        public string Region {  get; set; }

        public Trainer() { }

        public Trainer(int trainerID, string firstName, string lastName, int age, string region)
        {
            TrainerID = trainerID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Region = region;
        }

        public static void PopulateTrainers()
        {
            string connectionString = Settings.Default.dbConn;
        }

    }
}
