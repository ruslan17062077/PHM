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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
           
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            StaticApp.ClassData.GetData();
            if (StaticApp.ClassData.ListStatic.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Text) != null)
            {
                App.window.frame.NavigationService.Navigate(new Pages.Product());
            }
            else
            {
                MessageBox.Show("Нет такого аккаунта");
            }


        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            App.window.frame.NavigationService.Navigate(new Pages.Reg());
        }
    }
}
