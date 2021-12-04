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
            
            switch (Switcher.GetDirection())
            {
               
                case 1:
                    BitmapImage bi1 = new BitmapImage();
                    bi1.BeginInit();
                    bi1.UriSource = new Uri("Images/googmapBlueRing.png", UriKind.RelativeOrAbsolute);
                    bi1.EndInit();
                   
                    pointerImage.Margin = new Thickness(124, 635, 0, 0);
                    mapImage.Source = bi1;

                    instructionText.Content = "1. Go east on main street for 1 km" + Environment.NewLine + "2. Go south 8 km then turn left" + Environment.NewLine + "3. Continue on road for 2 km" + Environment.NewLine + "4. Go south for 4 km" + Environment.NewLine + "5. Destination will be on the right in 0.5 km";
                    searchText.Text = "Massive Blue Ring";
                    transitSwitchButton.IsEnabled = false;

                    break;
                case 2:
                    BitmapImage bi2 = new BitmapImage();
                    bi2.BeginInit();
                    bi2.UriSource = new Uri("Images/googmapShaq.png", UriKind.RelativeOrAbsolute);
                    bi2.EndInit();

                    pointerImage.Margin = new Thickness(325, 700, 0, 0);
                    mapImage.Source = bi2;

                    instructionText.Content = "1. Go east on main street for 1 km" + Environment.NewLine + "2. Go south 15 km then turn left" + Environment.NewLine + "3. Continue on road for 3 km" + Environment.NewLine + "4. Destination will be on the right in 0.5 km";
                    searchText.Text = "Shaqs Shake Shack";
                    transitSwitchButton.IsEnabled = false;
                    break;
                case 3:
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("Images/googmapComfort.png", UriKind.RelativeOrAbsolute);
                    bi3.EndInit();

                    pointerImage.Margin = new Thickness(410, 215, 0, 0);
                    mapImage.Source = bi3;

                    instructionText.Content = "1. Go east on McClevins street for 6 km" + Environment.NewLine + "2. Go south 400 m then turn right"  + Environment.NewLine + "3. Destination will be on the right in 100 m";
                    searchText.Text = "Comfort Inn";
                    transitSwitchButton.IsEnabled = false;
                    break;
                case 4:
                    BitmapImage bi4 = new BitmapImage();
                    bi4.BeginInit();
                    bi4.UriSource = new Uri("Images/googmapStampede.png", UriKind.RelativeOrAbsolute);
                    bi4.EndInit();

                    pointerImage.Margin = new Thickness(385, 360, 0, 0);
                    mapImage.Source = bi4;

                    instructionText.Content = "1. Go east on main street for 1 km" + Environment.NewLine + "2. Go south 5 km then turn right" + Environment.NewLine + "3. Continue on road for 3 km" + Environment.NewLine + "4. Go south for 2 km" + Environment.NewLine + "5. Destination will be on the left in 3 km";
                    searchText.Text = "Stampede";
                    transitSwitchButton.IsEnabled = false;
                    break;
                case 5:
                    BitmapImage bi5 = new BitmapImage();
                    bi5.BeginInit();
                    bi5.UriSource = new Uri("Images/googmapMall.png", UriKind.RelativeOrAbsolute);
                    bi5.EndInit();

                    pointerImage.Margin = new Thickness(155, -35, 0, 0);
                    mapImage.Source = bi5;

                    instructionText.Content = "1. Go west on main street for 3 km" + Environment.NewLine + "2. Go north 8 km then turn left" + Environment.NewLine + "3. Continue on road for 3 km" + Environment.NewLine  + "4. Destination will be on the right in 300 m";
                    searchText.Text = "Mall";
                    transitSwitchButton.IsEnabled = false;
                    break;

                case 6:
                    BitmapImage bi6 = new BitmapImage();
                    bi6.BeginInit();
                    bi6.UriSource = new Uri("Images/googmapRock.png", UriKind.RelativeOrAbsolute);
                    bi6.EndInit();

                    pointerImage.Margin = new Thickness(-100, 185, 0, 0);
                    mapImage.Source = bi6;

                    instructionText.Content = "1. Go wast on main street for 9 km"+  Environment.NewLine + "2. Destination will be on the left in 0.5 km";
                    searchText.Text = "Rock Rap Tour";
                    transitSwitchButton.IsEnabled = false;
                    break;
                default:
                    if (!Switcher.GetLanguage())
                    {
                        mapText.Text = "Carte";
                        exploreText.Text = "Explorer";
                        instructionButton.Content = "Imprimer Instructions";
                        instructionText.Content = "1. Allez vers l'ouest sur la rue ouest sur 1,5 km" + Environment.NewLine + "2. Allez au nord 100m puis tournez à gauche" + Environment.NewLine + "3. Prendre la sortie de la route principale à 0,5 km" + Environment.NewLine + "4. Prendre la sortie de la route principale à 4 km" + Environment.NewLine + "5. La destination sera sur la gauche dans 0,5 km";

                        searchText.Text = "Campus principal de l'Univers...";
                        transitSwitchButton.Content = "Passer en transit";
                    }
                    break;
            }
            Switcher.SetDirection(0);

            
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
        private Point point;
        private bool isDragged;
        private void Canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Canvas1.CaptureMouse();
            point = Mouse.GetPosition(this);
            isDragged = true;

        }

        private void Canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged == false)
                return;
            if (Canvas1.IsMouseCaptured)
            {

                var p = e.GetPosition(this);


                if (Canvas1.TranslatePoint(new Point(0, 0), Grid1).X + (p.X - point.X) > -375 && Canvas1.TranslatePoint(new Point(0, 0), Grid1).X + (p.X - point.X) < 375)
                {
                    translate.X += (p.X - point.X);
                }


                if (Canvas1.TranslatePoint(new Point(0, 0), Grid1).Y + (p.Y - point.Y) > -375 && Canvas1.TranslatePoint(new Point(0, 0), Grid1).Y + (p.Y - point.Y) < 375)
                {
                    translate.Y += (p.Y - point.Y);
                }


                point = p;
            }
        }
        private void Canvas1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Canvas1.ReleaseMouseCapture();
            isDragged = false;
        }
    }
}
