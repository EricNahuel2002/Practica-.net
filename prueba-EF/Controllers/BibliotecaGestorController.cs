using Entidad.Models;
using Microsoft.AspNetCore.Mvc;
using prueba_EF.Models;
using Servicio;

namespace prueba_EF.Controllers;

public class BibliotecaGestorController : Controller
{

    private IGestionBibliotecaServicio _bibliotecaServicio;

    public BibliotecaGestorController(IGestionBibliotecaServicio bibliotecaServicio)
    {
        _bibliotecaServicio = bibliotecaServicio;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RegistrarAutoresView()
    {
        return View();
    }
    public IActionResult RegistrarLibrosView()
    {
        return View();
    }
    public IActionResult RegistrarCursosView()
    {
        return View();
    }
    public IActionResult RegistrarMatriculasView()
    {
        return View();
    }

    public IActionResult RegistrarEstudiantesView()
    {

        return View();
    }




    [HttpPost]
    public IActionResult RegistrarAutor(Autor autor)
    {
        if (!ModelState.IsValid)
        {
            return View("RegistrarAutoresView", autor);
        }

        this._bibliotecaServicio.agregarAutor(autor);

        return View("RegistrarAutoresView");
    }
}
