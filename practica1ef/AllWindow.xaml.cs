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
    /// Логика взаимодействия для AllWindow.xaml
    /// </summary>
    
    public partial class AllWindow : Window
    {
        public class ViewModel
        {
            public string ProductsName { get; set; }
            public string CategoriesName { get; set; }
            public decimal Cost { get; set; }
            public int Amount { get; set; }
        }



        private PetShop33Entities alltable = new PetShop33Entities();




    }
}
