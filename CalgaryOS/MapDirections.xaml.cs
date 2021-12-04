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
    /// Interaction logic for MapDirections.xaml
    /// </summary>
    public partial class MapDirections : UserControl
    {
        DispatcherTimer DispatcherTimer = new DispatcherTimer();
        public MapDirections()
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
                mapText.Text = "Carte";
                exploreText.Text = "Explorer";
                instructionButton.Content = "Imprimer Instructions";
                instructionText.Content = "1. Allez vers l'ouest sur la rue ouest sur 1,5 km" +Environment.NewLine +"2. Allez au nord 100m puis tournez à gauche" + Environment.NewLine + "3. Prendre la sortie de la route principale à 0,5 km" + Environment.NewLine + "4. Prendre la sortie de la route principale à 4 km" + Environment.NewLine + "5. La destination sera sur la gauche dans 0,5 km";
                filterButton.Content = "Filtres";
                searchText.Text = "Campus principal de l'Univers...";
                transitSwitchButton.Content = "Passer en transit";
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
            Switcher.Switch(new TransitDirections());
            DispatcherTimer_Stop();
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
            DispatcherTimer_Stop();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
            DispatcherTimer_Stop();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new MapDirections());
            Switcher.Switch(new LanguageScreen());
            DispatcherTimer_Stop();
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
    }
}
