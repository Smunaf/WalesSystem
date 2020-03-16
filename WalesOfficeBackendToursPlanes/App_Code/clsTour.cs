using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsUser
/// </summary>
public class clsTour
{
    private Int32 mTourNo;

    public Int32 TourNo
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

    private string mTourName;

    public string TourName
    {
        get
        {
            return mTourName;
        }
        set
        {
            mTourName = value;
        }
    }

    private string mLocation;

    public string Location
    {
        get
        {
            return mLocation;
        }
        set
        {
            mLocation = value;
        }
    }


    private DateTime mDate;

    public DateTime Date
    {
        get
        {
            return mDate;
        }
        set
        {
            mDate = value;
        }
    }

    private DateTime mDepartureTime;

    public DateTime DepartureTime
    {
        get
        {
            return mDepartureTime;
        }
        set
        {
            mDepartureTime = value;
        }
    }

    private Int32 mCapacity;

    public Int32 Capacity
    {
        get
        {
            return mCapacity;
        }
        set
        {
            mCapacity = value;
        }
    }

    private decimal mPrice;

    public decimal Price
    {
        get
        {
            return mPrice;
        }
        set
        {
            mPrice = value;
        }
    }

    
    private Boolean mTourGuide;

    public Boolean TourGuide
    {
        get
        {
            return mTourGuide;
        }
        set
        {
            mTourGuide = value;
        }
    }


    public string UserValid(string TourName,
                           string Location,
                           string Date,
                           string Departure,
                           string Capacity,
                           string Price)


    ///this fuction is used to validate the data in a new user
    ///it accepts six parameters and returns a string containing the text of the erros (if any)
    ///otherwise of no errors it returns a blank string 


    {
        string ErrorMessage; //var to store any error message
        ErrorMessage = ""; //initialise the var with a blank string
                           //if the string is less than 1 char or more than 6


        if (TourName.Length < 1 | TourName.Length > 20)
        {
            //record an error
            ErrorMessage = ErrorMessage + "Tour Name must be between 1 and 20 characters, ";
        }


        //try
        //{
        //    Decimal temp;
        //    temp = Convert.ToDecimal(Price);

        //    if (temp < 1000.00m | temp > 1300000.00m)
        //    {
        //        ErrorMessage = ErrorMessage + "Price must be between 1000 and 1300000, ";
        //    }
        //}
        //catch
        //{
        //    ErrorMessage = ErrorMessage + "Price was not in the correct format, format needs to be decimal, ";
        //}

        //try
        //{
        //    Int32 temp;
        //    temp = Convert.ToInt32(Mileage);

        //    if (temp < 100 | temp > 200000)
        //    {
        //        ErrorMessage = ErrorMessage + "Mileage must be between 100 and 200000, ";
        //    }
        //}
        //catch
        //{
        //    ErrorMessage = ErrorMessage + "Mileage was not in the correct format, format needs to be integer, ";
        //}

        //try
        //{
        //    DateTime temp; //var to store the date
        //    temp = Convert.ToDateTime(ManufactureDate); //assign the date to the temporary var
        //}
        //catch
        //{
        //    ErrorMessage = ErrorMessage + "Manufacture Date was not in the correct format, format needs to be Date, ";
        //}

        //if (CarManufacturer.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Car Manufacturer cannot be blank, ";
        //}

        //if (CarManufacturer.Length < 3 | CarManufacturer.Length > 15)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Car Manufacturer must be between 3 and 15 characters, ";
        //}

        //if (ManufactureDate.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Manufacture Date cannot be blank, ";
        //}

        //if (ManufactureDate.Length < 10 | ManufactureDate.Length > 10)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Manufacture Date must be in a date format as shown in the example of '01/01/2001' being 10 characters long in total, ";
        //}


        //if (CarModel.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Car Model cannot be blank, ";
        //}

        //if (CarModel.Length < 2 | CarModel.Length > 15)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Car Model must be between 2 and 15 characters, ";
        //}


        //if (Price.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Price cannot be blank, ";
        //}

        //if (Price.Length < 7 | Price.Length > 10)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Price must be between 7 and 10 characters, ";
        //}

        //if (Colour.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Colour cannot be blank, ";
        //}

        //if (Colour.Length < 3 | Colour.Length > 12)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Colour must be between 3 and 12 characters, ";
        //}

        //if (Mileage.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Mileage cannot be blank, ";
        //}

        //if (Mileage.Length < 3 | Mileage.Length > 6)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Mileage must be between 3 and 6 characters, ";
        //}

        //if (NoOfSeats.Length == 0)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Number of Seats cannot be blank, ";
        //}

        //if (NoOfSeats.Length < 1 | NoOfSeats.Length > 1)
        //{
        //    //record an error
        //    ErrorMessage = ErrorMessage + "Number of Seats must only be 1 character long, ";
        //}


        //if there were no errors
        if (ErrorMessage == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrorMessage;
        }



    }


    //function for the find public method
    public Boolean Find(Int32 TourNo)
    {
        //initalise the DBConnection
        clsDataConnection dBConnection = new clsDataConnection();
        //add the car id paramater
        dBConnection.AddParameter("@TourNo", TourNo);
        //execute the query
        dBConnection.Execute("sproc_tblTours_FilterByTourName");
        //if the record was found
        if (dBConnection.Count == 1)
        {
            //get the user id
            mTourNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TourNo"]);
            //get the first name
            mTourName = Convert.ToString(dBConnection.DataTable.Rows[0]["TourName"]);
            //get the second name
            mLocation = Convert.ToString(dBConnection.DataTable.Rows[0]["Location"]);
            //get the telephone number
            mDate = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["Date"]);
            //get the role
            mDepartureTime = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DepartureTime"]);
            //get the email
            mCapacity = Convert.ToInt32(dBConnection.DataTable.Rows[0]["Capacity"]);
            //get the price
            mPrice = Convert.ToDecimal(dBConnection.DataTable.Rows[0]["Price"]);
            //get the tourguide
            try
            {
                mTourGuide = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["TourGuide"]);
            }
            catch
            {
                mTourGuide = true;
            }
            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }

    }
}
