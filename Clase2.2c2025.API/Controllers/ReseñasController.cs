using Clase2._2c2025.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Clase2._2c2025.Entidad;

namespace Clase2._2c2025.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReseñasController : ControllerBase
    {
        IReseñaServicio _reseñaServicio;
        ITipoLocalServicio TipoLocalServicio;

        public ReseñasController(IReseñaServicio reseñaServicio, ITipoLocalServicio tipoLocalServicio)
        {
            this._reseñaServicio = reseñaServicio;
            TipoLocalServicio = tipoLocalServicio;
        }

        [HttpGet]
        public IActionResult GetReseñas()
        {

            return Ok(_reseñaServicio.obtenerReseñas());
        }

        [HttpPost]
        public IActionResult PostReseña(Reseña reseña)
        {
            _reseñaServicio.agregarReseña(reseña);
            return Ok();
        }


        [HttpGet("TiposLocales")]
        public IActionResult GetTiposDeLocales()
        {
            return Ok(TipoLocalServicio.obtenerTiposDeLocales());
        }

        [HttpPost("TiposLocales")]
        public IActionResult PostTipoDeLocal(TipoLocal tipoLocal)
        {
            TipoLocalServicio.agregarTipoLocal(tipoLocal);
            return Ok();
        }
    }
}
