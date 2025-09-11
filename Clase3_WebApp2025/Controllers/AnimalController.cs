using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace Clase3_WebApp2025.Controllers;

public class AnimalController : Controller
{
    private IAnimalServicio _AnimalServicio;

    public AnimalController(IAnimalServicio animalServicio) 
    {
        this._AnimalServicio = animalServicio;
    }
    public IActionResult Index()
    {
        return View(this._AnimalServicio.ListarAnimales());
    }


}
