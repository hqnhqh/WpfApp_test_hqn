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
    /// Window9__2__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window9__2__2 : Window
    {
       

        //自定义命令
        public class ClearCommad : ICommand
        {
            //当命令可执行状态发送改变时，应当被激发
            public event EventHandler CanExecuteChanged;

            //用于判断命令是否可以执行（暂不实现）
            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            //命令执行，带有与业务相关的Clear逻辑
            public void Execute(object parameter)
            {
                IView view = parameter as IView;
                if (view != null)
                {
                    view.Clear();
                }
            }
        }


        public Window9__2__2()
        {
            InitializeComponent();

            //声明命令并使命令源和目标与之关联
            ClearCommad clearCmd = new ClearCommad();
            this.ctrlClear.Command = clearCmd;
            this.ctrlClear.CommandTarget = this.miniView;
        }

        
    }
}
