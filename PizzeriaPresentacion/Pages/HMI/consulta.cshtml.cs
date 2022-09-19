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
    public class consultaModel : PageModel
    {
        private readonly IRepositorioTb_cliente _repoCliente;
        [BindProperty]
        public IEnumerable<Cliente> listaCliente{get; set;}


        public consultaModel(IRepositorioTb_cliente repoCliente)
        {
            _repoCliente = repoCliente;
        }
        public void OnGet()
        {
            listaCliente = _repoCliente.ConsultarClientes();
        }
    }
}
