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
    /// Interaction logic for Airlines.xaml
    /// </summary>
    public partial class Airlines : Window
    {
        public Airlines()
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
            var AirlinesData = from airlines in AirlineHelper.airlines select airlines;
            listAirlines.ItemsSource = AirlinesData;
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
            /*if (customerID.Text != "" && customerName.Text != "" && customerAddress.Text != "" &&
                customerEmail.Text != "" && customerPhone.Text != "")
            {
                if (LoginHelper.isSuperUser)
                {
                    try
                    {
                        if (CustomerHelper.AddCustomer(new Customer() { ID = Convert.ToInt32(customerID.Text), Name = customerName.Text, Address = customerAddress.Text, Email = customerEmail.Text, Phone = customerPhone.Text }))
                        {
                            MessageBox.Show("Successfully Added");
                            listCustomers.ItemsSource = CustomerHelper.customers;
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
            }*/
        }
        private void UpdateEvent(object sender, RoutedEventArgs e)
        {

            /*if (listCustomers.SelectedIndex >= 0)
            {
                if (customerID.Text != "" && customerName.Text != "" && customerAddress.Text != "" &&
                customerEmail.Text != "" && customerPhone.Text != "")
                {
                    if (LoginHelper.isSuperUser)
                    {
                        try
                        {
                            if (MessageBox.Show("Do you want to update this item?",
"Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            {
                                if (CustomerHelper.UpdateCustomer(new Customer() { ID = Convert.ToInt32(customerID.Text), Name = customerName.Text, Address = customerAddress.Text, Email = customerEmail.Text, Phone = customerPhone.Text }))
                                {
                                    MessageBox.Show("Successfully Updated");
                                    listCustomers.ItemsSource = CustomerHelper.customers;
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

            */
        }
        private void DeleteEvent(object sender, RoutedEventArgs e)
        {
            if (listAirlines.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic airline = listAirlines.SelectedItem as dynamic;
                int airlineID = airline.ID;
                if (LoginHelper.isSuperUser)
                {
                    if (AirlineHelper.findAirlineByID(airlineID))
                    {
                        if (MessageBox.Show("Do you want to delete this item?",
    "Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            AirlineHelper.deleteAirline(airlineID);
                            MessageBox.Show("Successfully deleted");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Airline does not exist");
                    }

                    listAirlines.ItemsSource = AirlineHelper.airlines;

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
           /* if (MessageBox.Show("Do you want to reset the textbox values?",
    "Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                customerID.Text = "";
                customerName.Text = "";
                customerAddress.Text = "";
                customerEmail.Text = "";
                customerPhone.Text = "";
            }
           */
        }

        private void listAirlines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*if (listAirlines.SelectedIndex >= 0)
            {
                //use dynamic as type to cast your anonymous object
                dynamic customer = listCustomers.SelectedItem as dynamic;
                int id = customer.ID;
                if (CustomerHelper.findCustomerByID(id))
                {
                    customerID.Text = Convert.ToString(customer.ID);
                    customerName.Text = customer.Name;
                    customerAddress.Text = customer.Address;
                    customerEmail.Text = customer.Email;
                    customerPhone.Text = customer.Phone;
                }
                else
                {
                    MessageBox.Show("Customer does not exist");
                }

            }
            else
            {
                MessageBox.Show("Please select an item to Update", "Error");
            }
            */
        }
    }
}
