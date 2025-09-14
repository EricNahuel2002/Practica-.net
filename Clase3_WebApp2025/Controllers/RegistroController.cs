using Entidades;
using Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Clase3_WebApp2025.Controllers
{
    public class RegistroController : Controller
    {
        private IRegistroServicio registroService;

        public RegistroController(IRegistroServicio IRegistroService) 
        {
            this.registroService = IRegistroService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario(model.NombreUsuario, model.Email, model.Contraseña);

            this.registroService.RegistrarUsuario(usuario);
            return RedirectToAction("Index");
            }
            return View("Index",model);
        }
    }
}
