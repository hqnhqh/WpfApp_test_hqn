using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Data;


namespace WpfApp1
{
    //使用自定义的接口会报异常，使用Windows.Data类中的IValueConverter接口编译成功
    //public interface IValueConverter
    //{
    //    object Convert(object value, Type targetType, object parameter, CultureInfo culture);
    //    object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    //}

    //种类
    public enum Category
    {
        Bomber,
        Fighter
    }

    //状态
    public enum State
    {
        Avaliable,
        Locked,
        Unknown
    }

    //飞机
    public class Plane
    {
        public Category category { get; set; }
        public string Name { get; set; }
        public State state { get; set; }
    }
    public class CategoryToSourceConverter : IValueConverter
    {
        //将Category转换为Uri
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Category c = (Category)value;
            switch (c)
            {
                case Category.Bomber:
                    return @"\Icons\Bomber.png";
                case Category.Fighter:
                    return @"\Icons\Fighter.png";
                default:
                    return null;
            }
        }
        //不会被调用
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StateToNullanleBoolConverter : IValueConverter
    {
        //将State转换为bool?
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State s = (State)value;
            switch (s)
            {
                case State.Locked:
                    return false;
                case State.Avaliable:
                    return true;
                case State.Unknown:
                default:
                    return null;
            }
        }

        //将bool?转换为State
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nb = (bool?)value;
            switch (nb)
            {
                case true:
                    return State.Avaliable;
                case false:
                    return State.Locked;
                case null:
                default:
                    return State.Unknown;
            }
        }
    }
    /// <summary>
    /// Window6__4__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__4__2 : Window
    {
        public Window6__4__2()
        {
            InitializeComponent();
        }

        private void buttonLoaad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> planList = new List<Plane>()
            {
                new Plane() {category =Category.Bomber,Name="B-1",state=State.Unknown },
                new Plane() {category =Category.Bomber,Name="B-2",state=State.Unknown },
                new Plane() {category =Category.Fighter,Name="F-22",state=State.Unknown },
                new Plane() {category =Category.Fighter,Name="Su-47",state=State.Unknown },
                new Plane() {category =Category.Bomber,Name="B-52",state=State.Unknown },
                new Plane() {category =Category.Fighter,Name="J-10",state=State.Unknown }
            };
            this.listBoxPlane.ItemsSource = planList;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane p in listBoxPlane.Items)
            {
                sb.AppendLine(string.Format("Category={0},Name={1},State={2}", p.category, p.Name, p.state));
            }
            File.WriteAllText(@"D:\PlaneList.txt", sb.ToString());
        }
    }
}
