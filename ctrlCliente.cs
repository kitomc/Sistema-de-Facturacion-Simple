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
    public partial class ctrlCliente : UserControl
    {
        public ctrlCliente()
        {
            InitializeComponent();

        }
       
        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            BL.Clientes clientes = new BL.Clientes();
            BL.Conexion conexion = new BL.Conexion();
            Inicio inicio = new Inicio();
            clientes.Nombre = tbNombre.Text.ToString();
            clientes.Apellido = tbApellido.Text.ToString();
            clientes.Telefono = tbTelefono.Text.ToString();

            //inicio.dgv_DB.DataSource=(conexion.AgregarCliente(clientes.Nombre, clientes.Apellido, clientes.Telefono));
            inicio.dgv_DB.DataSource = conexion.cliente();
            inicio.Mensaje = clientes.Nombre;

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
