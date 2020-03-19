using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAircraft
/// </summary>
public class clsAircraft
{
    //private member variable for primary key
    private Int32 mAircraftNo;
    //public property for RoleID
    public Int32 AircraftNo
    {
        get
        {
            return mAircraftNo;
        }
        set
        {
            mAircraftNo = value;
        }
    }

    //private member variable for role
    private string mAircraftModel;
    //public property for Role
    public string AircraftModel
    {
        get
        {
            return mAircraftModel;
        }
        set
        {
            mAircraftModel = value;
        }
    }
}