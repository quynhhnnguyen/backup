using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront.Dashboard
{
    /* Booking History Page - Preparing booking list which booking details 
     *          including product(s), package(s) break-down price and total price
     * Author: Quynh Nguyen (Queenie)
     * Created Date: Jan 2019
     */
    public partial class OrderHisory : System.Web.UI.Page
    {
        List<Booking> bookings = new List<Booking>();

        //Load Booking History data for logged-in user
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedin"] != null) // logged in
            {
                bookings = BookingDB.GetBookingDetails(Convert.ToInt32(Session["CustID"]));
                Session["BookingsCount"] = bookings.Count;
                dlBookings.DataSource = bookings;
                dlBookings.DataBind();
            }
            else //not log in yet, so redirect to login page
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        // Load  Booking Details for each booking.
        protected void dlBookings_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            ListView gw = (ListView)e.Item.FindControl("dlBookingDetails");
            int bookingId = Convert.ToInt32(((TextBox)e.Item.FindControl("BookingId")).Text);

            gw.DataSource = (from bookingObj in bookings
                             where bookingObj.BookingId == bookingId
                             select bookingObj.BookingDetails).Single();

            gw.DataBind();
        }
    }
}