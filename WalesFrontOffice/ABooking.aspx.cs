using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalesClasses;

public partial class ABooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsBooking
        clsBookings ABooking = new clsBookings();
        //capture the Booking no
        ABooking.BookingNo = Convert.ToInt32(txtBookingNo.Text);
        //store the booking in the session objecgt
        Session["ABooking"] = ABooking;
        //redirect to the viewer page
        Response.Redirect("BookingViewer.aspx");
    }
}