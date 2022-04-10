using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer contact no
        string CustomerContactNo = txtCustomerContactNo.Text;
        //capture the customer delivery addr
        string DeliveryAddr = txtDeliveryAddr.Text;
        //capture the customer dob
        string CustomerDob = txtCustomerDob.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
        if (Error == "")
        {
            //capture the CustomerName
            ACustomer.CustomerName = CustomerName;
            //capture the CustomerContactNo
            ACustomer.CustomerContactNo = CustomerContactNo;
            //capture the DeliveryAddr
            ACustomer.DeliveryAddr = DeliveryAddr;
            //capture the CustomerDob
            ACustomer.CustomerDob = Convert.ToDateTime(DeliveryAddr);
            //capture the AccountStatus
            ACustomer.AccountStatus = chkAccountStatus.Checked;
            //create new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;
            //add the new record
            CustomerList.Add();
            //redirect back to the listpage
            Response.Redirect("CustomerManagementList.aspx");
        }    
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}