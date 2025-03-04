using System.Data;
using Capa_Entidades;

namespace Capa_LogicaDeNegocios
{


   public class ClienteNegocio
   {
       AccesoDatos Acceso = new AccesoDatos();

      public DataTable ListarClientes()
      {
        string query = "SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM dbo.TBLCLIENTES";
        return Acceso.EjecutarConsulta(query);
      }

        public string BorrarCliente(int idCliente)
        {
            string query = $"DELETE FROM dbo.TBLCLIENTES WHERE IdCliente = {idCliente}";
            return Acceso.EjecutarComando(query);
        }

        public DataTable BuscarClientes(string filtro)
        {
            string query = $"SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail FROM dbo.TBLCLIENTES WHERE StrNombre LIKE '%{filtro}%'";
            return Acceso.EjecutarConsulta(query);
        }

        public DataTable ListarClientesCombo()
        {
            string query = "SELECT IdCliente, StrNombre FROM dbo.TBLCLIENTES";
            return Acceso.EjecutarConsulta(query);
        }


    }

}