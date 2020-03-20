using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalesClasses;

public partial class Delete : System.Web.UI.Page
{
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }
    void DeleteCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerNo);
        CustomerBook.Delete();
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}