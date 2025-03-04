using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Productos
    {
        public int IdProducto { get; set; }
        public string StrNombre { get; set; }
        public string StrCodigo { get; set; }
        public decimal NumPrecioCompra { get; set; }
        public decimal NumPrecioVenta { get; set; }
        public int IdCategoria { get; set; }
        public string StrDetalle { get; set; }
        public string StrFoto { get; set; }
        public int NumStock { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }
    }
}
