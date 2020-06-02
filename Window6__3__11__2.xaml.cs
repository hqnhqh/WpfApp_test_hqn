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
    /// Window6__3__11__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__3__11__2 : Window
    {
        public Window6__3__11__2()
        {
            InitializeComponent();

            this.SetBinding();
        }

        private void SetBinding()
        {
            //创建并配置ObjectDataProvider对象
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName="AddNum";
            //加两个string类型的对象，避免Add重载不知道调哪个，（现在是调带2个string参数的Add方法）
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            //以ObjectDataProvider对象为Source创建Binding
            Binding bindingToArg1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                //Binding对象只负责把UI元素收集的数据写入直接Source（即ObjectDataProvider对象），而不是被ObjectDataProvider对象包装的Calculator对象
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            //数据源本身代表数据的时候使用.作Path
            Binding bindingToResult = new Binding(".") { Source = odp };

            //将Binding 关联到UI元素上
            this.textBoxArg1.SetBinding(TextBox.TextProperty, bindingToArg1);
            this.textBoxArg2.SetBinding(TextBox.TextProperty, bindingToArg2);
            this.textBoxResult.SetBinding(TextBox.TextProperty, bindingToResult);

            //正常情况下，前两个TextBox应该作为源，ObjectDataProvider作为最后一个TextBox的源
            //但这里3个TextBox都以ObjectDataProvider作为源，因为数据驱动UI的理论要求尽可能地使用数据对象作为源，UI元素作为Target
        }
    }
}
