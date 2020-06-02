using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WpfApp1
{
    /// <summary>
    /// Window5__3__3.xaml 的交互逻辑
    /// </summary>
    public partial class Window5__3__3 : Window
    {
        public Window5__3__3()
        {
            InitializeComponent();
        }

        private void ButtonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DependencyObject level1 = VisualTreeHelper.GetParent(btn);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);
            MessageBox.Show($"level1 {level1.ToString()}\rlevel2 {level2.ToString()}\rlevel3 {level3.GetType().ToString()}");
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            this.listBoxEmplyee.Items.Clear();
            this.listBoxEmplyee.DisplayMemberPath = "Name";
            this.listBoxEmplyee.SelectedValue = "Id";
            this.listBoxEmplyee.ItemsSource = empList;
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        List<Employee> empList = new List<Employee>()
        {
            new Employee (){Id=1,Name="Time",Age=30},
            new Employee (){Id=2,Name="Tom",Age=26},
            new Employee (){Id=3,Name="Guo",Age=26},
            new Employee (){Id=4,Name="Yan",Age=25},
            new Employee (){Id=5,Name="Owen",Age=30},
            new Employee (){Id=6,Name="Victor",Age=30}
        };     
    }
}
