using Capa_Entidades;
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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuarioSeguridad_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioSeguridad.Text == "Usuario")
            {
                txtUsuarioSeguridad.Text = "";
                txtUsuarioSeguridad.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtUsuarioSeguridad_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioSeguridad.Text == "")
            {
                txtUsuarioSeguridad.Text = "Usuario";
                txtUsuarioSeguridad.ForeColor = Color.DimGray;
            }
        }

        private void txtClaveSeguridad_Enter(object sender, EventArgs e)
        {
            if (txtClaveSeguridad.Text == "Clave")
            {
                txtClaveSeguridad.Text = "";
                txtClaveSeguridad.ForeColor = Color.FromArgb(64, 64, 64);
                txtClaveSeguridad.UseSystemPasswordChar = true;
            }
        }

        private void txtClaveSeguridad_Leave(object sender, EventArgs e)
        {
            if (txtClaveSeguridad.Text == "")
            {
                txtClaveSeguridad.Text = "Clave";
                txtClaveSeguridad.ForeColor = Color.DimGray;
                txtClaveSeguridad.UseSystemPasswordChar = false;
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new AccesoDatos().ObtenerConexion())

            {
                string query = "UPDATE usuarios SET password=@password WHERE usuario=@usuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", txtUsuarioSeguridad.Text);
                cmd.Parameters.AddWithValue("@password", txtClaveSeguridad.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Contraseña actualizada correctamente");
        }

        private void txtUsuarioSeguridad_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnActualizarAdmin_Click(object sender, EventArgs e)
        {
            if (cmbBoxEmpl.SelectedValue != null && txtUsuarioSeguridad.Text != "" && txtClaveSeguridad.Text != "")
            {
                int idEmpleado = Convert.ToInt32(cmbBoxEmpl.SelectedValue);
                string usuario = txtUsuarioSeguridad.Text;
                string clave = txtClaveSeguridad.Text;


                AccesoDatos acceso = new AccesoDatos();
                if (acceso.ActualizarUsuario(idEmpleado, usuario, clave))
                {
                    MessageBox.Show("Usuario actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios.");
            }
        }


        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            cmbBoxEmpl.DataSource = usuarioNegocio.ObtenerEmpleados();
            cmbBoxEmpl.DisplayMember = "strNombre";
            cmbBoxEmpl.ValueMember = "IdEmpleado";
            cmbBoxEmpl.SelectedIndex = -1;
        }

        UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

        private void cmbBoxEmpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxEmpl.SelectedValue != null)
            {
                try
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    int idEmpleado = 0;

                    if (cmbBoxEmpl.SelectedValue is DataRowView)
                    {
                        idEmpleado = Convert.ToInt32(((DataRowView)cmbBoxEmpl.SelectedItem)["IdEmpleado"]);
                    }
                    else
                    {
                        idEmpleado = Convert.ToInt32(cmbBoxEmpl.SelectedValue);
                    }

                    // Datos de seguridad
                    DataTable dt = usuarioNegocio.ObtenerDatosSeguridad(idEmpleado);

                    if (dt.Rows.Count > 0)
                    {
                        txtUsuarioSeguridad.Text = dt.Rows[0]["StrUsuario"].ToString();
                        txtClaveSeguridad.Text = dt.Rows[0]["StrClave"].ToString();
                    }
                    else
                    {
                        txtUsuarioSeguridad.Clear();
                        txtClaveSeguridad.Clear();
                        MessageBox.Show("No hay datos de seguridad para este empleado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnBuscarSeguridad_Click(object sender, EventArgs e)
        {
            cmbBoxEmpl_SelectedIndexChanged(sender, e);

        }

    }
}