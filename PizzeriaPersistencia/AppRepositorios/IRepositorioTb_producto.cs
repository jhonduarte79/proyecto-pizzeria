using PizzeriaDominio;
using System.Collections.Generic;

namespace PizzeriaPersistencia
{
    public interface IRepositorioTb_producto
    {
        Producto CrearProducto(Producto producto);
        Producto ConsultarProducto(int Id);
        IEnumerable<Producto> ConsultarProductos();
        Producto ActualizarProducto(Producto producto);
        void EliminarProducto(int Id);  
    }
}