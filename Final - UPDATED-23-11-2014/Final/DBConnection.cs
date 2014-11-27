using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Final
{
    public partial class Database
        
    {
        static string constring = ConfigurationManager.ConnectionStrings["SchoolsEntities"].ConnectionString;
        
    }
}
