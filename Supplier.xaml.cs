using CAR_BD.SELLS_CARDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Логика взаимодействия для Supplier.xaml
    /// </summary>
    public partial class Supplier : Page
    {

        SUPPLIERTableAdapter supplier = new SUPPLIERTableAdapter();
        public Supplier()
        {
            InitializeComponent();
            avto.ItemsSource = supplier.GetData();
        }


        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close(); 
        }

        private void AddSupplier_Click(object sender, RoutedEventArgs e)
        {
            string SURNAME = SurnameSupplier.Text;
            string SUPPLIER_NAME = NameSupplier.Text;
            string PATRONYMIC = PatronymicSupplier.Text;

            supplier.InsertQuery(SURNAME, SUPPLIER_NAME, PATRONYMIC);
            avto.ItemsSource = supplier.GetData();
        }

        private void DeleteSupplier_Click(object sender, RoutedEventArgs e)
        {
            object id = (avto.SelectedItem as DataRowView).Row[0];
            supplier.DeleteQuery(Convert.ToInt32(id));
            avto.ItemsSource = supplier.GetData();
        }

        private void UpdateSupplier_Click(object sender, RoutedEventArgs e)
        {

            string SURNAME = SurnameSupplier.Text;
            string SUPPLIER_NAME = NameSupplier.Text;
            string PATRONYMIC = PatronymicSupplier.Text;

            object sui = (avto.SelectedItem as DataRowView).Row[0];
            supplier.UpdateQuery(SURNAME, SUPPLIER_NAME, PATRONYMIC, Convert.ToInt32(sui));
            avto.ItemsSource = supplier.GetData();
        }
    }
}
