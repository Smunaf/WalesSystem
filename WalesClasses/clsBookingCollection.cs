using System;
using System.Collections.Generic;
using WalesClasses;

namespace WalesClasses
{
    public class clsBookingCollection
    {
        clsDataConnection dbConnection = new clsDataConnection();

        //private data member for the list
        List<clsBookings> mBookingList = new List<clsBookings>();

        //private data member for mThisBooking
        clsBookings mThisBooking = new clsBookings();

        //show how many bookings there are in the list
        public int Count
        {
            get
            {
                //return the count of the list
                return mBookingList.Count;
            }
            set
            {
               
            }
        }

        public clsBookings ThisBooking
        {
            get
            {
                return mThisBooking;
            }
            set
            {
                mThisBooking = value;
            }
        }

        public List<clsBookings> BookingList
        {
            get
            {
                List<clsBookings> mBookingList = new List<clsBookings>();
                //var for storing the record count
                Int32 RecordCount;
                //var for storing the index for the loop
                Int32 Index = 0;
                //get the count of the records
                RecordCount = dbConnection.Count;
                //loop until all records are processed
                while (Index < RecordCount)
                {
                    //create a blank booking page
                    clsBookings NewBooking = new clsBookings();
                    //copy the data from the table to the ram
                    NewBooking.BookingNo = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["BookingNo"]);
                    NewBooking.CustomerNo = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["CustomerNo"]);
                    NewBooking.TourNo = Convert.ToInt32(dbConnection.DataTable.Rows[Index]["TourNo"]);
                    //Temporarily set to int instead of date time. 
                    NewBooking.DateandTime = Convert.ToDateTime(dbConnection.DataTable.Rows[Index]["DateTime"]);
                    //add the blank page to the array list
                    mBookingList.Add(NewBooking);
                    //increase the index
                    Index++;
                }
                return mBookingList;
            }


        }


        //function for adding new booking record to the database 
        public Int32 Add(clsBookings NewBooking)
        {
            clsDataConnection NewDBBooking = new clsDataConnection();
            //add the parameters
            NewDBBooking.AddParameter("@BookingNo", NewBooking.BookingNo);
            NewDBBooking.AddParameter("@CustomerNo", NewBooking.CustomerNo);
            NewDBBooking.AddParameter("@TourNo", NewBooking.TourNo);
            NewDBBooking.AddParameter("@DateTime", NewBooking.DateandTime);
            NewDBBooking.AddParameter("@PassengerCount", NewBooking.PassengerCount);
            //execute the insert stored procedure 
            return NewDBBooking.Execute("sproc_tblBookings_Insert");
        }

        //function to update an existing record on the dbase
        public void Update(clsBookings ExistingBooking)
        {
            clsDataConnection ExistingDBBooking = new clsDataConnection();
            //add parameters
            ExistingDBBooking.AddParameter("@BookingNo", ExistingBooking.BookingNo);
            ExistingDBBooking.AddParameter("@CustomerNo", ExistingBooking.CustomerNo);
            ExistingDBBooking.AddParameter("@TourNo", ExistingBooking.TourNo);
            ExistingDBBooking.AddParameter("@DateTime", ExistingBooking.DateandTime);
            ExistingDBBooking.AddParameter("@PassengerCount", ExistingBooking.PassengerCount);
            //execute the sproc
            ExistingDBBooking.Execute("sproc_tblBooking_Update");
        }

        public Boolean Delete()
        {
            try
            {
                //instance of data connection called mydatabase
                clsDataConnection MyDataBase = new clsDataConnection();
                //add booking no parameter passed to this function to the list of parameteres to use in the database
                MyDataBase.AddParameter("@BookingNo", mThisBooking.BookingNo);
                //execute the sproc
                MyDataBase.Execute("sproc_tblBooking_Delete");
                //returntrue
                return true;
            }
            catch
            {
                //error
                return false;
            }
        }

        //function to define the reportbytourname method
        public void ReportByTourName(string TourName)
        {
            //initialise the dbase connection
            dbConnection = new clsDataConnection();
            //add the parameter data used by sproc
            dbConnection.AddParameter("@TourName", TourName);
            //execute the sproc to filter
            dbConnection.Execute("sproc_tblTours_FilterByTourName");
        }
    }
}