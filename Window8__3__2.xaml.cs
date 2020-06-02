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
    class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source) { }
        public DateTime ClickTime { get; set; }
    }
    class TimeButton : Button
    {
        //声明和注册路由事件
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent
        ("ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        //CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        //激发路由事件，借用Click事件的激发方法
        protected override void OnClick()
        {
            base.OnClick(); //保证Button原有功能正常使用，Click事件能被激发

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
    /// <summary>
    /// Window8__3__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window8__3__2 : Window
    {

        public Window8__3__2()
        {
            InitializeComponent();
        }

        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format("{0}到达{1}", timeStr, element.Name);
            this.listBox.Items.Add(content);
        }
    }
}
