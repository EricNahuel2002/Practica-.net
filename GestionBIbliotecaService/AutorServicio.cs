using Entidad.Models;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio;


public interface IAutorServicio
{
    void AgregarAutor(Autor autor);

    void EliminarAutorPorId(int id);

    Autor[] ObtenerAutores();

    Autor ObtenerAutorPorId(int id);

    void EditarAutor(Autor autor);
}

public class AutorServicio : IAutorServicio
{

    private IAutorRepository _autorRepository;

    public AutorServicio(IAutorRepository autorRepository)
    {
        this._autorRepository = autorRepository;
    }

    public void AgregarAutor(Autor autor)
    {
        this._autorRepository.AgregarAutor(autor);
    }

    public void EditarAutor(Autor autor)
    {
        this._autorRepository.EditarAutor(autor);
    }

    public void EliminarAutorPorId(int id)
    {
        this._autorRepository.EliminarAutor(id);
    }

    public Autor[] ObtenerAutores()
    {
        return this._autorRepository.ObtenerAutores();
    }

    public Autor ObtenerAutorPorId(int id)
    {
        return this._autorRepository.ObtenerAutorPorId(id);
    }
}
