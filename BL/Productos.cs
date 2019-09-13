using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.BL
{
   public class Productos
    {
        public int IdProductos { get; set; }
        public string  Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }

        public Clientes Clientes{ get; set; }

    }
}
