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
    /// Window7__3.xaml 的交互逻辑
    /// </summary>
    public partial class Window7__3 : Window
    {
        class School : DependencyObject
        {
            public static int GetGrade(DependencyObject obj)
            {
                return (int)obj.GetValue(GradeProperty);
            }
            public static void SetGrade(DependencyObject obj, int value)
            {
                obj.SetValue(GradeProperty, value);
            }

            //附加属性，用RegisterAttached注册
            public static readonly DependencyProperty GradeProperty =
            DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(School), new UIPropertyMetadata(0));
        }

        class Human : DependencyObject { }
        public Window7__3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human();
            School.SetGrade(human, 6);
            int grade = School.GetGrade(human);
            MessageBox.Show(grade.ToString());
        }
    }
}
