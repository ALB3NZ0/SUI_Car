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
    /// Логика взаимодействия для GlobaLInfo.xaml
    /// </summary>
    public partial class GlobaLInfo : Page
    {


        GLOBAL_INFOTableAdapter globalInfo = new GLOBAL_INFOTableAdapter();

        SUPPLIERTableAdapter supplier = new SUPPLIERTableAdapter();

        CARTableAdapter car = new CARTableAdapter();

        WHERE_THE_CAR_COMES_FROMTableAdapter wherethecar = new WHERE_THE_CAR_COMES_FROMTableAdapter();



        public GlobaLInfo()
        {
            InitializeComponent();
            avto.ItemsSource = globalInfo.GetData();

            SUPPLIER_IDComboBox.ItemsSource = supplier.GetData();
            SUPPLIER_IDComboBox.DisplayMemberPath = "ID_SUPPLIER";

            CAR_IDComboBox.ItemsSource = car.GetData();
            CAR_IDComboBox.DisplayMemberPath = "ID_CARNAME";

            WHERE_IDComboBox.ItemsSource = wherethecar.GetData();
            WHERE_IDComboBox.DisplayMemberPath = "ID_WHERE_THE_CAR_COMES_FROM";



        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void AddID_Click(object sender, RoutedEventArgs e)
        {
            int CARNAME_ID = int.Parse(CARNAMEID.Text);
            int WhereTheCar_ID = int.Parse(WhereTheCarID.Text);
            int Supplier_ID = int.Parse(SupplierID.Text);

            globalInfo.InsertQuery(CARNAME_ID, WhereTheCar_ID, Supplier_ID);
            avto.ItemsSource = globalInfo.GetData();
        }

        private void DeleteIDr_Click(object sender, RoutedEventArgs e)
        {
            object id = (avto.SelectedItem as DataRowView).Row[0];
            globalInfo.DeleteQuery(Convert.ToInt32(id));
            avto.ItemsSource = globalInfo.GetData();
        }

        private void UpdateID_Click(object sender, RoutedEventArgs e)
        {
            int CARNAME_ID = int.Parse(CARNAMEID.Text);
            int WhereTheCar_ID = int.Parse(WhereTheCarID.Text);
            int Supplier_ID = int.Parse(SupplierID.Text);

            object sui = (avto.SelectedItem as DataRowView).Row[0];
            globalInfo.UpdateQuery(CARNAME_ID, WhereTheCar_ID, Supplier_ID, Convert.ToInt32(sui));
            avto.ItemsSource = globalInfo.GetData();
        }

        private void CAR_IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object Firecell = (CAR_IDComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(Firecell.ToString());
        }

        private void WHERE_IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object Firecell = (WHERE_IDComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(Firecell.ToString());
        }

        private void SUPPLIER_IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object Firecell = (SUPPLIER_IDComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(Firecell.ToString());
        }
    }
}
