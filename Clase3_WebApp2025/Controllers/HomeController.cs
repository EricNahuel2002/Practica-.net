using System.Diagnostics;
using Clase3_WebApp2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase3_WebApp2025.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Response.Cookies.Append("last-login", fecha);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
