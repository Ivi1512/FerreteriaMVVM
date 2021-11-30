using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMVVM.Models
{
    class ProductosModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id { set; get; }
        public string _id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(_id));
            }
        }

        private ObservableCollection<string> proveedor { set; get; }
        public ObservableCollection<string> Proveedor
        {
            get { return proveedor; }
            set
            {
                proveedor = value;
                OnPropertyChanged(nameof(Proveedor));
            }
        }

        private string categoria { set; get; }
        public string Categoria
        {
            get { return categoria; }
            set
            {
                categoria = value;
                OnPropertyChanged(nameof(Categoria));
            }
        }

        private string marca { set; get; }
        public string Marca
        {
            get { return marca; }
            set
            {
                marca = value;
                OnPropertyChanged(nameof(Marca));
            }
        }

        private string material { set; get; }
        public string Material
        {
            get { return material; }
            set
            {
                material = value;
                OnPropertyChanged(nameof(Material));
            }
        }

        private string referencia { set; get; }
        public string Referencia
        {
            get { return referencia; }
            set
            {
                referencia = value;
                OnPropertyChanged(nameof(Referencia));
            }
        }

        private string descripcion { set; get; }
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        private double precio { set; get; }
        public double Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private DateTime fechaEntrada { set; get; }
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set
            {
                fechaEntrada = value;
                OnPropertyChanged(nameof(FechaEntrada));
            }
        }

        private int stock { set; get; }
        public int Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                OnPropertyChanged(nameof(Stock));
            }
        }

    }
}
