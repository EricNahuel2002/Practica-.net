using Entidad.Models;
using Entidad.Context;
namespace Repositorio;


public interface IAutorRepository
{
    void Add(Autor autor);
    void Delete(Autor autor);
}

public class AutorRepository : IAutorRepository
{

    BibliotecaDBContext ctx;

    public AutorRepository(BibliotecaDBContext ctx)
    {
        this.ctx = ctx;
    }

    public void Add(Autor autor)
    {
        ctx.Autors.Add(autor);
        ctx.SaveChanges();
    }

    public void Delete(Autor autor)
    {
        ctx.Autors.Where(a1 => a1.AutorId == autor.AutorId).First();
        ctx.SaveChanges();
    }
}
