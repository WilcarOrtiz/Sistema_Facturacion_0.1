using Entitades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProductos : ArchivosProductos
    {
        public RepositorioProductos() : base()
        {
            ruta = "ListaProductos.TXT";
        }

        public RepositorioProductos(String FileName) : base(FileName) { }

        public List<Producto> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Entitades.Producto> products = new List<Entitades.Producto>();
            while (!sr.EndOfStream)
            {
                products.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return products;
        }

        Entitades.Producto Mappear(String linea)
        {
            var Articulo = new Entitades.Producto();
            Articulo.ID = linea.Split(';')[0];
            Articulo.Codigo = linea.Split(';')[1];
            Articulo.NombreProducto = linea.Split(';')[2];
            Articulo.Descripcion = linea.Split(';')[3];
            Articulo.Cantidad = int.Parse(linea.Split(';')[4]);
            Articulo.Unidad = linea.Split(';')[5];
            Articulo.PrecioC = float.Parse(linea.Split(';')[6]);
            Articulo.PrecioV = float.Parse(linea.Split(';')[7]);
            return Articulo;
        }

        public string Actualizar(List<Entitades.Producto> products, bool Modo)
        {

            var sw = new StreamWriter(ruta, Modo);
            foreach (var item in products)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            return "Correcto";

        }
    }
}
