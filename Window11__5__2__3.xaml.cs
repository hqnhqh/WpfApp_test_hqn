using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    public class L2BConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int textLength = (int)value;
            return textLength > 6 ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object paramete, CultureInfo culture)
        {
            throw new NotFiniteNumberException();
        }
    }
    /// <summary>
    /// Window11__5__2__3.xaml 的交互逻辑
    /// </summary>
    public partial class Window11__5__2__3 : Window
    {
        public Window11__5__2__3()
        {
            InitializeComponent();
        }
    }
}
