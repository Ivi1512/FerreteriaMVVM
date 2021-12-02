using FerreteriaMVVM.Models;
using FerreteriaMVVM.Services;
using FerreteriaMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FerreteriaMVVM.Commands
{
    class ProductosCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            if(parameter is string)
            {
                string hola = parameter.ToString();
                if (hola.Equals("cargarLista"))
                {
                    productosViewModel.ListaProductos = DBHandler.GetProductos();
                }

            }
            else
            {
                ProductosModel producto = (ProductosModel)parameter;
                productosViewModel.CurrentProducto = (ProductosModel)producto.Clone();
                productosViewModel.SelectedProducto = (ProductosModel)producto.Clone();
            }

        }


        private ProductosViewModel productosViewModel { set; get; }
        public ProductosCommand(ProductosViewModel ProductosViewModel)
        {
            productosViewModel = ProductosViewModel;
        }
    }
}
