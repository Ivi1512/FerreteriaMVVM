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
    class CrearProductoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductosView vista = (ProductosView)parameter;

            productosViewModel.CurrentProducto.Proveedores = (ProveedoresModel)vista.combo.SelectedItem;
            bool crearOK = DBHandler.CrearProductos(productosViewModel.CurrentProducto);
            if (crearOK)
            {
                MessageBox.Show("Creado");
                vista.E01MostrarProducto();
                vista.edt_odigo_barras.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


        private ProductosViewModel productosViewModel { set; get; }

        public CrearProductoCommand(ProductosViewModel productosViewModel)
        {
            this.productosViewModel = productosViewModel;
        }
    }
}
