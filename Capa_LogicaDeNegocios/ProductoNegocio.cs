using System.Data;
using Capa_Entidades;



namespace Capa_LogicaDeNegocios
{
    public class ProductoNegocio
    {
        AccesoDatos Acceso = new AccesoDatos();

        public DataTable ListarProductos()
        {
            string query = "SELECT IdProducto, StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, NumStock, IdCategoria, StrDetalle, StrFoto, DtmFechaModifica, StrUsuarioModifica FROM TBLPRODUCTOS";
            return Acceso.EjecutarConsulta(query);
        }

        public void InsertarProducto(E_Productos producto)
        {
            string query = $"INSERT INTO TBLPRODUCTOS (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, NumStock, IdCategoria, StrDetalle, StrFoto, DtmFechaModifica, StrUsuarioModifica) " +
                           $"VALUES ('{producto.StrNombre}', '{producto.StrCodigo}', {producto.NumPrecioCompra}, {producto.NumPrecioVenta}, {producto.NumStock}, {producto.IdCategoria}, '{producto.StrDetalle}', '{producto.StrFoto}', '{producto.DtmFechaModifica}', '{producto.StrUsuarioModifica}')";
            Acceso.EjecutarComando(query);
        }

        public void EditarProducto(E_Productos producto)
        {
            string query = $"UPDATE TBLPRODUCTOS SET StrNombre = '{producto.StrNombre}', StrCodigo = '{producto.StrCodigo}', NumPrecioCompra = {producto.NumPrecioCompra}, NumPrecioVenta = {producto.NumPrecioVenta}, NumStock = {producto.NumStock}, IdCategoria = {producto.IdCategoria}, StrDetalle = '{producto.StrDetalle}', StrFoto = '{producto.StrFoto}', DtmFechaModifica = '{producto.DtmFechaModifica}', StrUsuarioModifica = '{producto.StrUsuarioModifica}' WHERE IdProducto = {producto.IdProducto}";
            Acceso.EjecutarComando(query);
        }

        public void EliminarProducto(int IdProducto)
        {
            string query = $"DELETE FROM TBLPRODUCTOS WHERE IdProducto = {IdProducto}";
            Acceso.EjecutarComando(query);
        }


        public DataTable ListarCategorias()
        {
            string query = "SELECT IdCategoria, , DtmFechaModifica, StrUsuarioModifico FROM TBLCATEGORIA_PROD";
            return Acceso.EjecutarConsulta(query);
        }

    }
}