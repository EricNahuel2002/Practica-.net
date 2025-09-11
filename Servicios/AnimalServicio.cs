using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios;

public interface IAnimalServicio
{
    List<Animal> ListarAnimales();
}
public class AnimalServicio : IAnimalServicio
{
    List<Animal> animales;
    public AnimalServicio()
    {
        animales = new List<Animal>();
        animales.Add(new Oveja(1,"Pepe","Macho"));
        animales.Add(new Vaca(2,"Rosa","Hembra"));
        animales.Add(new Vaca(3,"Melano","Macho"));
    }
    public List<Animal> ListarAnimales()
    {
        return this.animales;
    }
}
