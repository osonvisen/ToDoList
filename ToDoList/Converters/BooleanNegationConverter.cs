using System;
using Avalonia.Data.Converters;
using System.Globalization;

namespace ToDoList.Converters
{
    public class BooleanNegationConverter : IValueConverter
    {
        public static readonly BooleanNegationConverter Instance = new BooleanNegationConverter();

        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is bool b && !b;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is bool b && b;
        }
    }
}

