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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTb.Text) || string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                StaticApp.ClassData.SetData(nameTb.Text, login.Text, password.Text);
                MessageBox.Show("Вы успрешно зарегистрированы");
                App.window.frame.Navigate(new Uri("Pages/Auth.xaml", UriKind.Relative));
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            App.window.frame.Navigate(new Uri("Pages/Auth.xaml", UriKind.Relative));
        }
    }
}
