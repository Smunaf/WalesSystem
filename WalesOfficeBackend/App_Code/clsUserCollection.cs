using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsUserCollection
/// </summary>
public class clsUserCollection
{
    public clsUserCollection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    clsDataConnection dBConnection = new clsDataConnection(); //create a connection to the database
    //member var for current user
    clsUser mThisUser = new clsUser();

    //public ThisUser property
    public clsUser ThisUser
    {
        get
        {
            return mThisUser;
        }
        set
        {
            mThisUser = value;
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
            MyDatabase.AddParameter("@UserID", mThisUser.UserID);
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

    public List<clsUser> UserList
    {

        get
        {
            //create an array list of type clsUserPage
            List<clsUser> mUserList = new List<clsUser>();
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
                clsUser NewUser = new clsUser();
                //copy the data from the table to the RAM
                NewUser.UserID = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["UserID"]);
                NewUser.FirstName = Convert.ToString(dBConnection.DataTable.Rows[Index]["FirstName"]);
                NewUser.SecondName = Convert.ToString(dBConnection.DataTable.Rows[Index]["SecondName"]);
                NewUser.Role = Convert.ToString(dBConnection.DataTable.Rows[Index]["Role"]);
                NewUser.Address = Convert.ToString(dBConnection.DataTable.Rows[Index]["Address"]);
                NewUser.Email = Convert.ToString(dBConnection.DataTable.Rows[Index]["Email"]);
                NewUser.DOB = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["DOB"]);
                NewUser.TelephoneNumber = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["TelephoneNumber"]);
                NewUser.AdminPrivileges = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["AdminPrivileges"]);
                //add the blank page to the array list
                mUserList.Add(NewUser);
                //increase the index
                Index++;
            }
            return mUserList;
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
        clsDataConnection NewDBUser = new clsDataConnection();
        //add the parameters
        NewDBUser.AddParameter("@FirstName", mThisUser.FirstName);
        NewDBUser.AddParameter("@SecondName", mThisUser.SecondName);
        NewDBUser.AddParameter("@Role", mThisUser.Role);
        NewDBUser.AddParameter("@Address", mThisUser.Address);
        NewDBUser.AddParameter("@Email", mThisUser.Email);
        NewDBUser.AddParameter("@DOB", mThisUser.DOB);
        NewDBUser.AddParameter("@TelephoneNumber", mThisUser.TelephoneNumber);
        NewDBUser.AddParameter("@AdminPrivileges", mThisUser.AdminPrivileges);
        //execute the stored procedure returning the primary key value of the new record
        return NewDBUser.Execute("sproc_tblUsers_Insert");
    }

    public void Update()
    {
        ///this function will update an existing user in the database
        ///it accepts a single parameter an object of type clsUserPage
        ///this UserID
        ///property must have a valid value for this to work
      
        //connect to the database
        clsDataConnection ExistingDBUser = new clsDataConnection();
        //add the parameters
        ExistingDBUser.AddParameter("@FirstName", mThisUser.FirstName);
        ExistingDBUser.AddParameter("@SecondName", mThisUser.SecondName);
        ExistingDBUser.AddParameter("@Role", mThisUser.Role);
        ExistingDBUser.AddParameter("@Address", mThisUser.Address);
        ExistingDBUser.AddParameter("@Email", mThisUser.Email);
        ExistingDBUser.AddParameter("@DOB", mThisUser.DOB);
        ExistingDBUser.AddParameter("@TelephoneNumber", mThisUser.TelephoneNumber);
        ExistingDBUser.AddParameter("@AdminPrivileges", mThisUser.AdminPrivileges);
        ExistingDBUser.AddParameter("@UserID", mThisUser.UserID);

        //execute the query
        ExistingDBUser.Execute("sproc_tblUsers_Update");
    }

    ///this function defines the ReportByFirstName method
    public void ReportByFirstName(string FirstName)
    ///it accepts a single parameter FirstName and returns no value
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter data used by the stored procedure
        dBConnection.AddParameter("@FirstName", FirstName);
        //execute the store procedure to delete the user
        dBConnection.Execute("sproc_tblUsers_FilterByFirstName");
    }


}