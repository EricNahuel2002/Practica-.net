using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string Titulo { get; set; } = null!;

    public int? AnioPublicacion { get; set; }

    public int AutorId { get; set; }

    public virtual Autor Autor { get; set; } = null!;
}
