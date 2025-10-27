using Entidad.Models;
using Microsoft.AspNetCore.Mvc;
using prueba_EF.Models;
using Servicio;

namespace prueba_EF.Controllers;

public class BibliotecaGestorController : Controller
{



    public BibliotecaGestorController()
    {
    }

    public IActionResult Index()
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


    
}
