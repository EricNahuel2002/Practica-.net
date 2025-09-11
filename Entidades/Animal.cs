using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;

public abstract class Animal
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Sexo { get; set; }

    public Animal(int id, string v1, string v2)
    {
        this.Id = id;
        this.Nombre = v1;
        this.Sexo = v2;
    }

    public abstract string HacerRuido();
}
