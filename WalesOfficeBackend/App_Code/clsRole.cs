using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsRole
{
    //private member variable for primary key
    private Int32 mRoleID;
    //public property for RoleID
    public Int32 RoleID
    {
        get
        {
            return mRoleID;
        }
        set
        {
            mRoleID = value;
        }
    }

    //private member variable for role
    private string mRole;
    //public property for Role
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
}