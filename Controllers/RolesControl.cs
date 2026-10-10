using EDUSEX.Models;

namespace EDUSEX.Controllers
{
    internal class RolesControl
    {
        public string ObtenerNombreRol(int idRol)
        {
            return Roles.ObtenerNombreRol(idRol);
        }
    }
}