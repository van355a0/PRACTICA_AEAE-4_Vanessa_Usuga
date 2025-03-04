using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Presentacion
{
    public partial class frmClientes : Form
    {
        public int IdCliente { get; internal set; }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "Nombre Cliente")
            {
                txtNombreCliente.Text = "";
                txtNombreCliente.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                txtNombreCliente.Text = "Nombre Cliente";
                txtNombreCliente.ForeColor = Color.DimGray;
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "Documento")
            {
                txtDocumento.Text = "";
                txtDocumento.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                txtDocumento.Text = "Documento";
                txtDocumento.ForeColor = Color.DimGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Teléfono";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DimGray;
            }
        }


        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new AccesoDatos().ObtenerConexion())
                {
                    string query = "INSERT INTO dbo.TBLCLIENTES (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail) " +
                                   "VALUES (@nombre, @documento, @direccion, @telefono, @email)";


                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
