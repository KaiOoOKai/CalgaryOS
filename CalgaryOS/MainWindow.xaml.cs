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

namespace CalgaryOS
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            City cty = new City();
            Explore exp = new Explore();

            MapDefault mdef = new MapDefault();
            MapDirections mdir = new MapDirections();
            MapSearch msea = new MapSearch();
            MapFilters mfil = new MapFilters();

            TransitDefault tdef = new TransitDefault();
            TransitDirections tdir = new TransitDirections();
            TransitSearch tsea = new TransitSearch();

            cty.Show();
            exp.Show();
            mdef.Show();
            mdir.Show();
            msea.Show();
            mfil.Show();
            tdef.Show();
            tdir.Show();
            tsea.Show();
        }
    }
}
