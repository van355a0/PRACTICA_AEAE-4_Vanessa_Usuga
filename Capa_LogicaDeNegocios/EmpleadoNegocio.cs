using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;


namespace Capa_LogicaDeNegocios

{
    public class EmpleadoNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public DataTable ObtenerEmpleados()
        {
            return datos.ListarEmpleados();
        }

        public string InsertarEmpleado(string nombre, string documento, string direccion, string telefono, string email, int idRol, DateTime fechaInicio, DateTime fechaRetiro, string datosAdicionales)
        {
            return datos.InsertarEmpleado(nombre, documento, direccion, telefono, email, idRol, fechaInicio, fechaRetiro, datosAdicionales);
        }

        public string EliminarEmpleado(int idEmpleado)
        {
            return datos.BorrarEmpleado(idEmpleado);
        }

        public void ActualizarEmpleado(Capa_Entidades.EntidadEmpleados empleado)
        {
            string consulta = $"UPDATE TBLEMPLEADO SET StrNombre='{empleado.StrNombre}', NumDocumento='{empleado.NumDocumento}', StrDireccion='{empleado.StrDireccion}', StrTelefono='{empleado.StrTelefono}', StrEmail='{empleado.StrEmail}', StrDatosAdicionales='{empleado.StrDatosAdicionales}', IdRolEmpleado={empleado.IdRolEmpleado}, DtmIngreso='{empleado.DtmIngreso}', DtmRetiro='{empleado.DtmRetiro}' WHERE IdEmpleado={empleado.IdEmpleado}";
            datos.Ejecutar(consulta);
        }

        public List<Rol> ObtenerRoles()
    {
        return datos.ObtenerRoles();
    }



    }
}
