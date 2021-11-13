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

namespace WPFCheckBox
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

        private void cbAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllToppings.IsChecked == true);

            cbPepperoni.IsChecked = newVal;
            cbAnchovies.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllToppings.IsChecked = null;
            if((cbPepperoni.IsChecked == true) && (cbMozzarella.IsChecked == true) && (cbAnchovies.IsChecked == true))
            {
                cbAllToppings.IsChecked = true;
            }           
            if((cbPepperoni.IsChecked == false) && (cbMozzarella.IsChecked == false) && (cbAnchovies.IsChecked == false))
            {
                cbAllToppings.IsChecked = false;
            }
        }
    }
}
