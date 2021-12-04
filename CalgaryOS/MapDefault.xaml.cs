﻿using System;
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
    public partial class MapDefault : UserControl
    {
        DispatcherTimer DispatcherTimer = new DispatcherTimer();
        public MapDefault()
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
            if (Filters.GetHotel() == false) 
            {
                hotelButton.Visibility = Visibility.Hidden;
                hotelButton.IsEnabled = false;

                hotelLabel.Visibility = Visibility.Hidden;
                hotelLabel.IsEnabled = false;
            }
            else
            {
                hotelButton.Visibility = Visibility.Visible;
                hotelButton.IsEnabled = true;

                hotelLabel.Visibility = Visibility.Visible;
                hotelLabel.IsEnabled = true;
            }

            if (Filters.GetShopping() == false)
            {
                shoppingButton.Visibility = Visibility.Hidden;
                shoppingButton.IsEnabled = false;

                shoppingLabel.Visibility = Visibility.Hidden;
                shoppingLabel.IsEnabled = false;
            }
            else
            {
                shoppingButton.Visibility = Visibility.Visible;
                shoppingButton.IsEnabled = true;

                shoppingLabel.Visibility = Visibility.Visible;
                shoppingLabel.IsEnabled = true;
            }

            if (Filters.GetEvent() == false)
            {
                eventButton.Visibility = Visibility.Hidden;
                eventButton.IsEnabled = false;

                eventLabel.Visibility = Visibility.Hidden;
                eventLabel.IsEnabled = false;
            }
            else
            {
                eventButton.Visibility = Visibility.Visible;
                eventButton.IsEnabled = true;

                eventLabel.Visibility = Visibility.Visible;
                eventLabel.IsEnabled = true;
            }

            if (Filters.GetSight() == false)
            {
                sightButton.Visibility = Visibility.Hidden;
                sightButton.IsEnabled = false;

                sightLabel.Visibility = Visibility.Hidden;
                sightLabel.IsEnabled = false;
            }
            else
            {
                sightButton.Visibility = Visibility.Visible;
                sightButton.IsEnabled = true;

                sightLabel.Visibility = Visibility.Visible;
                sightLabel.IsEnabled = true;
            }

            if (Filters.GetRestaurant() == false)
            {
                restaurantButton.Visibility = Visibility.Hidden;
                restaurantButton.IsEnabled = false;

                restaurantLabel.Visibility = Visibility.Hidden;
                restaurantLabel.IsEnabled = false;
            }
            else
            {
                restaurantButton.Visibility = Visibility.Visible;
                restaurantButton.IsEnabled = true;

                restaurantLabel.Visibility = Visibility.Visible;
                restaurantLabel.IsEnabled = true;
            }

            if (Filters.GetHotspot() == false)
            {
                hotspotButton.Visibility = Visibility.Hidden;
                hotspotButton.IsEnabled = false;

                hotspotLabel.Visibility = Visibility.Hidden;
                hotspotLabel.IsEnabled = false;
            }
            else 
            {
                hotspotButton.Visibility = Visibility.Visible;
                hotspotButton.IsEnabled = true;

                hotspotLabel.Visibility = Visibility.Visible;
                hotspotLabel.IsEnabled = true;
            }
              
              
                        
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

            if (!Switcher.getLanguage()) 
            {
                localButton.Content = "ÉVÉNEMENT LOCAL";
                filterButton.Content = "Filtres";
                textBlock.Text = "Chercher";
                shoppingLabel.Content = "Grand centre commercial";
                shoppingLabel.Margin = new Thickness(115, 39, 0, 0);
                eventLabel.Content = "La Tournée rap de The Rock";
                eventLabel.Margin = new Thickness(-45,207,0,0);
                sightLabel.Content = "Bague Bleue Massive";
                sightLabel.Margin = new Thickness(110, 536, 0, 0);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Explore());
            DispatcherTimer_Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
            DispatcherTimer_Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
            DispatcherTimer_Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapSearch());
            DispatcherTimer_Stop();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapFilters());
            DispatcherTimer_Stop();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new MapDefault());
            Switcher.Switch(new LanguageScreen());
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

        private void localButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Explore());
            DispatcherTimer_Stop();
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
    }
}
