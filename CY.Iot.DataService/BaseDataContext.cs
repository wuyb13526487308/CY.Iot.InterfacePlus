using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.DataService
{
    public class BaseDataContext : System.Data.Linq.DataContext
    {
        private static string getConnectionString
        {
            get
            {
                string configName = System.Configuration.ConfigurationManager.AppSettings["defaultDatabase"];
                return System.Configuration.ConfigurationManager.ConnectionStrings[configName].ConnectionString;
            }
        }
        public BaseDataContext() : base(getConnectionString)
        {
        }
    }
}
