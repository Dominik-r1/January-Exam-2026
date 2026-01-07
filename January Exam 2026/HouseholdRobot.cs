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
        private List<HouseholdSkill> Skills { get; set; }

        //methods
        public override string DescribeRobot()
        {
            //temporarily hardcoded
            return $"I am a household robot\n" +
                $"I can help with chores around the house\n\n" +
                $"Household Robot Skills:" +
                $"{Skills}\n\n" +
                $"Battery Information:\n" +
                $"{DisplayBatteryInformation()}".ToString();
        }
    }
}
