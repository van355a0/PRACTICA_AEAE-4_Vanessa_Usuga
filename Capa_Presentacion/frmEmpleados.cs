using Capa_Entidades;
using Capa_LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleadosGrid();
            CargarComboBoxRoles();
        }


        EmpleadoNegocio negocio = new EmpleadoNegocio();


        private void CargarEmpleadosGrid()
        {
            try
            {
                dgEmpleados.DataSource = negocio.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            txtNombreEmpleado.Clear();
            txtDocumentoEm.Clear();
            txtDireccionEm.Clear();
            txtTelefonoEm.Clear();
            txtEmailEmp.Clear();
            richTxtDatosAD.Clear();
            comboBoxRolEmp.SelectedIndex = -1;
        }


        private void CargarComboBoxRoles()
        {
            try
            {
                comboBoxRolEmp.DataSource = negocio.ObtenerRoles();
                comboBoxRolEmp.DisplayMember = "StrDescripcion";
                comboBoxRolEmp.ValueMember = "IdRolEmpleado";
                comboBoxRolEmp.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRolEmp.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un rol válido para el empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                EntidadEmpleados empleado = new EntidadEmpleados
                {
                    StrNombre = txtNombreEmpleado.Text,
                    NumDocumento = txtDocumentoEm.Text,
                    StrDireccion = txtDireccionEm.Text,
                    StrTelefono = txtTelefonoEm.Text,
                    StrEmail = txtEmailEmp.Text,
                    IdRolEmpleado = Convert.ToInt32(comboBoxRolEmp.SelectedValue),
                    DtmIngreso = dateTimeFechaInicioE.Value,
                    DtmRetiro = dateTimeFechaRetiroEm.Value,
                    StrDatosAdicionales = richTxtDatosAD.Text
                };


                string mensaje = negocio.InsertarEmpleado(
                    empleado.StrNombre,
                    empleado.NumDocumento,
                    empleado.StrDireccion,
                    empleado.StrTelefono,
                    empleado.StrEmail,
                    empleado.IdRolEmpleado,
                    empleado.DtmIngreso,
                    empleado.DtmRetiro,
                    empleado.StrDatosAdicionales
                );

                MessageBox.Show(mensaje);


                CargarEmpleadosGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
            }
        }


        private void btnBorrarEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgEmpleados.SelectedRows.Count > 0)
                {
                    int idEmpleado = Convert.ToInt32(dgEmpleados.CurrentRow.Cells["IdEmpleado"].Value);
                    string mensaje = negocio.EliminarEmpleado(idEmpleado);
                    MessageBox.Show(mensaje);


                    CargarEmpleadosGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
            }
        }

        private void btnEditarEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdEmpleadoSeleccionado != 0)
                {
                    EntidadEmpleados empleado = new EntidadEmpleados
                    {
                        IdEmpleado = IdEmpleadoSeleccionado,
                        StrNombre = txtNombreEmpleado.Text,
                        NumDocumento = txtDocumentoEm.Text,
                        StrDireccion = txtDireccionEm.Text,
                        StrTelefono = txtTelefonoEm.Text,
                        StrEmail = txtEmailEmp.Text,
                        StrDatosAdicionales = richTxtDatosAD.Text,
                        IdRolEmpleado = Convert.ToInt32(comboBoxRolEmp.SelectedValue),
                        DtmIngreso = dateTimeFechaInicioE.Value,
                        DtmRetiro = dateTimeFechaRetiroEm.Value
                    };


                    negocio.ActualizarEmpleado(empleado);

                    MessageBox.Show("Empleado actualizado con éxito.");

                    CargarEmpleadosGrid();
                    LimpiarCampos();
                    IdEmpleadoSeleccionado = 0;
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el empleado: " + ex.Message);
            }
        }



        int IdEmpleadoSeleccionado = 0;


        private void dgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    IdEmpleadoSeleccionado = Convert.ToInt32(dgEmpleados.CurrentRow.Cells["IdEmpleado"].Value);
                    txtNombreEmpleado.Text = dgEmpleados.CurrentRow.Cells["StrNombre"].Value.ToString();
                    txtDocumentoEm.Text = dgEmpleados.CurrentRow.Cells["NumDocumento"].Value.ToString();
                    txtDireccionEm.Text = dgEmpleados.CurrentRow.Cells["StrDireccion"].Value.ToString();
                    txtTelefonoEm.Text = dgEmpleados.CurrentRow.Cells["StrTelefono"].Value.ToString();
                    txtEmailEmp.Text = dgEmpleados.CurrentRow.Cells["StrEmail"].Value.ToString();
                    richTxtDatosAD.Text = dgEmpleados.CurrentRow.Cells["StrDatosAdicionales"].Value.ToString();
                    comboBoxRolEmp.SelectedValue = dgEmpleados.CurrentRow.Cells["IdRolEmpleado"].Value;
                    dateTimeFechaInicioE.Value = Convert.ToDateTime(dgEmpleados.CurrentRow.Cells["DtmIngreso"].Value);
                    dateTimeFechaRetiroEm.Value = Convert.ToDateTime(dgEmpleados.CurrentRow.Cells["DtmRetiro"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar un empleado: " + ex.Message);
            }
        }

        
    }
}
