using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using Capa_Entidades;




public class AccesoDatos
{
    SqlConnection conexion;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt;
    DataSet ds;

    public AccesoDatos()
    {
        conexion = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;");
    }

    public void AbrirBd()
    {
        try
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Falló conexión: " + ex.Message);
        }
    }

    public void CerrarBd()
    {
        try
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Falló cerrar conexión: " + ex.Message);
        }
    }


    public string ValidarUsuario(string StrUsuario, string StrClave)
    {
        try
        {
            string strEmpleado = "";
            string sentencia = "SELECT e.strNombre, e.IdRolEmpleado FROM TBLSEGURIDAD s " +
                               "JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado " +
                               "WHERE s.StrUsuario = @usuario AND s.StrClave = @clave";

            AbrirBd();

            using (SqlCommand cmd = new SqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@usuario", StrUsuario);
                cmd.Parameters.AddWithValue("@clave", StrClave);

                using (SqlDataReader LectorDatos = cmd.ExecuteReader())
                {
                    if (LectorDatos.Read())
                    {
                        strEmpleado = Convert.ToString(LectorDatos["strNombre"]);
                    }
                }
            }

            CerrarBd();

            return strEmpleado;
        }
        catch (Exception ex)
        {
            MessageBox.Show("FALLA LECTURA: " + ex.Message);
            return "";
        }
    }



    public SqlConnection ObtenerConexion()
    {
        return conexion;
    }

    public string EjecutarComando(string query)
    {
        try
        {
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                AbrirBd();
                comando.ExecuteNonQuery();
                CerrarBd();
                return "Comando ejecutado correctamente";
            }
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }


    public DataTable cargartabla(string tabla, string strCondicion)
    {
        try
        {
            AbrirBd();
            string Sql = "Select * from " + tabla + " " + strCondicion;
            da = new SqlDataAdapter(Sql, conexion);
            ds = new DataSet();
            da.Fill(ds, tabla);
            DataTable dt = new DataTable();
            dt = ds.Tables[tabla];
            CerrarBd();
            return dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
            return null;
        }
    }
    public DataTable EjecutarComandoDatos(string cmd)
    {
        try
        {
            AbrirBd();
            da = new SqlDataAdapter(cmd, conexion);
            dt = new DataTable();
            da.Fill(dt);
            CerrarBd();
            return dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
            return null;
        }
    }

    public bool ActualizarUsuario(int idEmpleado, string usuario, string clave)
    {
        try
        {
            string query = "UPDATE TBLSEGURIDAD SET StrUsuario = @usuario, StrClave = @clave WHERE IdEmpleado = @idEmpleado";
            AbrirBd();

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
            return false;
        }
        finally
        {
            CerrarBd();
        }


    }


    public string BorrarCliente(int IdCliente)
    {
        try
        {
            using (SqlConnection conn = ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_BorrarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
                cmd.ExecuteNonQuery();
                return "Cliente eliminado correctamente.";
            }

        }
        catch (Exception ex)
        {
            return "Error al borrar cliente: " + ex.Message;
        }
    }

    public DataTable ListarClientes()
    {
        DataTable dt = new DataTable();
        try
        {
            using (SqlConnection conn = new SqlConnection("Server = VANESSA; Database = DBFACTURAS; Trusted_Connection = True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ListarClientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al listar clientes: " + ex.Message);
        }
        return dt;
    }

    public DataTable EjecutarConsulta(string query)
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
        }
        return dt;
    }

    public DataTable ListarEmpleados()
    {
        using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarEmpleados", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }


    public string InsertarEmpleado(string nombre, string documento, string direccion, string telefono, string email, int idRol, DateTime fechaInicio, DateTime fechaRetiro, string datosAdicionales)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertarEmpleado", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StrNombre", nombre);
                cmd.Parameters.AddWithValue("@NumDocumento", documento);
                cmd.Parameters.AddWithValue("@StrDireccion", direccion);
                cmd.Parameters.AddWithValue("@StrTelefono", telefono);
                cmd.Parameters.AddWithValue("@StrEmail", email);
                cmd.Parameters.AddWithValue("@IdRolEmpleado", idRol);
                cmd.Parameters.AddWithValue("@DtmIngreso", fechaInicio);
                cmd.Parameters.AddWithValue("@DtmRetiro", fechaRetiro);
                cmd.Parameters.AddWithValue("@StrDatosAdicionales", datosAdicionales);
                cmd.ExecuteNonQuery();
                return "Empleado insertado correctamente";
            }
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }

    public string BorrarEmpleado(int idEmpleado)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_BorrarEmpleado", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.ExecuteNonQuery();
                return "Empleado eliminado correctamente";
            }
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }

    public List<Rol> ObtenerRoles()
    {
        List<Rol> roles = new List<Rol>();
        string consulta = "SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES";
        SqlCommand command = new SqlCommand(consulta, conexion);

        try
        {
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Rol rol = new Rol
                {
                    IdRolEmpleado = reader.GetInt32(0),
                    StrDescripcion = reader.GetString(1)
                };
                roles.Add(rol);
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al obtener roles: " + ex.Message);
        }
        finally
        {
            conexion.Close();
        }

        return roles;
    }

    public void Ejecutar(string consulta)
    {
        using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
        {
            SqlCommand cmd = new SqlCommand(consulta, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable Listar(string consulta)
    {
        using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    public DataTable ObtenerDatos(string query, SqlParameter[] parametros)
    {
        DataTable dt = new DataTable();
        using (SqlConnection conexion = ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddRange(parametros);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }

    public DataTable BuscarEmpleado(string criterio)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_BuscarEmpleado", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Criterio", criterio);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al buscar empleado: " + ex.Message);
            return null;
        }
    }


    public DataTable ObtenerDatosSeguridad(int idEmpleado)
    {
        DataTable dt = new DataTable();
        string query = "SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = @IdEmpleado";
        using (SqlConnection con = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
        }
        return dt;
    }

    public DataTable ObtenerProductos()
    {
        string query = "SELECT IdProducto, StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, IdCategoria, StrDetalle, strFoto, NumStock, DtmFechaModifica, StrUsuarioModifica FROM TBLPRODUCTO";
        return EjecutarConsulta(query);
    }



    public DataTable ListarProductos()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection("Server=VANESSA;Database=DBFACTURAS;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("SP_ListarProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al listar productos: " + ex.Message);
            return null;
        }
    }

    public string InsertarProducto(E_Productos producto)
    {
        try
        {
            using (SqlConnection conn = ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_PRODUCTO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StrNombre", producto.StrNombre);
                cmd.Parameters.AddWithValue("@StrCodigo", producto.StrCodigo);
                cmd.Parameters.AddWithValue("@NumPrecioCompra", producto.NumPrecioCompra);
                cmd.Parameters.AddWithValue("@NumPrecioVenta", producto.NumPrecioVenta);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                cmd.Parameters.AddWithValue("@StrDetalle", producto.StrDetalle);
                cmd.Parameters.AddWithValue("@StrFoto", producto.StrFoto);
                cmd.Parameters.AddWithValue("@NumStock", producto.NumStock);
                cmd.Parameters.AddWithValue("@StrUsuarioModifica", producto.StrUsuarioModifica);
                cmd.ExecuteNonQuery();
                return "Producto insertado correctamente.";
            }
        }
        catch (Exception ex)
        {
            return "Error al insertar el producto: " + ex.Message;
        }
    }


    public void EditarProducto(E_Productos producto)
    {
        using (SqlCommand cmd = new SqlCommand("SP_EDITAR_PRODUCTO", ObtenerConexion()))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            cmd.Parameters.AddWithValue("@StrNombre", producto.StrNombre);
            cmd.Parameters.AddWithValue("@StrCodigo", producto.StrCodigo);
            cmd.Parameters.AddWithValue("@NumPrecioCompra", producto.NumPrecioCompra);
            cmd.Parameters.AddWithValue("@NumPrecioVenta", producto.NumPrecioVenta);
            cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
            cmd.Parameters.AddWithValue("@StrDetalle", producto.StrDetalle);
            cmd.Parameters.AddWithValue("@StrFoto", producto.StrFoto);
            cmd.Parameters.AddWithValue("@NumStock", producto.NumStock);
            cmd.Parameters.AddWithValue("@StrUsuarioModifica", producto.StrUsuarioModifica);
            cmd.ExecuteNonQuery();
        }
    }

    public void EliminarProducto(int IdProducto)
    {
        using (SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PRODUCTO", ObtenerConexion()))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable ObtenerDatos(string consulta)
    {
       DataTable dt = new DataTable();
       using (SqlConnection con = new SqlConnection("Server = VANESSA; Database = DBFACTURAS; Trusted_Connection = True;"))
       {
                SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                da.Fill(dt);
       }
       return dt;
    }

   














}