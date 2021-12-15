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
    class CrearProveedorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProveedoresView vista = (ProveedoresView)parameter;

            
                bool crearOK = DBHandler.CrearProveedores(proveedoresViewModel.CurrentProveedor);
                if(crearOK)
                {
                    MessageBox.Show("Creado");
                    vista.E01MostrarProveedor();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            
        }


        private ProveedoresViewModel proveedoresViewModel;

        public CrearProveedorCommand(ProveedoresViewModel proveedoresViewModel)
        {
            this.proveedoresViewModel = proveedoresViewModel;
        }
    }
}
