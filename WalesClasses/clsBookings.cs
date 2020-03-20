using System;
using System.Collections.Generic;
using WalesClasses;

namespace WalesClasses
{
    public class clsBookings
    {
        public clsBookings()
        {
        }

        //private member variables
        private int mBookingNo;

        private int mCustomerNo;

        private int mTourNo;

        private DateTime mDateandTime;

        private int mPassengerCount;

        //public property
        public int BookingNo
        {
            get
            {
                return mBookingNo;
            }
            set
            {
                mBookingNo = value;
            }
        }
        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }
        public int TourNo
        {
            get
            {
                return mTourNo;
            }
            set
            {
                mTourNo = value;
            }
        }
        public DateTime DateandTime
        {
            get
            {
                return  mDateandTime;
            }
            set
            {
                mDateandTime = value;
            }
        }
        public int PassengerCount
        {
            get
            {
                return mPassengerCount;
            }
            set
            {
                mPassengerCount = value;
            }
        }

        //find function for retrieving tour and customer details
        public Boolean Find(int BookingNo)
        {
            //set the private data members to the test data value
            mBookingNo = 1;

            mCustomerNo = 1;

            mTourNo = 1;

           // mDateandTime = Convert.ToDateTime("01/01/2001");

            mPassengerCount = 1;

            return true;

                ////connect to the database
                //clsDataConnection dBConnection = new clsDataConnection();
                ////add the tour no parameter
                //dBConnection.Execute("dbo.sproc_tblBookings_FilterByBookingNo");
                ////if a record was found
                //if (dBConnection.Count == 1)
                //{
                //    //get the values
                //    mBookingNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["BookingNo"]);
                //    CustomerNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CustomerNo"]);
                //    TourNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TourNo"]);
                //    DateandTime = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateTime"]); 
                //}
                ////return uccess
                //return true;
        }
    }
}