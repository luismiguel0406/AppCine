using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class conexionbd
    {
        protected SqlConnection conexion = new SqlConnection("Data Source =.;Initial Catalog = cinedb ;Integrated Security=true");


        public SqlConnection abrirConexion()
        {

            if (conexion.State ==ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {

            if (conexion.State==ConnectionState.Open)
            {
                conexion.Close();
                
            }
            return conexion;
        }
      }

    
}
