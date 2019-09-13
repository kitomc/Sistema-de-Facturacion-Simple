using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.BL
{
  public  class Utilidades
    {

       static public void MostrarPanel(Panel Contenedor, ctrlProductos Objeto)
        {
            if (Contenedor.Contains(Objeto) == false)
            {
                Contenedor.Controls.Add(Objeto);
                Objeto.Dock = DockStyle.Fill;
                Objeto.BringToFront();

            }
            else
            {
                Objeto.BringToFront();
            }

        }



    }
}
