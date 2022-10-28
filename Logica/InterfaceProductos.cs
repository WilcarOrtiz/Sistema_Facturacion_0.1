﻿using Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface InterfaceProductos<T>
    {
        string AgregarProducto(Producto Articulo);
        string EliminarProducto(Producto Articulo);
        List<T> GetAllProductos();
        T ObtenerPorCodigo(String Codigo);
        string Editar(String ID, String Codigo, String NombreProducto, 
            String Descripcion, String Unidad, int Cantidad, 
            float PrecioC, float PrecioV, Producto Articulo); 
    }
}
