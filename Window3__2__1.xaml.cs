using System.Windows;
using System.Windows.Media;


namespace WpfApp1
{
    /// <summary>
    /// Window3__2__1.xaml 的交互逻辑
    /// </summary>
    public partial class Window3__2__1 : Window
    {
        public Window3__2__1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //这里的代码，跟 xaml 里 Fill="Blue" 功能相同
            //Fill实际应接收一个Brush对象，但是我们传入字符串"Blue"也被识别到了
            //这是因为使用 Attribute=Value 语法时，xaml会自动对字符串Value进行类型转换
            //

            SolidColorBrush sBrush = new SolidColorBrush();  //SolidColorBrush是Brush的派生类
            sBrush.Color = Colors.Blue;
            this.rectangle.Fill = sBrush;

            //this.rectangle.Fill = "Blue"; //报错
        }
    }
}
