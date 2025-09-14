using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;

public class RegistroViewModel
{
    [Required(ErrorMessage = "Campo requerido")]
    public string NombreUsuario { get; set; }

    [Required(ErrorMessage = "Campo requerido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Campo requerido")]
    [Range(8,15,ErrorMessage = "Entre 8 y 15 caracteres.")]
    public string Contraseña { get; set; }
    [Required(ErrorMessage = "Campo requerido")]
    [Compare("Contraseña",ErrorMessage ="Las contraseñas no coinciden.")]
    public string ContraseñaRepetida { get; set; }
}
