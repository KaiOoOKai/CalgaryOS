using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalgaryOS
{
    class Switcher
    {
        public static MainWindow pageSwitcher;
        static bool lastPage = false;
        static UserControl stored;
        static int counter = 1;
        static bool english = true;
        static int direction = 0;
        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
        public static void SetState(bool state, UserControl page)
        {
            stored = page;
            lastPage = state;
        }

        public static bool GetState()
        {
            return lastPage;

        }
        public static UserControl GetPage()
        {
            lastPage = false;
            return stored;
        }

        public static int GetCounter()
        {
            return counter;
        }
        public static void SetCounter()
        {
            if (counter == 5)
            {
                counter = 1;
            }
            else
            {
                counter += 1;
            }
        }
        public static void SetLanguage(bool setter) 
        {
            english = setter;
        }
        public static bool GetLanguage() 
        {
            return english;
        }

        public static int GetDirection() 
        {
            return direction;
        }
        public static void SetDirection(int i) 
        {
            direction = i;
        }
    }
}