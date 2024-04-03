using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using practica1.PetShop33DataSetTableAdapters;

namespace practica1
{
    /// <summary>
    /// Логика взаимодействия для CategoryWindow1.xaml
    /// </summary>
    public partial class CategoryWindow1 : Window
    {
        CategoriesTableAdapter category = new CategoriesTableAdapter();

        public CategoryWindow1()
        {
            InitializeComponent();
            gridCategories.ItemsSource = category.GetData();
            ComTxt.ItemsSource = category.GetData();
            ComTxt.DisplayMemberPath = "Description";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridCategories.ItemsSource = category.SearByName(Searchetxt.Text);
        }

        private void ComTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComTxt.SelectedItem != null)
            {
                var Description = (string)(ComTxt.SelectedItem as DataRowView).Row["Description"];
                gridCategories.ItemsSource = category.FilterByName(Description);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            gridCategories.ItemsSource = category.GetData();
        }
    }
}