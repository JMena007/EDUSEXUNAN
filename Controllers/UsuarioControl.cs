using EDUSEX.Models;
using System.Collections.Generic;

namespace EDUSEX.Controllers
{
    internal class UsuarioControl
    {
        public void InsertarUsuario(Usuarios usuario)
        {
            usuario.InsertarUsuario();
        }

        public bool CedulaExiste(string cedula)
        {
            return Usuarios.CedulaExiste(cedula);
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            return Usuarios.ObtenerUsuarios();
        }

        public void Editarusuario(Usuarios usuario)
        {
            usuario.EditarUsuario();
        }

        public void EliminarUsuario(int idUsuario)
        {
            Usuarios usuario = Usuarios.ObtenerUsuarioPorId(idUsuario);
            usuario?.EliminarUsuario();
        }

        public Usuarios BuscarPorCedula(string cedula)
        {
            return Usuarios.BuscarPorCedula(cedula);
        }

        public Usuarios BuscarPorCedulaONombre(string valor)
        {
            return Usuarios.BuscarPorCedulaONombre(valor);
        }

        public Usuarios ObtenerUsuarioPorId(int idUsuario)
        {
            return Usuarios.ObtenerUsuarioPorId(idUsuario);
        }

        public Usuarios ValidarLogin (string correo, string password)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Ingrese su correo y contraseña.");
                return null;
            }
            return Usuarios.ValidarLogin(correo, password);
        } 
        
            
        
    }
}