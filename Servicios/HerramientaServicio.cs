using Entidades;

namespace Servicios
{
    public interface IHerramientaServicio
    {
        List<Herramienta> ObtenerHerramientas();
        void AgregarHerramienta(Herramienta herramienta);
        void EliminarHerramienta(int id);

        void EditarHerramienta(Herramienta herramienta);

        Herramienta BuscarHerramienta(int id);
    }
    public class HerramientaServicio : IHerramientaServicio
    {
        private List<Herramienta> herramientas;

        public HerramientaServicio()
        {
            herramientas = new List<Herramienta>();
            herramientas.Add(new Herramienta(1, "Martillo", "Para clavos", 12, "martillo.jpg"));
            herramientas.Add(new Herramienta(2, "Sierra", "Para madera", 13, "sierra.jpg"));
            herramientas.Add(new Herramienta(3, "Destornillaodr", "Para tornillos", 22, "destornillador.jpg"));
        }
        public void AgregarHerramienta(Herramienta herramienta)
        {
            herramientas.Add(herramienta);
        }

        public Herramienta BuscarHerramienta(int id)
        {
            return this.herramientas.Find(h => h.Id == id);
        }

        public void EditarHerramienta(Herramienta herramienta)
        {
            var i = herramientas.FindIndex(h => h.Id == herramienta.Id);
            if(i != -1)
            {
                this.herramientas[i] = herramienta;
            }
        }

        public void EliminarHerramienta(int id)
        {
            herramientas.RemoveAll(h => h.Id == id);
        }

        public List<Herramienta> ObtenerHerramientas()
        {
            return herramientas;
        }
    }
}
