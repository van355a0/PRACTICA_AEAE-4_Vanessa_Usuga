using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class EntidadEmpleados
    {
        public int IdEmpleado { get; set; }
        public string StrNombre { get; set; }
        public string NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string StrEmail { get; set; }
        public int IdRolEmpleado { get; set; }
        public DateTime DtmIngreso { get; set; }
        public DateTime DtmRetiro { get; set; }
        public string StrDatosAdicionales { get; set; }
    }

    public class Rol
    {
        public int IdRolEmpleado { get; set; }
        public string StrDescripcion { get; set; }
    }
}
