using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace practica1ef
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private PetShop33Entities product = new PetShop33Entities();
        public ProductWindow()
        {
            InitializeComponent();
            gridProduct.ItemsSource = product.Products.ToList();
            ComTxt.ItemsSource = product.Categories.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridProduct.ItemsSource = product.Products.ToList().Where(item => item.ProductName.Contains(Searchetxt.Text));

        }

        private void ComTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComTxt.SelectedItem != null)
            {
                var selected = ComTxt.SelectedItem as Categories;
                gridProduct.ItemsSource = product.Products.ToList().Where(item => item.CategoryID == selected.CategoryID);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            gridProduct.ItemsSource = product.Products.ToList();
        }
    }

      
      

    }

