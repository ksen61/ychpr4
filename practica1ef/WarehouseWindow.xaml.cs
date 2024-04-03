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
using System.Windows.Shapes;

namespace practica1ef
{
    /// <summary>
    /// Логика взаимодействия для WarehouseWindow.xaml
    /// </summary>
    public partial class WarehouseWindow : Window
    {
        private PetShop33Entities storehouse = new PetShop33Entities();
        public WarehouseWindow()
        {
            InitializeComponent();
            gridProductDetails.ItemsSource = storehouse.ProductDetails.ToList();
            ComTxt.ItemsSource = storehouse.Products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchText = Searchetx.Text;
            if (!String.IsNullOrWhiteSpace(searchText))
            {
                gridProductDetails.ItemsSource = storehouse.ProductDetails.ToList().Where(item => item.Color == null || item.Color.Contains(searchText));
            }
            else
            {
                gridProductDetails.ItemsSource = storehouse.ProductDetails.ToList();
            }
        }

        private void ComTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComTxt.SelectedItem != null)
            {
                var selected = ComTxt.SelectedItem as Products;
                gridProductDetails.ItemsSource = storehouse.ProductDetails.ToList().Where(item => item.ProductID == selected.ProductID && item.ProductID == selected.ProductID);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            gridProductDetails.ItemsSource = storehouse.ProductDetails.ToList();
        }
    }
}