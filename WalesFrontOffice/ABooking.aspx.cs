using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalesClasses;

public partial class ABooking : System.Web.UI.Page
{
    Int32 BookingNo;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    void DisplayBooking(Int32 BookingNo)
    {
        //instance of booking clas
        clsBookings BookingList = new clsBookings();
        //find record to display
        BookingList.Find(BookingNo);
        //display the data
        txtCustomerNo.Text = BookingList.CustomerNo.ToString();
        txtTourNo.Text = BookingList.TourNo.ToString();
        txtDateandTime.Text = BookingList.DateandTime.ToShortDateString();
        txtPassengerCount.Text = BookingList.PassengerCount.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //instance of cls booking
        clsBookings ThisBooking = new clsBookings();
        //variable to store error msg
        string ErrorMessage;
        //test data entered
        ErrorMessage = ThisBooking.BookingValid(txtCustomerNo.Text,
                                                txtTourNo.Text,
                                                txtPassengerCount.Text,
                                                txtDateandTime.Text);
        //if no errors 
        if (ErrorMessage == "")
        {
            //instance of booking collection class
            clsBookingCollection BookingList = new clsBookingCollection();
            //insert new data
            if (BookingNo == -1)
            {
                //copy data from the interface to the object
                BookingList.ThisBooking.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
                BookingList.ThisBooking.TourNo = Convert.ToInt32(txtTourNo.Text);
                BookingList.ThisBooking.PassengerCount = Convert.ToInt32(txtPassengerCount.Text);
                BookingList.ThisBooking.DateandTime = Convert.ToDateTime(txtDateandTime);
                //add the new record
                BookingList.Add();
            }
            else//update existing data
            {
                BookingList.ThisBooking.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
                BookingList.ThisBooking.TourNo = Convert.ToInt32(txtTourNo.Text);
                BookingList.ThisBooking.PassengerCount = Convert.ToInt32(txtPassengerCount.Text);
                BookingList.ThisBooking.DateandTime = Convert.ToDateTime(txtDateandTime);
                //add the new record
                BookingList.Update();
            }
            //Redirect back to the bookings list
            Response.Redirect("StaffBooking.aspx");
        }
        else
        {
            //display error message
            lblError.Text = ErrorMessage;
        }
    }
}