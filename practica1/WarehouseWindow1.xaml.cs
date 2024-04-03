using practica1.PetShop33DataSetTableAdapters;
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
using System.Windows.Shapes;

namespace practica1
{
    /// <summary>
    /// Логика взаимодействия для WarehouseWindow1.xaml
    /// </summary>
    public partial class WarehouseWindow1 : Window
    {
        ProductDetailsTableAdapter details = new ProductDetailsTableAdapter();
        ProductsTableAdapter product = new ProductsTableAdapter();


        public WarehouseWindow1()
        {
            InitializeComponent();
            gridProductDetails.ItemsSource = details.GetData();
            ComTxt.ItemsSource = product.GetData();
            ComTxt.DisplayMemberPath = "ProductName";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridProductDetails.ItemsSource = details.SearrhBy(Searchetxt.Text);

        }

        private void ComTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ComTxt.SelectedItem != null)
            {
                var ProductID = (int)(ComTxt.SelectedItem as DataRowView).Row["ProductID"];
                gridProductDetails.ItemsSource = details.ProduIDBy(ProductID);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            gridProductDetails.ItemsSource = details.GetData();

        }
    }
}
