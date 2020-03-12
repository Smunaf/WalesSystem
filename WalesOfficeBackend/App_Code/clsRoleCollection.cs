using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class clsRoleCollection
{
    //create a connection to the database with class level scope
    clsDataConnection Roles = new clsDataConnection();

    //constructor
    public clsRoleCollection()
    {
        //execute the select all query
        Roles.Execute("sproc_tblRole_SelectAll");
    }

    //this read only function gives us the count property
    public Int32 Count
    {
        get
        {
            //return the count of the data from the database
            return Roles.Count;
        }
    }

    //this readonly function exposes the query results collection
    public List<clsRole> AllRoles
    {
        get
        {
            //create a instance of a list callled mAllFuelTypes
            List<clsRole> mAllRoles = new List<clsRole>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the number of records to process
            while (Index < Roles.Count)
            {
                //set up the new entry to be added to the list
                clsRole NewRole = new clsRole();
                //get the fuel type no from the database
                NewRole.RoleID = Convert.ToInt32(Roles.DataTable.Rows[Index]["RoleID"]);
                //get the fuel type from the database
                NewRole.Role = Convert.ToString(Roles.DataTable.Rows[Index]["Role"]);
                //add the new entry to the list
                mAllRoles.Add(NewRole);
                //increment the index to the next record
                Index++;
            }
            //return the query results from the database
            return mAllRoles;
        }
    }

}