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
    public class menuModel : PageModel
    {
        private readonly IRepositorioTb_producto _repoProducto;
        [BindProperty]
        public Producto producto{get; set;}
        [BindProperty]
        public IEnumerable<Producto> listaProductos{get; set;}
        public menuModel(IRepositorioTb_producto repoProducto)
        {
            _repoProducto = repoProducto;
        }
        public void OnGet()
        {
            //listaProductos = new List<Producto>();
            
            this.listaProductos = _repoProducto.ConsultarProductos();
            if(producto == null)
            {
                RedirectToPage("/Error");
            } 
            RedirectToPage("/HMI/carrito");
        }
       
    }
}
