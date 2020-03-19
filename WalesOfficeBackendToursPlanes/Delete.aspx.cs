using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the text box txtUserID
        TourNo = Convert.ToInt32(Request.QueryString["TourNo"]);
    }

    Int32 TourNo;


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //this function handles the click event of the yes button

        //create an instance of the class clsUserCollection called ThisUser
        clsTourCollection TourList = new clsTourCollection();
        //declare a boolean variable for found
        Boolean Found;
        //try and find the record to delete
        Found = TourList.ThisTour.Find(TourNo);
        //if the record is found
        if (Found)
        {
            //invoke the delete method of the object
            TourList.Delete();
        }
        Response.Redirect("Default.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirects the user from the confirm delete page back to the main page
        Response.Redirect("Default.aspx");
    }
}