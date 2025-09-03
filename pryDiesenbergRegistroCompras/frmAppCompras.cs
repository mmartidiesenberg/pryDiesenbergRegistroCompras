using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        DateTime vFecha;
        string vProducto;
        int vCantidad;
        int vPrecioUnitario;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = lstNombre.Text;
            vCantidad = Convert.ToInt32(numCant.Value);
            vPrecioUnitario = Convert.ToInt32(txtPrecio.Text);

            lblResultados.Text =
                vFecha.ToString() + " - " + vProducto
                + vCantidad.ToString() + " - "
                + vPrecioUnitario.ToString();   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numCant.Value > 0)
            {
                txtPrecio.Enabled = true; 
            }
        }

        private void lstNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNombre_TextChanged(object sender, EventArgs e)
        {
            if (lstNombre.Text != "")
                numCant.Enabled = true;
            else 
                numCant.Enabled = false;   
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
       
