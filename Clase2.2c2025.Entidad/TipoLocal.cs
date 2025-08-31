using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2._2c2025.Entidad
{
    public class TipoLocal
    {
        public string Nombre {  get; set; }

        public TipoLocal (string nombre)
        {
            Nombre = nombre;
        }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
