using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class ControlStock : Form
    {

   
        

        public ControlStock()
        {
            InitializeComponent();
        }

        private void ControlStock_Load(object sender, EventArgs e)
        {

            foreach (var item in Logica.Inventario.ListaProductos)
            {
                lstBoxListaProductos.Items.Add(item.Nombre);
            }
            
        }
    }
}
