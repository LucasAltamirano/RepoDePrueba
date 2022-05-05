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
    public partial class Salon : Form
    {
        public Salon()
        {
            InitializeComponent();
        }

        private void picBoxMesa1_Click(object sender, EventArgs e)
        {
            frmConsumo formConsumo =new  frmConsumo();
            formConsumo.ShowDialog();
            int numeroMesa = 1;
            Mesa myMesa = Logica.Mesa.SincronizarMesas(numeroMesa);
            myMesa.Disponibilidad = true;
            myMesa.Consumo1 = Inventario.ListaProductos;
        }

        private void picBoxMesa2_Click(object sender, EventArgs e)
        {
            frmConsumo formConsumo = new frmConsumo();
            formConsumo.ShowDialog();
            int numeroMesa = 2;
            Mesa myMesa = Logica.Mesa.SincronizarMesas(numeroMesa);
            myMesa.Disponibilidad = true;
            myMesa.Consumo1 = Inventario.ListaProductos;
        }

        private void picBoxMesa3_Click(object sender, EventArgs e)
        {
            int numeroMesa = 3;
            Mesa myMesa = Logica.Mesa.SincronizarMesas(numeroMesa);
            myMesa.Disponibilidad = true;
            myMesa.Consumo1 = Inventario.ListaProductos;
        }

        private void picBoxMesa4_Click(object sender, EventArgs e)
        {
            int numeroMesa = 4;
            Mesa myMesa = Logica.Mesa.SincronizarMesas(numeroMesa);
            myMesa.Disponibilidad = true;
            myMesa.Consumo1 = Inventario.ListaProductos;
        }


    }
}
