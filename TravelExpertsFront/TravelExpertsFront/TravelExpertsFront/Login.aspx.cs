using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront
{
    /* Login handling 
     * Author: Jeremiah Lobo
     * Created Date: Jan 2019
     */
    public partial class Login : System.Web.UI.Page
    {
        CustomerDB custDB = new CustomerDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.CustLoginName = txtUsername.Text;
            string customerPassword = txtpassword.Text;

            if (custDB.CustomerLogin(customerPassword, cust))
            {
                //Redirect to dashboard
                Session["loggedin"] = true;
                Session["CustID"] = cust.CustomerID;
                Response.Redirect("~/dashboard/index.aspx");
                
            }
            else
            {
                lblErrorMessage.Text = "Please Check Your Username and Password";
            }

        }
    }
}