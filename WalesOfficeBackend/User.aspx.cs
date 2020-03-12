using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User : System.Web.UI.Page
{
    //var to store the UserID
    Int32 UserID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        UserID = Convert.ToInt32(Request.QueryString["UserID"]);
        if (IsPostBack != true)
        {
            //update the contents of the drop down list
            DisplayRoles();
            //if the UserID is not -1 then display the data from the record
            if (UserID != -1)
            {
                //display the data for this user
                DisplayUsers(UserID);
            }
        }
    }


    //this function displays the data for a user on the web form
    void DisplayUsers(Int32 UsersID)
    {
        //create an instance of the user class
        clsUser UserList = new clsUser();
        //find the record we want to display
        UserList.Find(UserID);
        //display the first name
        txtFirstName.Text = UserList.FirstName;
        //display the second name
        txtSecondName.Text = UserList.SecondName;
        //display the telephone number
        txtTelephoneNumber.Text = UserList.TelephoneNumber.ToString();
        //display the email
        txtEmail.Text = UserList.Email;
        //display the address
        txtAddress.Text = UserList.Address;
        //display the dob
        txtDOB.Text = UserList.DOB.ToShortDateString();
        //display the admin priviledges
        chkAdminPriviledges.Checked = UserList.AdminPriviledges;
        //set the drop down list to display the role
        ddlRole.SelectedValue = Convert.ToString(UserList.Role);
        //set the drop down list to display the role
        ddlRole.SelectedValue = Convert.ToString(UserList.Role);

    }






    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //create an instance of the user page class
        clsUser ThisUser = new clsUser();
        //var to store any error messages
        string ErrorMessage;
        //test the data on the web form
        ErrorMessage = ThisUser.UserValid(txtFirstName.Text,
                                        txtSecondName.Text,
                                        txtDOB.Text,
                                        txtAddress.Text,
                                        txtEmail.Text,
                                        txtTelephoneNumber.Text);
                                        


        //if there is no error message
        if (ErrorMessage == "")
        {
            //create a new instance of the user class
            clsUserCollection UserList = new clsUserCollection();
            //do something with the data - insert or update
            //
            //if the User ID is -1
            if (UserID == -1)
            {
                //copy the data from the interface to the object
                UserList.ThisUser.FirstName = txtFirstName.Text;
                UserList.ThisUser.SecondName = txtSecondName.Text;
                UserList.ThisUser.TelephoneNumber = Convert.ToInt32(txtTelephoneNumber.Text);
                UserList.ThisUser.Email = txtEmail.Text;
                UserList.ThisUser.Address = txtAddress.Text;
                UserList.ThisUser.DOB = Convert.ToDateTime(txtDOB.Text);
                UserList.ThisUser.Role = Convert.ToString(ddlRole.SelectedValue);
                //add the new record
                UserList.Add();
            }
            else
            {
                //this is an exsiting record
                //copy the data from the interface to the object
                UserList.ThisUser.FirstName = txtFirstName.Text;
                UserList.ThisUser.SecondName = txtSecondName.Text;
                UserList.ThisUser.TelephoneNumber = Convert.ToInt32(txtTelephoneNumber.Text);
                UserList.ThisUser.Email = txtEmail.Text;
                UserList.ThisUser.Address = txtAddress.Text;
                UserList.ThisUser.DOB = Convert.ToDateTime(txtDOB.Text);
                UserList.ThisUser.Role = Convert.ToString(ddlRole.SelectedValue);
                //update the existing record
                UserList.Update();
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

    

    //this function is used to populate the role drop down list
    Int32 DisplayRoles()
    {
        //create an instance of the role class
        clsRoleCollection Roles = new clsRoleCollection();
        //var to store the role id primary key
        string RoleID;
        //var to store the name of the role 
        string Role;
        //var to store the index of the loop
        Int32 Index = 0;
        //while the index is less than the number of records to process
        while (Index < Roles.Count)
        {
            //get the role id from the database
            RoleID = Convert.ToString(Roles.AllRoles[Index].RoleID);
            //get the fuel type name from the database
            Role = Convert.ToString(Roles.AllRoles[Index].Role);
            //set up the new row to be added to the list
            ListItem NewRole = new ListItem(Role, RoleID);
            //add the new row to the list
            ddlRole.Items.Add(NewRole);
            //increment the index to the next record
            Index++;
        }
        //return the number of records found
        return Roles.Count;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Redirects the user when clicking the delete button to the delete button confirmation screen
        Response.Redirect("Default.aspx");
    }


}