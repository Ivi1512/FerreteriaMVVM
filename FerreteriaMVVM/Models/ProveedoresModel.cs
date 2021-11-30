using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMVVM.Models
{
    class ProveedoresModel : INotifyPropertyChanged, ICloneable
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

        private string nombre { set; get; }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private string poblacion { set; get; }
        public string Poblacion
        {
            get { return poblacion; }
            set
            {
                poblacion = value;
                OnPropertyChanged(nameof(poblacion));
            }
        }

        private string telefono { set; get; }
        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;
                OnPropertyChanged(nameof(telefono));
            }
        }


        public ProveedoresModel(string id, string nombre, string poblacion, string telefono)
        {
            _id = id;
            Nombre = nombre;
            Poblacion = poblacion;
            Telefono = telefono;
        }

        public ProveedoresModel()
        {
        }
    }

   
}
