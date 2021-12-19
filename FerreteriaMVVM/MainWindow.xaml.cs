using FerreteriaMVVM.ViewModels;
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

namespace FerreteriaMVVM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "BtnBienvenida":
                    BtnBienvenida.IsEnabled = false;
                    BtnProveedores.IsEnabled = true;
                    BtnProductos.IsEnabled = true;
                    break;
                case "BtnProveedores":
                    BtnBienvenida.IsEnabled = true;
                    BtnProveedores.IsEnabled = false;
                    BtnProductos.IsEnabled = true;
                    break;
                case "BtnProductos":
                    BtnBienvenida.IsEnabled = true;
                    BtnProveedores.IsEnabled = true;
                    BtnProductos.IsEnabled = false;
                    break;
            }
        }
    }
}
