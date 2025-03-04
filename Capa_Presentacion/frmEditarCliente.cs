using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmEditarCliente : Form
    {
        private int idCliente;

        public frmEditarCliente(int id)
        {
            try
            {
                InitializeComponent();
                idCliente = id;
                CargarDatosCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }

        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void CargarDatosCliente()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
                {
                    conexion.Open();
                    string query = "SELECT StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM TBLCLIENTES WHERE IdCliente = @id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombreClienteE.Text = reader["StrNombre"].ToString();
                        txtDocumentoE.Text = reader["NumDocumento"].ToString();
                        txtDireccionE.Text = reader["StrDireccion"].ToString();
                        txtTelefonoE.Text = reader["StrTelefono"].ToString();
                        txtEmailE.Text = reader["StrEmail"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + ex.Message);
            }
        }

        private void btnSalirClienteE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarClienteE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
                {
                    conexion.Open();
                    string query = "UPDATE TBLCLIENTES SET StrNombre=@nombre, NumDocumento=@documento, StrDireccion=@direccion, StrTelefono=@telefono, StrEmail=@email WHERE IdCliente=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Pasar valores de los TextBox a la consulta
                    cmd.Parameters.AddWithValue("@nombre", txtNombreClienteE.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDocumentoE.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionE.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoE.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailE.Text);
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario abierto correctamente.");
        }

        private void txtNombreClienteE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
