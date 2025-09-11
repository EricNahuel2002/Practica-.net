using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;

public class Oveja : Animal
{
    public Oveja(int id, string v1, string v2) : base(id, v1, v2)
    {
    }

    public override string HacerRuido()
    {
        return "VAA BASURA";
    }
}
