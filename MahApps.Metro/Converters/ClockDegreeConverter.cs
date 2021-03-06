﻿namespace MahApps.Metro.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    /// <summary>
    /// Converts a double representing either hour/minute/second to the corresponding angle.
    /// </summary>
    [ValueConversion(typeof(double), typeof(double))]
    public class ClockDegreeConverter : IValueConverter
    {
        public double TotalParts { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                return 360 / TotalParts * (int)value;
            }
            return 360 / TotalParts * (double)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}