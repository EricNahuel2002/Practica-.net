using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace Servicios;

public interface IRegistroServicio
{
    void RegistrarUsuario(Usuario usuario);
    Usuario BuscarUsuario(int id);

    void ModificarUsuario(Usuario usuario);
}

public class RegistroServicio : IRegistroServicio
{
    private List<Usuario> _UsuarioList;
    private int idNuevoUsuario;

    public RegistroServicio()
    {
        this._UsuarioList = new List<Usuario>();
        _UsuarioList.Add(new Usuario(1, "pepe525", "pepe525@gmail.com", "contraseña"));
        _UsuarioList.Add(new Usuario(1, "lucas", "lucas@gmail.com", "contraseña2"));
        _UsuarioList.Add(new Usuario(1, "tomas", "tomas@gmail.com", "contraseña3"));
        idNuevoUsuario = 1;
    }

    public Usuario BuscarUsuario(int id)
    {
        throw new NotImplementedException();
    }

    public void ModificarUsuario(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        usuario.Id = idNuevoUsuario++;
        this._UsuarioList.Add(usuario);
    }
}
