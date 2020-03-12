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
        UserID = Convert.ToInt32(Request.QueryString["UserID"]);
    }

    Int32 UserID;







    protected void btnYes_Click(object sender, EventArgs e)
    {
        //this function handles the click event of the yes button

        //create an instance of the class clsUserCollection called ThisUser
        clsUserCollection UserList = new clsUserCollection();
        //declare a boolean variable for found
        Boolean Found;
        //try and find the record to delete
        Found = UserList.ThisUser.Find(UserID);
        //if the record is found
        if (Found)
        {
            //invoke the delete method of the object
            UserList.Delete();
        }
        Response.Redirect("Default.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirects the user from the confirm delete page back to the main page
        Response.Redirect("Default.aspx");
    }
}