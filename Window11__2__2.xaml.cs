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
    //厂商名称转换为Logo图片路径
    public class AutomakerToLogoPathConverter : IValueConverter
    {
        //正向转换
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format(@"/Resources/Images/{0}.jpg", (string)value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        //未被用到
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    //汽车名称转换为照片路径
    public class NameToPhotoPathConverter : IValueConverter
    {
        //正向转换
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format(@"/Resources/Logos/{0}.png", (string)value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        //未被用到
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Window11__2__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window11__2__2 : Window
    {

        public Window11__2__2()
        {
            InitializeComponent();
            InitialCarList();
        }

        //初始化ListBox
        private void InitialCarList()
        {
            List<cCar> carList = new List<cCar>()
            {
                new cCar (){Automaker ="Rafale",Name="Diablo",Year="1990",TopSpeed="340"},
                new cCar (){Automaker ="Rafale",Name="Murcielago",Year="2001",TopSpeed="353"},
                new cCar (){Automaker ="Rafale",Name="Gallardo",Year="2003",TopSpeed="325"},
                new cCar (){Automaker ="Rafale",Name="Reventon",Year="2008",TopSpeed="356"},
            };

            //填充数据源
            this.listBoxCars.ItemsSource = carList;
        }
    }
}
