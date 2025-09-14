using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades;

public class Usuario
{
    public Usuario(int id, string nombreUsuario, string email, string contraseña)
    {
        Id = id;
        NombreUsuario = nombreUsuario;
        Email = email;
        Contraseña = contraseña;
    }
    public Usuario(string nombreUsuario, string email, string contraseña)
    {
        NombreUsuario = nombreUsuario;
        Email = email;
        Contraseña = contraseña;
    }

    public int Id { get; set; }
    public string NombreUsuario {  get; set; }
    public string Email { get; set; }
    public string Contraseña { get; set; }  
}
