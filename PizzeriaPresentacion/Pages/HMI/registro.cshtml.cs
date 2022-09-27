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
    public class registroModel : PageModel
    {
        
        private readonly IRepositorioTb_cliente _repoCliente;
        public IEnumerable<Cliente> listaCliente{get; set;}
        [BindProperty]
        public Cliente cliente{get; set;}

        public registroModel(IRepositorioTb_cliente repoCliente)
        {
            _repoCliente = repoCliente;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _repoCliente.CrearCliente(cliente);
            return RedirectToPage("/HMI/login");
        }
    }
}
