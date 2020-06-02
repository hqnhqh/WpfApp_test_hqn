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
    /// Window6__3__9.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__3__9 : Window
    {
        public Window6__3__9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("File/RawData.xml");

            XmlDataProvider xdp = new XmlDataProvider();
            xdp.Document = doc;

            //使用XPath选择需要暴露的数据
            //现在是需要暴露一组Student
            xdp.XPath = @"/StudentList/Student";

            this.listViewStudents.DataContext = xdp;
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
