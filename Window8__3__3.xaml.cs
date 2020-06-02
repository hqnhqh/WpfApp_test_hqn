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
    /// Window8__3__3.xaml 的交互逻辑
    /// </summary>
    public partial class Window8__3__3 : Window
    {
        public Window8__3__3()
        {
            InitializeComponent();

            //为主窗体添加对Button.Click事件的侦听
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.Button_Click));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strOriginalSource = string.Format("VisualTree start point: {0}, type is {1}",
            (e.OriginalSource as FrameworkElement).Name, e.OriginalSource.GetType().Name);

            string strSource = string.Format("LogicalTree start point:{0}, type is {1}",
            (e.Source as FrameworkElement).Name, e.Source.GetType().Name);

            MessageBox.Show(strOriginalSource + "\r\n" + strSource);
        }
    }
}
