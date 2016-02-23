using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RC_Configurator.domain.File_IO
{
    class BatteryIO

    {
        static string path = "C:\\Users\\Kriegerfaust\\Documents\\Visual Studio 2015\\Projects\\RC-Configurator\\RC-Configurator\\domain\\Config\\batteryConfig.txt";
        
        //Writes to battery config file
        public static void write(string input)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(input);
            }
        }


        //Reads through the Battery config file and create a list of Battery objects from it
        public static void read(List<Battery> batteries)
        {
            
            using (StreamReader sr = File.OpenText(path))
            {
                List<String> battery = new List<string>();
                string s = "";
                //This section only runs when there is more content in the config file to read
                while (sr.Peek() > 1)
                {
                    //read the current line and split the string into separate parameters
                    s = sr.ReadLine();
                    foreach (string parameter in s.Split(','))
                    {
                        battery.Add(parameter);
                    }
                    //Assign each parameter to a helper variable for readability 
                    try {
                        string name = battery[0];
                        int weight = Int32.Parse(battery[1]);
                        int capacity = Int32.Parse(battery[2]);
                        string configuration = battery[3];
                        int discharge = Int32.Parse(battery[4]);
                        int peakDischarge = Int32.Parse(battery[5]);

                        //Create a new battery object from the above parameteres
                        Battery newBattery = new Battery(name, weight, capacity, configuration, discharge, peakDischarge);

                        //Add the new battery to the List<Battery> taken as a method parameter
                        batteries.Add(newBattery);
                        //Clear the reader string
                        s = "";
                        //Clear the saved battery parameters
                        battery.Clear();
                    }
                    catch
                    {
                        //If the reader pulled invalid data from the config file, close the StreamReader and exit the method
                        sr.Close();
                        return;
                    }
                }
                //If there is no more content to read from the config file, close the StreamReader
                sr.Close();
            }
            
        }
    }
}
