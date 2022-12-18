using System.Globalization;
using System.Windows.Data;

namespace Lab3Net6.Client.Utilities;
public class MultiParametersConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		=> values.Clone();
	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		=> value as object[] ?? throw new ArgumentException("Passed object should be object[]");
}
