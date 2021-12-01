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
    class ProductosViewModel : ViewModelBase
    {
        private ObservableCollection<ProductosModel> listaProductos { set; get; }
        public ObservableCollection<ProductosModel> ListaProductos
        {
            get { return listaProductos; }
            set
            {
                listaProductos = value;
                OnPropertyChanged(nameof(ListaProductos));
            }
        }


        private ProductosModel currentProducto { set; get; }
        public ProductosModel CurrentProducto
        {
            get { return currentProducto; }
            set
            {
                currentProducto = value;
                OnPropertyChanged(nameof(CurrentProducto));
            }
        }


        private ProductosModel selectedProducto { set; get; }
        public ProductosModel SelectedProducto
        {
            get { return selectedProducto; }
            set
            {
                selectedProducto = value;
                OnPropertyChanged(nameof(SelectedProducto));
            }
        }

        public ICommand ProductosCommand { set; get; }
        public ProductosViewModel()
        {
            currentProducto = new ProductosModel();
            listaProductos = new ObservableCollection<ProductosModel>();
            ProductosCommand = new ProductosCommand(this);
        }
    }
}
