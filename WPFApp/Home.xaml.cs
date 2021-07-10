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
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            

        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            if (LoginHelper.isLoggedIn == false)
            {
                Login window = new Login();
                window.Owner = this;
                this.Hide();
                window.ShowDialog();

            }
            /*var Users = from user in LoginHelper.users select user.Value["Username"];
            listUsers.DataContext = Users;*/
        }

        private void viewCustomers_Click(object sender, RoutedEventArgs e)
        {
            Customers window = new Customers();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }

        private void viewAirlines_Click(object sender, RoutedEventArgs e)
        {
            ViewAirlines window = new ViewAirlines();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }

        private void viewFlights_Click(object sender, RoutedEventArgs e)
        {
            ViewFlights window = new ViewFlights();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }

        private void viewPassenger_Click(object sender, RoutedEventArgs e)
        {
            ViewPassengers window = new ViewPassengers();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?",
"Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Close the window  
                Application.Current.Shutdown();
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Help window = new Help();
            window.Owner = this;
            //this.Hide();
            window.ShowDialog();
        }
    }
}
