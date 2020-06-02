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
    /// Window10__4.xaml 的交互逻辑
    /// </summary>
    public partial class Window10__4 : Window
    {
        public Window10__4()
        {
            InitializeComponent();

            Uri imgUri = new Uri(@"Resources/Images/Rafale.jpg", UriKind.Relative);
            this.ImageBg.Source = new BitmapImage(imgUri);
        }
    }
}
