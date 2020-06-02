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
    /// Window6__3__11.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__3__11 : Window
    {
        public Window6__3__11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //用来包装一个以方法暴露数据的对象
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "AddNum";
            odp.MethodParameters.Add("100");
            odp.MethodParameters.Add("200");
            odp.MethodParameters.Add("223");
            MessageBox.Show(odp.Data.ToString());
        }
    }

    class Calculator
    {
        public string AddNum(string arg1, string arg2)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            if (double.TryParse(arg1, out x) && double.TryParse(arg2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "Input Error!";
        }
        public string AddNum(string arg1, string arg2, string arg3)
        {
            double x = 0;
            double w = 0;
            double y = 0;
            double z = 0;
            if (double.TryParse(arg1, out x) && double.TryParse(arg3, out w) && double.TryParse(arg2, out y))
            {
                z = x + y + w;
                return z.ToString();
            }
            return "Input Error!";
        }
    }
}
