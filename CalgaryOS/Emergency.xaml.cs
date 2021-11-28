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

namespace CalgaryOS
{
    /// <summary>
    /// Interaction logic for MapDefault.xaml
    /// </summary>
    public partial class Emergency : UserControl
    {
      
        public Emergency()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LanguageScreen());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new EmergencyCall());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TransitDefault());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapSearch());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MapFilters());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.SetState(true, new MapDefault());
            Switcher.Switch(new LanguageScreen());
        }
      

        private void Canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

    }
}
