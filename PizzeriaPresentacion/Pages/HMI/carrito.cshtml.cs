using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzeriaPersistencia;
using PizzeriaDominio;

namespace PizzeriaPresentacion.Pages
{
    public class carritoModel : PageModel
    {
        private readonly IRepositorioTb_producto _repoProducto;
        private readonly IRepositorioTb_cliente _repoCliente;
        [BindProperty]
        public IEnumerable<Producto> listaProductos{get; set;}
        public List<Producto> listaProducto = new List<Producto>();
        [BindProperty]
        public Producto producto{get; set;}
        [BindProperty]
        public Cliente cliente{get; set;}
        public carritoModel(IRepositorioTb_producto repoProducto, IRepositorioTb_cliente repoCliente)
        {
            _repoProducto = repoProducto;
            _repoCliente = repoCliente;
        }
        public void OnGet(int productoId, int clienteId)
        {
            producto = new Producto();
            cliente = new Cliente();
            cliente = _repoCliente.ConsultarCliente(cliente.Email);
            producto = _repoProducto.ConsultarProducto(productoId);
            if(producto == null)
            {
                 RedirectToPage("/Error");
            } 
            else{
                 Page();
            }        
        }
       public async Task<IActionResult> OnPost(int clienteId, int productoId)
        {
            producto = _repoProducto.ConsultarProducto(productoId);           
            cliente = _repoCliente.ConsultarCliente(cliente.Email);
            if(cliente != null)
            {
                listaProducto.Add(producto);
                cliente.Producto = listaProducto;
                _repoCliente.ActualizarCliente(cliente);
                return RedirectToPage("/HMI/menu");
            } 
            else{
                return RedirectToPage("/Error");
            }        
        }
    }
}
