using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2._2c2025.Entidad;

namespace Clase2._2c2025.Logica
{
    public interface ITipoLocalServicio
    {
        void agregarTipoLocal(TipoLocal tipoLocal);
        List<TipoLocal> obtenerTiposDeLocales();
    }
    public class TipoLocalServicio : ITipoLocalServicio
    {
        private List<TipoLocal> TiposDeLocales;

        public TipoLocalServicio()
        {
            TiposDeLocales = new List<TipoLocal>();
        }

        public void agregarTipoLocal(TipoLocal tipoLocal)
        {
            TiposDeLocales.Add(tipoLocal);
        }

        public List<TipoLocal> obtenerTiposDeLocales()
        {
            return TiposDeLocales;
        }
    }
}
