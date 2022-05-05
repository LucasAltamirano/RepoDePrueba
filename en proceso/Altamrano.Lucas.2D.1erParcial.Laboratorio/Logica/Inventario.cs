using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Inventario
    {
        static  List<Productos> listaProductos;
            
       
        static Inventario()
        {
            listaProductos = new List<Productos>();

            Productos prod1 = new Productos("hamburguesas",253155,100f,50,ETipo.comestible);
            Productos prod2 = new Productos("licor",343434, 25.50f, 25, ETipo.bebible);
            Productos prod3 = new Productos("cerveza",25525, 20.00f,100, ETipo.bebible);
            Productos prod4 = new Productos("choripan ",253155,150.50f,50,ETipo.comestible);
            listaProductos.Add(prod3);
            listaProductos.Add(prod1);
            listaProductos.Add(prod2);
            listaProductos.Add(prod4);
        }

        public static List<Productos> ListaProductos
        {
            get { return listaProductos; }
            
        }
       
        public static void AgregarProductoALaLista(Productos producto)
        {
            if (producto is not null)
            {
                listaProductos.Add(producto);
            }
        }
    
    
    
    
    }//end class
}//end namespace
