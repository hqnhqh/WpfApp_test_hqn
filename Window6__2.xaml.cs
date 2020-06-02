using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.ComponentModel;

namespace WpfApp1
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                //激发事件
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public int Id { get; set; }
        //public string Name { get; set; }
        public int Age { get; set; }


        public string Skill { get; set; }
        public bool HasJob { get; set; }
    }

    /// <summary>
    /// Window6__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__2 : Window
    {
        Student stu;
        public Window6__2()
        {
            InitializeComponent();

            //准备数据源
            //stu = new Student();
            //准备Binding
            //Binding binding = new Binding();
            //binding.Source = stu;
            //binding.Path = new PropertyPath("Name");

            //使用Binding连接数据源与Binding目标（目标，数据源属性，Binding实例）
            //BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);

            //实际工作中由于TextBox这类UI元素对SetBinding进行了封装，我们不用上面那种方式
            //封装后只需要两个参数SetBinding(Dependency, BindingBase)
            this.textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new WpfApp1.Student() });
        }

        static int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            //点击时，stu类的Name属性改变，界面上TextBoxText也跟着改变
            stu.Name = "Name1"+count.ToString();
        }
    }
}
