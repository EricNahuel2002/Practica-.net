using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Estudiante
{
    public int EstudianteId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
