using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Window6__3__3.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__3__3 : Window
    {
        public Window6__3__3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> stringList = new List<string>() { "Tinothy", "Tom", "Blog" };
            this.textBox3.SetBinding(TextBox.TextProperty, new Binding("[0]") { Source = stringList });
            this.textBox4.SetBinding(TextBox.TextProperty, new Binding("[1].Length") { Source = stringList, Mode=BindingMode.OneWay });
            this.textBox5.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = stringList, Mode = BindingMode.OneWay });

            //Binding
            List<Country> countryList = new List<Country> { new Country { Name = "中国", ProvinceList = new List<Province> { new Province { Name = "四川", CityList = new List<City> { new City { Name = "成都" } } } } } };
            this.textBox6.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countryList });
            this.textBox7.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList[0].Name") { Source = countryList });
            this.textBox8.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/CityList[0].Name") { Source = countryList });
        }
    }

    class City
    {
        public string Name { get; set; }
    }
    class Province
    {
        public string Name { get; set; }
        public List<City> CityList { get; set; }
    }
    class Country
    {
        public string Name { get; set; }
        public List<Province> ProvinceList { get; set; }
    }

}
