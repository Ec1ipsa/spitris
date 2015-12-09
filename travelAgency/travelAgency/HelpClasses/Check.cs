using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace travelAgency.HelpClasses
{
    static class Check
    {

        /* проверка на целое положительное число */
        internal static bool checkNumber(string text)
        {
            int number;
            bool result = Int32.TryParse(text, out number);

            if (result)
                if (number >= 0) return true;
            return false;
        }
        //ПРОВЕРКА НА ВЕЩЕСТВЕННОЕ ЧИСЛО
        internal static bool checkFloatNumber(string text)
        {
            float number;
            bool result = float.TryParse(text, out number);

            if (result)
                if (number >= 0) return true;
            return false;
        }
        //проверка одного текстбокса на пустоту
        internal static bool checkFullItem(TextBox item)
        {
            if (item.Text != "")
            {
                item.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                return true;
            }
            else
            {
                item.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                return false;
            }
        }

    }
}
