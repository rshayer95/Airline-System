using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for ViewAirlines.xaml
    /// </summary>
    public partial class ViewAirlines : Window
    {
        public ViewAirlines()
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
            var airlineData = from data in AirlineHelper.airlines select data;
            listAirlines.ItemsSource = airlineData;

            
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
            if (airlineID.Text != "" && airlineName.Text != "" && AirlineHelper.selectedMeal != "" &&
                AirlineHelper.selectedAirplane != "" && seatsAvailable.Text != "")
            {
                if (LoginHelper.isSuperUser)
                {
                    try
                    {
                        if (AirlineHelper.AddAirline(new Airline() { ID = Convert.ToInt32(airlineID.Text), Name = airlineName.Text, Airplane = AirlineHelper.selectedAirplane, seatsAvailable = Convert.ToInt32(seatsAvailable.Text), mealsAvailable = AirlineHelper.selectedMeal }))
                        {
                            MessageBox.Show("Successfully Added");
                            var airlineData = from data in AirlineHelper.airlines select data;
                            listAirlines.ItemsSource = airlineData;

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
            
            if (listAirlines.SelectedIndex >= 0)
            {
                if (airlineID.Text != "" && airlineName.Text != "" && seatsAvailable.Text != "" &&
                AirlineHelper.selectedMeal != "" && AirlineHelper.selectedAirplane != "")
                {
                    if (LoginHelper.isSuperUser)
                    {
                        try
                        {
                            if (MessageBox.Show("Do you want to update this item?",
"Update Item", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            {
                                if (AirlineHelper.UpdateAirline(new Airline() { ID = Convert.ToInt32(airlineID.Text), Name = airlineName.Text, Airplane = AirlineHelper.selectedAirplane, seatsAvailable = Convert.ToInt32(seatsAvailable.Text), mealsAvailable = AirlineHelper.selectedMeal }))
                                {
                                    MessageBox.Show("Successfully Updated");
                                    var airlineData = from data in AirlineHelper.airlines select data;
                                    listAirlines.ItemsSource = airlineData;

                                }
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
            if (listAirlines.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic AIRLINE = listAirlines.SelectedItem as dynamic;
                int airlineID = AIRLINE.ID;
                if (LoginHelper.isSuperUser)
                {
                    if (AirlineHelper.findAirlineByID(airlineID))
                    {
                        if (MessageBox.Show("Do you want to delete this item?",
    "Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            AirlineHelper.deleteAirline(airlineID);
                            MessageBox.Show("Successfully deleted");
                            listAirlines.SelectedIndex = listAirlines.SelectedIndex - 1;
                            var airlineData = from data in AirlineHelper.airlines select data;
                            listAirlines.ItemsSource = airlineData;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Airline does not exist");
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
                airlineID.Text = "";
                airlineName.Text = "";
                seatsAvailable.Text = "";
                AirlineHelper.selectedMeal = "";
                AirlineHelper.selectedAirplane = "";
                sushi.IsChecked = false;
                chicken.IsChecked = false;
                salad.IsChecked = false;
                Paranthas.IsChecked = false;
                boeing777.IsChecked = false;
                india2375.IsChecked = false;
                canada270.IsChecked = false;
                ethihad100.IsChecked = false;
            }

        }

        private void listAirlines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listAirlines.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic AIRLINE_DATA = listAirlines.SelectedItem as dynamic;
                int id = AIRLINE_DATA.ID;
                if (AirlineHelper.findAirlineByID(id))
                {
                    airlineID.Text = Convert.ToString(AIRLINE_DATA.ID);
                    airlineName.Text = AIRLINE_DATA.Name;
                    seatsAvailable.Text = Convert.ToString(AIRLINE_DATA.seatsAvailable);
                    switch (AIRLINE_DATA.mealsAvailable)
                    {
                        case "Sushi":
                            sushi.IsChecked = true;
                            break;
                        case "Salad":
                            salad.IsChecked = true;
                            break;
                        case "Chicken":
                            chicken.IsChecked = true;
                            break;
                        case "Paranthas":
                            Paranthas.IsChecked = true;
                            break;
                        default:
                            MessageBox.Show("Option not available");
                            break;

                    }
                    switch (AIRLINE_DATA.Airplane)
                    {
                        case "Boeing 777":
                            boeing777.IsChecked = true;
                            break;
                        case "Canada 270":
                            canada270.IsChecked = true;
                            break;
                        case "India 2375":
                            india2375.IsChecked = true;
                            break;
                        case "Ethihad 100":
                            ethihad100.IsChecked = true;
                            break;
                        default:
                            MessageBox.Show("Option not available");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Airline does not exist");
                }

            }
            else
            {
                MessageBox.Show("Nothing selected", "Error");
            }
        }

        private void meal_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender; // checked RadioButton

            AirlineHelper.selectedMeal = radioButton.Content.ToString();
        }
        private void airplane_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender; // checked RadioButton

            AirlineHelper.selectedAirplane = radioButton.Content.ToString();
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
