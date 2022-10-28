using System;
using Entitades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Logica
{
    public class FuncionesProductos : InterfaceProductos<Producto>
    {

        Datos.RepositorioProductos RepositorioProductos = new Datos.RepositorioProductos();
        List<Producto> products;

        public FuncionesProductos()
        {
            products = new List<Producto>();
            products = RepositorioProductos.GetAll();
        }
        //Esto add a product.
        public string AgregarProducto(Producto Articulo)
        {
            String Mensaje;
            try
            {
                products.Add(Articulo);
                Mensaje = RepositorioProductos.GuardarProducto(Articulo);
            }
            catch (Exception EX)
            {
                Mensaje = " " + EX;
            }
            return Mensaje;
        }

        public string Editar(String ID, String Codigo, String NombreProducto, String Descripcion, String Unidad, int Cantidad, float PrecioC, float PrecioV, Producto Articulo)
        {
            try
            {
                Articulo.ID = ID;
                Articulo.Codigo = Codigo;
                Articulo.NombreProducto = NombreProducto;
                Articulo.Descripcion = Descripcion;
                Articulo.Cantidad = Cantidad;
                Articulo.Unidad = Unidad;
                Articulo.PrecioC = PrecioC;
                Articulo.PrecioV = PrecioV;
                return RepositorioProductos.Actualizar(products, false);

            }
            catch (Exception EX)
            {
                return "" + EX;
                throw;
            }
        }

        public string EliminarProducto(Producto Articulo)
        {
            try
            {
                products.Remove(Articulo);
                return RepositorioProductos.Actualizar(DisminuirId(products),false);
            }
            catch (Exception EX)
            {
                return " " + EX;
                throw;
            }
        }

        public List<Producto> GetAllProductos()
        {
            return RepositorioProductos.GetAll();
        }

        public Producto ObtenerPorCodigo(String Codigo)
        {
            foreach (var item in products)
            {
                if (item.Codigo == Codigo)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Producto> DisminuirId(List<Producto> products)
     
        {
            int Conta = 1;
            foreach (var item in products)
            {
                item.ID = Conta.ToString(); 
                Conta++;
            }
            return products;
        }
        public int GetById()
        {
            return GetAllProductos().Count + 1;
        }

        public String ArticuloXId(String id)
        {
            String Cod ="";
            foreach (Producto item in RepositorioProductos.GetAll())
            {
                if (item.ID == id)
                {
                    Cod = item.Codigo;
                }
            }
            return Cod;
        }
        public String IdXArticulo(String Cod)
        {
            String ID = ""; 
            foreach (Producto item in RepositorioProductos.GetAll())
            {
                if (item.Codigo == Cod)
                {
                    ID = item.ID;
                }
            }
            return ID;
        }
    }
}
