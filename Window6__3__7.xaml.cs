﻿using System;
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
    /// Window6__3__7.xaml 的交互逻辑
    /// </summary>
    public partial class Window6__3__7 : Window
    {
        public Window6__3__7()
        {
            InitializeComponent();

            //准备数据源
            List<Student> stuList = new List<Student>()
            {
                new Student() {Id=0,Name="Tim",Age=29 },
                new Student() {Id=1,Name="Tom",Age=28 },
                new Student() {Id=2,Name="Kyle",Age=27 },
                new Student() {Id=3,Name="Tony",Age=26 },
                new Student() {Id=4,Name="Vina",Age=25 },
                new Student() {Id=5,Name="Mike",Age=24 },
            };

            //为LIstBox设置Binding
            this.listBoxStudents.ItemsSource = stuList;
            this.listBoxStudents.DisplayMemberPath = "Name";

            //为TextBox设置Binding
            Binding binding = new Binding("SelectedItem.Name") { Source = this.listBoxStudents };
            this.textBoxId.SetBinding(TextBox.TextProperty, binding);
        }

    }

}
