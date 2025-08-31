using Clase2._2c2025.Entidad;

namespace Clase2._2c2025.Logica
{

    public interface IReseñaServicio
    {
        void agregarReseña(Reseña reseña);
        List<Reseña> obtenerReseñas();
    }
    public class ReseñaServicio : IReseñaServicio
    {
        private List<Reseña> _listReseñas;

        public ReseñaServicio()
        {
            _listReseñas = new List<Reseña> ();
        }

        public void agregarReseña(Reseña reseña)
        {
            _listReseñas.Add(reseña);
        }

        public List<Reseña> obtenerReseñas()
        {
            return _listReseñas;
        }
    }
}
