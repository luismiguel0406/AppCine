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
        protected SqlConnection getConnection()
        {
            return new SqlConnection("Data Source =.;Initial Catalog = cinedb ;Integrated Security=true");
        }
        
        
      }
    
    
}
