using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion_GUI
{
    public partial class FrmVistaProductos : Form
    {
        Logica.FuncionesProductos funcionesProductos = new Logica.FuncionesProductos();
        int fila;
        DataTable Tabla;
        public FrmVistaProductos()
        {
            InitializeComponent();
        }

        public struct Datos
        {
            public string Codigo;
            public string ID;
            public string Unidad;
            public string NombreProducto;
            public string Descripcion;
            public int Cantidad;
            public float PrecioC;
            public float PrecioV;
        }
        void VistaParaProductos(Entitades.Producto Articulo)
        {
            MessageBox.Show(Articulo.NombreProducto);
            Datos informacion;
            informacion.ID = Articulo.ID;
            informacion.Codigo = Articulo.Codigo;
            informacion.NombreProducto = Articulo.NombreProducto;
            informacion.Descripcion = Articulo.Descripcion;
            informacion.Cantidad = Articulo.Cantidad;
            informacion.Unidad = Articulo.Unidad;
            informacion.PrecioC = Articulo.PrecioC;
            informacion.PrecioV = Articulo.PrecioV;
            FrmProductosEdit FPE = new FrmProductosEdit(informacion);
            FPE.ShowDialog();
        }
        void DeclaracionTabla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Codigo");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Cantidad");
            Tabla.Columns.Add("Unidad");
            Tabla.Columns.Add("$ Compra");
            Tabla.Columns.Add("$ Venta");
        }
        void CargarTabla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Codigo");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Cantidad");
            Tabla.Columns.Add("Unidad");
            Tabla.Columns.Add("$ Compra");
            Tabla.Columns.Add("$ Venta");
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                Tabla.Rows.Add(item.Codigo, item.NombreProducto, item.Cantidad, item.Unidad, item.PrecioC, item.PrecioV);
            }
            GrillaCatalogo.DataSource = Tabla;
        }
        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataView Dv = Tabla.DefaultView;
            switch (cmbTipoBusqueda.Text)
            {
                case "Codigo":
                    Dv.RowFilter = " Codigo LIKE '" + textBusqueda.Text + "%'";
                    GrillaCatalogo.DataSource = Dv;
                    break;

                case "Nombre":
                    Dv.RowFilter = " Nombre  LIKE '" + textBusqueda.Text + "%'";
                    GrillaCatalogo.DataSource = Dv;
                    break;
            }
        }
        void CargarGrillaCatalogo()
        {
            GrillaCatalogo.Rows.Clear();
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                GrillaCatalogo.Rows.Add(item.Codigo, item.NombreProducto, item.Cantidad, item.Unidad, item.PrecioC, item.PrecioV);
            }
        }
        public void GrillaCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 0)
            {
                String Codigo = GrillaCatalogo.Rows[fila].Cells[0].Value.ToString();
                MessageBox.Show(funcionesProductos.EliminarProducto(funcionesProductos.ObtenerPorCodigo(Codigo)));
                CargarGrillaCatalogo();

            }
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 1)
            {
                VistaParaProductos(funcionesProductos.GetAllProductos()[e.RowIndex]);
                CargarTabla();
                //CargarGrillaCatalogo();
            }

        }

        private void GrillaCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmVistaProductos_Load(object sender, EventArgs e)
        {
            CargarTabla();
            DeclaracionTabla();
        }
    }
}
