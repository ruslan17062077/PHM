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
    /// Логика взаимодействия для InfoAdd.xaml
    /// </summary>
    public partial class InfoAdd : Page
    {
        private String name;
        public InfoAdd(String _name)
        {
            name = _name;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(proddesc.Text))
            {
                PHM.InfoProd.ClassDataInfoProd.GetData();
                if(PHM.InfoProd.ClassDataInfoProd.ListStatic.Any(x => x.Name == proddesc.Text))
                {
                    MessageBox.Show("У этого продукта уже есть компонент с таким названием");
                }
                else
                {
                    PHM.InfoProd.ClassDataInfoProd.SetData(name, proddesc.Text);
                    MessageBox.Show("Добавленно!");
                    App.window.frame.NavigationService.Navigate(new Info(name));
                }
            }
            else
            {
                MessageBox.Show("Введите название");
            }
        }
    }
}
