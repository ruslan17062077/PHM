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
    /// Логика взаимодействия для ProdAdd.xaml
    /// </summary>
    public partial class ProdAdd : Page
    {
        public ProdAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(prodname.Text))
            {
                PHM.Product.ClassDataProduct.GetData();
                if(PHM.Product.ClassDataProduct.ListStatic.Any(x => x.Name == prodname.Text))
                {
                    MessageBox.Show("Продукт с таким названием уже есть в базе");
                }
                else
                {
                    PHM.Product.ClassDataProduct.SetData(prodname.Text);
                    MessageBox.Show("Добавленно!");
                    App.window.frame.NavigationService.Navigate(new Product());
                }       
            }
            else
            {
                MessageBox.Show("Введите название");
            }
        }
    }
}
