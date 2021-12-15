using FerreteriaMVVM.Models;
using FerreteriaMVVM.ViewModels;
using FerreteriaMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FerreteriaMVVM.Commands
{
    class LimpiarFormularioProductosCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductosView vista = (ProductosView)parameter;

            productosViewModel.CurrentProducto = new ProductosModel();
            vista.E00EstadoInicial();
            vista.edt_odigo_barras.IsEnabled = true;
        }

        private ProductosViewModel productosViewModel;

        public LimpiarFormularioProductosCommand(ProductosViewModel productosViewModel)
        {
            this.productosViewModel = productosViewModel;
        }
    }
}
