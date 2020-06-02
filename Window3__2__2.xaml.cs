using System.ComponentModel;
using System.Globalization;
using System.Windows;


namespace WpfApp1
{
    //等价[TypeConverterAttribute(typeof(StringToHumanTypeConverter))]
    [TypeConverter(typeof(StringToHumanTypeConverter))]
    public class Human
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }

    public class StringToHumanTypeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                Human h = new Human();
                h.Name = value as string;
                return h;
            }

            return base.ConvertFrom(context, culture, value);
        }
    }

    /// <summary>
    /// Window3__2__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window3__2__2 : Window
    {
        public Window3__2__2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human h = (Human)this.FindResource("human");
            MessageBox.Show(h.Child.Name);
        }
    }

}
