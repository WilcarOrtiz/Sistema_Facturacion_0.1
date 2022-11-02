namespace Presentacion_GUI
{
    partial class FrmVistaProductos
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
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GrillaCatalogo = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(250, 30);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(264, 26);
            this.textBusqueda.TabIndex = 7;
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(126, 28);
            this.cmbTipoBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(116, 28);
            this.cmbTipoBusqueda.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Buscar por";
            // 
            // GrillaCatalogo
            // 
            this.GrillaCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Column15});
            this.GrillaCatalogo.Location = new System.Drawing.Point(36, 89);
            this.GrillaCatalogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaCatalogo.Name = "GrillaCatalogo";
            this.GrillaCatalogo.RowHeadersWidth = 62;
            this.GrillaCatalogo.Size = new System.Drawing.Size(1094, 616);
            this.GrillaCatalogo.TabIndex = 8;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "";
            this.Eliminar.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Editar";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmVistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1169, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrillaCatalogo);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.cmbTipoBusqueda);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaProductos";
            this.Text = "FrmVistaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GrillaCatalogo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}