using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;
using Capa_Entidades;
using System.Data.SqlClient;



namespace Capa_Presentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        ProductoNegocio negocio = new ProductoNegocio();
        E_Productos entidad = new E_Productos();
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        } 
        
        private void txtIdProducto_Enter(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "ID")
            {
                txtIdProducto.Text = "";
                txtIdProducto.ForeColor = Color.DimGray;
            }
        }

        private void txtIdProducto_Leave(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "")
            {
                txtIdProducto.Text = "ID";
                txtIdProducto.ForeColor = Color.DimGray;
            }
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "Nombre Producto")
            {
                txtNombreProducto.Text = "";
                txtNombreProducto.ForeColor = Color.DimGray;
            }
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                txtNombreProducto.Text = "Nombre Producto";
                txtNombreProducto.ForeColor = Color.DimGray;
            }
        }

        private void txtCodigoRef_Enter(object sender, EventArgs e)
        {
            if (txtCodigoRef.Text == "Codigo Referencia")
            {
                txtCodigoRef.Text = "";
                txtCodigoRef.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtCodigoRef_Leave(object sender, EventArgs e)
        {
            if (txtCodigoRef.Text == "")
            {
                txtCodigoRef.Text = "Codigo Referencia";
                txtCodigoRef.ForeColor = Color.DimGray;
            }
        }

        private void txtPrecioCompra_Enter(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "Precio Compra")
            {
                txtPrecioCompra.Text = "";
                txtPrecioCompra.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "")
            {
                txtPrecioCompra.Text = "Precio Compra";
                txtPrecioCompra.ForeColor = Color.DimGray;
            }
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "Precio Venta")
            {
                txtPrecioVenta.Text = "";
                txtPrecioVenta.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "")
            {
                txtPrecioVenta.Text = "Precio Venta";
                txtPrecioVenta.ForeColor = Color.DimGray;
            }
        }

        private void txtCantidadStock_Enter(object sender, EventArgs e)
        {
            if (txtCantidadStock.Text == "Cantidad Stock")
            {
                txtCantidadStock.Text = "";
                txtCantidadStock.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtCantidadStock_Leave(object sender, EventArgs e)
        {
            if (txtCantidadStock.Text == "")
            {
                txtCantidadStock.Text = "Cantidad Stock";
                txtCantidadStock.ForeColor = Color.DimGray;
            }
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarProductosGrid();
            CargarCategorias();
            LlenarComboBoxCategorias();
            CargarProductos();
        }


        void LlenarComboBoxCategorias()
        {
            AccesoDatos datos = new AccesoDatos();
            DataTable dt = datos.Listar("SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD");

            cboCategoriaProd.DataSource = dt;
            cboCategoriaProd.DisplayMember = "StrDescripcion";
            cboCategoriaProd.ValueMember = "IdCategoria";
            cboCategoriaProd.SelectedIndex = -1;
        }



        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCodigoRef.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCantidadStock.Clear();
            cboCategoriaProd.SelectedIndex = -1;
            richTxtRutaImagen.Clear();
            richTxtDetallesProd.Clear();
        }


        private void CargarCategorias()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            DataTable dt = negocio.ListarCategorias();

            cboCategoriaProd.DataSource = dt;
            cboCategoriaProd.DisplayMember = "StrDescripcion";
            cboCategoriaProd.ValueMember = "IdCategoria";
        }
        private void CargarProductosGrid()
        {
            try
            {
                DataTable dt = negocio.ListarProductos();
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgProductos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }



        private void bntAñadirCliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarProductos()
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            DataTable productos = productoNegocio.ListarProductos();
            dgProductos.DataSource = productos;
        }

        private void btnGuardarProd_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Validar categoría
                if (cboCategoriaProd.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una categoría válida para el producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de los valores numéricos (precio y stock)
                decimal precioCompra, precioVenta;
                int cantidadStock;
                if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra) || !decimal.TryParse(txtPrecioVenta.Text, out precioVenta) ||
                    !int.TryParse(txtCantidadStock.Text, out cantidadStock))
                {
                    MessageBox.Show("Por favor, ingrese valores válidos para los precios y el stock.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCategoria = Convert.ToInt32(cboCategoriaProd.SelectedValue);

                string rutaImagen = string.Empty;
                if (!string.IsNullOrEmpty(richTxtRutaImagen.Text))
                {
                    rutaImagen = richTxtRutaImagen.Text;
                }

                using (SqlConnection conexion = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
                {
                    conexion.Open();

                    string query = "INSERT INTO TBLPRODUCTO (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, IdCategoria, StrDetalle, strFoto, NumStock, DtmFechaModifica, StrUsuarioModifica) " +
                                   "VALUES (@StrNombre, @StrCodigo, @NumPrecioCompra, @NumPrecioVenta, @IdCategoria, @StrDetalle, @strFoto, @NumStock, @DtmFechaModifica, @StrUsuarioModifica)";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Agregar los parámetros y asignarles los valores de los campos
                    cmd.Parameters.AddWithValue("@StrNombre", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@StrCodigo", txtCodigoRef.Text);
                    cmd.Parameters.AddWithValue("@NumPrecioCompra", precioCompra);
                    cmd.Parameters.AddWithValue("@NumPrecioVenta", precioVenta);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("@StrDetalle", richTxtDetallesProd.Text);
                    cmd.Parameters.AddWithValue("@strFoto", rutaImagen);
                    cmd.Parameters.AddWithValue("@NumStock", cantidadStock);
                    cmd.Parameters.AddWithValue("@DtmFechaModifica", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@StrUsuarioModifica", "Admin"); // Usuario por defecto

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto Guardado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductosGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnProdEditar_Click_1(object sender, EventArgs e)
        {
            if (txtIdProducto.Text != "" && int.TryParse(txtIdProducto.Text, out int idProducto))
            {
                entidad.IdProducto = idProducto;
                entidad.StrNombre = txtNombreProducto.Text;
                entidad.StrCodigo = txtCodigoRef.Text;

                if (decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra))
                {
                    entidad.NumPrecioCompra = precioCompra;
                }
                else
                {
                    MessageBox.Show("El precio de compra no es válido.");
                    return;
                }

                if (decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
                {
                    entidad.NumPrecioVenta = precioVenta;
                }
                else
                {
                    MessageBox.Show("El precio de venta no es válido.");
                    return;
                }

                if (int.TryParse(txtCantidadStock.Text, out int cantidadStock))
                {
                    entidad.NumStock = cantidadStock;
                }
                else
                {
                    MessageBox.Show("La cantidad de stock no es válida.");
                    return;
                }

                entidad.IdCategoria = Convert.ToInt32(cboCategoriaProd.SelectedValue);
                entidad.StrDetalle = richTxtDetallesProd.Text;
                entidad.DtmFechaModifica = DateTime.Now;
                entidad.StrUsuarioModifica = "Admin";

                negocio.EditarProducto(entidad);
                MessageBox.Show("Producto Editado Correctamente");
                ListarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto para editar");
            }
        }

        private void ListarProductos()
        {
            DataTable productos = negocio.ListarProductos();
            dgProductos.DataSource = productos;
        }

        private void btnBorrarProd_Click_1(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int idProducto = Convert.ToInt32(dgProductos.CurrentRow.Cells["IdProducto"].Value);
                    negocio.EliminarProducto(idProducto); // Llamar a la capa de negocio para eliminar el producto

                    MessageBox.Show("Producto eliminado correctamente.");

                    CargarProductosGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrarProd")
            {
                int posActual = dgProductos.CurrentRow.Index;

                if (MessageBox.Show($"¿Seguro de borrar el producto {dgProductos["StrNombre", posActual].Value.ToString()}?", "CONFIRME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdProducto = Convert.ToInt32(dgProductos["IdProducto", posActual].Value);
                    negocio.EliminarProducto(IdProducto);

                    MessageBox.Show("Producto eliminado correctamente.");

                    CargarProductosGrid();
                }
            }


            if (dgProductos.Columns[e.ColumnIndex].Name == "btnProdEditar")
            {
                int posActual = dgProductos.CurrentRow.Index;

                // Cargar los valores del producto en los campos de texto
                txtIdProducto.Text = dgProductos["IdProducto", posActual].Value.ToString();
                txtNombreProducto.Text = dgProductos["StrNombre", posActual].Value.ToString();
                txtCodigoRef.Text = dgProductos["StrCodigo", posActual].Value.ToString();
                txtPrecioCompra.Text = dgProductos["NumPrecioCompra", posActual].Value.ToString();
                txtPrecioVenta.Text = dgProductos["NumPrecioVenta", posActual].Value.ToString();
                txtCantidadStock.Text = dgProductos["NumStock", posActual].Value.ToString();
                cboCategoriaProd.SelectedValue = dgProductos["IdCategoria", posActual].Value;
                richTxtDetallesProd.Text = dgProductos["StrDetalle", posActual].Value.ToString();
                richTxtRutaImagen.Text = dgProductos["strFoto", posActual].Value.ToString();
            }

            CargarProductosGrid();
        }

        private void dgProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Cargar los valores del producto en los campos de texto
                txtIdProducto.Text = dgProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                txtNombreProducto.Text = dgProductos.CurrentRow.Cells["StrNombre"].Value.ToString();
                txtCodigoRef.Text = dgProductos.CurrentRow.Cells["StrCodigo"].Value.ToString();
                txtPrecioCompra.Text = dgProductos.CurrentRow.Cells["NumPrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = dgProductos.CurrentRow.Cells["NumPrecioVenta"].Value.ToString();
                txtCantidadStock.Text = dgProductos.CurrentRow.Cells["NumStock"].Value.ToString();
                cboCategoriaProd.SelectedValue = dgProductos.CurrentRow.Cells["IdCategoria"].Value;
                richTxtDetallesProd.Text = dgProductos.CurrentRow.Cells["StrDetalle"].Value.ToString();
                richTxtRutaImagen.Text = dgProductos.CurrentRow.Cells["strFoto"].Value.ToString();
            }
        }
    }
}

