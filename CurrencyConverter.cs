using System.Globalization;
using System.Windows.Data;

namespace ExpenseIT;
internal class CurrencyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // parameter passed in by xaml; targetType determined by binding target;
        // culture is the language, currency, and formatting preferences set in xaml
        if (value is decimal amount)
        {
            var currency = parameter as string;
            return $"{amount.ToString(culture)}{currency}";
        }

        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // Ignore, as 1 way binding only.
        throw new NotImplementedException();
    }
}