using Alquiler_Eventos.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alquiler_Eventos.Pages.PageCliente
{
    public class AltaModel : PageModel
    {
        [BindProperty] public string id { get; set; } = "";
        [BindProperty] public string nombre { get; set; } = "";
        [BindProperty] public string tipo { get; set; } = "";
        [BindProperty] public string documento { get; set; } = "";
        [BindProperty] public string direccion { get; set; } = "";
        [BindProperty] public string telefono { get; set; } = "";
        [BindProperty] public string email { get; set; } = "";
        [BindProperty] public bool activo { get; set; } 
        public string Mensaje { get; set; } = "";
        public void OnGet()
        {
        }

        public IActionResult OnPostAgregar()
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
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("El ID del Cliente debe ser mayor que cero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Cliente");
                }
                if (Request.Form["tipo"] == "")
                {
                    throw new Exception("Debe ingresar el Tipo del Cliente");
                }
                if (Request.Form["documento"] == "")
                {
                    throw new Exception("Debe ingresar el Documento del Cliente");
                }
                if (Request.Form["direccion"] == "")
                {
                    throw new Exception("Debe ingresar la Dirección del Cliente");
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

                Cliente unCliente = new Cliente(Id, Nombre, Tipo, Documento, Direccion, Telefono, Email, Activo);

                Controladora unaControladora = new Controladora();

                if (!unaControladora.AltaCliente(unCliente))
                {
                    throw new Exception("Ya existe un Cliente con ese ID");
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

