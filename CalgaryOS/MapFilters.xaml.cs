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
    /// Interaction logic for MapFilters.xaml
    /// </summary>
    public partial class MapFilters : UserControl
    {
        public MapFilters()
        {
            InitializeComponent();
            if (Filters.GetHotel())
            {
                hotelCheck.IsChecked = true;
            }
            else 
            {
                hotelCheck.IsChecked = false;
            }

            if (Filters.GetEvent())
            {
                eventCheck.IsChecked = true;
            }
            else
            {
                eventCheck.IsChecked = false;
            }

            if (Filters.GetSight())
            {
               sightCheck.IsChecked = true;
            }
            else
            {
                sightCheck.IsChecked = false;
            }

            if (Filters.GetShopping())
            {
                shoppingCheck.IsChecked = true;
            }
            else
            {
                shoppingCheck.IsChecked = false;
            }

            if (Filters.GetHotspot())
            {
                hotspotCheck.IsChecked = true;
            }
            else
            {
                hotspotCheck.IsChecked = false;
            }

            if (Filters.GetRestaurant())
            {
                restaurantCheck.IsChecked = true;
            }
            else
            {
                restaurantCheck.IsChecked = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Explore());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new City());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapSearch());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapDefault());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new MapFilters());
            Switcher.Switch(new LanguageScreen());
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
         
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
           
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
         
        }

        private void CheckBox_Checked_5(object sender, RoutedEventArgs e)
        {
            
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (Filters.GetRestaurant())
            {
                Filters.SetRestaurant(false);

            }
            else
            {
                Filters.SetRestaurant(true);
            }
        }

        private void CheckBox_Click_2(object sender, RoutedEventArgs e)
        {
            if (Filters.GetShopping())
            {
                Filters.SetShopping(false);

            }
            else
            {
                Filters.SetShopping(true);
            }
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (Filters.GetHotel())
            {
                Filters.SetHotel(false);

            }
            else
            {
                Filters.SetHotel(true);
            }
        }

        private void CheckBox_Click_3(object sender, RoutedEventArgs e)
        {
            if (Filters.GetEvent())
            {
                Filters.SetEvent(false);

            }
            else
            {
                Filters.SetEvent(true);
            }
        }

        private void CheckBox_Click_4(object sender, RoutedEventArgs e)
        {

            if (Filters.GetSight())
            {
                Filters.SetSight(false);

            }
            else
            {
                Filters.SetSight(true);
            }
        }

        private void CheckBox_Click_5(object sender, RoutedEventArgs e)
        {
            if (Filters.GetHotspot())
            {
                Filters.SetHotspot(false);

            }
            else
            {
                Filters.SetHotspot(true);
            }
        }
    }
}
