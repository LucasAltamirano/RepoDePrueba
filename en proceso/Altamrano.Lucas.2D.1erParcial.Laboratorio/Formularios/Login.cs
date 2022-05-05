using Logica;
using System;
using System.Windows.Forms;


namespace Formularios
{
    public partial class FormLoguin : Form
    {
        public FormLoguin()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txbUsuario.Text;
            string pass = this.txbPassword.Text;


            Usuarios nuevoUsuario = GestorUsuarios.BuscarUsuario(usuario, pass);

            if (nuevoUsuario is not null)
            {
                MessageBox.Show("Bienvenido usuario" + usuario, "Logueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool esAdmn = GestorUsuarios.TipoUsuario(nuevoUsuario);

                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrecta verifique", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



            //string usuarioRegistrado = "pepe";
            //string passRegistrado = "rufoso";





        }


    }

}
