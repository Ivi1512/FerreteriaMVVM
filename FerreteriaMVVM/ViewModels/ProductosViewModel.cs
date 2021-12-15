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
        private ObservableCollection<ProveedoresModel> listaProveedores;
        public ObservableCollection<ProveedoresModel> ListaProveedores
        {
            get => listaProveedores is null ? listaProveedores = new ObservableCollection<ProveedoresModel>() : listaProveedores;
            set
            {
                if(listaProveedores != value)
                {
                    listaProveedores = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<string> listaCategorias { set; get; }
        public ObservableCollection<string> listaMateriales { set; get; }
        public ObservableCollection<string> listaMarcas { set; get; }

        private ObservableCollection<ProductosModel> listaProductos;
        public ObservableCollection<ProductosModel> ListaProductos
        {
            get => listaProductos is null ? listaProductos = new ObservableCollection<ProductosModel>() : listaProductos;
            set
            {
                listaProductos = value;
                OnPropertyChanged(nameof(ListaProductos));
            }
        }


        private ProductosModel currentProducto;
        public ProductosModel CurrentProducto
        {
            get { return currentProducto; }
            set
            {
                currentProducto = value;
                OnPropertyChanged();
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

        public ICommand LimpiarFormularioProductosCommand { set; get; }

        public ICommand CrearProductoCommand { set; get; }

        public ProductosViewModel()
        {
            currentProducto = new ProductosModel();
            ListaProveedores = DBHandler.GetProveedores();
            listaCategorias = DBHandler.GetCategorias();
            listaMarcas = DBHandler.GetMarcas();
            listaMateriales = DBHandler.GetMateriales();
            listaProductos = new ObservableCollection<ProductosModel>();
            ProductosCommand = new ProductosCommand(this);
            LimpiarFormularioProductosCommand = new LimpiarFormularioProductosCommand(this);
            CrearProductoCommand = new CrearProductoCommand(this);
        }
    }
}
