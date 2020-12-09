using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class FontConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fuente = "";
            if (value.Equals("China"))
                fuente = "Chinese Wok Food St";
            else if (value.Equals("Americana"))
                fuente = "Slim Summer";
            else if (value.Equals("Mexicana"))
                fuente = "Taco Salad";
            return fuente;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
