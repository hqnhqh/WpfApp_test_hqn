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
    /// Window7__2__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window7__2__2 : Window
    {
        public class Student : DependencyObject
        {
            //DependencyProperty实例声明，有三个修饰符 public static readonly
            //public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Student));

            public string  Name
            {
                get { return (string)GetValue(NameProperty); }
                set { SetValue(NameProperty, value); }
            }

            // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
            public static readonly DependencyProperty NameProperty =
                DependencyProperty.Register("Name", typeof(string), typeof(Student));

            public BindingExpressionBase SetBingding(DependencyProperty dp,BindingBase binding)
            {
                return BindingOperations.SetBinding(this,dp,binding);
            }
        }

        Student stu;
        public Window7__2__2()
        {
            InitializeComponent();

            stu = new Student();
            //Binding binding = new Binding("Text") { Source = textBox1 };
            //BindingOperations.SetBinding(stu, Student.NameProperty, binding);
            stu.SetBingding(Student.NameProperty,new Binding("Text") {Source = textBox1 });
            textBox2.SetBinding(TextBox.TextProperty,new Binding("Name") {Source = stu });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            //把textBox1.Text属性值存储到依赖属性
            //stu.SetValue(Student.NameProperty, this.textBox1.Text);
            stu.Name = this.textBox1.Text;
            //把依赖属性里的值读出来
            //textBox2.Text = (string)stu.GetValue(Student.NameProperty);
            this.textBox2.Text = stu.Name;
        }
    }

}
