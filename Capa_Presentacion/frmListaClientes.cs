using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        AccesoDatos Acceso = new AccesoDatos();
        ClienteNegocio logicaClientes = new ClienteNegocio();



        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            CargarClientesGrid();
            CargarClientesComboBox();
        }

        private void CargarClientesGrid()
        {
            try
            {
                DataTable dt = logicaClientes.ListarClientes();
                dgClientes.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void CargarClientesComboBox()
        {
            try
            {
                DataTable dt = logicaClientes.ListarClientesCombo();
                cboClientes.DataSource = dt;
                cboClientes.DisplayMember = "StrNombre";
                cboClientes.ValueMember = "IdCliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes en ComboBox: " + ex.Message);
            }
        }


        private void bntAñadirCliente_Click(object sender, EventArgs e)
        {
            frmClientes Cliente = new frmClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            CargarClientesGrid();
            CargarClientesComboBox();
        }

        private void btnClienteEditar_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedValue != null)
            {
                int idCliente = Convert.ToInt32(cboClientes.SelectedValue);
                frmEditarCliente editarCliente = new frmEditarCliente(idCliente);
                editarCliente.ShowDialog();
                CargarClientesGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarCliente.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                try
                {
                    DataTable dt = logicaClientes.BuscarClientes(filtro);
                    dgClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar clientes: " + ex.Message);
                }
                txtBuscarCliente.Text = "";
            }
            else
            {
                CargarClientesGrid();
            }
        }


        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrarCliente")
            {
                int posActual = dgClientes.CurrentRow.Index;

                if (MessageBox.Show($"¿Seguro de borrar al cliente {dgClientes[1, posActual].Value.ToString()}?", "CONFIRME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                    string Mensaje = logicaClientes.BorrarCliente(IdCliente);

                    MessageBox.Show(Mensaje);

                    CargarClientesGrid();
                }
            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnClienteEditar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmClientes Cliente = new frmClientes();

                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }

            CargarClientesGrid();
        }


        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string idCliente = dgClientes.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();
                string nombreCliente = dgClientes.Rows[e.RowIndex].Cells["StrNombre"].Value.ToString();


                cboClientes.SelectedValue = idCliente;
                cboClientes.Text = nombreCliente;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedValue != null)
            {
                string infocombo = $"Valor en el combo:\nID: [ {cboClientes.SelectedValue} ] Nombre: [ {cboClientes.Text} ]";
                MessageBox.Show(infocombo);
            }
            else
            {
                MessageBox.Show("No hay cliente seleccionado en el ComboBox.");
            }
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedValue != null)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(cboClientes.SelectedValue);
                    string mensaje = logicaClientes.BorrarCliente(idCliente);
                    MessageBox.Show(mensaje);
                    CargarClientesGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

    }
}
