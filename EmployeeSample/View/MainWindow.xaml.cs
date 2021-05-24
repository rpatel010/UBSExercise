using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace EmployeeSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class IsGreaterThanConverter : IValueConverter
    {
        public static readonly IValueConverter Instance = new IsGreaterThanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var compareValue = (double)value;
            int compareToValue;
            if (Int32.TryParse(parameter.ToString(), out compareToValue))
                return compareValue > compareToValue;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IsLessThanConverter : IValueConverter
    {
        public static readonly IValueConverter Instance = new IsLessThanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var compareValue = (double)value;
            int compareToValue;
            if (Int32.TryParse(parameter.ToString(), out compareToValue))
                return compareValue < compareToValue;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
