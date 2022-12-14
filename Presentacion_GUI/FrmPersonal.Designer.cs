namespace Presentacion_GUI
{
    partial class FrmPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonal));
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.pbGuardarPersonal = new System.Windows.Forms.PictureBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.pbFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.dgListaEmpleados = new System.Windows.Forms.DataGridView();
            this.gbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).BeginInit();
            this.gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.txtCorreo);
            this.gbIngreso.Controls.Add(this.txtApellidos);
            this.gbIngreso.Controls.Add(this.pbGuardarPersonal);
            this.gbIngreso.Controls.Add(this.txtNombres);
            this.gbIngreso.Controls.Add(this.pbFotoEmpleado);
            this.gbIngreso.Controls.Add(this.cmbCargos);
            this.gbIngreso.Controls.Add(this.txtCedula);
            this.gbIngreso.Controls.Add(this.txtTelefono);
            this.gbIngreso.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gbIngreso.Location = new System.Drawing.Point(52, 44);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(526, 638);
            this.gbIngreso.TabIndex = 1;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(116, 447);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 26);
            this.txtCorreo.TabIndex = 4;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(116, 344);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(228, 26);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // pbGuardarPersonal
            // 
            this.pbGuardarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardarPersonal.Image")));
            this.pbGuardarPersonal.Location = new System.Drawing.Point(386, 517);
            this.pbGuardarPersonal.Name = "pbGuardarPersonal";
            this.pbGuardarPersonal.Size = new System.Drawing.Size(92, 83);
            this.pbGuardarPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardarPersonal.TabIndex = 8;
            this.pbGuardarPersonal.TabStop = false;
            this.pbGuardarPersonal.Click += new System.EventHandler(this.pbGuardarPersonal_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(116, 291);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(228, 26);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.Text = "Nombres";
            this.txtNombres.Enter += new System.EventHandler(this.txtNombres_Enter);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            this.txtNombres.Leave += new System.EventHandler(this.txtNombres_Leave);
            // 
            // pbFotoEmpleado
            // 
            this.pbFotoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFotoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoEmpleado.Image")));
            this.pbFotoEmpleado.Location = new System.Drawing.Point(180, 25);
            this.pbFotoEmpleado.Name = "pbFotoEmpleado";
            this.pbFotoEmpleado.Size = new System.Drawing.Size(116, 117);
            this.pbFotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFotoEmpleado.TabIndex = 0;
            this.pbFotoEmpleado.TabStop = false;
            // 
            // cmbCargos
            // 
            this.cmbCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Items.AddRange(new object[] {
            "VENDEDOR",
            "SEGURIDAD",
            "LIMPIEZA",
            "MESERO(A)"});
            this.cmbCargos.Location = new System.Drawing.Point(116, 187);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(228, 28);
            this.cmbCargos.TabIndex = 6;
            this.cmbCargos.TabIndexChanged += new System.EventHandler(this.cmbCargos_SelectedIndexChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(116, 238);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(228, 26);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Text = "Cedula";
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(116, 393);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(228, 26);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.dgListaEmpleados);
            this.gbLista.Location = new System.Drawing.Point(584, 44);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(535, 638);
            this.gbLista.TabIndex = 2;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista";
            // 
            // dgListaEmpleados
            // 
            this.dgListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaEmpleados.Location = new System.Drawing.Point(31, 25);
            this.dgListaEmpleados.Name = "dgListaEmpleados";
            this.dgListaEmpleados.RowHeadersWidth = 62;
            this.dgListaEmpleados.RowTemplate.Height = 28;
            this.dgListaEmpleados.Size = new System.Drawing.Size(474, 585);
            this.dgListaEmpleados.TabIndex = 0;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1169, 755);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).EndInit();
            this.gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.PictureBox pbGuardarPersonal;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.PictureBox pbFotoEmpleado;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dgListaEmpleados;
    }
}