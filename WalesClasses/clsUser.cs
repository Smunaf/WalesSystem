
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WalesClasses;

namespace WalesClasses
{
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

        private Boolean mAdminPrivileges;

        public Boolean AdminPrivileges
        {
            get
            {
                return mAdminPrivileges;
            }
            set
            {
                mAdminPrivileges = value;
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
                //get the admin Privileges
                try
                {
                    mAdminPrivileges = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["AdminPrivileges"]);
                }
                catch
                {
                    mAdminPrivileges = true;
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



}

