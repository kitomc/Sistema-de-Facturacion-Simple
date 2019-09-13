using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.BL
{
  public  class Facturas
    {
        public int IdFactura { get; set; }
        public Clientes Clientes { get; set; }
        public ICollection<Productos> Productos { get; set; }
        public DateTime fecha { get; set; }
    }
}
