using Microsoft.AspNetCore.Mvc;
using Servicios;
using Entidades;
namespace Clase3_WebApp2025.Controllers
{
    public class HerramientaController : Controller
    {
        private IHerramientaServicio herramientaServicio;

        public HerramientaController(IHerramientaServicio herramientaServicio) 
        {
            this.herramientaServicio = herramientaServicio;
        }

        public IActionResult Index()
        {
            return View(herramientaServicio.ObtenerHerramientas());
        }

        [HttpPost]
        public IActionResult Agregar(Herramienta herramienta)
        {
            this.herramientaServicio.AgregarHerramienta(herramienta);
            return View("Index",this.herramientaServicio.ObtenerHerramientas());
        }

        public IActionResult HerramientaForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            this.herramientaServicio.EliminarHerramienta(id);
            return View("Index",this.herramientaServicio.ObtenerHerramientas());
        }

        public IActionResult EditarHerramientaForm(int id)
        {
            Herramienta herramienta = this.herramientaServicio.BuscarHerramienta(id);
            return View("EditarHerramientaForm",herramienta);
        }

        [HttpPost]
        public IActionResult Editar(Herramienta herramienta)
        {
            this.herramientaServicio.EditarHerramienta(herramienta);
            return View("Index",herramientaServicio.ObtenerHerramientas());
        }
    }
}
