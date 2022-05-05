namespace Logica
{


    public class Administrador : Usuarios
    {
        public Administrador(int dni, string nombreUsuario, string pass, bool esAdministrador) : base(dni, nombreUsuario, pass, esAdministrador)
        {
        }
    }
}
