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
    public class productoModel : PageModel
    {
        private readonly IRepositorioTb_producto _repoProducto;
        [BindProperty]
        public Producto producto{get; set;}
        public productoModel(IRepositorioTb_producto repositorioTb_Producto)
        {
            _repoProducto = repositorioTb_Producto;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            producto = _repoProducto.CrearProducto(producto);
            if(producto != null)
            {
                return Page();
            }
            return RedirectToPage("/Error");
        }
    }
}
