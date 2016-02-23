using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RC_Configurator.domain.Components;

namespace RC_Configurator.domain.File_IO
{
    class MotorIO
    {

        static string path = "C:\\Users\\Kriegerfaust\\Documents\\Visual Studio 2015\\Projects\\RC-Configurator\\RC-Configurator\\domain\\Config\\motorConfig.txt";

        //Writes to motor config file
        public static void write(string input)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(input);
            }
        }


        //Reads through the motor config file and create a list of Battery objects from it
        public static void read(List<Motor> motors)
        {

            using (StreamReader sr = File.OpenText(path))
            {
                List<String> motor = new List<string>();
                string s = "";
                //This section only runs when there is more content in the config file to read
                while (sr.Peek() > 1)
                {
                    //read the current line and split the string into separate parameters
                    s = sr.ReadLine();
                    foreach (string parameter in s.Split(','))
                    {
                        motor.Add(parameter);
                    }
                    //Assign each parameter to a helper variable for readability 
                    try
                    {
                        string name = motor[0];
                        int weight = Int32.Parse(motor[1]);
                        int kV = Int32.Parse(motor[2]);
                        int maxCurrent = Int32.Parse(motor[3]);
                        int maxVoltage = Int32.Parse(motor[4]);
                        int maxPower = Int32.Parse(motor[5]);
                        string minCell = motor[6];
                        string maxCell = motor[7];
                        int requiredESC = Int32.Parse(motor[8]);


                        //Create a new motor object from the above parameteres
                        Motor newMotor = new Motor(name, weight, kV, maxCurrent, maxVoltage, maxPower, minCell, maxCell, requiredESC);

                        //Add the new motor to the List<Motor> taken as a method parameter
                        motors.Add(newMotor);
                        //Clear the reader string
                        s = "";
                        //Clear the saved motor parameters
                        motor.Clear();
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

