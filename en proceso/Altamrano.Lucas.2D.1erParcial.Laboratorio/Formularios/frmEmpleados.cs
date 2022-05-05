using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Formularios
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            foreach (Usuarios item in Logica.GestorUsuarios.MuestroListaUsuarios)
            {
                if (item is Empleado)
                {
                    lstBoxEmpleados.Items.Add(item.MostrarInfo());
                }
                
            }
        }

        private void btnAgregarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado formAltaEmpleado = new frmAltaEmpleado();
            formAltaEmpleado.ShowDialog();


        }
    }
}
