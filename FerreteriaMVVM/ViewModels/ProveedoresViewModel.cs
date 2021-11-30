using FerreteriaMVVM.Commands;
using FerreteriaMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FerreteriaMVVM.ViewModels
{
    class ProveedoresViewModel : ViewModelBase
    {
        private ObservableCollection<ProveedoresModel> listaProveedores { set; get; }
        public ObservableCollection<ProveedoresModel> ListaProveedores
        {
            get { return listaProveedores; }
            set
            {
                listaProveedores = value;
                OnPropertyChanged(nameof(ListaProveedores));
            }
        }


        private ProveedoresModel currentProvedor { set; get; }
        public ProveedoresModel CurrentProveedor 
        {
            get { return currentProvedor; }
            set
            {
                currentProvedor = value;
                OnPropertyChanged(nameof(CurrentProveedor));
            }
        }


        private ProveedoresModel selectedProvedor { set; get; }
        public ProveedoresModel SelectedProveedor
        {
            get { return selectedProvedor; }
            set
            {
                selectedProvedor = value;
                OnPropertyChanged(nameof(SelectedProveedor));
            }
        }

        public ICommand ProveedoresCommand { set; get; }
        public ProveedoresViewModel()
        {
            currentProvedor = new ProveedoresModel();
            listaProveedores = new ObservableCollection<ProveedoresModel>();
            ProveedoresCommand = new ProveedoresCommand(this);
        }
    }
}
