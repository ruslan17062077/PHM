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
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : Page
    {
        private String name;
        public Info(String _name)
        {
            name = _name;
            InitializeComponent();
            PHM.InfoProd.ClassDataInfoProd.GetData();
            prodInfoGrid.ItemsSource = PHM.InfoProd.ClassDataInfoProd.ListStatic.Where(x=> x.Name == name);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.window.frame.Navigate(new InfoAdd(name));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Task.Delay(3000);
            App.window.frame.Navigate(new Product());
        }
    }
}
