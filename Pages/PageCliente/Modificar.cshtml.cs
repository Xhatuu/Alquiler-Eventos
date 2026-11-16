using Alquiler_Eventos.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alquiler_Eventos.Pages.PageCliente
{
    public class ModificarModel : PageModel
    {
        public Cliente cliente { get; set; } = new Cliente();
        [BindProperty] public int id { get; set; }
        [BindProperty] public string nombre { get; set; } = "";
        [BindProperty] public string tipo { get; set; } = "";
        [BindProperty] public string documento { get; set; } = "";
        [BindProperty] public string direccion { get; set; } = "";
        [BindProperty] public string telefono { get; set; } = "";
        [BindProperty] public string email { get; set; } = "";
        [BindProperty] public bool activo { get; set; }
        public string Mensaje { get; set; } = "";
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
            if (cliente != null)
            {
                this.id = cliente.Id;
                nombre = cliente.Nombre;
                tipo = cliente.Tipo;
                documento = cliente.Documento;
                direccion = cliente.Direccion;
                telefono = cliente.Telefono;
                email = cliente.Email;
                activo = cliente.Activo;
            }
            else
            {
                Mensaje = "El Cliente no existe";
            }
        }
        public IActionResult OnPostModificar()
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
                if (int.Parse(Request.Form["id"]) <= 0)
                {
                    throw new Exception("El ID del Cliente debe ser mayor que cero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Cliente");
                }
                if (Request.Form["tipo"] == "")
                {
                    throw new Exception("Debe ingresar el tipo del Cliente");
                }
                if (Request.Form["documento"] == "")
                {
                    throw new Exception("Debe ingresar el documento del Cliente");
                }
                if (Request.Form["direccion"] == "")
                {
                    throw new Exception("Debe ingresar Dirección del Cliente");
                }
                if (Request.Form["telefono"] == "")
                {
                    throw new Exception("Debe ingresar el Teléfono del Cliente");
                }
                if (Request.Form["email"] == "")
                {
                    throw new Exception("Debe ingresar el Email del Cliente");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Tipo = Request.Form["tipo"];
                string Documento = Request.Form["documento"];
                string Direccion = Request.Form["direccion"];
                string Telefono = Request.Form["telefono"];
                string Email = Request.Form["email"];
                bool Activo = Request.Form["activo"] == "on";

                Controladora unaControladora = new Controladora();

                if (!unaControladora.ModificarCliente(Id, Nombre, Tipo, Documento, Direccion, Telefono, Email, Activo))
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
