using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace January_Exam_2026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create robot objects
            HouseholdRobot r1 = new HouseholdRobot("HouseBot", 500, 300);
            HouseholdRobot r2 = new HouseholdRobot("GardenMate", 500, 450);
            HouseholdRobot r3 = new HouseholdRobot("Housemate 3000", 500, 500);
            DeliveryRobot r4 = new DeliveryRobot("DeliverBot", 500, 20);
            DeliveryRobot r5 = new DeliveryRobot("FlyBot", 500, 0);
            DeliveryRobot r6 = new DeliveryRobot("Driver", 500, 100);
            //give certain robots skills
            r2.DownloadSkill(Robot.HouseholdSkill.Gardening);
            r3.DownloadSkill(Robot.HouseholdSkill.Laundry);
            r3.DownloadSkill(Robot.HouseholdSkill.Cooking);

            //add to List of robots
            List<Robot> robots = new List<Robot>() { r1, r2, r3, r4, r5, r6 };
            //set listbox source
            lbxRobotList.ItemsSource = robots ;

        }

        private void lbxRobotList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //clear previous text
            tblkDetails.Text = "";
            //fins selected object
            Robot selectedRobot = lbxRobotList.SelectedItem as Robot;

            if (selectedRobot != null)
            {
                tblkDetails.Text = selectedRobot.DescribeRobot();
            }

        }

        private void btnCharge_Click(object sender, RoutedEventArgs e)
        {
            Robot selectedRobot = lbxRobotList.SelectedItem as Robot;

            //if no item selected, display message and quit method
            if (selectedRobot == null)
            {
                MessageBox.Show("Please select a robot to charge");
                return;
            }
                

            // check if robot is already full charges
            if (selectedRobot.CurrentPowerKWH == selectedRobot.PowerCapacityKWH)
            {
                MessageBox.Show("Robot is already fully charged.");
                return;
            }
            //calc time taken as a percentage
            double percentageNeeded = 100 - selectedRobot.getBatteryPercentage();
            //as an example total charge time will be 300 mins
            double timeTaken = 300 / percentageNeeded;


            //make current power == capacity (charge it)
            double cap = selectedRobot.PowerCapacityKWH;
            selectedRobot.CurrentPowerKWH = cap;

            //display message
            MessageBox.Show($"Robot fully Charged. Time taken: {timeTaken}");
            //refreshlbx
            //clear previous text
            tblkDetails.Text = "";
            tblkDetails.Text = selectedRobot.DescribeRobot();
        }
    }
}
