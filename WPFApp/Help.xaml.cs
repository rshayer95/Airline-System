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
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the Help window?",
"Quit Application", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Close the current window  
                Application.Current.Windows[Application.Current.Windows.Count - 2].Close();
            }
            
        }
    }
}
