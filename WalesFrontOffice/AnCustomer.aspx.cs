using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalesClasses;


public partial class AnCustomer : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            
            if (CustomerNo != -1)
            {
                DisplayCustomer();

            }

        }
    }

    

    void DisplayCustomer()
    {
        //create an instance ofthe customer book 
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update 
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //display the record to update 
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtSureName.Text = CustomerBook.ThisCustomer.SureName;
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtdob.Text = CustomerBook.ThisCustomer.DOB.ToString();
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        txtTelephone.Text = CustomerBook.ThisCustomer.Telephone.ToString();

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerNo == -1)
        {


            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    void Add()
    {
        WalesClasses.clsCustomerCollection CustomerBook = new WalesClasses.clsCustomerCollection();
        //validate the data on the web form
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtSureName.Text, txtAddress.Text, txtdob.Text, txtEmail.Text, txtTelephone.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.SureName = txtSureName.Text;
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.DOB = Convert.ToDateTime(txtdob.Text);
            CustomerBook.ThisCustomer.Email = txtEmail.Text;
            CustomerBook.ThisCustomer.Telephone = Convert.ToInt32(txtTelephone.Text);
            //add the record
            CustomerBook.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
    void Update()
    {
        WalesClasses.clsCustomerCollection CustomerBook = new WalesClasses.clsCustomerCollection();
        //validate the data on the web form
        string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtSureName.Text, txtAddress.Text, txtdob.Text, txtEmail.Text, txtTelephone.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerNo);
            //get the data entered by the user
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.SureName = txtSureName.Text;
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.DOB = Convert.ToDateTime(txtdob.Text);
            CustomerBook.ThisCustomer.Email = txtEmail.Text;
            CustomerBook.ThisCustomer.Telephone = Convert.ToInt32(txtTelephone.Text);
            //Update the record
            CustomerBook.Update();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
        void DisplayCustomer()
        {
            //create an instance of the Customer
            clsCustomerCollection Customer = new clsCustomerCollection();
            //find the record to update
            Customer.ThisCustomer.Find(CustomerNo);
            //display the data for this record
            txtFirstName.Text = Customer.ThisCustomer.FirstName;
            txtSureName.Text = Customer.ThisCustomer.SureName;
            txtAddress.Text = Customer.ThisCustomer.Address;
            txtdob.Text = Customer.ThisCustomer.DOB.ToString();
            txtEmail.Text = Customer.ThisCustomer.Email;
            txtTelephone.Text = Customer.ThisCustomer.Telephone.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}