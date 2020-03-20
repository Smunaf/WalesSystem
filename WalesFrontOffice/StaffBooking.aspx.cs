using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalesClasses;

public partial class StaffBooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (IsPostBack == false)
        //{
        ////    display all bookings
        //    DisplayBookings("");
        //}
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        DisplayBookings("");
    }

    Int32 DisplayBookings(string BookingNoFilter)
    {
        //variable to store the bookings table primary key
        Int32 BookingNo;
        //var to store the tour name
        string CustomerNo;
        //var to store the location
        string TourNo;
        //instance of the collection class
        clsBookingCollection BookingRecord = new clsBookingCollection();
        //
        BookingRecord.ReportByBookingNo(BookingNoFilter);
        //var to store teh count of records
        Int32 RecordCount;
        //var to index the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = BookingRecord.Count;
        //clear the list box
        lstDisplay.Items.Clear();
        //
        while (Index < RecordCount)
        {
            //get the primary key
            BookingNo = BookingRecord.BookingList[Index].BookingNo;
            //get the customerno
            CustomerNo = Convert.ToString(BookingRecord.BookingList[Index].CustomerNo);
            //get the tour no
            TourNo = Convert.ToString(BookingRecord.BookingList[Index].TourNo);
            //new entry for listbox with all data together
            ListItem NewEntry = new ListItem(CustomerNo + " " + TourNo + " ", BookingNo.ToString());
            //add the new entry
            lstDisplay.Items.Add(NewEntry);
            //index the next record
            Index++;
        }
        //return the count of records found
        return RecordCount;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ABooking.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}