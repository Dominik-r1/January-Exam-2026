using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Exam_2026
{
    internal class DeliveryRobot : Robot
    {
        //properties
        public DeliveryMode ModeOfDelivery { get; set; }
        public double MaxLoadKG { get; set; }

        //methods
        public override string DescribeRobot()
        {
            //temporarily hardcoded
            return $"I am a delivery robot.\n\n" +
                $"I specialise in delivery by {ModeOfDelivery}\n" +
                $"The maximim load I can carry is {MaxLoadKG} kg\n\n" +
                $"Battery Information:" +
                $"{DisplayBatteryInformation()}".ToString();
        }

    }
}
