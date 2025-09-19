using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Clase3_WebApp2025.Controllers;

public class SesionController : Controller
{
    public IActionResult Index()
    {
        //CON VIEWDATA

        this.ObtenerHerramientasViewData();
        this.ObtenerHerramientasViewBag();
        HerramientaView herramienta = new HerramientaView("Pala");
        return View(herramienta);
    }

    public void ObtenerHerramientasViewData()
    {
        List<Herramienta> list = new List<Herramienta>();
        list.Add(new Herramienta(1, "martillo"));
        list.Add(new Herramienta(2, "Destornillador"));
        ViewData["herramientasVD"] = list;
    }


    public void ObtenerHerramientasViewBag()
    {
        List<Herramienta> list = new List<Herramienta>();
        list.Add(new Herramienta(3, "Pico"));
        list.Add(new Herramienta(4, "Hacha"));
        ViewBag.HerramientasVB = list;
    }

    [HttpPost]
    public IActionResult Mensaje()
    {
        TempData["Mensaje"] = "Soy el TempData";
        return RedirectToAction("Index");
    }


    public IActionResult PasajeDeDatosView()
    {
            return View();
    }


    public IActionResult MensajeDeSesionView(string usuario)
    {
        string usuarioPorSession = HttpContext.Session.GetString("usuario");
        string mensajeError = "ERROR";

        if (usuarioPorSession != usuario)
        {
            ViewData["mensaje"] = $"ERROR, desde query string llego: {usuario}                 Y por sesion llego: {usuarioPorSession}";
        }
        else
        {
            ViewData["mensaje"] = $"Hola, {usuarioPorSession}";
        }
        return View();
    }


    [HttpPost]
    public IActionResult metodo(string nombre)
    {
        HttpContext.Session.SetString("usuario", nombre);
        return RedirectToAction("MensajeDeSesionView", new { usuario = nombre });
    }
}
