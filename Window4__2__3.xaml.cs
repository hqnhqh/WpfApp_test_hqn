using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Window4__2__3.xaml 的交互逻辑
    /// </summary>
    public partial class Window4__2__3 : Window
    {
        public Window4__2__3()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = this.Content as StackPanel;
            TextBox textBox = stackPanel.Children[0] as TextBox;
            if (string.IsNullOrEmpty(textBox.Name))
            {
                textBox.Text = "No name!";
            }
            else
            {
                textBox.Text = textBox.Name;
            }
        }
    }
}
