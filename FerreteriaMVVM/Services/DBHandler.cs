using FerreteriaMVVM.Models;
using FerreteriaMVVM.ViewModels;
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
        public static ObservableCollection<ProveedoresModel> listaProveedores;

        public static ObservableCollection<ProveedoresModel> GetProveedores()
        {
            listaProveedores = new ObservableCollection<ProveedoresModel>();
            listaProveedores.Add(new ProveedoresModel("almacen1", "Ikea", "addfd", "5866254"));
            listaProveedores.Add(new ProveedoresModel("almacen2", "Leroy Merlin", "addfd", "12522"));
            listaProveedores.Add(new ProveedoresModel("almacen3", "Carlos", "addfd", "12545"));
            listaProveedores.Add(new ProveedoresModel("almacen4", "Manolo", "addfd", "259901"));

            return listaProveedores;
        }

        internal static bool CrearProveedores(ProductosModel currentProducto)
        {
            throw new NotImplementedException();
        }

        public static ObservableCollection<string> GetCategorias()
        {
            ObservableCollection<string> listCategorias = new ObservableCollection<string>();
            listCategorias.Add("Llaves");
            listCategorias.Add("Herramientas");
            listCategorias.Add("Calefacción");
            listCategorias.Add("Electricidad");
            listCategorias.Add("Tornillería");

            return listCategorias;

        }

        public static ObservableCollection<string> GetMarcas()
        {
            ObservableCollection<string> listMarcas = new ObservableCollection<string>();
            listMarcas.Add("Wurt");
            listMarcas.Add("Palmera");
            listMarcas.Add("Bosch");
            listMarcas.Add("Still");

            return listMarcas;

        }

        public static ObservableCollection<string> GetMateriales()
        {
            ObservableCollection<string> listMateriales= new ObservableCollection<string>();
            listMateriales.Add("Aluminio");
            listMateriales.Add("Cobre");
            listMateriales.Add("Latón");
            listMateriales.Add("Inoxidable");
            listMateriales.Add("Plástico");

            return listMateriales;
        }


        public static ObservableCollection<ProductosModel> listaProductos;

        public static ObservableCollection<ProductosModel> GetProductos()
        {
            listaProductos = new ObservableCollection<ProductosModel>();

            var random = new Random();
            var listCategoria = GetCategorias();
            var listMarca = GetMarcas();
            var listProveedores = GetProveedores();
            var listMaterial = GetMateriales();
            

            for(int i = 0; i<10; i++)
            {
                int index = random.Next(listCategoria.Count);
                int index2 = random.Next(listMarca.Count);
                int index3 = random.Next(listProveedores.Count);
                int index4 = random.Next(listMaterial.Count);

                ProductosModel p = new ProductosModel();
                p._id = i.ToString();
                p.Proveedores = listProveedores[index3];
                p.Categoria = listCategoria[index];
                p.Marca = listMarca[index2];
                p.Material = listMaterial[index4];
                p.Referencia = "fh";
                p.Descripcion = "hola";
                p.Precio = 52.0;
                p.FechaEntrada = DateTime.Today;
                p.Stock = 8;

                listaProductos.Add(p);
            }

            return listaProductos;
        }

        
        public static bool CrearProveedores(ProveedoresModel proveedor)
        {
            bool creadoOK = false;
            try
            {
                listaProveedores.Add(proveedor);
                creadoOK = true;
            }
            catch(Exception e)
            {

            }

            return creadoOK;
        }


        public static bool CrearProductos(ProductosModel producto)
        {
            bool creadoOK = false;
            try
            {
                listaProductos.Add(producto);
                creadoOK = true;
            }
            catch(Exception e)
            {

            }

            return creadoOK;
        }
    }
}
