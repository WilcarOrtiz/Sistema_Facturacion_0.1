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
            this.pbGuardarPersonal = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.pbFotoEmpleado = new System.Windows.Forms.PictureBox();
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
            this.gbIngreso.Controls.Add(this.pbGuardarPersonal);
            this.gbIngreso.Controls.Add(this.txtContraseña);
            this.gbIngreso.Controls.Add(this.cmbCargos);
            this.gbIngreso.Controls.Add(this.txtTelefono);
            this.gbIngreso.Controls.Add(this.txtCorreo);
            this.gbIngreso.Controls.Add(this.txtApellidos);
            this.gbIngreso.Controls.Add(this.txtNombres);
            this.gbIngreso.Controls.Add(this.txtCedula);
            this.gbIngreso.Controls.Add(this.pbFotoEmpleado);
            this.gbIngreso.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gbIngreso.Location = new System.Drawing.Point(52, 44);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(544, 615);
            this.gbIngreso.TabIndex = 1;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso";
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
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(124, 485);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(228, 26);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "Contraseña";
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
            this.cmbCargos.Location = new System.Drawing.Point(124, 171);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(228, 28);
            this.cmbCargos.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(124, 377);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(228, 26);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(124, 431);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 26);
            this.txtCorreo.TabIndex = 4;
            this.txtCorreo.Text = "Correo";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(124, 328);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(228, 26);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(124, 275);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(228, 26);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.Text = "Nombres";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(124, 222);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(228, 26);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Text = "Cedula";
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
            // gbLista
            // 
            this.gbLista.Controls.Add(this.dgListaEmpleados);
            this.gbLista.Location = new System.Drawing.Point(615, 44);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(504, 638);
            this.gbLista.TabIndex = 2;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista";
            // 
            // dgListaEmpleados
            // 
            this.dgListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaEmpleados.Location = new System.Drawing.Point(33, 31);
            this.dgListaEmpleados.Name = "dgListaEmpleados";
            this.dgListaEmpleados.RowHeadersWidth = 62;
            this.dgListaEmpleados.RowTemplate.Height = 28;
            this.dgListaEmpleados.Size = new System.Drawing.Size(448, 585);
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
        private System.Windows.Forms.TextBox txtContraseña;
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