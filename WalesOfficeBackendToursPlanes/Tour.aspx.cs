using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tour : System.Web.UI.Page
{
    Int32 TourNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        TourNo = Convert.ToInt32(Request.QueryString["TourNo"]);
        if (IsPostBack != true)
        {
            //update the contents of the drop down list
            DisplayAircrafts();
            //if the UserID is not -1 then display the data from the record
                if (TourNo != -1)
                {
                    //display the data for this user
                    DisplayTours(TourNo);
                }
         }

    }

    //this function displays the data for a user on the web form
    void DisplayTours(Int32 TourNo)
    {
        //create an instance of the user class
        clsTour TourList = new clsTour();
        //find the record we want to display
        TourList.Find(TourNo);
        //display the first name
        txtTourName.Text = TourList.TourName;
        //display the second name
        txtLocation.Text = TourList.Location;
        //display the telephone number
        txtDate.Text = TourList.Date.ToShortDateString();
        //display the email
        txtDeparture.Text = TourList.DepartureTime.ToShortTimeString();
        //display the address
        txtCapacity.Text = TourList.Capacity.ToString();
        //display the dob
        txtPrice.Text = TourList.Price.ToString();
        //display the admin priviledges
        chkTourGuide.Checked = TourList.TourGuide;
       
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //create an instance of the user page class
        clsTour ThisTour = new clsTour();
        //var to store any error messages
        string ErrorMessage;
        //test the data on the web form
        ErrorMessage = ThisTour.UserValid(txtTourName.Text,
                                        txtLocation.Text,
                                        txtDate.Text,
                                        txtDeparture.Text,
                                        txtCapacity.Text,
                                        txtPrice.Text);



        //if there is no error message
        if (ErrorMessage == "")
        {
            //create a new instance of the user class
            clsTourCollection TourList = new clsTourCollection();
            //do something with the data - insert or update
            //
            //if the User ID is -1
            if (TourNo == -1)
            {
                //copy the data from the interface to the object
                TourList.ThisTour.TourName = txtTourName.Text;
                TourList.ThisTour.Location = txtLocation.Text;
                TourList.ThisTour.Date = Convert.ToDateTime(txtDate.Text);
                TourList.ThisTour.DepartureTime = Convert.ToDateTime(txtDeparture.Text);
                TourList.ThisTour.Capacity = Convert.ToInt32(txtCapacity.Text);
                TourList.ThisTour.Price = Convert.ToDecimal(txtPrice.Text);
                TourList.ThisTour.AircraftModel = Convert.ToString(ddlAircraft.SelectedValue);
                //add the new record
                TourList.Add();
            }
            else
            {
                //copy the data from the interface to the object
                TourList.ThisTour.TourName = txtTourName.Text;
                TourList.ThisTour.Location = txtLocation.Text;
                TourList.ThisTour.Date = Convert.ToDateTime(txtDate.Text);
                TourList.ThisTour.DepartureTime = Convert.ToDateTime(txtDeparture.Text);
                TourList.ThisTour.Capacity = Convert.ToInt32(txtCapacity.Text);
                TourList.ThisTour.Price = Convert.ToDecimal(txtPrice.Text);
                TourList.ThisTour.AircraftModel = Convert.ToString(ddlAircraft.SelectedValue);
                //add the new record
                TourList.Update();
            }
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = ErrorMessage;

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Redirects the user when clicking the delete button to the delete button confirmation screen
        Response.Redirect("Default.aspx");
    }

    //this function is used to populate the role drop down list
    Int32 DisplayAircrafts()
    {
        //create an instance of the role class
        clsAircraftCollection Aircrafts = new clsAircraftCollection();
        //var to store the role id primary key
        string AircraftNo;
        //var to store the name of the role 
        string AircraftModel;
        //var to store the index of the loop
        Int32 Index = 0;
        //while the index is less than the number of records to process
        while (Index < Aircrafts.Count)
        {
            //get the role id from the database
            AircraftNo = Convert.ToString(Aircrafts.AllAircrafts[Index].AircraftNo);
            //get the fuel type name from the database
            AircraftModel = Convert.ToString(Aircrafts.AllAircrafts[Index].AircraftModel);
            //set up the new row to be added to the list
            ListItem NewAircraft = new ListItem(AircraftModel, AircraftNo);
            //add the new row to the list
            ddlAircraft.Items.Add(NewAircraft);
            //increment the index to the next record
            Index++;
        }
        //return the number of records found
        return Aircrafts.Count;
    }
}