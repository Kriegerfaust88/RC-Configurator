using RC_Configurator.domain.Components;
using RC_Configurator.domain.Database.Table_Managers;
using RC_Configurator.domain.File_IO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Configurator.domain.Database
{
    public class DBManager
    {
        private BatteryTableManager batteryManager;
        private MotorTableManager motorManager;
        private PropellerTableManager propellerManager;
        private ReceiverTableManager receiverManager;
        private ServoTableManager servoManager;
        private SpeedControllerTableManager speedControllerManager;
       

        public DBManager()
        {   
            batteryManager = new BatteryTableManager();
            motorManager = new MotorTableManager();
            propellerManager = new PropellerTableManager();
            receiverManager = new ReceiverTableManager();
            servoManager = new ServoTableManager();
            speedControllerManager = new SpeedControllerTableManager();

            
        }

        public void saveBattery(string name, int weight, int capacity, string configuration, int discharge, int peakDischarge)
        {
            batteryManager.saveBattery(name, weight, capacity, configuration, discharge, peakDischarge);
        }

        public void saveMotor(string name, int weight, int kV, int maxCurrent, int maxVoltage, int maxPower, string minCell, string maxCell, int requiredESC)
        {
            motorManager.saveMotor(name, weight, kV, maxCurrent, maxVoltage, maxPower, minCell, maxCell, requiredESC);
        }

        public void savePropeller(string name, double weight, int bladeLength, decimal bladePitch, int bladeCount)
        {
            propellerManager.save(name, weight, bladeLength,  bladePitch, bladeCount);
        }

        public void saveReceiver(string name, double weight, int channelCount, int minVoltage, int maxVoltage)
        {
            receiverManager.save(name, weight, channelCount, minVoltage, maxVoltage);
        }

        public void saveServo(string name, double weight, int minVoltage, int maxVoltage)
        {
            servoManager.save(name, weight, minVoltage, maxVoltage);
        }

        public void saveSpeedController(string name, double weight, int constCurrent, int burstCurrent, string minCell, string maxCell, string circuitType)
        {
            speedControllerManager.save(name, weight, constCurrent, burstCurrent, minCell, maxCell, circuitType);
        }

        public Dictionary<string, Battery> getBatteries()
        {
            batteryManager.updateBatteries();
            return batteryManager.getSavedBatteries();
        }

        public Dictionary<string, Motor> getMotors()
        {
            motorManager.updateMotors();
            return motorManager.getSavedMotors();
        }

        public Dictionary<string, Propeller> getPropellers()
        {
            propellerManager.update();
            return propellerManager.getSavedPropellers();
        }

        public Dictionary<string, Receiver> getReceievers()
        {
            receiverManager.update();
            return receiverManager.getSavedReceivers();
        }

        public Dictionary<string, Servo> getServos()
        {
            servoManager.update();
            return servoManager.getSavedServos();
        }

        public Dictionary<string, SpeedController> getSpeedControllers()
        {
            speedControllerManager.update();
            return speedControllerManager.getSavedSpeedControllers();
        }


    }
}

