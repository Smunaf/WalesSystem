using System;
using System.Collections.Generic;

namespace WalesClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }

            set
            {
                //we shall worry about this later
            }

        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DOB", mThisCustomer.DOB);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SureName", mThisCustomer.SureName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Telephone", mThisCustomer.Telephone);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public int Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DOB", mThisCustomer.DOB);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SureName", mThisCustomer.SureName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Telephone", mThisCustomer.Telephone);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
        

        public clsCustomerCollection()
        {
            //var for the class
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount = 0;
            //object for the data 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored precedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the arrary list with the data table
            PopulateArray(DB);
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                //copy the data from the table to the RAM
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.SureName = Convert.ToString(DB.DataTable.Rows[Index]["SureName"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Telephone = Convert.ToInt32(DB.DataTable.Rows[Index]["Telephone"]);
                //add the blank page to the array list
                mCustomerList.Add(AnCustomer);
                //increase the Index
                Index++;
            }
        }
        public void ReportByAddress(string Address)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Address", Address);
            DB.Execute("sproc_tblCustomer_FilterByAddress");
        }
        void PopulateArray(clsDataConnection DB)
        {
            //var for the class
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count;
            //execute the stored precedure
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                //copy the data from the table to the RAM
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.SureName = Convert.ToString(DB.DataTable.Rows[Index]["SureName"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Telephone = Convert.ToInt32(DB.DataTable.Rows[Index]["Telephone"]);
                //add the blank page to the array list
                mCustomerList.Add(AnCustomer);
                //increase the Index
                Index++;
            }
        }


    }
}
