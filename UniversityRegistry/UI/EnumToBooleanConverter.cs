using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Class for converting enum values to booleans
    /// </summary>
    class EnumToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Converts an enum to a boolean by comparing it to the supplied paramter
        /// if value and parameter are the same, the method returns true; otherwise false
        /// </summary>
        /// <param name="value">the enum value to convert</param>
        /// <param name="targetType">the type to convert (boolean)</param>
        /// <param name="parameter">the enum to compare to</param>
        /// <param name="culture">the culture info</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.Equals(parameter);
        }
        /// <summary>
        /// Converts a boolean into an enum value.  If the boolean is true, the parameter is returned,
        /// otherwise DependencyProperty.UnsetValue is returned (which unsets the control)
        /// </summary>
        /// <param name="value">The boolean to convert</param>
        /// <param name="targetType">The type to convert (should be an enum)</param>
        /// <param name="param">The enumeration value to check</param>
        /// <param name="culture">The culture info</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object param, CultureInfo culture)
        {
            if ((bool)value) return param;
            else return DependencyProperty.UnsetValue;
        }

    }
}
