using System;
using System.Globalization;
using Xamarin.Forms;

namespace task2LoginPage.Converter
{
    public class IntToBoolConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
          
            return ((int)value) > 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

