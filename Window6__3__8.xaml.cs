using System;
using System.Collections.Generic;
using System.Data;
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
    /// Window6__3__8.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__3__8 : Window
    {
        public Window6__3__8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //获取DataTable实例
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Age", Type.GetType("System.String"));
            
            dt.Rows.Add(new object[] { "1", "Tim", "29" });
            dt.Rows.Add(new object[] { "2", "Tom", "28" });
            dt.Rows.Add(new object[] { "3", "Tony", "27" });
            dt.Rows.Add(new object[] { "4", "Kyle", "26" });
            dt.Rows.Add(new object[] { "3", "Vina", "25" });
            dt.Rows.Add(new object[] { "3", "Emily", "24" });


            this.listBoxStudents.DisplayMemberPath = "Name";
            this.listBoxStudents.ItemsSource = dt.DefaultView;
        }
    }
}
