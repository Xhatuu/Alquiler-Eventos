using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquiler_Eventos.Dominio;

namespace Alquiler_Eventos.Pages.PageCliente
{
    public class EliminarModel : PageModel
    {
        public Cliente cliente { get; set; } = new Cliente();
        public string Mensaje { get; set; } = "";

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
            if (cliente == null)
            {
                Mensaje = "El Cliente no existe";
            }
        }
        public IActionResult OnPostEliminar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID del Cliente");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID del Cliente debe ser un numero");
                }
                int Id = int.Parse(Request.Form["id"]);
                if (Id <= 0)
                {
                    throw new Exception("El ID del Cliente debe ser mayor que cero");
                }
                Controladora unaControladora = new Controladora();
                if (!unaControladora.BajaCliente(Id))
                {
                    throw new Exception("El Cliente no existe");
                }
                return Redirect("/PageCliente/Listar");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                return Page();
            }
        }
    }
}
