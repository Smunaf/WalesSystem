using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalesClasses;

public partial class BookingViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new isntance of clsBookings
        clsBookings ABooking = new clsBookings();
        //get the data from the session object
        ABooking = (clsBookings)Session["ABooking"];
        //display the booing number for the entry
        Response.Write(ABooking.BookingNo);
    }
}