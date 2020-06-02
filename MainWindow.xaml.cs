using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Type[] types = System.Reflection.Assembly.GetExecutingAssembly().GetExportedTypes();
        //private int totalitem;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ButtonIndexed> listButton = new List<ButtonIndexed>();

            foreach (Type t in types)
            {
                if (t.BaseType == typeof(Window) && t.Name != "MainWindow")
                {
                    ButtonIndexed button = new ButtonIndexed
                    {
                        Content = t.Name,
                        Width = 120
                    };
                    button.Click += Button_Click;
                    button.CalcIndex(t.Name);

                    listButton.Add(button);
                }
            }

            listButton.Sort((x, y) => x.chapter.CompareTo(y.chapter));//升序
            //int total = 0;
            foreach (ButtonIndexed item in listButton)
            {
                //total++;
                wrapPanel.Children.Add(item);
            }
            //totalitem = wrapPanel.Children.Count;
            //Sort();
        }

        private void Sort()
        {
            //int min, temp;
            //UIElementCollection indexeds = wrapPanel.Children;
            //indexeds.

            //for (int i = 0; i < totalitem - 1; i++)
            //{
            //    min = i;
            //    for (int j = i + 1; j < totalitem - 1; j++)
            //    {
            //        if (list[min] > list[j])
            //        {
            //            min = j;
            //        }
            //    }
            //    temp = list[i];
            //    list[i] = list[min];
            //    list[min] = temp;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Type t in types)
            {
                if (t.BaseType == typeof(Window))
                {
                    if (sender.ToString().Substring(sender.ToString().IndexOf(':') + 2) == t.Name)
                    {
                        dynamic obj = t.Assembly.CreateInstance(t.FullName);
                        (obj as Window).Show();
                    }
                }
            }
        }
    }

    class ButtonIndexed : Button
    {
        internal int chapter;

        internal void CalcIndex(string btnName)
        {
            //string str = "提取123abc提取234234234";
            int scale = 0x10000;
            string r = @"[0-9]+";

            Regex reg = new Regex(r, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection mc = reg.Matches(btnName);//设定要查找的字符串
            foreach (Match m in mc)
            {
                string s = m.Groups[0].Value;
                chapter += int.Parse(s) * scale;
                scale >>= 4;
            }
        }
    }
}
