using EDUSEX.Models;

namespace EDUSEX.Controllers
{
    public class CredencialControl
    {
        public Credenciales ValidarLogin(string usuario, string password)
        {
            return Credenciales.ValidarLogin(usuario, password);
        }

        public void InsertarCredencial(Credenciales credencial)
        {
            credencial.InsertarCredencial();
        }
    }
}