using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;

public class Vaca : Animal
{
    public Vaca(int id, string v1, string v2) : base(id, v1, v2)
    {
    }

    public override string HacerRuido()
    {
        return "MUU HIJO DE PUTA";
    }
}
