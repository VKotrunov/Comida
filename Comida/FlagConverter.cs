using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class FlagConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tipo = "";
            if (value.Equals("China"))
                tipo = "china.png";
            else if (value.Equals("Americana"))
                tipo = "united_states.png";
            else if (value.Equals("Mexicana"))
                tipo = "mexico.png";
            return tipo;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
