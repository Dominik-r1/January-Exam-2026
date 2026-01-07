using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace January_Exam_2026
{
    internal abstract class Robot
    {
        //properties
        public string RobotName { get; set; }
        public double PowerCapacityKWH { get; set; }
        public double CurrentPowerKWH { get; set; }

        //constructors
        public Robot(string n, double cap, double cur)
        {
            RobotName = n;
            PowerCapacityKWH = cap;
            CurrentPowerKWH = cur; 
        }
        public Robot(string n)
        {
            RobotName = n;
        }

        //methods
        //returns battery level as a percentage
        public double getBatteryPercentage()
        {
            // current battery / capacity X 100
            return (CurrentPowerKWH / PowerCapacityKWH) * 100;
        }

        public string DisplayBatteryInformation()
        {
            return $"Battery Information\n" +
                   $"Capacity: {PowerCapacityKWH} kWh\n" +
                   $"Current Power: {CurrentPowerKWH} kWh\n" +
                   $"Battery Level: {getBatteryPercentage()}%".ToString();
        }
        public abstract string DescribeRobot();
     
        public override string ToString()
        {
            return $"Robot Name: {RobotName} ]".ToString();
        }

        //ENUMS
        public enum HouseholdSkill
        {
            Cooking,
            Cleaning,
            Laundry,
            Gardening,
            ChildCare
        }
        public enum DeliveryMode
        {
            Walking,
            Driving,
            Flying
        }
    }
}
