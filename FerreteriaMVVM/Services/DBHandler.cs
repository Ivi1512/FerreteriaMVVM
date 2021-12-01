using FerreteriaMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMVVM.Services
{
    class DBHandler
    {
        public static ObservableCollection<ProveedoresModel> listaProveedores { set; get; }

        public static ObservableCollection<ProveedoresModel> GetProveedores()
        {
            listaProveedores = new ObservableCollection<ProveedoresModel>();

            listaProveedores.Add(new ProveedoresModel("id1", "dff", "fsdfds", "54536"));
            listaProveedores.Add(new ProveedoresModel("id2", "dff", "fsdfds", "5455543546"));
            listaProveedores.Add(new ProveedoresModel("id3", "dff", "fsdfds", "45"));
            listaProveedores.Add(new ProveedoresModel("id4", "dff", "fsdfds", "459688"));

            return listaProveedores;
        }



        public static ObservableCollection<ProductosModel> listaProductos { set; get; }
        public static ObservableCollection<ProductosModel> GetProductos()
        {
            listaProductos = new ObservableCollection<ProductosModel>();

            listaProductos.Add(new ProductosModel("id1", listaProveedores, "fad", "fsdf", "sadad", "DASD", "sdfsdf", 56.2, DateTime.Today, 5));

            return listaProductos;
        }
    }
}
