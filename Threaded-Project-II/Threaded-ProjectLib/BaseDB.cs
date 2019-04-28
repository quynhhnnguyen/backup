using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    /* Author: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     * Implement base sql functions.
     */
    public class BaseDB
    {

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file, using the 
            // System.Configuration.ConfigurationManager.ConnectionStrings property 
            //Connects to the App config 

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                return ConfigurationManager.ConnectionStrings["travelexpertsLocalDB"].ConnectionString;
            }
            else {
                Utils.WriteErrorLog("Missing database configuration, please check those information in App.config");
            }

            return null;

        }
    }
}
