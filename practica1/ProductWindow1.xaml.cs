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
    /// Логика взаимодействия для ProductWindow1.xaml
    /// </summary>
    public partial class ProductWindow1 : Window
    {
        ProductsTableAdapter product = new ProductsTableAdapter();
        CategoriesTableAdapter category = new CategoriesTableAdapter();

        public ProductWindow1()
        {
            InitializeComponent();
            gridProducts.ItemsSource = product.GetData();
            ComTxt.ItemsSource = category.GetData();
            ComTxt.DisplayMemberPath = "CategoryName";
        }

        private void ComTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComTxt.SelectedItem != null)
            {
                var CategoryID = (int)(ComTxt.SelectedItem as DataRowView).Row["CategoryID"];
                gridProducts.ItemsSource = product.CatIDBy(CategoryID);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            gridProducts.ItemsSource = product.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridProducts.ItemsSource = product.SearrBy(Searchetxt.Text);
        }
    }
}