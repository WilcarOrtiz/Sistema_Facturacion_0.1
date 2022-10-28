using System;
using Entitades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace Presentacion_GUI
{
    public partial class FrmProductosEdit : Form
    {
        Logica.FuncionesProductos FuncionesProductos = new Logica.FuncionesProductos();
        String Id;
        int CantidadI;
        public FrmProductosEdit(FrmAdmin.Datos informacion)
        {
            InitializeComponent();
            Id = informacion.ID;
            txtNombreProducEditar.Text = informacion.NombreProducto;
            txtDescripEditar.Text = informacion.Descripcion;
            cmbUnidadesEdit.Text = informacion.Unidad;
            textCodigoEditar.Text = informacion.Codigo;
            txtPrecioCEdit.Text = informacion.PrecioC.ToString();
            txtPrecioVEdit.Text = informacion.PrecioV.ToString();
            CantidadEdit.Value = informacion.Cantidad;
            CantidadI = informacion.Cantidad;

        }
        public Boolean vacio()
        {
            if (txtNombreProducEditar.Text == "" || txtDescripEditar.Text == "" || cmbUnidadesEdit.Text == "" || textCodigoEditar.Text == "" || txtPrecioCEdit.Text == "" || txtPrecioVEdit.Text == "")
            {
                MessageBox.Show("Falta informacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        void CapturarActualizacion()
        {
            MessageBox.Show(textCodigoEditar.Text);
            String Cod = FuncionesProductos.ArticuloXId(Id);
            Producto Articulo = FuncionesProductos.ObtenerPorCodigo(Cod);
            String IdEdit = FuncionesProductos.IdXArticulo(textCodigoEditar.Text);
            if ((Id == IdEdit) || (FuncionesProductos.ObtenerPorCodigo(Cod) == null))
            {
                MessageBox.Show(FuncionesProductos.Editar(Id, textCodigoEditar.Text, txtNombreProducEditar.Text,
                    txtDescripEditar.Text, cmbUnidadesEdit.Text, ((int)CantidadEdit.Value + CantidadI),
                    float.Parse(txtPrecioCEdit.Text), float.Parse(txtPrecioVEdit.Text)
                    , Articulo));

            }
            else
            {
                switch (MessageBox.Show("El codigo ya existe para otro producto\nDesea continuar con la actulizacion", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.OK:
                        textCodigoEditar.Text = "";
                        textCodigoEditar.Focus();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }
        private void BtnGuardarEdit_Click(object sender, EventArgs e)
        {
            CapturarActualizacion();
            this.Close(); 
        }

        private void BtnCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
