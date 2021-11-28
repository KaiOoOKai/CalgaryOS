using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalgaryOS
{
    class Filters
    {

        static bool Event = true;
        static bool Hotel= true;
        static bool Hotspot = true;
        static bool Restaurant = true;
        static bool Sight = true;
        static bool Shopping = true;


        public static void SetEvent(bool state)
        {
            Event = state;
        }

        public static bool GetEvent()
        {
            return Event;
        }

        public static void SetHotel(bool state)
        {
            Hotel = state;
        }

        public static bool GetHotel()
        {
            return Hotel;
        }

        public static void SetHotspot(bool state)
        {
            Hotspot = state;
        }

        public static bool GetHotspot()
        {
            return Hotspot;
        }

        public static void SetRestaurant(bool state)
        {
            Restaurant = state;
        }

        public static bool GetRestaurant()
        {
            return Restaurant;
        }

        public static void SetSight(bool state)
        {
            Sight = state;
        }

        public static bool GetSight()
        {
            return Sight;
        }

        public static void SetShopping(bool state)
        {
            Shopping = state;
        }

        public static bool GetShopping()
        {
            return Shopping;
        }
    }
}
