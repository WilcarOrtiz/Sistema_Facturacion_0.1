using Entitades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class CrudUsuario : Form
    {
        
        public CrudUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            switch (vacio())
            {
                case true:

                    MessageBox.Show("Debe llenar todos los campos", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    break;

                    case false:

                    CrearUsuario();
                    Restablecer();

                     break;
                
            }
        }

        public void CrearUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Contraseña = txtContraseña.Text;
            usuario.NombreUser = txtUsusario.Text; 

            FrmPersonal frmPersonal = new FrmPersonal();    
            usuario.Nombre = frmPersonal.
        }

        public Boolean vacio()
        {
            if (txtContraseña.Text=="" || txtContraseña.Text == "Contraseña" || txtUsusario.Text =="" || txtUsusario.Text=="Usuario")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Restablecer()
        {
            txtUsusario.Text = "";
            txtContraseña.Text = "";
        }
    }
}
