using System.Text;

namespace Logica
{
    
    public abstract class Usuarios
    {


        private int dni;
        private string nombreUsuario;
        private string pass;
        private bool esAdministrador;

        protected Usuarios(int dni, string nombreUsuario, string pass, bool esAdministrador)
        {
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.pass = pass;
            this.esAdministrador = esAdministrador;
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
        }
        public string Pass
        {
            get { return pass; }
        }

        public bool EsAdministrador
        {
            get
            { return esAdministrador; }
        }

        public virtual string MostrarInfo()
        {

            return DatosUsuario();
        }


        private string DatosUsuario()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine($" ID :{dni}");
            stringbuilder.AppendLine($"  Nombre Usuario:{nombreUsuario}");
            stringbuilder.AppendLine($"  Admisnistrador:{esAdministrador}");
           

            return stringbuilder.ToString();
        }






    }//end class
}//end namespace
