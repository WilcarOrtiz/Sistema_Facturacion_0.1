using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Presentacion_GUI
{
    public partial class FrmAdmin : Form
    {

        Logica.FuncionesProductos funcionesProductos = new Logica.FuncionesProductos();
        int fila;DataTable Tabla;
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtCedula.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //falta la validacion de si existe la cedula 
                    txtNombres.Focus();
                }
            }
        }
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombres.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombres.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtApellidos.Focus();
                }
            }
        }
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtApellidos.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtApellidos.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtTelefono.Focus();
                }
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefono.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtCorreo.Focus();
                }
            }
        }
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (!txtCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("La direccion no contiene el caracter @ ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCorreo.Text = "";
                    txtCorreo.Focus();
                }
                else
                {
                    txtContraseña.Focus();
                }
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefono.TextLength < 5)
                {
                    MessageBox.Show("La longitud de la contraseña es muy corta...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    pbGuardarPersonal.Focus();
                }
            }
        }
        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seleccion();
            txtCedula.Select();
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            Seleccion();Seleccion2();
            CargarGrillaProductos();CargarTabla();
        }
        public void Restablecer()
        {
            txtCedula.Text = "Cedula";txtNombres.Text = "Nombres";txtApellidos.Text = "Apellidos";
            txtTelefono.Text = "Telefono";txtCorreo.Text = "Correo";txtContraseña.Text = "Contraseña";cmbCargos.SelectedIndex = -1;
        }
        public void Seleccion()
        {
            if (cmbCargos.Text == "")
            {
                BloqueoTextBox();
            }
            else
            {
                DesbloqueoTextBox();

                if (cmbCargos.Text == "VENDEDOR")
                {
                    txtContraseña.Enabled = true;
                }
            }
        }
        public void BloqueoTextBox()
        {
            txtApellidos.Enabled = false;txtTelefono.Enabled = false;
            txtCedula.Enabled = false;txtContraseña.Enabled = false;
            txtCorreo.Enabled = false;txtNombres.Enabled = false;
        }
        public void DesbloqueoTextBox()
        {
            txtApellidos.Enabled = true;txtTelefono.Enabled = true;
            txtCedula.Enabled = true;txtCorreo.Enabled = true;
            txtNombres.Enabled = true;txtContraseña.Enabled = false;
        }
        private void txtCedula_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula")
            {
                txtCedula.Clear();
            }
        }
        private void txtNombres_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "Nombres")
            {
                txtNombres.Clear();
            }
        }
        private void txtApellidos_Click(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Clear();
            }
        }
        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Clear();
            }
        }
        private void txtCorreo_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Clear();
            }
        }
        private void txtContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Clear();
            };
        }
        private void pbGuardarPersonal_Click(object sender, EventArgs e)
        {
            switch (vacio())
            {
                case true:
                    MessageBox.Show("Debe llenar todos los campos", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case false:
                    Restablecer();
                    break;
            }
        }
        public Boolean vacio()
        {
            if (txtContraseña.Text == "" || txtCedula.Text == "" || txtApellidos.Text == "" ||
                txtNombres.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
            {
                return true;
            }
            return false;
        }
        ///////////////////  PAGINA DE PRODUCTOS.  //////////////////////////////
        public void BloqueoProduct()
        {
            txtNombreProduc.Enabled = false;txtDescrip.Enabled = false;txtPrecioC.Enabled = false;
            txtCodigo.Enabled = false;txtPrecioV.Enabled = false;Cantidad.Enabled = false;
        }
        public void DesbloqueoProduct()
        {
            txtNombreProduc.Enabled = true;txtDescrip.Enabled = true;txtPrecioC.Enabled = true;
            txtCodigo.Enabled = true;txtPrecioV.Enabled = true;Cantidad.Enabled = true;
        }
        public void Seleccion2()
        {
            if (cmbUnidades.Text == "")
            {
                BloqueoProduct();
            }
            else
            {
                DesbloqueoProduct();
            }
        }
        public Boolean vacio2()
        {
            if (txtNombreProduc.Text == "" || txtPrecioC.Text == "" || txtCodigo.Text == "" || Cantidad.Value == 0 || txtPrecioV.Text == "")
            {
                return true;
            }
            return false;
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.TextLength < 0)
                {
                    MessageBox.Show("Debe ingresar un codigo correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (funcionesProductos.ObtenerPorCodigo(txtCodigo.Text) != null)
                    {
                        MessageBox.Show("El codigo ya existe para otro producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                    }
                    else { txtNombreProduc.Focus(); }
                }
            }
        }
        private void txtNombreProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombreProduc.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombreProduc.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtDescrip.Focus();
                }
            }
        }
        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtDescrip.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                txtPrecioC.Focus();
            }
        }
        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPrecioC.TextLength == 0)
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtPrecioV.Focus()
;
                }
            }
        }
        private void cmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seleccion2();
        }
        private void Cantidad_SelectedItemChanged(object sender, EventArgs e)
        {
            Cantidad.UpButton();
        }
        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPrecioV.TextLength == 0)
                {
                    MessageBox.Show("Debe ingresar un precio correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Cantidad.Focus();
                }
            }
        }
        //CAPTURA DE INFORMACION 
        void GuardarP()
        {
            var Articulo = new Entitades.Producto();
            Articulo.ID = funcionesProductos.GetById().ToString();
            Articulo.Codigo = txtCodigo.Text;
            Articulo.NombreProducto = txtNombreProduc.Text;
            Articulo.Descripcion = txtDescrip.Text;
            Articulo.Cantidad = (int)Cantidad.Value;
            Articulo.Unidad = cmbUnidades.Text;
            Articulo.PrecioC = float.Parse(txtPrecioC.Text);
            Articulo.PrecioV = float.Parse(txtPrecioV.Text);
            var Respuesta = funcionesProductos.AgregarProducto(Articulo);
            MessageBox.Show(Respuesta, "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            switch (vacioP())
            {
                case true:
                    MessageBox.Show("Verifique los campos obligatorios", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case false:
                    GuardarP();
                    RestablecerCasillasProductos();
                    CargarGrillaProductos();
                    break;
            }
        }
        public void RestablecerCasillasProductos()
        {
            txtCodigo.Text = "";txtNombreProduc.Text = ""; txtDescrip.Text = "";
            Cantidad.Value = 1;cmbUnidades.Text = "";txtPrecioC.Text = "";
            txtPrecioV.Text = "";cmbUnidades.Focus();

        }
        public Boolean vacioP()
        {
            if (txtCodigo.Text == "" || txtNombreProduc.Text == "" || txtDescrip.Text == "" || Cantidad.Value == 0
                || cmbUnidades.Text == "" || txtPrecioC.Text == "" || txtPrecioV.Text == "")
            {
                return true;
            }
            return false;
        }
        void CargarGrillaProductos()
        {
            GrillaProductos.Rows.Clear();
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                GrillaProductos.Rows.Add(item.Codigo, item.NombreProducto, item.Descripcion, item.Cantidad, item.Unidad, item.PrecioC, item.PrecioV);
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
                String Codigo = GrillaCatalogo.Rows[fila].Cells[2].Value.ToString();
                MessageBox.Show(funcionesProductos.EliminarProducto(funcionesProductos.ObtenerPorCodigo(Codigo)));
                CargarTabla();
                CargarGrillaProductos();

            }
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 1)
            {
                VistaParaProductos(funcionesProductos.GetAllProductos()[e.RowIndex]);
                CargarTabla();
                CargarGrillaProductos();
            }
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
        void CargarTabla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Codigo");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Cantidad");
            Tabla.Columns.Add("Unidad");
            Tabla.Columns.Add("p. Venta");
            Tabla.Columns.Add("P. Compra");
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                Tabla.Rows.Add(item.Codigo, item.NombreProducto, item.Cantidad, item.Unidad, item.PrecioV, item.PrecioC);
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        void GenerarPDF()
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            string TituloPdf = DateTime.Now.ToString("REPORTE (dd/MM/yyyy)");
            Guardar.FileName = TituloPdf + ".pdf";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            string filas = string.Empty;
            decimal total = 0;
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                filas += "<tr>";
                filas += "<td>" + item.Codigo.ToString() + "</td>";
                filas += "<td>" + item.NombreProducto.ToString() + "</td>";
                filas += "<td>" + item.Cantidad.ToString() + "</td>";
                filas += "<td>" + item.Unidad.ToString() + "</td>";
                filas += "<td>" + item.PrecioV.ToString() + "</td>";
                filas += "<td>" + item.PrecioC.ToString() + "</td>";
                filas += "</tr>";
                total += funcionesProductos.ValorFinal(item.Unidad.ToString(), item.Cantidad, item.PrecioC);
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(Guardar.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.IconoCervezaPdf,System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
