using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CAR_BD.SELLS_CARDataSetTableAdapters;

namespace CAR_BD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avto avtoPage = new Avto();
            this.Content = avtoPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Supplier supplierPage = new Supplier();
            this.Content = supplierPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WhereTheCar whereTheCarPage = new WhereTheCar();
            this.Content = whereTheCarPage;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GlobaLInfo globaLInfoPage = new GlobaLInfo();
            this.Content = globaLInfoPage;
        }
    }
}
