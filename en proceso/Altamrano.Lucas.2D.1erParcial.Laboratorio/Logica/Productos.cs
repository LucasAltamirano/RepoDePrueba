using System.Text;

namespace Logica
{
        public enum ETipo
        {
            comestible,
            bebible,
        }

    public  class Productos
    {
        private string nombre;
        private int codigoDeProducto;
        private float valorXUnidad;
        private int cantidadStock;
        private ETipo tipo;

        public Productos(string nombre,int codigoDeProducto, float valorXUnidad, int cantidadStock,ETipo tipo)
        {
            this.Nombre = nombre;
            this.codigoDeProducto = codigoDeProducto;
            this.valorXUnidad = valorXUnidad;
            this.cantidadStock = cantidadStock;
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public string GetProductos()
        {
            return this.Nombre;
        }


        public   string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre :{Nombre}");
            stringBuilder.AppendLine($"Tipo de producto :{tipo}");
            stringBuilder.AppendLine($"Valor Unitario :{valorXUnidad}");
            stringBuilder.AppendLine($"Cantidad de Stock :{cantidadStock}");
            stringBuilder.AppendLine($"Codigo de producto :{codigoDeProducto}");
            
            return stringBuilder.ToString();
        }






    }
}
