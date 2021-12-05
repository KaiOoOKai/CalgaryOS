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
    public partial class TaxiDirections : UserControl
    {
        DispatcherTimer DispatcherTimer = new DispatcherTimer();
        public TaxiDirections()
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

                    pointerImage.Margin = new Thickness(205, 683, 0, 0);
                    mapImage.Source = bi1;

                    
                    searchText.Text = "Massive Blue Ring";
            

                    break;
                case 2:
                    BitmapImage bi2 = new BitmapImage();
                    bi2.BeginInit();
                    bi2.UriSource = new Uri("Images/googmapShaq.png", UriKind.RelativeOrAbsolute);
                    bi2.EndInit();

                    pointerImage.Margin = new Thickness(405, 785, 0, 0);
                    mapImage.Source = bi2;

                 
                    searchText.Text = "Shaqs Shake Shack";
 
                    break;
                case 3:
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("Images/googmapComfort.png", UriKind.RelativeOrAbsolute);
                    bi3.EndInit();

                    pointerImage.Margin = new Thickness(480, 285, 0, 0);
                    mapImage.Source = bi3;

                    
                    searchText.Text = "Comfort Inn";
                   
                    break;
                case 4:
                    BitmapImage bi4 = new BitmapImage();
                    bi4.BeginInit();
                    bi4.UriSource = new Uri("Images/googmapStampede.png", UriKind.RelativeOrAbsolute);
                    bi4.EndInit();

                    pointerImage.Margin = new Thickness(453, 420, 0, 0);
                    mapImage.Source = bi4;

                  
                    searchText.Text = "Stampede";
                   
                    break;
                case 5:
                    BitmapImage bi5 = new BitmapImage();
                    bi5.BeginInit();
                    bi5.UriSource = new Uri("Images/googmapMall.png", UriKind.RelativeOrAbsolute);
                    bi5.EndInit();

                    pointerImage.Margin = new Thickness(225, 37, 0, 0);
                    mapImage.Source = bi5;

                  
                    searchText.Text = "Mall";
              
                    break;

                case 6:
                    BitmapImage bi6 = new BitmapImage();
                    bi6.BeginInit();
                    bi6.UriSource = new Uri("Images/googmapRock.png", UriKind.RelativeOrAbsolute);
                    bi6.EndInit();

                    pointerImage.Margin = new Thickness(11, 255, 0, 0);
                    mapImage.Source = bi6;

                    searchText.Text = "Rock Rap Tour";
                   
                    break;
                default:
                    if (!Switcher.GetLanguage())
                    {
                        mapText.Text = "Carte";
                        exploreText.Text = "Explorer";
                        
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
            instructionText.Content = "Taxi Ordered";
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


                if (Canvas1.TranslatePoint(new Point(0, 0), Grid1).X + (p.X - point.X) > -250 && Canvas1.TranslatePoint(new Point(0, 0), Grid1).X + (p.X - point.X) < 250)
                {
                    translate.X += (p.X - point.X);
                }


                if (Canvas1.TranslatePoint(new Point(0, 0), Grid1).Y + (p.Y - point.Y) > -250 && Canvas1.TranslatePoint(new Point(0, 0), Grid1).Y + (p.Y - point.Y) < 250)
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
