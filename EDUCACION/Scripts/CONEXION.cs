using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EDUCACION
{
    internal class CONEXION
    {

        public bool flagBD = true;
        bool conesnulo = false;
        String cadena = "Data Source=LAPTOP-HNTNC1IL;Initial Catalog=COLEGIOPROYECTO;Integrated Security=True";
        public SqlConnection con = null;


        public CONEXION()
        {
            //cadena = "Data Source=DEVELOP;Initial Catalog=Tienda;User ID=admon;Password=1";
            //cadena = "Data Source=DEVELOP;Initial Catalog=Tienda;Integrated Security=True";
            con = new SqlConnection(cadena);
            con.Open();

            if (con == null)
            {
                flagBD = false;
                conesnulo = true;
                MessageBox.Show(con.ToString());
            }
            else if (con.State.Equals(ConnectionState.Closed))
            {
                flagBD = false;
                MessageBox.Show(con.ToString());
            }
        }
        ~CONEXION()
        {
        }
    }
}
