using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMVVM.Models
{
    class ProductosModel : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Clone()
        {
            return MemberwiseClone();
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

        private ProveedoresModel proveedores { set; get; }
        public ProveedoresModel Proveedores
        {
            get { return proveedores; }
            set
            {
                proveedores = value;
                OnPropertyChanged(nameof(Proveedores));
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

        public ProductosModel()
        {
            proveedores = new ProveedoresModel();
        }

        public ProductosModel(string id, string categoria, string marca, string material, string referencia, string descripcion, double precio, DateTime fechaEntrada, int stock)
        {
            this.id = id;
            this.categoria = categoria;
            this.marca = marca;
            this.material = material;
            this.referencia = referencia;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fechaEntrada = fechaEntrada;
            this.stock = stock;
        }
    }
}
