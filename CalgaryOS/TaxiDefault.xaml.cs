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
using System.Diagnostics;
using System.Windows.Threading;
namespace CalgaryOS
{
    /// <summary>
    /// Interaction logic for MapDefault.xaml
    /// </summary>
    public partial class TaxiDefault : UserControl
    {
        DispatcherTimer DispatcherTimer = new DispatcherTimer();
        public TaxiDefault()
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

            blueButton.Visibility = Visibility.Hidden;
            blueButton.IsEnabled = false;
            getBlueDirection.Visibility = Visibility.Hidden;
            getBlueDirection.IsEnabled = false;

            shaqButton.Visibility = Visibility.Hidden;
            shaqButton.IsEnabled = false;
            getShaqDirection.Visibility = Visibility.Hidden;
            getShaqDirection.IsEnabled = false;

            stampedeButton.Visibility = Visibility.Hidden;
            stampedeButton.IsEnabled = false;
            getStampedeDirection.Visibility = Visibility.Hidden;
            getStampedeDirection.IsEnabled = false;

            innButton.Visibility = Visibility.Hidden;
            innButton.IsEnabled = false;
            getInnDirection.Visibility = Visibility.Hidden;
            getInnDirection.IsEnabled = false;

            mallButton.Visibility = Visibility.Hidden;
            mallButton.IsEnabled = false;
            getMallDirection.Visibility = Visibility.Hidden;
            getMallDirection.IsEnabled = false;

            rockButton.Visibility = Visibility.Hidden;
            rockButton.IsEnabled = false;
            getRockDirection.Visibility = Visibility.Hidden;
            getRockDirection.IsEnabled = false;




           
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
            Switcher.Switch(new TaxiSearch());
        }
        private void Taxi(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TaxiDefault());
        }
        private void Map(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TaxiSearch());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new TaxiDefault());
            Switcher.Switch(new LanguageScreen());
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


                if (Canvas1.TranslatePoint(new Point(0, 0), Grid1).X + (p.X - point.X) > -150 && Canvas1.TranslatePoint(new Point(0, 0), Grid1).X + (p.X - point.X) < 150)
                {
                    translate.X += (p.X - point.X);
                }
           

                if (Canvas1.TranslatePoint(new Point(0, 0), Grid1).Y + (p.Y - point.Y) > -150 && Canvas1.TranslatePoint(new Point(0, 0), Grid1).Y + (p.Y - point.Y) < 150)
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

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }
        private void sightButtonClick(object sender, RoutedEventArgs e)
        {
            if (blueButton.IsEnabled)
            {
                blueButton.Visibility = Visibility.Hidden;
                blueButton.IsEnabled = false;
                getBlueDirection.Visibility = Visibility.Hidden;
                getBlueDirection.IsEnabled = false;
            }
            else
            {
                blueButton.Visibility = Visibility.Visible;
                blueButton.IsEnabled = true;
                getBlueDirection.Visibility = Visibility.Visible;
                getBlueDirection.IsEnabled = true;
            }

        }

        private void restaurantButtonClick(object sender, RoutedEventArgs e)
        {
            if (shaqButton.IsEnabled)
            {
                shaqButton.Visibility = Visibility.Hidden;
                shaqButton.IsEnabled = false;
                getShaqDirection.Visibility = Visibility.Hidden;
                getShaqDirection.IsEnabled = false;
            }
            else
            {
                shaqButton.Visibility = Visibility.Visible;
                shaqButton.IsEnabled = true;
                getShaqDirection.Visibility = Visibility.Visible;
                getShaqDirection.IsEnabled = true;
            }
        }



        private void hotspotButtonClick(object sender, RoutedEventArgs e)
        {
            if (stampedeButton.IsEnabled)
            {
                stampedeButton.Visibility = Visibility.Hidden;
                stampedeButton.IsEnabled = false;
                getStampedeDirection.Visibility = Visibility.Hidden;
                getStampedeDirection.IsEnabled = false;
            }
            else
            {
                stampedeButton.Visibility = Visibility.Visible;
                stampedeButton.IsEnabled = true;
                getStampedeDirection.Visibility = Visibility.Visible;
                getStampedeDirection.IsEnabled = true;
            }
        }


        private void hotelButtonClick(object sender, RoutedEventArgs e)
        {
            if (innButton.IsEnabled)
            {
                innButton.Visibility = Visibility.Hidden;
                innButton.IsEnabled = false;
                getInnDirection.Visibility = Visibility.Hidden;
                getInnDirection.IsEnabled = false;
            }
            else
            {
                innButton.Visibility = Visibility.Visible;
                innButton.IsEnabled = true;
                getInnDirection.Visibility = Visibility.Visible;
                getInnDirection.IsEnabled = true;
            }
        }

        private void mallButtonClick(object sender, RoutedEventArgs e)
        {
            if (mallButton.IsEnabled)
            {
                mallButton.Visibility = Visibility.Hidden;
                mallButton.IsEnabled = false;
                getMallDirection.Visibility = Visibility.Hidden;
                getMallDirection.IsEnabled = false;
            }
            else
            {
                mallButton.Visibility = Visibility.Visible;
                mallButton.IsEnabled = true;
                getMallDirection.Visibility = Visibility.Visible;
                getMallDirection.IsEnabled = true;
            }
        }

        private void rockButtonClick(object sender, RoutedEventArgs e)
        {
            if (rockButton.IsEnabled)
            {
                rockButton.Visibility = Visibility.Hidden;
                rockButton.IsEnabled = false;
                getRockDirection.Visibility = Visibility.Hidden;
                getRockDirection.IsEnabled = false;
            }
            else
            {
                rockButton.Visibility = Visibility.Visible;
                rockButton.IsEnabled = true;
                getRockDirection.Visibility = Visibility.Visible;
                getRockDirection.IsEnabled = true;
            }
        }

        private void getBlueDirectionButton(object sender, RoutedEventArgs e)
        {
            Switcher.SetDirection(1);
            Switcher.Switch(new TaxiDirections());
            DispatcherTimer_Stop();
        }

        private void getShaqDirectionButton(object sender, RoutedEventArgs e)
        {
            Switcher.SetDirection(2);
            Switcher.Switch(new TaxiDirections());
            DispatcherTimer_Stop();
        }

        private void getInnDirectionButton(object sender, RoutedEventArgs e)
        {
            Switcher.SetDirection(3);
            Switcher.Switch(new TaxiDirections());
            DispatcherTimer_Stop();
        }

        private void getStampedeDirectionButton(object sender, RoutedEventArgs e)
        {
            Switcher.SetDirection(4);
            Switcher.Switch(new TaxiDirections());
            DispatcherTimer_Stop();
        }

        private void getMallDirectionButton(object sender, RoutedEventArgs e)
        {
            Switcher.SetDirection(5);
            Switcher.Switch(new TaxiDirections());
            DispatcherTimer_Stop();
        }

        private void getRockDirectionButton(object sender, RoutedEventArgs e)
        {
            Switcher.SetDirection(6);
            Switcher.Switch(new TaxiDirections());
            DispatcherTimer_Stop();
        }

       
    }
}
