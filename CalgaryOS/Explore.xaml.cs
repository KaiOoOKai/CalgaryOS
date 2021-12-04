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
    /// Interaction logic for Explore.xaml
    /// </summary>
    public partial class Explore : UserControl
    {
        DispatcherTimer DispatcherTimer = new DispatcherTimer();
        public Explore()
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
                helpLabel.Content = "Tapez pour les directions";
                helpLabel.Margin = new Thickness(25, 53, 0, 0);
                eventsLabel.Content = "Événements";
                eventsLabel.Margin = new Thickness(130, 513, 26, 0);

                restaurant1.Content = "1: Monsieur Donnis";
                restaurant2.Content = "2: Fête de Dunkaroo";

                sightLabel.Content = "Vues";
                sight1.Content = "1: Montagne de la baguette";
                sight2.Content = "2: Fontaine d'eau";
                sight3.Content = "3: Bague Bleue";

                event2.Content = "2: Fête des Quilles";
                event3.Content = "3: La Tournée rap de The Rock";

                mapText.Text = "Carte";
                exploreText.Text = "Explorer";
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

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new Explore());
            Switcher.Switch(new LanguageScreen());
            DispatcherTimer_Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
            DispatcherTimer_Stop();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDirectionsMCD());
            DispatcherTimer_Stop();
        }
       

        private void Services(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
            DispatcherTimer_Stop();
        }

        private void Transit(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
            DispatcherTimer_Stop();
        }
        private void Taxi(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TaxiDefault());
            DispatcherTimer_Stop();
        }
        private void Map(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
            DispatcherTimer_Stop();
        }
    }
}
