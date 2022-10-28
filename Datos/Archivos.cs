using System;
using Entitades; 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivos
    {
        protected String ruta;

        public Archivos()
        {
            ruta = "Producto.txt";
        }
        public Archivos(string FileName)
        {
            ruta = FileName;
        }

        public String GuardarProducto(Entitades.Producto Articulo)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Articulo.ToString());
            sw.Close();
            return "Correcto";
        }

    }
}
