﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergRegistroCompras
{
    public partial class frmAppCompras : Form
    {
        public frmAppCompras()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Registrado Correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void lstNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                numCantidad.Enabled = true;
            }
        }
    }
}
