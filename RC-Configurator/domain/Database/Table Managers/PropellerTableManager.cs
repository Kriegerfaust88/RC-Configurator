using RC_Configurator.domain.Components;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database.Table_Managers
{
    class PropellerTableManager : TableManager
    {
        private Dictionary<string, Propeller> savedPropellers;

        public PropellerTableManager()
        {
            
            savedPropellers = new Dictionary<string, Propeller>();

        }

        public Dictionary<string, Propeller> getSavedPropellers()
        {
            return savedPropellers;
        }
       
        public override void save()
        {

        }

        public void save(string name, double weight, int bladeLength, decimal bladePitch, int bladeCount)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {

                m_dbConnection.Open();

                SQLiteCommand insertPropeller = new SQLiteCommand("INSERT INTO propellers (name, weight, bladeLength, bladePitch, bladeCount)" +
                    "VALUES (@nameParam, @weightParam, @bladeLengthParam, @bladePitchParam, @bladeCountParam)", m_dbConnection);

                insertPropeller.Parameters.AddWithValue("@nameParam", name);
                insertPropeller.Parameters.AddWithValue("@weightParam", weight);
                insertPropeller.Parameters.AddWithValue("@bladeLengthParam", bladeLength);
                insertPropeller.Parameters.AddWithValue("@bladePitchParam", bladePitch);
                insertPropeller.Parameters.AddWithValue("@bladeCountParam", bladeCount);

                try
                {
                    insertPropeller.ExecuteNonQuery();
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
            //Create a Dictionary to hold the propellers saved in the database
            Dictionary<string, Propeller> propellers = new Dictionary<string, Propeller>();

            //Create a new connection to the database
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;"))
            {
                //Open database connection
                m_dbConnection.Open();

                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    //Select everything from the 'propellers' table
                    SQLiteCommand getPropellers = new SQLiteCommand("SELECT * FROM propellers", m_dbConnection);
                    SQLiteDataReader reader = getPropellers.ExecuteReader();

                    //Read every entry in the propellers table
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        Propeller propeller = new Propeller((string)reader["name"], (int)reader["weight"], (int)reader["bladeLength"], (decimal)reader["bladePitch"], (int)reader["bladeCount"]);
                        //Add the Propeller into the dictionary using the name as the key and a new Propeller object as the value
                        propellers.Add(name, propeller);
                    }
                }
                //Close the database connection
                m_dbConnection.Close();
            }
            //Save the updated savedPropeller list 
            savedPropellers = propellers;
        }

        public override void remove()
        {
            throw new NotImplementedException();
        }

    }
}
