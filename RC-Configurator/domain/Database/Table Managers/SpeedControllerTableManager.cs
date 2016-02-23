using RC_Configurator.domain.Components;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database.Table_Managers
{
    class SpeedControllerTableManager : TableManager
    {
       
        private Dictionary<string, SpeedController> savedSpeedControllers;

        public SpeedControllerTableManager()
        {
            savedSpeedControllers = new Dictionary<string, SpeedController>();
        }

        public Dictionary<string, SpeedController> getSavedSpeedControllers()
        {
            return savedSpeedControllers;
        }

        public override void save()
        {
            throw new NotImplementedException();
        }

        public void save(string name, double weight, int constCurrent, int burstCurrent, string minCell, string maxCell, string circuitType)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {

                m_dbConnection.Open();

                SQLiteCommand insertSpeedController = new SQLiteCommand("INSERT INTO speedControllers (name, weight, constCurrent, burstCurrent, minCell, maxCell, circuitType)" +
                    "VALUES (@nameParam, @weightParam, @constCurrentParam, @burstCurrentParam, @minCellParam, @maxCellParam, @circuitTypeParam)", m_dbConnection);

                insertSpeedController.Parameters.AddWithValue("@nameParam", name);
                insertSpeedController.Parameters.AddWithValue("@weightParam", weight);
                insertSpeedController.Parameters.AddWithValue("@constCurrentParam", constCurrent);
                insertSpeedController.Parameters.AddWithValue("@burstCurrentParam", burstCurrent);
                insertSpeedController.Parameters.AddWithValue("@minCellParam", minCell);
                insertSpeedController.Parameters.AddWithValue("@maxCellParam", maxCell);
                insertSpeedController.Parameters.AddWithValue("@circuitTypeParam", circuitType);

                try
                {
                    insertSpeedController.ExecuteNonQuery();
                }
                catch
                {
                    throw new NullReferenceException();
                }

                m_dbConnection.Close();
            }
        }

        public override void update()
        {
            //Create a Dictionary to hold the SpeedControllers saved in the database
            Dictionary<string, SpeedController> speedControllers = new Dictionary<string, SpeedController>();

            //Create a new connection to the database
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                //Open database connection
                m_dbConnection.Open();


                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    //Select everything from the 'SpeedControllers' table
                    SQLiteCommand getSpeedControllers = new SQLiteCommand("SELECT * FROM speedControllers", m_dbConnection);
                    SQLiteDataReader reader = getSpeedControllers.ExecuteReader();

                    //Read every entry in the SpeedControllers table
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        SpeedController speedController = new SpeedController((string)reader["name"], (double)reader["weight"], (int)reader["constCurrent"], (int)reader["burstCurrent"], (string)reader["minCell"], 
                            (string)reader["maxCell"], (string)reader["circuitType"]);
                        //Add the battery into the dictionary using the name as the key and a new SpeedController object as the value
                        savedSpeedControllers.Add(name, speedController);
                    }
                }
                //Close the database connection
                m_dbConnection.Close();
            }
            //Save the updated savedSpeedController list 
            savedSpeedControllers = speedControllers;
        }

        public override void remove()
        {
            throw new NotImplementedException();
        }
    }
}
