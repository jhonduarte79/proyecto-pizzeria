using PizzeriaDominio;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaPersistencia
{
    public class RepositorioTb_producto : IRepositorioTb_producto
    {
        private readonly AppContext _appContext = new AppContext();
        public Producto CrearProducto(Producto producto)
        {
            var productoAdicionado = _appContext.Tb_producto.Add(producto);
            _appContext.SaveChanges();
            return productoAdicionado.Entity;
        }
        public Producto ConsultarProducto(int Id)
        {
            return _appContext.Tb_producto.FirstOrDefault(p => p.Id==Id);
        }
        public  IEnumerable<Producto> ConsultarProductos()
        {
            return _appContext.Tb_producto;
        }
        public  Producto ActualizarProducto(Producto producto)
        {
            var productoEncontrado = _appContext.Tb_producto.FirstOrDefault(p => p.Id==producto.Id);
            if(productoEncontrado != null){
                productoEncontrado.Nombre = producto.Nombre;
                productoEncontrado.Cantidad = producto.Cantidad;
                productoEncontrado.Precio = producto.Precio;
                productoEncontrado.Url = producto.Url;

                _appContext.SaveChanges();
            }
            return productoEncontrado;
        }
        public void EliminarProducto(int Id)
        {
            var productoEncontrado = _appContext.Tb_producto.FirstOrDefault(p => p.Id==Id);
            {
                _appContext.Tb_producto.Remove(productoEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}