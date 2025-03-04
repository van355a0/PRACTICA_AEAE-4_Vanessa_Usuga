using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class UsuarioNegocio
    {
        AccesoDatos acceso = new AccesoDatos();

        public string Login(string usuario, string password)
        {
            return acceso.ValidarUsuario(usuario, password);
        }

        public bool ActualizarUsuario(int idEmpleado, string usuario, string clave)
        {
            AccesoDatos datos = new AccesoDatos();
            return datos.ActualizarUsuario(idEmpleado, usuario, clave);
        }

        public DataTable ObtenerEmpleados()
        {
            AccesoDatos datos = new AccesoDatos();
            return datos.ListarEmpleados();
        }


        public DataTable ObtenerUsuarioPorEmpleado(int idEmpleado)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = "SELECT usuario AS Usuario, password AS Clave FROM TBLSEGURIDAD WHERE IdEmpleado = @IdEmpleado";
            SqlParameter[] parametros = {
        new SqlParameter("@IdEmpleado", idEmpleado)
    };

            return acceso.ObtenerDatos(query, parametros);
        }

        public DataTable ObtenerDatosSeguridad(int idEmpleado)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            return accesoDatos.ObtenerDatosSeguridad(idEmpleado);
        }


    }



}
