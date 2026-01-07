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
        public List<HouseholdSkill> Skills { get; set; }


        //constructor
        public HouseholdRobot(string n, double cap, double cur)
            : base(n, cap, cur)
        {
            //every household robot gets Cleaning added to skills
            DownloadSkill(HouseholdSkill.Cleaning);
        }
        //ctor for when only name given - other values set zero
        public HouseholdRobot(string n) : this(n, 0, 0) { }


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

        public void DownloadSkill(HouseholdSkill skill)
        {
            Skills.Add(skill);
            Skills
        }
    }
}
