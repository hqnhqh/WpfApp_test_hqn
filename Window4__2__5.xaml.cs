using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Window4__2__5.xaml 的交互逻辑
    /// </summary>
    public partial class Window4__2__5 : Window
    {
        public Window4__2__5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = this.FindResource("myString") as string;
            this.textBox1.Text = str;
        }
    }
}
