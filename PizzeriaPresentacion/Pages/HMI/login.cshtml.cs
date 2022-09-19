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
    public class loginModel : PageModel
    {
        private readonly IRepositorioTb_cliente _repoCliente;
        
        [BindProperty]
        public Cliente cliente{get; set;}

        public loginModel(IRepositorioTb_cliente repoCliente)
        {
            _repoCliente = repoCliente;
        }
        public void OnGet()
        {  
            cliente = new Cliente(); 
        }
        public async Task<IActionResult> OnPost()
        {
            cliente = _repoCliente.ConsultarCliente(cliente.Email);
            if(cliente == null)
            {
                return RedirectToPage("/Error"); 
            } 
            else{
                return Page();
            }        
        }
        public async Task<IActionResult> OnPostEditar()
        {
            cliente = _repoCliente.ActualizarCliente(cliente);
            if(cliente != null)
            {
                return RedirectToPage("/HMI/consulta");
            }
            else{
                return RedirectToPage("/Error");
            }
            
        }        
    }

}
