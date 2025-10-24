using Repositorio;
using Entidad.Models;
namespace Servicio;

public interface IGestionBibliotecaServicio
{
    void agregarAutor(Autor autor);

}

public class GestionBibliotecaServicio : IGestionBibliotecaServicio
{

    private IAutorRepository _autorRepository;

    public GestionBibliotecaServicio(IAutorRepository autorRepo)
    {
        _autorRepository = autorRepo;
    }

    public void agregarAutor(Autor autor)
    {
        _autorRepository.Add(autor);
    }

}
