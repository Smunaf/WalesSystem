using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalesClasses
{
    public class clsCustomer
    {
        //private data member for the CustomerNo property
        private Int32 mCustomerNo;
        private string mAddress;
        private DateTime mDOB;
        private string mFirstName;
        private string mSureName;
        private string mEmail;
        private Int32 mTelephone;

        public string Address {
            get
            {
                return mAddress;
            }
                set
            {
                mAddress = value;
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
        public string FirstName {
            get

            {
                return mFirstName;
            }
                set
            {
                mFirstName = value;
            }
               }
        public string SureName {
            get

            {
                return mSureName;
            }
                set
            {
                mSureName = value;
            }
                }
        public int Telephone
        {
            get
            {
                return mTelephone;
            }

                set
            {
                mTelephone = value;
            }
                }

        public string Valid(string FirstName, string SureName, string Address, string DOB, string Email, string Telephone)
        {
            return "";
        }
        public bool Find(int customerNo)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found(there should be either one
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mAddress  = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
               mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSureName = Convert.ToString(DB.DataTable.Rows[0]["SureName"]);
               mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
               mTelephone = Convert.ToInt32(DB.DataTable.Rows[0]["Telephone"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }
    }
}