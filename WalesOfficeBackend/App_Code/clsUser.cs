using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsUser
/// </summary>
public class clsUser
{
    private Int32 mUserID;

    public Int32 UserID
    {
        get
        {
            return mUserID;
        }
        set
        {
            mUserID = value;
        }
    }

    private string mFirstName;

    public string FirstName
    {
        get
        {
            return mFirstName;
        }
        set
        {
            mFirstName = value;
        }
    }

    private string mSecondName;

    public string SecondName
    {
        get
        {
            return mSecondName;
        }
        set
        {
            mSecondName = value;
        }
    }


    private string mRole;

    public string Role
    {
        get
        {
            return mRole;
        }
        set
        {
            mRole = value;
        }
    }

    private string mAddress;

    public string Address
    {
        get
        {
            return mAddress;
        }
        set
        {
            mAddress = value;
        }
    }

    private string mEmail;

    public string Email
    {
        get
        {
            return mEmail;
        }
        set
        {
            mEmail = value;
        }
    }

    private DateTime mDOB;

    public DateTime DOB
    {
        get
        {
            return mDOB;
        }
        set
        {
            mDOB = value;
        }
    }

    private Int32 mTelephoneNumber;

    public Int32 TelephoneNumber 
    {
        get
        {
            return mTelephoneNumber;
        }
        set
        {
            mTelephoneNumber = value;
        }
    }

    private Boolean mAdminPriviledges;

    public Boolean AdminPriviledges
    {
        get
        {
            return mAdminPriviledges;
        }
        set
        {
            mAdminPriviledges = value;
        }
    }


    public string UserValid(string FirstName,
                           string SecondName,
                           string DOB,
                           string Address,
                           string Email,
                           string TelephoneNumber)


    ///this fuction is used to validate the data in a new user
    ///it accepts six parameters and returns a string containing the text of the erros (if any)
    ///otherwise of no errors it returns a blank string 


    {
        string ErrorMessage; //var to store any error message
        ErrorMessage = ""; //initialise the var with a blank string
                           //if the string is less than 1 char or more than 6


        if (FirstName.Length < 1 | FirstName.Length > 20)
            {
                //record an error
                ErrorMessage = ErrorMessage + "First Name must be between 1 and 20 characters, ";
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
    public Boolean Find(Int32 UserID)
    {
        //initalise the DBConnection
        clsDataConnection dBConnection = new clsDataConnection();
        //add the car id paramater
        dBConnection.AddParameter("@UserID", UserID);
        //execute the query
        dBConnection.Execute("sproc_tblUsers_FilterByUserID");
        //if the record was found
        if (dBConnection.Count == 1)
        {
            //get the user id
            mUserID = Convert.ToInt32(dBConnection.DataTable.Rows[0]["UserID"]);
            //get the first name
            mFirstName = Convert.ToString(dBConnection.DataTable.Rows[0]["FirstName"]);
            //get the second name
            mSecondName = Convert.ToString(dBConnection.DataTable.Rows[0]["SecondName"]);
            //get the telephone number
            mTelephoneNumber = Convert.ToInt32(dBConnection.DataTable.Rows[0]["TelephoneNumber"]);
            //get the role
            mRole = Convert.ToString(dBConnection.DataTable.Rows[0]["Role"]);
            //get the email
            mEmail = Convert.ToString(dBConnection.DataTable.Rows[0]["Email"]);
            //get the dob
            mDOB = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DOB"]);
            //get the address
            mAddress = Convert.ToString(dBConnection.DataTable.Rows[0]["Address"]);
            //get the admin priviledges
            try
            {
                mAdminPriviledges = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["AdminPriviledges"]);
            }
            catch
            {
                mAdminPriviledges = true;
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
