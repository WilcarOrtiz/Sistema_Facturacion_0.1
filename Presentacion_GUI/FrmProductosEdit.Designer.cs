namespace Presentacion_GUI
{
    partial class FrmProductosEdit
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbUnidadesEdit = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CantidadEdit = new System.Windows.Forms.NumericUpDown();
            this.textCodigoEditar = new System.Windows.Forms.TextBox();
            this.txtPrecioVEdit = new System.Windows.Forms.TextBox();
            this.txtPrecioCEdit = new System.Windows.Forms.TextBox();
            this.txtNombreProducEditar = new System.Windows.Forms.TextBox();
            this.txtDescripEditar = new System.Windows.Forms.TextBox();
            this.BtnGuardarEdit = new System.Windows.Forms.PictureBox();
            this.BtnCancelarEdit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadInicial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardarEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelarEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Unidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Precio de Venta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Precio de Compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Codigo";
            // 
            // cmbUnidadesEdit
            // 
            this.cmbUnidadesEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUnidadesEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadesEdit.FormattingEnabled = true;
            this.cmbUnidadesEdit.Items.AddRange(new object[] {
            "UNIDAD",
            "CAJA (24 Unds)",
            "CANASTA (30 Unds)"});
            this.cmbUnidadesEdit.Location = new System.Drawing.Point(47, 169);
            this.cmbUnidadesEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnidadesEdit.Name = "cmbUnidadesEdit";
            this.cmbUnidadesEdit.Size = new System.Drawing.Size(110, 21);
            this.cmbUnidadesEdit.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Cantidad en bodega: ";
            // 
            // CantidadEdit
            // 
            this.CantidadEdit.Location = new System.Drawing.Point(172, 266);
            this.CantidadEdit.Name = "CantidadEdit";
            this.CantidadEdit.Size = new System.Drawing.Size(59, 20);
            this.CantidadEdit.TabIndex = 51;
            // 
            // textCodigoEditar
            // 
            this.textCodigoEditar.Location = new System.Drawing.Point(187, 169);
            this.textCodigoEditar.Name = "textCodigoEditar";
            this.textCodigoEditar.Size = new System.Drawing.Size(65, 20);
            this.textCodigoEditar.TabIndex = 53;
            // 
            // txtPrecioVEdit
            // 
            this.txtPrecioVEdit.Location = new System.Drawing.Point(171, 225);
            this.txtPrecioVEdit.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVEdit.Name = "txtPrecioVEdit";
            this.txtPrecioVEdit.Size = new System.Drawing.Size(80, 20);
            this.txtPrecioVEdit.TabIndex = 47;
            // 
            // txtPrecioCEdit
            // 
            this.txtPrecioCEdit.Location = new System.Drawing.Point(46, 225);
            this.txtPrecioCEdit.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCEdit.Name = "txtPrecioCEdit";
            this.txtPrecioCEdit.Size = new System.Drawing.Size(110, 20);
            this.txtPrecioCEdit.TabIndex = 40;
            // 
            // txtNombreProducEditar
            // 
            this.txtNombreProducEditar.Location = new System.Drawing.Point(47, 56);
            this.txtNombreProducEditar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducEditar.Name = "txtNombreProducEditar";
            this.txtNombreProducEditar.Size = new System.Drawing.Size(205, 20);
            this.txtNombreProducEditar.TabIndex = 38;
            // 
            // txtDescripEditar
            // 
            this.txtDescripEditar.Location = new System.Drawing.Point(47, 106);
            this.txtDescripEditar.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripEditar.Multiline = true;
            this.txtDescripEditar.Name = "txtDescripEditar";
            this.txtDescripEditar.Size = new System.Drawing.Size(205, 35);
            this.txtDescripEditar.TabIndex = 39;
            // 
            // BtnGuardarEdit
            // 
            this.BtnGuardarEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGuardarEdit.Location = new System.Drawing.Point(46, 364);
            this.BtnGuardarEdit.Name = "BtnGuardarEdit";
            this.BtnGuardarEdit.Size = new System.Drawing.Size(79, 50);
            this.BtnGuardarEdit.TabIndex = 55;
            this.BtnGuardarEdit.TabStop = false;
            this.BtnGuardarEdit.Click += new System.EventHandler(this.BtnGuardarEdit_Click);
            // 
            // BtnCancelarEdit
            // 
            this.BtnCancelarEdit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancelarEdit.Location = new System.Drawing.Point(172, 364);
            this.BtnCancelarEdit.Name = "BtnCancelarEdit";
            this.BtnCancelarEdit.Size = new System.Drawing.Size(100, 50);
            this.BtnCancelarEdit.TabIndex = 56;
            this.BtnCancelarEdit.TabStop = false;
            this.BtnCancelarEdit.Click += new System.EventHandler(this.BtnCancelarEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cantidad a adicionar:";
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.AutoSize = true;
            this.CantidadInicial.Location = new System.Drawing.Point(169, 300);
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.Size = new System.Drawing.Size(0, 13);
            this.CantidadInicial.TabIndex = 58;
            // 
            // FrmProductosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 459);
            this.Controls.Add(this.CantidadInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelarEdit);
            this.Controls.Add(this.BtnGuardarEdit);
            this.Controls.Add(this.textCodigoEditar);
            this.Controls.Add(this.CantidadEdit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecioVEdit);
            this.Controls.Add(this.txtPrecioCEdit);
            this.Controls.Add(this.txtDescripEditar);
            this.Controls.Add(this.txtNombreProducEditar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbUnidadesEdit);
            this.Name = "FrmProductosEdit";
            this.Text = "FrmProductosEdit";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardarEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelarEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbUnidadesEdit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown CantidadEdit;
        private System.Windows.Forms.TextBox textCodigoEditar;
        private System.Windows.Forms.TextBox txtPrecioVEdit;
        private System.Windows.Forms.TextBox txtPrecioCEdit;
        private System.Windows.Forms.TextBox txtNombreProducEditar;
        private System.Windows.Forms.TextBox txtDescripEditar;
        private System.Windows.Forms.PictureBox BtnGuardarEdit;
        private System.Windows.Forms.PictureBox BtnCancelarEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CantidadInicial;
    }
}