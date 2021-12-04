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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalgaryOS
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class LanguageScreen : UserControl
    {
        public LanguageScreen()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Emergency());
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
            switch (sender.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last()) {
                case "English":
                    Switcher.SetLanguage(true);
                    Switcher.Switch(new MapDefault());
                    break;
                case "Français":
                    Switcher.SetLanguage(false);
                    Switcher.Switch(new MapDefault());
                    break;
                default:
                    Switcher.Switch(new MapDefault());
                    break;

            }
        }
    }
}
