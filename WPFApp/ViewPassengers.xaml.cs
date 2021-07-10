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
    /// Interaction logic for ViewPassengers.xaml
    /// </summary>
    public partial class ViewPassengers : Window
    {
        public ViewPassengers()
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
            var passengers = from passengerData in passengerHelper.passengers select passengerData;
            listPassengers.ItemsSource = passengers;

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
            window.ShowDialog();
        }
        private void InsertEvent(object sender, RoutedEventArgs e)
        {
            if (passengerID.Text != "" && customerID.Text != "" && flightID.Text != "")
            {
                if (LoginHelper.isSuperUser)
                {
                    try
                    {
                        if (passengerHelper.AddPassenger(new Passenger() { ID = Convert.ToInt32(passengerID.Text), customerID = Convert.ToInt32(customerID.Text), flightID = Convert.ToInt32(flightID.Text) }))
                        {
                            MessageBox.Show("Successfully Added");
                            var passengers = from passengerData in passengerHelper.passengers select passengerData;
                            listPassengers.ItemsSource = passengers;
                        }
                        else
                        {
                            MessageBox.Show("Either Customer ID or Flight ID does not exists");
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter valid data to insert");
                    }
                }
                else
                {
                    MessageBox.Show("You do not have permission to add the item");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data to insert");
            }
        }
        private void UpdateEvent(object sender, RoutedEventArgs e)
        {

            if (listPassengers.SelectedIndex >= 0)
            {
                if (passengerID.Text != "" && customerID.Text != "" && flightID.Text != "")
                {
                    if (LoginHelper.isSuperUser)
                    {
                        try
                        {
                            if (passengerHelper.UpdatePassenger(new Passenger() { ID = Convert.ToInt32(passengerID.Text), customerID = Convert.ToInt32(customerID.Text), flightID = Convert.ToInt32(flightID.Text) }))
                            {
                                MessageBox.Show("Successfully Updated");
                                var passengers = from passengerData in passengerHelper.passengers select passengerData;
                                listPassengers.ItemsSource = passengers;
                            }
                            else
                            {
                                MessageBox.Show("Either Passenger Id, Customer ID or Flight ID does not exists");
                            }


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please enter valid data to update");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to update the item");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid data to update");
                }
            }
            else
            {
                MessageBox.Show("Please select and item to Update", "Error");
            }


        }
        private void DeleteEvent(object sender, RoutedEventArgs e)
        {
            if (listPassengers.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic passenger_Data = listPassengers.SelectedItem as dynamic;
                int id = passenger_Data.ID;
                if (LoginHelper.isSuperUser)
                {
                    if (passengerHelper.findPassengerByID(id))
                    {
                        if (MessageBox.Show("Do you want to delete this item?",
    "Delete Item", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            passengerHelper.deletePassenger(id);
                            MessageBox.Show("Successfully deleted");
                            listPassengers.SelectedIndex = listPassengers.SelectedIndex - 1;
                            var passengers = from passengerData in passengerHelper.passengers select passengerData;
                            listPassengers.ItemsSource = passengers;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Flight does not exist");
                    }

                }
                else
                {
                    MessageBox.Show("You don't have permissions to delete the items", "Error");
                }

            }
            else
            {
                MessageBox.Show("Please select an item to delete", "Error");
            }

        }



        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to reset the textbox values?",
    "Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                flightID.Text = "";
                customerID.Text = "";
                passengerID.Text = "";
                
            }

        }

        private void listPassengers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listPassengers.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic PASSENGER = listPassengers.SelectedItem as dynamic;
                int id = PASSENGER.ID;
                if (passengerHelper.findPassengerByID(id))
                {
                    passengerID.Text = Convert.ToString(PASSENGER.ID);
                    customerID.Text = Convert.ToString(PASSENGER.customerID);
                    flightID.Text = Convert.ToString(PASSENGER.flightID);
                }
                else
                {
                    MessageBox.Show("Flight does not exist");
                }

            }
            else
            {
                MessageBox.Show("Nothing selected", "Error");
            }
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            Home window = new Home();
            window.Owner = this;
            this.Hide();
            window.ShowDialog();
        }

    }
}
