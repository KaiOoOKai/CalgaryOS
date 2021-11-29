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

namespace CalgaryOS
{
    /// <summary>
    /// Interaction logic for MapDirections.xaml
    /// </summary>
    public partial class TaxiDirections : UserControl
    {
        public TaxiDirections()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDirections());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Explore());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TaxiDefault());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new TaxiDirections());
            Switcher.Switch(new LanguageScreen());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }
        private void Explore(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Explore());
        }

        private void Services(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
        }

        private void Transit(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
        }
        private void Taxi(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TaxiDefault());
        }
        private void Map(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
        }

        private void Order(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TaxiOrdered());
        }
    }
}
