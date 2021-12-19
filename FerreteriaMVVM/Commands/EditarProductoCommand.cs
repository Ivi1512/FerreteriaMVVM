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
    class EditarProductoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductosView vista = (ProductosView)parameter;

            if (Validation.ValidarCamposVaciosProducto(vista))
            {
                MessageBoxResult confirmacion = MessageBox.Show("¿Estas seguro que quieres editar el producto?", "Confirmación", MessageBoxButton.YesNo);
                switch (confirmacion)
                {
                    case MessageBoxResult.Yes:
                        if (DBHandler.EditarProductos(((ProductosViewModel)vista.DataContext).CurrentProducto))
                        {
                            vista.E01MostrarProducto();
                            vista.txtWarning.Visibility = Visibility.Collapsed;
                            vista.edt_codigo_barras.IsEnabled = false;
                        }
                        break;

                    case MessageBoxResult.No:
                        break;
                }
            }
        }

        public EditarProductoCommand()
        {
            
        }
    }
}
