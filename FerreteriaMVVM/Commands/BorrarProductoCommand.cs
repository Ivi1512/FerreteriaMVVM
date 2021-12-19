using FerreteriaMVVM.Models;
using FerreteriaMVVM.Services;
using FerreteriaMVVM.ViewModels;
using FerreteriaMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FerreteriaMVVM.Commands
{
    class BorrarProductoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductosView vista = (ProductosView)parameter;
            MessageBoxResult confirmacion = MessageBox.Show("¿Estas seguro que quieres borrar el producto?", "Confirmación", MessageBoxButton.YesNo);
            switch (confirmacion)
            {
                case MessageBoxResult.Yes:
                    if (DBHandler.BorrarProductos(((ProductosViewModel)vista.DataContext).CurrentProducto))
                    {
                        ((ProductosViewModel)vista.DataContext).CurrentProducto = new ProductosModel();
                        vista.E00EstadoInicial();
                        vista.txtWarning.Visibility = Visibility.Collapsed;
                    }
                    break;

                case MessageBoxResult.No:
                    break;
            }
        }

        public BorrarProductoCommand()
        {
            
        }
    }
}
