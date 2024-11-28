using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Week12DemoA.Properties;

namespace Week12DemoA
{
    public class Country
    {
        public static List<Country> countries = new List<Country>();

        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public int RegionID { get; set; }

        public Country() { }

        public Country(string countryID, string countryName, int regionID)
        {
            CountryID = countryID;
            CountryName = countryName;
            RegionID = regionID;
        }

        public static void PopulateCountries()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Countries", conn);

                SqlCommand cmd;
                
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Countries";
                cmd.CommandType = System.Data.CommandType.Text;


                // SELECT * FROM COUNTRIES WHERE UPPER(CountryName) LIKE '@Letter%'

                //cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = "spGetSomeCountries";
                //cmd.Parameters.AddWithValue("@Letter", "A");
                //cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Country c = new Country();
                    c.CountryID = reader["CountryID"].ToString();
                    c.CountryName = reader["CountryName"].ToString();
                    c.RegionID = (int)reader["RegionID"];
                    countries.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public bool UpdateCountry()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @CountryName, RegionID =" +
                    "@RegionID WHERE CoundryID = @CountryID", conn);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);
                cmd.Parameters.AddWithValue("@RegionID", RegionID);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {

                }
                conn.Close();
                return true;
            }
            catch (Exception e) 
            {
                throw new Exception (e.Message);
            }
        }


    }
}
