using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion.BL
{
   public class Conexion
    {
       string cc = @"Data Source=DESKTOP-F0SL1Q3\SQLEXPRESS;Initial Catalog=Factura;Integrated Security=True";


        public DataTable cliente()
        {


            SqlConnection con = new SqlConnection(cc);
            SqlDataAdapter oda = new SqlDataAdapter();
            DataTable odt = new DataTable();

            SqlCommand ocmd = con.CreateCommand();
            ocmd.CommandText = "select * from Cliente";
            oda.SelectCommand = ocmd;
            oda.Fill(odt);

            return odt;

        }

        public DataTable AgregarCliente(string Nombre,string Apellido, string Telefono)
        {

            SqlConnection con = new SqlConnection(cc);
            SqlDataAdapter oda = new SqlDataAdapter();
            DataTable odt = new DataTable();
            int x = 9;
            int z = 6;
            z++;
            x++;
            SqlCommand ocmd = con.CreateCommand();
            ocmd.CommandText = "INSERT INTO Cliente (Nombre, Apellido, Telefono, IdProductos)VALUES(" + Nombre +","+Apellido+","+Telefono+","+x+");";
            oda.SelectCommand = ocmd;
            oda.Fill(odt);
            return odt;
        }


        

    }
}
