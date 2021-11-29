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
    /// Interaction logic for Explore.xaml
    /// </summary>
    public partial class Explore : UserControl
    {
        public Explore()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new Explore());
            Switcher.Switch(new LanguageScreen());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDirectionsMCD());
        }
    }
}
