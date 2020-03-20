
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
                return mDateandTime;
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
            //connect to the database
            clsDataConnection dBConnection = new clsDataConnection();
            //add the tour no parameter
            dBConnection.AddParameter("@BookingNo", BookingNo);
            //execute the sproc 
            dBConnection.Execute("sproc_tblBooking_FilterByBookingNo");
            //if a record was found
            if (dBConnection.Count == 1)
            {
                //get the values
                mBookingNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["BookingNo"]);
                mCustomerNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CustomerNo"]);
                mTourNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TourNo"]);
                mDateandTime = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateTime"]);
                mPassengerCount = Convert.ToInt32(dBConnection.DataTable.Rows[0]["PassengerCount"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        

        //validation function for new booking data and delivering error msg
        public string BookingValid(string CustomerNo,
                                   string TourNo,
                                   string DateandTime,
                                   string PassengerCount)
        {
            //variable to store error message
            string ErrorMessage;
            //initialised with a blank string
            ErrorMessage = "";
            if (CustomerNo.Length < 1 | CustomerNo.Length > 10)
            {
                //error
                ErrorMessage = ErrorMessage + "Customer Number cannot be longer than 10 digits";
            }
            try
            {
                Int32 temp;
                temp = Convert.ToInt32(TourNo);
                if (temp < 1 | temp > 10)
                {
                    ErrorMessage = ErrorMessage + "Tour Number cannot be longer than 10 digits";
                }
            }
            catch
            {
                ErrorMessage = ErrorMessage + "Tour Number: Incorrect Formart. Must be Integer";
            }
            try
            {
                DateTime temp;
                temp = Convert.ToDateTime(DateandTime);
            }
            catch
            {
                ErrorMessage = ErrorMessage + "Date and Time : Incorrect Format. Must be dd/mm/yyyy";
            }
            try
            {
                Int32 temp;
                temp = Convert.ToInt32(PassengerCount);
                if (temp < 1 | temp > 1)
                {
                    ErrorMessage = ErrorMessage + "Passenger Count : Incorrect. Cannot exceed 6 passengers";
                }
            }
            catch
            {
                ErrorMessage = ErrorMessage + "Passenger Count : Incorrect. Must be Integer";
            }

            //if no errors
            if (ErrorMessage == "")
            {
                return "";
            }
            else
            {
                return "Error List : " + ErrorMessage;
            }
        }
    }
}