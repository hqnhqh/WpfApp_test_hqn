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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{

    //自定义命令源
    public class MycommandSource : UserControl, ICommandSource
    {
        //继承自IcommandSource的三个属性
        public ICommand Command { get; set; }
        public object CommandParameter { get; set; }
        public IInputElement CommandTarget { get; set; }

        //在组件被单机时连带执行命令

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            //在命令目标上执行命令，或称让命令作用于命令目标
            if (this.CommandTarget != null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }
    }

    public interface IView
    {
        //属性
        bool IsChanged { get; set; }

        //方法
        void SetBinding();
        void Refresh();
        void Clear();
        void Save();
    }

    /// <summary>
    /// MiniView.xaml 的交互逻辑
    /// </summary>
    public partial class MiniView : UserControl,IView
    {
        public MiniView()
        {
            InitializeComponent();
        }

        //继承自IView的成员们
        public bool IsChanged { get; set; }
        public void SetBinding() { }
        public void Refresh() { }
        public void Save() { }

        //用于清除内容的业务逻辑
        public void Clear()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }
    }
}
