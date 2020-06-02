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
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Window11__4__2__5.xaml 的交互逻辑
    /// </summary>
    public partial class Window11__4__2__5 : Window
    {
        public Window11__4__2__5()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = e.OriginalSource as MenuItem;
            XmlElement xe = mi.Header as XmlElement;
            MessageBox.Show(xe.Attributes["Name"].Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO 还有问题，在xaml界面能显示出菜单，及文件，编辑项，但是运行后菜单不见了
            var test = this.FindResource("ds");
        }
    }
}
