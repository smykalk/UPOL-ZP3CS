using System;
using System.Windows.Data;
using System.Windows.Media;


namespace DomaciRozpocet {
	/// <summary>
	/// Convertor for cells that show a monetary value
	/// Returns red for negative value, green for positive
	/// </summary>
	public class ValueToCellColorConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			decimal input = (decimal)value;
			if (input < 0)
				return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b00000"));
			else
				return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00b026"));
		}
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			throw new NotSupportedException();
		}
	}
}
