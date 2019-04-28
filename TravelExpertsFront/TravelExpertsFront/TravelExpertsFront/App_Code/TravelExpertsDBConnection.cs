using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFront.App_Code
{
    /* Travel Experts Database Connection
     * Author: Jonathan Pirca
     * Created Date: Jan 2019
     */
    public class TravelExpertsDBConnection
    {
        public static SqlConnection GetConnection()
        {
            // get connection string from Web.config
            string connString = ConfigurationManager.ConnectionStrings["rdsconnect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}