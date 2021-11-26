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
        
    }
}
    