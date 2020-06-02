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
    /// Window11__2.xaml 的交互逻辑
    /// </summary>
    public partial class Window11__2 : Window
    {

        public Window11__2()
        {
            InitializeComponent();
            InitialCarList();
        }

        //初始化ListBox
        private void InitialCarList()
        {
            List<cCar> carList = new List<cCar>()
            {
                new cCar (){Automaker ="Lamborghini",Name="Diablo",Year="1990",TopSpeed="340"},
                new cCar (){Automaker ="Lamborghini",Name="Murcielago",Year="2001",TopSpeed="353"},
                new cCar (){Automaker ="Lamborghini",Name="Gallardo",Year="2003",TopSpeed="325"},
                new cCar (){Automaker ="Lamborghini",Name="Reventon",Year="2008",TopSpeed="356"},
            };

            foreach (cCar car in carList)
            {
                CarListItemView view = new CarListItemView();
                view.Car = car;
                this.listBoxCars.Items.Add(view);
            }

        }
        private void ListBoxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarListItemView view = e.AddedItems[0] as CarListItemView;
            if (view != null)
            {
                this.detailView.Car = view.Car;
            }
        }
    }
}
