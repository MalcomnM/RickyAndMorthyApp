using System;
using System.Globalization;
using Xamarin.Forms;

namespace RickAndMorthyApp.Utilities
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // WRITE CONVERTER LOGIC HERE
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
