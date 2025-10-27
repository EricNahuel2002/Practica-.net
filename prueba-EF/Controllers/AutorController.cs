using Entidad.Models;
using Microsoft.AspNetCore.Mvc;
using Servicio;

namespace prueba_EF.Controllers;

public class AutorController : Controller
{

    private IAutorServicio _autorServicio;

    public AutorController(IAutorServicio autorServicio)
    {
        this._autorServicio = autorServicio;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RegistrarAutorView()
    {
        return View();
    }


    [HttpPost]
    public IActionResult RegistrarAutor(Autor autor)
    {
        if (!ModelState.IsValid)
        {
            return View("RegistrarAutorView", autor);
        }

        this._autorServicio.AgregarAutor(autor);

        return RedirectToAction("ListarAutores");
    }

    [HttpGet]
    public IActionResult EditarAutorView(int id)
    {
        var autor = this._autorServicio.ObtenerAutorPorId(id);
        return View(autor);
    }


    [HttpGet]
    public IActionResult Eliminar(int id)
    {
        this._autorServicio.EliminarAutorPorId(id);
        return RedirectToAction("ListarAutores");
    }

    public IActionResult ListarAutores()
    {
        Autor[] autores = this._autorServicio.ObtenerAutores();

        return View(autores);

    }


    [HttpPost]
    public IActionResult Editar(Autor autor)
    {
        if (!ModelState.IsValid)
        {
            return View("EditarAutorView", autor);
        }

        this._autorServicio.EditarAutor(autor);

        return RedirectToAction("ListarAutores");
    }

}
