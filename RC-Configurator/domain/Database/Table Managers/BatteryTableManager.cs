using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database
{
    public class BatteryTableManager
    {

        private Dictionary<string, Battery> savedBatteries;

        public BatteryTableManager()
        {
            savedBatteries = new Dictionary<string, Battery>();
        }

        public Dictionary<string, Battery> getSavedBatteries()
        {
            return savedBatteries;
        }

        public void updateBatteries()
        {
            //Create a Dictionary to hold the batteries saved in the database
            Dictionary<string, Battery> batteries = new Dictionary<string, Battery>();

            //Create a new connection to the database
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                //Open database connection
                m_dbConnection.Open();


                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    //Select everything from the 'batteries' table
                    SQLiteCommand getBatteries = new SQLiteCommand("SELECT * FROM batteries", m_dbConnection);
                    SQLiteDataReader reader = getBatteries.ExecuteReader();

                    //Read every entry in the batteries table
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        Battery battery = new Battery((string)reader["name"], (int)reader["weight"], (int)reader["capacity"], (string)reader["configuration"], (int)reader["discharge"], (int)reader["peakDischarge"]);
                        //Add the battery into the dictionary using the name as the key and a new Battery object as the value
                        batteries.Add(name, battery);
                    }
                }
                //Close the database connection
                m_dbConnection.Close();
            }
            //Save the updated savedBattery list 
            savedBatteries = batteries;
        }

        public void saveBattery(string name, int weight, int capacity, string configuration, int discharge, int peakDischarge)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();

                SQLiteCommand insertBattery = new SQLiteCommand("INSERT INTO batteries (name, weight, capacity, configuration, discharge, peakDischarge)" +
                    "VALUES (@nameParam, @weightParam, @capParam, @configParam, @dischargeParam, @peakParam)", m_dbConnection);
                insertBattery.Parameters.AddWithValue("@nameParam", name);
                insertBattery.Parameters.AddWithValue("@weightParam", weight);
                insertBattery.Parameters.AddWithValue("@capParam", capacity);
                insertBattery.Parameters.AddWithValue("@configParam", configuration);
                insertBattery.Parameters.AddWithValue("@dischargeParam", discharge);
                insertBattery.Parameters.AddWithValue("@peakParam", peakDischarge);
                try
                {
                    insertBattery.ExecuteNonQuery();
                }
                catch
                {
                    throw new NullReferenceException();
                }
                m_dbConnection.Close();
            }
        }

        public void removeBattery(string name)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();

                SQLiteCommand removeBattery = new SQLiteCommand("");
            }
        }

    }
}
