using System;
using System.Collections.Generic;
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
            HouseholdRobot r1 = new HouseholdRobot("HouseBot");
            HouseholdRobot r2 = new HouseholdRobot("GardenMate");
            HouseholdRobot r3 = new HouseholdRobot("Housemate 3000");
            DeliveryRobot r4 = new DeliveryRobot("DeliverBot");
            DeliveryRobot r5 = new DeliveryRobot("FlyBot");
            DeliveryRobot r6 = new DeliveryRobot("Driver");

            List<Robot> robots = new List<Robot>() { r1, r2, r3, r4, r5, r6 };

            lbxRobotList.ItemsSource = robots;

        }

        private void lbxRobotList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
