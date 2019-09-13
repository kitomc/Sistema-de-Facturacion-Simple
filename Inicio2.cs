using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Facturacion
{
    public partial class Inicio : MaterialSkin.Controls.MaterialForm
    {
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public Inicio()
        {
            InitializeComponent();
        }

    


         
    

    

       
        private void LbMostrar_Click(object sender, EventArgs e)
        {
            if (pnl_Izquierdo.Width == 57)
            {
                pnl_Izquierdo.Visible = false;
                pnl_Izquierdo.Width = 235;
                PanelTransicion.ShowSync(pnl_Izquierdo);
                logoTransicion.ShowSync(pbLogo);
                logoTransicion.ShowSync(lbLogo);
            }
            else
            {
                logoTransicion.HideSync(pbLogo);
                logoTransicion.HideSync(lbLogo);
                pnl_Izquierdo.Visible = false;
                pnl_Izquierdo.Width = 57;
                PanelTransicion.ShowSync(pnl_Izquierdo);
            }
        }




        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ctrlCliente usercliente = new ctrlCliente();

            if (pnl_Contenedor.Contains(usercliente)==false)
           
            {
                pnl_Contenedor.Controls.Add(usercliente);
                usercliente.Dock = DockStyle.Fill;
                usercliente.BringToFront();
                
            }
            else
            {
                usercliente.BringToFront();
            }



        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ctrlProductos OctrlProductos = new ctrlProductos();
            BL.Utilidades.MostrarPanel(pnl_Contenedor, OctrlProductos);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           
        }

        private void Dgv_DB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
