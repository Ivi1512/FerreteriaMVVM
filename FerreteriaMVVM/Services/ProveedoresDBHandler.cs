using FerreteriaMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMVVM.Services
{
    class ProveedoresDBHandler
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
    }
}
