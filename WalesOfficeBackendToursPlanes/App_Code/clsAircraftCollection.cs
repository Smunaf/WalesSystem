using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAircraftCollection
/// </summary>
public class clsAircraftCollection
{
    //create a connection to the database with class level scope
    clsDataConnection Aircrafts = new clsDataConnection();

    //constructor
    public clsAircraftCollection()
    {
        //execute the select all query
        Aircrafts.Execute("sproc_tblAircraft_SelectAll");
    }

    //this read only function gives us the count property
    public Int32 Count
    {
        get
        {
            //return the count of the data from the database
            return Aircrafts.Count;
        }
    }

    //this readonly function exposes the query results collection
    public List<clsAircraft> AllAircrafts
    { 
        get
        {
            //create a instance of a list callled mAllFuelTypes
            List<clsAircraft> mAllAircrafts = new List<clsAircraft>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the number of records to process
            while (Index < Aircrafts.Count)
            {
                //set up the new entry to be added to the list
                clsAircraft NewAircraft = new clsAircraft();
                //get the fuel type no from the databasea
                NewAircraft.AircraftNo = Convert.ToInt32(Aircrafts.DataTable.Rows[Index]["AircraftNo"]);
                //get the fuel type from the database
                NewAircraft.AircraftModel = Convert.ToString(Aircrafts.DataTable.Rows[Index]["AircraftModel"]);
                //add the new entry to the list
                mAllAircrafts.Add(NewAircraft);
                //increment the index to the next record
                Index++;
            }
            //return the query results from the database
            return mAllAircrafts;
        }
    }
}