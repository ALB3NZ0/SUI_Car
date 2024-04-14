using CAR_BD.SELLS_CARDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace CAR_BD
{
    /// <summary>
    /// Логика взаимодействия для Avto.xaml
    /// </summary>
    public partial class Avto : Page
    {

        CARTableAdapter car  = new CARTableAdapter();


        public Avto()
        {
            InitializeComponent();
            avto.ItemsSource = car.GetData();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            string NAME_CAR = NameСar.Text;
            string MODEL_CAR = ModelСar.Text;
            string COLOR_CAR = ColorCar.Text;
            string NUMBER_CAR = NumberCar.Text;

            car.InsertQuery(NAME_CAR,MODEL_CAR,COLOR_CAR,NUMBER_CAR);
            avto.ItemsSource = car.GetData();
        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
            object id = (avto.SelectedItem as DataRowView).Row[0];
            car.DeleteQuery(Convert.ToInt32(id));
            avto.ItemsSource = car.GetData();
        }

        private void UpdateCar_Click(object sender, RoutedEventArgs e)
        {
            object sui = (avto.SelectedItem as DataRowView).Row[0];
            car.UpdateQuery(NameСar.Text, ModelСar.Text, ColorCar.Text, NumberCar.Text, Convert.ToInt32(sui));
            avto.ItemsSource = car.GetData();
        }
    }
}
