using Entidad.Models;
using Entidad.Context;
using Microsoft.EntityFrameworkCore;
namespace Repositorio;


public interface IAutorRepository
{
    void AgregarAutor(Autor autor);
    void EliminarAutor(int id);

    Autor ObtenerAutorPorId(int id);

    Autor[] ObtenerAutores();

    void EditarAutor(Autor autor);
}

public class AutorRepository : IAutorRepository
{

    BibliotecaDBContext ctx;

    public AutorRepository(BibliotecaDBContext ctx)
    {
        this.ctx = ctx;
    }

    public void AgregarAutor(Autor autor)
    {
        ctx.Autors.Add(autor);
        ctx.SaveChanges();
    }

    public void EditarAutor(Autor autor)
    {
        ctx.Autors.Update(autor);
        ctx.SaveChanges();
    }

    public void EliminarAutor(int id)
    {
        var autor = this.ObtenerAutorPorId(id);
        ctx.Remove(autor);
        ctx.SaveChanges();
    }

    public Autor[] ObtenerAutores()
    {
        return ctx.Autors.ToArray();
    }

    public Autor ObtenerAutorPorId(int id)
    {
        return ctx.Autors.Where(a => a.AutorId == id).First();
    }
}
