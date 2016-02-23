using RC_Configurator.domain.Components;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database
{
    public class MotorTableManager
    {
        private Dictionary<string, Motor> savedMotors;

        public MotorTableManager()
        {
            savedMotors = new Dictionary<string, Motor>();
        }
        
        public Dictionary<string, Motor> getSavedMotors()
        {
            return savedMotors;
        }

        public void updateMotors()
        {
            //Create a Dictionary to hold the motors saved in the database
            Dictionary<string, Motor> motors = new Dictionary<string, Motor>();

            //Create a new connection to the database
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                //Open database connection
                m_dbConnection.Open();

                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    //Select everything from the 'motors' table
                    SQLiteCommand getMotors = new SQLiteCommand("SELECT * FROM motors", m_dbConnection);
                    SQLiteDataReader reader = getMotors.ExecuteReader();

                    //Read every entry in the motors table
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        Motor motor = new Motor((string)reader["name"], (int)reader["weight"], (int)reader["kv"], (int)reader["maxCurrent"], (int)reader["maxVoltage"], (int)reader["maxPower"], (string)reader["minCell"],
                            (string)reader["maxCell"], (int)reader["reqESC"]);
                        //Add the battery into the dictionary using the name as the key and a new Battery object as the value
                        motors.Add(name, motor);
                    }
                }
                //Close the database connection
                m_dbConnection.Close();
            }
            savedMotors = motors;
        }

        public void saveMotor(string name, int weight, int kV, int maxCurrent, int maxVoltage, int maxPower, string minCell, string maxCell, int requiredESC)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();

                SQLiteCommand insertMotor = new SQLiteCommand("INSERT INTO motors (name, weight, kV, maxCurrent, maxVoltage, maxPower, minCell, maxCell, reqESC)" +
                    "VALUES (@nameParam, @weightParam, @kVParam, @maxCurrentParam, @maxVoltageParam, @maxPowerParam, @minCellParam, @maxCellParam, @reqESCParam)", m_dbConnection);

                insertMotor.Parameters.AddWithValue("@nameParam", name);
                insertMotor.Parameters.AddWithValue("@weightParam", weight);
                insertMotor.Parameters.AddWithValue("@kVParam", kV);
                insertMotor.Parameters.AddWithValue("@maxCurrentParam", maxCurrent);
                insertMotor.Parameters.AddWithValue("@maxVoltageParam", maxVoltage);
                insertMotor.Parameters.AddWithValue("@maxPowerParam", maxPower);
                insertMotor.Parameters.AddWithValue("@minCellParam", minCell);
                insertMotor.Parameters.AddWithValue("@maxCellParam", maxCell);
                insertMotor.Parameters.AddWithValue("@reqESCParam", requiredESC);

                try
                {
                    insertMotor.ExecuteNonQuery();
                }
                catch
                {
                    throw new NullReferenceException();
                }


                m_dbConnection.Close();
            }
        }
    }
}
