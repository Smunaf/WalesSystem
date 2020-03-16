using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsTourCollection
/// </summary>
public class clsTourCollection
{
    public clsTourCollection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    clsDataConnection dBConnection = new clsDataConnection(); //create a connection to the database
    //member var for current user
    clsTour mThisTour = new clsTour();

    //public ThisUser property
    public clsTour ThisTour
    {
        get
        {
            return mThisTour;
        }
        set
        {
            mThisTour = value;
        }
    }



    public Boolean Delete()
    {
        //this public function provides the functionality for the delete method

        try //try to delete the record
        {
            //create an instance of the data connection class called MyDatabase
            clsDataConnection MyDatabase = new clsDataConnection();
            //add the UserID parameter passed to this function to the list of parameters to use in the database
            MyDatabase.AddParameter("@TourNo", mThisTour.TourNo);
            //execute the stored procedure in the database
            MyDatabase.Execute("sproc_tblUsers_Delete");
            //set the return value for the function

            return true;
        }
        catch
        {
            //report back that there was an error
            return false;
        }
    }

    public List<clsTour> TourList
    {

        get
        {
            //create an array list of type clsUserPage
            List<clsTour> mTourList = new List<clsTour>();
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = dBConnection.Count;
            //keep looping till all records are processed
            while (Index < RecordCount)
            {
                //create a blank user page
                clsTour NewTour = new clsTour();
                //copy the data from the table to the RAM
                NewTour.TourNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["UserID"]);
                NewTour.TourName = Convert.ToString(dBConnection.DataTable.Rows[0]["TourName"]);
                NewTour.Location = Convert.ToString(dBConnection.DataTable.Rows[0]["Location"]);
                NewTour.Date = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["Date"]);
                NewTour.DepartureTime = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DepartureTime"]);
                NewTour.Capacity = Convert.ToInt32(dBConnection.DataTable.Rows[0]["Capacity"]);
                NewTour.Price = Convert.ToDecimal(dBConnection.DataTable.Rows[0]["Price"]);
                //NewUser.TourGuide = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["TourGuide"]);
                //add the blank page to the array list
                mTourList.Add(NewTour);
                //increase the index
                Index++;
            }
            return mTourList;
        }
    }


    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
            //return the count of records
            return dBConnection.Count;
        }
    }

    public Int32 Add()
    ///this function will add a new user to the database
    ///it accepts a single parameter an object of type clsUser
    ///once the record is added the function returns the primary key value of the new record

    {
        //connect to the database
        clsDataConnection NewDBTour = new clsDataConnection();
        //add the parameters
        NewDBTour.AddParameter("@TourName", mThisTour.TourName);
        NewDBTour.AddParameter("@Location", mThisTour.Location);
        NewDBTour.AddParameter("@Date", mThisTour.Date);
        NewDBTour.AddParameter("@DepartureTime", mThisTour.DepartureTime);
        NewDBTour.AddParameter("@Capacity", mThisTour.Capacity);
        NewDBTour.AddParameter("@Price", mThisTour.Price);
        NewDBTour.AddParameter("@TourGuide", mThisTour.TourGuide);
        //execute the stored procedure returning the primary key value of the new record
        return NewDBTour.Execute("sproc_tblUsers_Insert");
    }

    public void Update()
    {
        ///this function will update an existing user in the database
        ///it accepts a single parameter an object of type clsUserPage
        ///this UserID
        ///property must have a valid value for this to work

        //connect to the database
        clsDataConnection ExistingDBTour = new clsDataConnection();
        //add the parameters
        ExistingDBTour.AddParameter("@TourName", mThisTour.TourName);
        ExistingDBTour.AddParameter("@Location", mThisTour.Location);
        ExistingDBTour.AddParameter("@Date", mThisTour.Date);
        ExistingDBTour.AddParameter("@DepartureTime", mThisTour.DepartureTime);
        ExistingDBTour.AddParameter("@Capacity", mThisTour.Capacity);
        ExistingDBTour.AddParameter("@Price", mThisTour.Price);
        ExistingDBTour.AddParameter("@TourGuide", mThisTour.TourGuide);
        //execute the query
        ExistingDBTour.Execute("sproc_tblUsers_Update");
    }

    ///this function defines the ReportByFirstName method
    public void ReportByTourName(string TourName)
    ///it accepts a single parameter FirstName and returns no value
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter data used by the stored procedure
        dBConnection.AddParameter("@TourName", TourName);
        //execute the store procedure to delete the user
        dBConnection.Execute("sproc_tblUsers_FilterByFirstName");
    }


}
