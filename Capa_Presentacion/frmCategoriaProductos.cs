using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Presentacion
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCategoria_Enter(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "Nombre Categoria")
            {
                txtNombreCategoria.Text = "";
                txtNombreCategoria.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtNombreCategoria_Leave(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                txtNombreCategoria.Text = "Nombre Categoria";
                txtNombreCategoria.ForeColor = Color.DimGray;
            }
        }
    }
}
