using RC_Configurator.domain.Components;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database.Table_Managers
{
    class ServoTableManager : TableManager
    {

        private Dictionary<string, Servo> savedServos;

        public ServoTableManager()
        {
            savedServos = new Dictionary<string, Servo>();
        }

        public Dictionary<string, Servo> getSavedServos()
        {
            return savedServos;
        }

        public override void save()
        {
            throw new NotImplementedException();
        }

        public void save(string name, double weight, int minVoltage, int maxVoltage)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {

                m_dbConnection.Open();

                SQLiteCommand insertServo = new SQLiteCommand("INSERT INTO servos (name, weight, minVoltage, maxVoltage)" +
                    "VALUES (@nameParam, @weightParam, @minVoltageParam, @maxVoltageParam)", m_dbConnection);

                insertServo.Parameters.AddWithValue("@nameParam", name);
                insertServo.Parameters.AddWithValue("@weightParam", weight);
                insertServo.Parameters.AddWithValue("@minVoltageParam", minVoltage);
                insertServo.Parameters.AddWithValue("@maxVoltageParam", maxVoltage);
                

                try
                {
                    insertServo.ExecuteNonQuery();
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
            //Create a Dictionary to hold the Servos saved in the database
            Dictionary<string, Servo> Servos = new Dictionary<string, Servo>();

            //Create a new connection to the database
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                //Open database connection
                m_dbConnection.Open();


                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    //Select everything from the 'Servos' table
                    SQLiteCommand getServos = new SQLiteCommand("SELECT * FROM servos", m_dbConnection);
                    SQLiteDataReader reader = getServos.ExecuteReader();

                    //Read every entry in the Servos table
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        Servo battery = new Servo((string)reader["name"], (double)reader["weight"], (int)reader["minVoltage"], (int)reader["maxVoltage"]);
                        //Add the battery into the dictionary using the name as the key and a new Servo object as the value
                        Servos.Add(name, battery);
                    }
                }
                //Close the database connection
                m_dbConnection.Close();
            }
            //Save the updated savedServo list 
            savedServos = Servos;
        }

        public override void remove()
        {
            throw new NotImplementedException();
        }
    }
}
