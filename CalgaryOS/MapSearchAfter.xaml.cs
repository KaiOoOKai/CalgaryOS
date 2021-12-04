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
using System.Windows.Threading;
namespace CalgaryOS
{
    /// <summary>
    /// Interaction logic for MapSearch.xaml
    /// </summary>
    public partial class MapSearchAfter : UserControl
    {
        DispatcherTimer DispatcherTimer = new DispatcherTimer();
        public MapSearchAfter()
        {
            InitializeComponent();
            DispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            DispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            switch (Switcher.GetCounter())
            {
                case 1:
                    languageButton.Content = "English";
                    break;
                case 2:
                    languageButton.Content = "Español";
                    break;
                case 3:
                    languageButton.Content = "Français";
                    break;
                case 4:
                    languageButton.Content = "普通话";
                    break;
                case 5:
                    languageButton.Content = "हिंदी";
                    break;
            }
            DispatcherTimer.Start();
            if (!Switcher.getLanguage())
            {
                choiceText.Content = "1. Campus principal de l'Université de Calgary" + Environment.NewLine + "2. Campus Spy Hill de l'Université de Calgary" + Environment.NewLine + "3. Campus du centre-ville de l'Université de Calgary";
                mapText.Text = "Carte";
                exploreText.Text = "Explorer";
                searchText.Text = "Université de Calgary";
                filterButton.Content = "Filtres";
                clearButton.Content = "Effacer";
                enterButton.Content = "Entrée";
            }
            
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {

            switch (Switcher.GetCounter())
            {
                case 1:
                    languageButton.Content = "English";
                    break;
                case 2:
                    languageButton.Content = "Español";
                    break;
                case 3:
                    languageButton.Content = "Français";
                    break;
                case 4:
                    languageButton.Content = "普通话";
                    break;
                case 5:
                    languageButton.Content = "हिंदी";
                    break;
            }
            Switcher.SetCounter();
        }
        private void DispatcherTimer_Stop()
        {
            DispatcherTimer.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Explore());
            DispatcherTimer_Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
            DispatcherTimer_Stop();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapFilters());
            DispatcherTimer_Stop();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new MapSearch());
            Switcher.Switch(new LanguageScreen());
            DispatcherTimer_Stop();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDirections());
            DispatcherTimer_Stop();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapSearch());
            DispatcherTimer_Stop();
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
    }
}
