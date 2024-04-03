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
    /// Логика взаимодействия для CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        private PetShop33Entities category = new PetShop33Entities();
        public CategoryWindow()
        {
            InitializeComponent();
            gridCategory.ItemsSource = category.Categories.ToList();
            ComTxt.ItemsSource = category.Products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridCategory.ItemsSource = category.Categories.ToList().Where(item  => item.CategoryName.Contains(Searchetxt.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(gridCategory.SelectedItem != null)
            {
                category.Categories.Remove(gridCategory.SelectedItem as Categories);
                category.SaveChanges();
                gridCategory.ItemsSource = category.Categories.ToList();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            gridCategory.ItemsSource = category.Categories.ToList();
        }

        private void ComTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ComTxt.SelectedItem != null)
            {
                var selected = ComTxt.SelectedItem as Products;
                gridCategory.ItemsSource = category.Categories.ToList().Where(item => item.CategoryID == selected.CategoryID);
            }
        }
    }
}
