using System.Collections.Generic;

namespace Logica
{
     public static class GestorUsuarios
    {
        private  static List<Usuarios> listaUsuarios;

         static   GestorUsuarios()
        {
            listaUsuarios = new List<Usuarios>();

            Empleado user2 = new Empleado(37023165,"lucas","emp",false);
            
            Administrador user1 = new Administrador(1,"eze","eze",true);

            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);

        }

        public  static  List<Usuarios> MuestroListaUsuarios 
        {
            get { return listaUsuarios; }
        }


        public static Usuarios BuscarUsuario( string usuario, string pass)
        {
            
            
            foreach (var usuarioRegistrado in MuestroListaUsuarios)
            {
                if (usuarioRegistrado.NombreUsuario == usuario && usuarioRegistrado.Pass == pass)
                {
                  
                    return usuarioRegistrado;
                }
               
            }   

            return null;
            }

        public static bool TipoUsuario(Usuarios user)
        {
            bool retorno = false;

            if (user.EsAdministrador)
            {
                return true;
            }

            return retorno;

        }









    }//end class
}//end Namespace
