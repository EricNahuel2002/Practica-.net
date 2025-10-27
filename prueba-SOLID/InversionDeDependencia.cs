using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_SOLID;



public interface IUserRepository
{
    void SaveUser(string username);
    IEnumerable<string> GetAllUsers();
}

public class UserRepository : IUserRepository
{
    private List<string> _users = new List<string>();

    public void SaveUser(string username)
    {
        Console.WriteLine($"Guardando usuario '{username}' en la base de datos...");
        _users.Add(username);
    }

    public IEnumerable<string> GetAllUsers()
    {
        return _users;
    }
}

public class UserService
{
    private IUserRepository _repository;


    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public void RegisterUser(string username)
    {
        Console.WriteLine($"Registrando usuario: {username}");
        _repository.SaveUser(username);
    }

    public void ShowAllUsers()
    {
        foreach (var user in _repository.GetAllUsers())
        {
            Console.WriteLine($"- {user}");
        }
    }
}

