using RC_Configurator.domain.Components;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database.Table_Managers
{
    class ReceiverTableManager : TableManager
    {

        private Dictionary<string, Receiver> savedReceivers;

        public ReceiverTableManager()
        {
            savedReceivers = new Dictionary<string, Receiver>();
        }

        public Dictionary<string, Receiver> getSavedReceivers()
        {
            return savedReceivers;
        }

        public override void save()
        {
            throw new NotImplementedException();
        }



        public void save(string name, double weight, int channelCount, int minVoltage, int maxVoltage)
        {

            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {

                m_dbConnection.Open();

                SQLiteCommand insertReceiver = new SQLiteCommand("INSERT INTO receivers (name, weight, channelCount, minVoltage, maxVoltage)" +
                    "VALUES (@nameParam, @weightParam, @channelParam, @minVoltageParam, @maxVoltageParam)", m_dbConnection);

                insertReceiver.Parameters.AddWithValue("@nameParam", name);
                insertReceiver.Parameters.AddWithValue("@weightParam", weight);
                insertReceiver.Parameters.AddWithValue("@channelParam", channelCount);
                insertReceiver.Parameters.AddWithValue("@minVoltageParam", minVoltage);
                insertReceiver.Parameters.AddWithValue("@maxVoltageParam", maxVoltage);

                try
                {
                    insertReceiver.ExecuteNonQuery();
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
            //Create a Dictionary to hold the receivers saved in the database
            Dictionary<string, Receiver> receivers = new Dictionary<string, Receiver>();

            //Create a new connection to the database
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                //Open database connection
                m_dbConnection.Open();


                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    //Select everything from the 'receivers' table
                    SQLiteCommand getReceivers = new SQLiteCommand("SELECT * FROM receivers", m_dbConnection);
                    SQLiteDataReader reader = getReceivers.ExecuteReader();

                    //Read every entry in the receivers table
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        Receiver battery = new Receiver((string)reader["name"], (double)reader["weight"], (int)reader["channelCount"], (int)reader["minVoltage"], (int)reader["maxVoltage"]);
                        //Add the battery into the dictionary using the name as the key and a new Receiver object as the value
                        receivers.Add(name, battery);
                    }
                }
                //Close the database connection
                m_dbConnection.Close();
            }
            //Save the updated savedReceiver list 
            savedReceivers = receivers;
        }

        public override void remove()
        {
            throw new NotImplementedException();
        }
    }
}
