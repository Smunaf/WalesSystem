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
            DisplayUsers("");
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 UserID;
        //check the list has been clicked first
        if (lstUsers.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            UserID = Convert.ToInt32(lstUsers.SelectedValue);
            //redirect to the delete page
            Response.Redirect("Delete.aspx?UserID=" + UserID);
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
        Response.Redirect("User.aspx?UserID=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 UserID;
        //check the list has been clicked first
        if (lstUsers.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            UserID = Convert.ToInt32(lstUsers.SelectedValue);
            //redirect to the editing page
            Response.Redirect("User.aspx?UserID=" + UserID);
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
        DisplayUsers(txtFirstName.Text);
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all users
        DisplayUsers("");
    }

    Int32 DisplayUsers(string FirstNameFilter)
    {
        Int32 UserID; //var to store the primary key
        string FirstName; //var to store the first name
        string SecondName; //var to store the second name
        string Role; // var to store the role
        clsUserCollection UserRecord = new clsUserCollection(); //create an instance of the user collection class
        UserRecord.ReportByFirstName(FirstNameFilter);
        Int32 RecordCount; //var to store the count of records
        Int32 Index = 0; //var to store the index for the loop
        RecordCount = UserRecord.Count; //get the count of records
        lstUsers.Items.Clear(); //clear the list box
        while (Index < RecordCount) //while there are records to process
        {
            UserID = UserRecord.UserList[Index].UserID; //get the primary key
            FirstName = UserRecord.UserList[Index].FirstName;//get the first name
            SecondName = UserRecord.UserList[Index].SecondName;//get the second name
            Role = UserRecord.UserList[Index].Role; //get the role
            ListItem NewEntry = new ListItem(FirstName + " " + SecondName + " " + Role, UserID.ToString()); //create a new entry for the list box
            lstUsers.Items.Add(NewEntry);//move the index to the next record
            Index++;
        }
        return RecordCount;//return the count of records found
    }

}