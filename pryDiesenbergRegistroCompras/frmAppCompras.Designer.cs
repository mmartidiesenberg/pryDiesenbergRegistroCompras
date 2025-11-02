namespace pryDiesenbergRegistroCompras
{
    partial class frmAppCompras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppCompras));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioU = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(42, 115);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 44);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(42, 210);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(335, 44);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Nombre del Producto";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(42, 298);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(316, 44);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad Comprada";
            // 
            // lblPrecioU
            // 
            this.lblPrecioU.AutoSize = true;
            this.lblPrecioU.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioU.Location = new System.Drawing.Point(42, 394);
            this.lblPrecioU.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecioU.Name = "lblPrecioU";
            this.lblPrecioU.Size = new System.Drawing.Size(239, 44);
            this.lblPrecioU.TabIndex = 3;
            this.lblPrecioU.Text = "Precio Unitario";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpFecha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(432, 112);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFecha.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(480, 43);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2025, 9, 3, 12, 42, 2, 0);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(584, 494);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(228, 60);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(190, 494);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(226, 60);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.MistyRose;
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCantidad.FormattingEnabled = true;
            this.txtCantidad.Location = new System.Drawing.Point(432, 202);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(434, 43);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.SelectedIndexChanged += new System.EventHandler(this.lstNombre_SelectedIndexChanged);
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // numCantidad
            // 
            this.numCantidad.BackColor = System.Drawing.Color.MistyRose;
            this.numCantidad.Enabled = false;
            this.numCantidad.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(432, 298);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(244, 43);
            this.numCantidad.TabIndex = 3;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.MistyRose;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(432, 388);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrecio.Mask = "99999";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(240, 43);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.BackColor = System.Drawing.Color.MistyRose;
            this.lblIngresar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(128, 17);
            this.lblIngresar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(745, 51);
            this.lblIngresar.TabIndex = 13;
            this.lblIngresar.Text = "Ingrese los Datos del Producto a Registrar";
            // 
            // frmAppCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(964, 577);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblPrecioU);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAppCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Compras";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioU;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox txtCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label lblIngresar;
    }
}

