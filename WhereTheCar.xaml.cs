using CAR_BD.SELLS_CARDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace CAR_BD
{
    /// <summary>
    /// Логика взаимодействия для WhereTheCar.xaml
    /// </summary>
    public partial class WhereTheCar : Page
    {

        WHERE_THE_CAR_COMES_FROMTableAdapter wherethecar = new WHERE_THE_CAR_COMES_FROMTableAdapter();

        public WhereTheCar()
        {
            InitializeComponent();
            avto.ItemsSource = wherethecar.GetData();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void AddWhereTheCar_Click(object sender, RoutedEventArgs e)
        {
            string TITLE = WhereTHECar.Text;

            wherethecar.InsertQuery(TITLE);
            avto.ItemsSource = wherethecar.GetData();

        }

        private void DeleteWhereTheCar_Click(object sender, RoutedEventArgs e)
        {
            object id = (avto.SelectedItem as DataRowView).Row[0];
            wherethecar.DeleteQuery(Convert.ToInt32(id));
            avto.ItemsSource = wherethecar.GetData();
        }

        private void UpdateWhereTheCar_Click(object sender, RoutedEventArgs e)
        {
            object sui = (avto.SelectedItem as DataRowView).Row[0];
            wherethecar.UpdateQuery(WhereTHECar.Text, Convert.ToInt32(sui));
            avto.ItemsSource = wherethecar.GetData();
        }
    }
}
