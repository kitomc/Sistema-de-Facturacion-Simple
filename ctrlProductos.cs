using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ctrlProductos : UserControl
    {
        public ctrlProductos()
        {
            InitializeComponent();
        }

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {

        }

        private void BtnAtrasProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
