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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PHM.Pages
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            

            InitializeComponent();
            PHM.Product.ClassDataProduct.GetData();
            prodGrid.ItemsSource = PHM.Product.ClassDataProduct.ListStatic.ToList();
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProdAdd());
        }

        private void prodGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selProd = prodGrid.SelectedItem as PHM.Product.Product;
            App.window.frame.NavigationService.Navigate(new Info(selProd.Name));
        }
    }
}
