using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConnectionConstants
    {
        public static string DefaultConnection = 
            System.Configuration.ConfigurationManager.ConnectionStrings[nameof(DefaultConnection)].ConnectionString;
    }
}
