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

            listaProveedores.Add(new ProveedoresModel("id1", "proveedor1", "fsdfds", "54536"));
            listaProveedores.Add(new ProveedoresModel("id2", "proveedor2", "fsdfds", "5455543546"));
            listaProveedores.Add(new ProveedoresModel("id3", "proveedor3", "fsdfds", "45"));
            listaProveedores.Add(new ProveedoresModel("id4", "proveedor4", "fsdfds", "459688"));

            return listaProveedores;
        }


        public static ObservableCollection<ProductosModel> listaProductos { set; get; }
        public static ObservableCollection<ProductosModel> GetProductos()
        {
            listaProductos = new ObservableCollection<ProductosModel>();

            var random = new Random();
            var listCategoria = new List<string>() { "Llaves", "Herramientas", "calefacción", "electricidad", "tornillería" };
            var listMarca = new List<string>() { "Wurt", "Palmera", "Bosch", "Still" };
            var listProveedores = new List<string>() { "almacen1", "almacen2", "almacen3", "almacen4" };
            var listMaterial = new List<string>() { "Aluminio", "Cobre", "Latón", "Inoxidable", "Plástico" };
            

            for(int i = 0; i<10; i++)
            {
                int index = random.Next(listCategoria.Count);
                int index2 = random.Next(listMarca.Count);
                int index3 = random.Next(listProveedores.Count);
                int index4 = random.Next(listMaterial.Count);

                ProductosModel p = new ProductosModel();
                p._id = i.ToString();
                p.Proveedor = listProveedores[index3];
                p.Categoria = listCategoria[index];
                p.Marca = listMarca[index2];
                p.Material = listMaterial[index4];
                p.Referencia = "fh";
                p.Descripcion = "hola";
                p.Precio = 52.0;
                p.FechaEntrada = DateTime.Today;
                p.Stock = 8;

                if (listProveedores.Equals("almacen1"))
                {
                    p.Proveedores._id = "almacen1";
                    p.Proveedores.Nombre = "Ikea";
                    p.Proveedores.Poblacion = "addfd";
                    p.Proveedores.Telefono = "5866254";
                }
                else if (listProveedores.Equals("almacen2"))
                {
                    p.Proveedores._id = "almacen2";
                    p.Proveedores.Nombre = "Leroy Merlin";
                    p.Proveedores.Poblacion = "addfd";
                    p.Proveedores.Telefono = "12522";
                }
                else if (listProveedores.Equals("almacen3"))
                {
                    p.Proveedores._id = "almacen3";
                    p.Proveedores.Nombre = "Carlos";
                    p.Proveedores.Poblacion = "addfd";
                    p.Proveedores.Telefono = "12545";
                }
                else if (listProveedores.Equals("almacen4"))
                {
                    p.Proveedores._id = "almacen4";
                    p.Proveedores.Nombre = "Manolo";
                    p.Proveedores.Poblacion = "addfd";
                    p.Proveedores.Telefono = "259901";
                }

                listaProductos.Add(p);
            }

            return listaProductos;
        }

        public static void hola()
        {


            //string[] categorias = new string[] { "Llaves", "Herramientas", "calefacción", "electricidad", "tornillería" };
            //string randomName = categorias[Random.Range(1, 4)];
        }
    }
}
