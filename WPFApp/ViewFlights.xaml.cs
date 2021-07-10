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
    /// Interaction logic for ViewFlights.xaml
    /// </summary>
    public partial class ViewFlights : Window
    {
        public ViewFlights()
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
            var flights = from flightsData in FlightHelper.flights select flightsData;
            listFlights.ItemsSource = flights;
             
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
            if (flightID.Text != "" && airlineID.Text != "" && DepartureCity.Text != "" &&
                DepartureDate.Text != "" && FlightHours.Text != "")
            {
                if (LoginHelper.isSuperUser)
                {
                    try
                    {
                        if (FlightHelper.AddFlight(new Flights() { ID = Convert.ToInt32(flightID.Text), airlineID = Convert.ToInt32(airlineID.Text), DepartureCity = DepartureCity.Text, DepartureDate = DepartureDate.Text, FlightHours = Convert.ToDouble(FlightHours.Text) }))
                        {
                            MessageBox.Show("Successfully Added");
                            var flights = from flightsData in FlightHelper.flights select flightsData;
                            listFlights.ItemsSource = flights;
                        }
                        else
                        {
                            MessageBox.Show("Airline ID does not exists");
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

           if (listFlights.SelectedIndex >= 0)
            {
                if (flightID.Text != "" && airlineID.Text != "" && DepartureCity.Text != "" &&
                DepartureDate.Text != "" && FlightHours.Text != "")
                {
                    if (LoginHelper.isSuperUser)
                    {
                        try
                        {
                            if (FlightHelper.UpdateFlight(new Flights() { ID = Convert.ToInt32(flightID.Text), airlineID = Convert.ToInt32(airlineID.Text), DepartureCity = DepartureCity.Text, DepartureDate = DepartureDate.Text, FlightHours = Convert.ToDouble(FlightHours.Text) }))
                            {
                                MessageBox.Show("Successfully Updated");
                                var flights = from flightsData in FlightHelper.flights select flightsData;
                                listFlights.ItemsSource = flights;
                            }
                            else
                            {
                                MessageBox.Show("Airline ID does not exists");
                            }


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please enter valid data to update");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to add the item");
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
           if (listFlights.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic flight = listFlights.SelectedItem as dynamic;
                int flightid = flight.ID;
                if (LoginHelper.isSuperUser)
                {
                    if (FlightHelper.findFlightByID(flightid))
                    {
                        if (MessageBox.Show("Do you want to delete this item?",
    "Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            FlightHelper.deleteFlight(flightid);
                            MessageBox.Show("Successfully deleted");
                            listFlights.SelectedIndex = listFlights.SelectedIndex - 1;
                            var flights = from flightsData in FlightHelper.flights select flightsData;
                            listFlights.ItemsSource = flights;
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
                airlineID.Text = "";
                DepartureCity.Text = "";
                DepartureDate.Text = "";
                FlightHours.Text = "";
            }

        }

        private void listFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if (listFlights.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic FLIGHT = listFlights.SelectedItem as dynamic;
                int id = FLIGHT.ID;
                if (FlightHelper.findFlightByID(id))
                {
                    flightID.Text = Convert.ToString(FLIGHT.ID);
                    airlineID.Text = Convert.ToString(FLIGHT.airlineID);
                    DepartureCity.Text = FLIGHT.DepartureCity;
                    DepartureDate.Text = FLIGHT.DepartureDate;
                    FlightHours.Text = Convert.ToString(FLIGHT.FlightHours);
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
