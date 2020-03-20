using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }
    void DisplayCustomers()
    {
        //create an instance of the Customer collection
        WalesClasses.clsCustomerCollection Customer = new WalesClasses.clsCustomerCollection();
        //set the data source to the list of counties in the collection
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerNo";
        //set the data field to display
        lstCustomerList.DataTextField = "FirstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnCustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("Delete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1) 
        {
            //get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the edit page
            Response.Redirect("AnCustomer.aspx");
        }  

        else
        {
            lblError.Text = "Please select a record to Edit from the list";

        }

    }
}