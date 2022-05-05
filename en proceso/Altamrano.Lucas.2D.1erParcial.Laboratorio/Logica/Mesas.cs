using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Mesa
    {
         // Atributos

        static Mesa[] mesas;
        private int identificador;
        private List<Productos> Consumo;
        private bool disponibilidad; 

        static Mesa()
        {
            mesas = new Mesa[19];

            InstanciarMesas();
        }

        public Mesa(int identificador, List<Productos> consumo, bool disponibilidad)
        {
            this.identificador = identificador;
            Consumo1 = consumo;
            this.Disponibilidad = disponibilidad;
        }

        public Mesa[] Mesas { get => mesas; set => mesas = value; }
        public int Identificador
        { 
            get { return identificador; }
        }
        public List<Productos> Consumo1 { get => Consumo; set => Consumo = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }

        private static void InstanciarMesas()
        {
            Mesa mesa1 = new Mesa(1,null,true);
            mesas[0] = mesa1;
            Mesa mesa2 = new Mesa(2, null, true);
            mesas[1] = mesa2;
            Mesa mesa3 = new Mesa(3, null, true);
            mesas[2] = mesa3;
            Mesa mesa4 = new Mesa(4, null, true);
            mesas[3] = mesa4;
            Mesa mesa5 = new Mesa(5, null, true);
            mesas[4] = mesa5;
            Mesa mesa6 = new Mesa(6, null, true);
            mesas[5] = mesa6;
            Mesa mesa7 = new Mesa(7, null, true);
            mesas[6] = mesa7;
            Mesa mesa8 = new Mesa(8, null, true);
            mesas[7] = mesa8;
            Mesa mesa9 = new Mesa(9, null, true);
            mesas[8] = mesa9;
            Mesa mesa10 = new Mesa(10, null, true);
            mesas[9] = mesa10;
            Mesa mesa11= new Mesa(11, null, true);
            mesas[10] = mesa11;
            Mesa mesa12= new Mesa(12, null, true);
            mesas[11] = mesa12;
            Mesa mesa13 = new Mesa(13, null, true);
            mesas[12] = mesa13;
            Mesa mesa14 = new Mesa(14, null, true);
            mesas[13] = mesa14;
            Mesa mesa15 = new Mesa(15, null, true);
            mesas[14] = mesa15;
            Mesa mesa16 = new Mesa(16, null, true);
            mesas[15] = mesa16;
            Mesa mesa17 = new Mesa(17, null, true);
            mesas[16] = mesa17;
            Mesa mesa18 = new Mesa(18, null, true);
            mesas[17] = mesa18;
            Mesa mesa19 = new Mesa(19, null, true);
            mesas[18] = mesa19;
            Mesa mesa20 = new Mesa(20, null, true);
            mesas[19] = mesa20;

        }

        public static Mesa SincronizarMesas(int numeroMesa)
        {
            foreach (var mesa in mesas)
            {
                if (mesa.Identificador==numeroMesa)
                {
                    return mesa;
                }
            }
            return null;
        }



    }
}
