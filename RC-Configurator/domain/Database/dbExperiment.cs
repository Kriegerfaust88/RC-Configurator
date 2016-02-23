using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database
{
     class dbExperiment
    {

        public dbExperiment()
        {
            
        }

        public void createTables()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");

            m_dbConnection.Open();

            string createBatteryTable = "CREATE TABLE batteries (name VARCHAR(20), weight INT, capacity INT, configuration VARCHAR(2), discharge INT, peakDischarge INT)";

            string createMotorTable = "CREATE TABLE motors (name VARCHAR(20), weight INT, kV INT, maxCurrent INT, maxVoltage INT, maxPower INT, minCell VARCHAR(2), maxCell VARCHAR(2), reqESC INT)";

            SQLiteCommand command = new SQLiteCommand(createBatteryTable, m_dbConnection);
            SQLiteCommand command2 = new SQLiteCommand(createMotorTable, m_dbConnection);


            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();

            m_dbConnection.Close();
        }

        public void createTestData()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "INSERT INTO batteries (name, weight, capacity, configuration, discharge, peakDischarge) values ('test', 100, 2000, '3S', 30, 40)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "INSERT INTO motors (name, weight, kv, maxCurrent, maxvoltage, maxPower, minCell, maxCell, reqESC) values ('test', 24, 1400, 30, 240, 500, '2S', '3S', 30)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public void createMotorTable()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");
            m_dbConnection.Open();
            string createMotorTable = "CREATE TABLE motors (name VARCHAR(20), weight INT, kV INT, maxCurrent INT, maxVoltage INT, maxPower INT, minCell VARCHAR(2), maxCell VARCHAR(2), reqESC INT)";
            SQLiteCommand command2 = new SQLiteCommand(createMotorTable, m_dbConnection);
            command2.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public void createMotorTestData()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "INSERT INTO motors (name, weight, kv, maxCurrent, maxvoltage, maxPower, minCell, maxCell, reqESC) values ('test', 24, 1400, 30, 240, 500, '2S', '3S', 30)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public void deleteMotorTable()
        {

            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");
            string sql = "DROP TABLE motors";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }

        public void createPropellerTable()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");
            m_dbConnection.Open();
            string createPropellerTable = "CREATE TABLE propellers (name VARCHAR(20), weight INT, bladeLength INT, bladePitch DECIMAL, bladeCount INT)";
            SQLiteCommand command = new SQLiteCommand(createPropellerTable, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public void createPropellerTestData()
        {

        }

        public void deletePropellerTable()
        {

            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=database.sqlite;Version=3;");
            string sql = "DROP TABLE propellers";
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }


    }
}
