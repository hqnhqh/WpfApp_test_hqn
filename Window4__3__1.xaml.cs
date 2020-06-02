using System;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Window4__3__1.xaml 的交互逻辑
    /// </summary>
    public partial class Window4__3__1 : Window
    {
        public Window4__3__1()
        {
            InitializeComponent();
        }
    }

    class MyButton : Button
    {
        //使用UserWindowType存储的类型创建一个实例
        public Type UserWindowType { get; set; }

        protected override void OnClick()
        {
            base.OnClick();
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if (win != null)
            {
                win.ShowDialog();
            }
        }
    }
}
