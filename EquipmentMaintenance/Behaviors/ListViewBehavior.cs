using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace EquipmentMaintenance
{
    public class AlternatingIndexConverter : IValueConverter
    {
        private static int _index;
        public SolidColorBrush Even { get; set; } = new SolidColorBrush(Colors.White);
        public SolidColorBrush Odd { get; set; } = ColorContvertor.GetSolidColorBrush("#F9F9F9F9");

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (_index++ % 2 == 0 ? Even : Odd);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class ColorContvertor
    {
        public static SolidColorBrush GetSolidColorBrush(string hex)
        {   
            hex = hex.Replace("#", string.Empty);

            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));

            return new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }
    }
}
