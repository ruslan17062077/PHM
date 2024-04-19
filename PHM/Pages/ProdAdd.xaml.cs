﻿using System;
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
            if (prodname.Text.Length != 0)
            {
                PHM.Product.ClassDataProduct.SetData(prodname.Text);
                App.window.frame.NavigationService.Navigate(new Product());
            }
            else
            {
                MessageBox.Show("Введите название");
            }
        }
    }
}
