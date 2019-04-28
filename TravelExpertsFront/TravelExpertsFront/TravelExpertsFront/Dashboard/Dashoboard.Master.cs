﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront.Dashboard
{
    /* Travel Experts Dashboard 
     * Author: Jeremiah Lobo
     * Created Date: Jan 2019
     */
    public partial class Dashoboard : System.Web.UI.MasterPage
    {
        public string customerstring;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedin"] != null)
            {
                Customer custObj = new Customer();
                CustomerDB customerDB = new CustomerDB();
                custObj.CustomerID = Convert.ToInt32(Session["CustID"]);
               
                customerDB.getallCustomerInfoById(custObj);
                Session["CustomerName"] = custObj.CustFirstName + " " + custObj.CustLastName;
                customerstring  = Session["CustomerName"].ToString();
                lblDashCustomerName.Text = customerstring;
            }
            else {
                Response.Redirect("~/Login.aspx");
            }
           
        }

    }
}