using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Exam_2026
{
    internal class HouseholdRobot : Robot
    {
        //properties
        private List<HouseholdSkill>

        //methods
        public override string DescribeRobot()
        {
            //temporarily hardcoded
            return $"I am a {RobotName} robot\n" +
                $"I can help with chores aroung the house\n\n" +
                $"{RobotName} Robot Skills:" +
                $"-Skills list-\n\n" +
                $"Battery Information:\n" +
                $"{DisplayBatteryInformation()}".ToString();

            
        }
    }
}
