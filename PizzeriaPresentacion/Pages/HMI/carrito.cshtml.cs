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
        [BindProperty]
        public Producto producto{get; set;}
        [BindProperty]
        public Cliente cliente{get; set;}
        public carritoModel(IRepositorioTb_producto repoProducto, IRepositorioTb_cliente repoCliente)
        {
            _repoProducto= repoProducto;
            _repoCliente = repoCliente;
        }
        public void OnGet()
        {
            producto = new Producto();
            listaProductos = new List<Producto>();
            listaProductos = _repoProducto.ConsultarProductos();
            if(producto == null)
            {
                 RedirectToPage("/Error");
            } 
            else{
                 Page();
            }        
        }
      /* public async Task<IActionResult> OnPost()
        {
            listaProductos = new List<Producto>();
            listaProductos = _repoProducto.ConsultarProductos();
            if(producto == null)
            {
                return RedirectToPage("/Error");
            } 
            else{
                return Page();
            }        
        }*/
    }
}
