using Alquiler_Eventos.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alquiler_Eventos.Pages.PageCliente
{
    public class ListarModel : PageModel
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Clientes = unaControladora.ListarClientes();
        }
    }
}
