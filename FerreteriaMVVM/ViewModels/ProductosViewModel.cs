using FerreteriaMVVM.Commands;
using FerreteriaMVVM.Models;
using FerreteriaMVVM.Services;
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
        public ObservableCollection<ProveedoresModel> listaProveedores { set; get; }
        public ObservableCollection<string> listaCategorias { set; get; }
        public ObservableCollection<string> listaMateriales { set; get; }
        public ObservableCollection<string> listaMarcas { set; get; }

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
            listaProveedores = DBHandler.GetProveedores();
            listaCategorias = new ObservableCollection<string>() { "Llaves", "Herramientas", "calefacción", "electricidad", "tornillería"};
            listaMarcas = new ObservableCollection<string>() { "Wurt", "Palmera", "Bosch", "Still" };
            listaMateriales = new ObservableCollection<string>() { "Aluminio", "Cobre", "Latón", "Inoxidable", "Plástico" };
            listaProductos = new ObservableCollection<ProductosModel>();
            ProductosCommand = new ProductosCommand(this);
        }
    }
}
