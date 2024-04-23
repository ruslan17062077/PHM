using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PHM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.window = this;
            frame.NavigationService.Navigate(new Pages.Auth());
            if (!Directory.Exists(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data"))
            {
                MessageBox.Show("Папка data нужна для корректной работы приложения пожалуйста не удаляйте и не переименовывайте ее!");
                Directory.CreateDirectory(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data");
            }
        }
    }
}
