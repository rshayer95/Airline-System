using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            

        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            LoginHelper.populateloginTable();
            CustomerHelper.populateCustomersData();
            AirlineHelper.populateAirlinesData();
            FlightHelper.populateFlightData();
            passengerHelper.populatePassengerData();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
           
           if(username.Text == "" && password.Password == "")
            {
                MessageBox.Show("Please enter username and password","Error");
                

            }
            else if(username.Text == "")
            {
                MessageBox.Show("Please enter your username", "Error");
            }
           else if (password.Password == "")
            {
                MessageBox.Show("Please enter your password", "Error");
            }
            else
            {
                var users = LoginHelper.users.Where(u =>username.Text == u.Value["Username"] && password.Password == u.Value["Password"]);
                var superUser = from superUsers in LoginHelper.users where username.Text == superUsers.Value["Username"] && password.Password == superUsers.Value["Password"] select superUsers.Value["SuperUser"];
                if (users.Count() == 1)
                {
                    LoginHelper.isLoggedIn = true;
                    if (superUser.Count() > 0)
                    {
                        foreach (var SuperUser in superUser)
                        {
                            if (SuperUser == "1")
                            {
                                LoginHelper.isSuperUser = true;
                                break;
                            }
                        }
                    }
                    Home window = new Home();
                    window.Owner = this;
                    this.Hide(); 
                    window.ShowDialog();

                }
                else
                {
                        MessageBox.Show("Invalid Username/Password");
                }
            }

        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?",
"Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Close the window  
                Application.Current.Shutdown();
            }
            
        }
    }
}
