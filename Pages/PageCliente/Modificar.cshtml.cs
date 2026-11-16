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
        [BindProperty] public string apellido { get; set; } = "";
        [BindProperty] public string direccion { get; set; } = "";
        [BindProperty] public string telefono { get; set; } = "";
        public string Mensaje { get; set; } = "";
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
            if (cliente != null)
            {
                this.id = cliente.Id;
                nombre = cliente.Nombre;
                apellido = cliente.Apellido;
                direccion = cliente.Direccion;
                telefono = cliente.Telefono;
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
                if (Request.Form["apellido"] == "")
                {
                    throw new Exception("Debe ingresar el Apellido del Cliente");
                }
                if (Request.Form["direccion"] == "")
                {
                    throw new Exception("Debe ingresar Dirección del Cliente");
                }
                if (Request.Form["telefono"] == "")
                {
                    throw new Exception("Debe ingresar el Teléfono del Cliente");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Apellido = Request.Form["apellido"];
                string Direccion = Request.Form["direccion"];
                string Telefono = Request.Form["telefono"];

                Controladora unaControladora = new Controladora();

                if (!unaControladora.ModificarCliente(Id, Nombre, Apellido, Direccion, Telefono))
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
