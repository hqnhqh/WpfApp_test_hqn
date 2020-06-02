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
    /// Window10__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window10__2 : Window
    {
        public Window10__2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //res1是静态资源，更新不生效
            this.Resources["res1"] = new TextBlock() { Text = "天涯共此时" };
            this.Resources["res2"] = new TextBlock() { Text = "天涯共此时" };
        }
    }
}
