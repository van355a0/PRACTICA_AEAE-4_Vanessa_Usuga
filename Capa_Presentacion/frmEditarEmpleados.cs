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

namespace Capa_Presentacion.Presentacion__Forms_
{
    public partial class frmEditarEmpleados : Form
    {
        private int idEmpleado;

        public frmEditarEmpleados(int id)
        {
            try
            {
                InitializeComponent();
                idEmpleado = id;
                CargarDatosEmpleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }

        public frmEditarEmpleados()
        {
            InitializeComponent();
        }

        private void CargarDatosEmpleado()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
                {
                    conexion.Open();
                    string query = "SELECT StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro, strDatosAdicionales FROM TBLMPLEADOS WHERE IdEmpleado = @id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", idEmpleado);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombreEmplEdit.Text = reader["StrNombre"].ToString();
                        txtDocEmplEdit.Text = reader["NumDocumento"].ToString();
                        txtDireccionEmplEdit.Text = reader["StrDireccion"].ToString();
                        txtTelefonoEmplEdit.Text = reader["StrTelefono"].ToString();
                        txtEmailEmplEdit.Text = reader["StrEmail"].ToString();
                        cboBoxRolEmpEdit.SelectedItem = reader["IdRolEmpleado"];
                        dTimeFechaInicioEdit.Value = Convert.ToDateTime(reader["DtmIngreso"]);
                        dTimeFechaRetiroEdit.Value = Convert.ToDateTime(reader["DtmRetiro"]);
                        richTxtDatosADEdit.Text = reader["strDatosAdicionales"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del empleado: " + ex.Message);
            }
        }


        private void btnSalirEmplEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
                {
                    conexion.Open();
                    string query = "UPDATE TBLMPLEADOS SET StrNombre=@nombre, NumDocumento=@documento, StrDireccion=@direccion, StrTelefono=@telefono, StrEmail=@email, IdRolEmpleado=@rol WHERE IdEmpleado=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Pasar valores de los TextBox a la consulta
                    cmd.Parameters.AddWithValue("@nombre", txtNombreEmplEdit.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDocEmplEdit.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionEmplEdit.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoEmplEdit.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailEmplEdit.Text);
                    cmd.Parameters.AddWithValue("@rol", cboBoxRolEmpEdit.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    cmd.Parameters.AddWithValue("@ingreso", dTimeFechaInicioEdit.Value);
                    cmd.Parameters.AddWithValue("@retiro", dTimeFechaRetiroEdit.Value);
                    cmd.Parameters.AddWithValue("@datos", richTxtDatosADEdit.Text);
                    cmd.Parameters.AddWithValue("@id", idEmpleado);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }
        }

        private void frmEditarEmpleados_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario abierto correctamente.");
        }


    }
}
