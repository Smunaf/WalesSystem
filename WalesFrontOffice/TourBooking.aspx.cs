            using System;
using WalesClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TourBooking : System.Web.UI.Page
{
    //var to store the TourNo
    Int32 TourNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        ////get data from query string and copy to variable
        //TourNo = Convert.ToInt32(Request.QueryString["TourNo"]);
        //if (IsPostBack != true)
        //{
        //    //if tour no is not -1 then display the data
        //    if (TourNo != -1)
        //    {
        //        //display the tour data
        //        DisplayTour(TourNo);
        //    } 
            
        //}
    }

    protected void btnCustDetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookingViewer.aspx");
    }

    ////function to fill the webform with the tour details
    //void DisplayTour(Int32 TourNo)
    //{
    //    //instance of booking class/////////////////////////////////CHANGE TO CLSTOUR 
    //    clsBookings TourList = new clsBookings();
    //    //get the right tour record
    //    TourList.Find(TourNo);
    //    //display the data
    //    txtTourName.Text = TourList.TourName;
    //    txtLocation.Text = TourList.Location;
    //    //txtCapacity.Text = Convert.ToString(TourList.Capacity);
    //    txtPrice.Text = Convert.ToString(TourList.Price);
    //    txtTime.Text = Convert.ToString(TourList.DepatureTime);
    //    txtDate.Text = Convert.ToString(TourList.Date);
    //}
}