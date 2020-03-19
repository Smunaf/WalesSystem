using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first appearance of this form
        if (IsPostBack == false)
        {
            //display all users
            DisplayTours("");
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all users
        DisplayTours("");
    }

    Int32 DisplayTours(string TourNameFilter)
    {
        Int32 TourNo; //var to store the primary key
        string TourName; //var to store the first name
        string Location; //var to store the second name
        Decimal Price; // var to store the role
        string AircraftModel;
        clsTourCollection TourRecord = new clsTourCollection(); //create an instance of the user collection class
        TourRecord.ReportByTourName(TourNameFilter);
        Int32 RecordCount; //var to store the count of records
        Int32 Index = 0; //var to store the index for the loop
        RecordCount = TourRecord.Count; //get the count of records
        lstTours.Items.Clear(); //clear the list box
        while (Index < RecordCount) //while there are records to process
        {
            TourNo = TourRecord.TourList[Index].TourNo; //get the primary key
            TourName = TourRecord.TourList[Index].TourName;//get the first name
            Location = TourRecord.TourList[Index].Location;//get the second name
            Price = TourRecord.TourList[Index].Price; //get the role
            AircraftModel = TourRecord.TourList[Index].AircraftModel;
            ListItem NewEntry = new ListItem(TourName + " " + Location + " " + Price + " " + AircraftModel, TourNo.ToString()); //create a new entry for the list box
            lstTours.Items.Add(NewEntry);//move the index to the next record
            Index++;
        }
        return RecordCount;//return the count of records found
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 TourNo;
        //check the list has been clicked first
        if (lstTours.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            TourNo = Convert.ToInt32(lstTours.SelectedValue);
            //redirect to the delete page
            Response.Redirect("Delete.aspx?TourNo=" + TourNo);
        }
        else
        {
            //display an error
            lblError.Text = "You must select an item off the list first to delete it.";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Redirects the user when clicking the delete button to the delete button confirmation screen
        Response.Redirect("Tour.aspx?TourNo=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 TourNo;
        //check the list has been clicked first
        if (lstTours.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            TourNo = Convert.ToInt32(lstTours.SelectedValue);
            //redirect to the editing page
            Response.Redirect("Tour.aspx?TourNo=" + TourNo);
        }
        else
        {
            //display an error
            lblError.Text = "You must select an item off the list first to edit it.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //display only users matching the text in the first name text box
        DisplayTours(txtTourName.Text);
    }
}