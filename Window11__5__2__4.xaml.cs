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
    /// Window11__5__2__4.xaml 的交互逻辑
    /// </summary>
    public partial class Window11__5__2__4 : Window
    {
        public Window11__5__2__4()
        {
            InitializeComponent();

            List<Student> stuList = new List<Student>()
            {
                new Student() {Id=1,Name="Tim",Age=30 },
                new Student() {Id=2,Name="Tom",Age=27 },
                new Student() {Id=3,Name="Yue",Age=26 },
                new Student() {Id=4,Name="Kenny",Age=28 },
                new Student() {Id=5,Name="Michael",Age=35 },
                new Student() {Id=6,Name="Surface",Age=100 },
            };

            this.listBoxStudent.ItemsSource = stuList;
        }
    }
}
