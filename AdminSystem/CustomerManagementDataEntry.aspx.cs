using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with page level scope
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the customer to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            //if this is not new record
            if (CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find record to update
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerContactNo.Text = CustomerBook.ThisCustomer.CustomerContactNo;
        txtDeliveryAddr.Text = CustomerBook.ThisCustomer.DeliveryAddr;
        txtCustomerDob.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        chkAccountStatus.Checked = CustomerBook.ThisCustomer.AccountStatus;
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
            //capture the customer no
            ACustomer.CustomerNo = CustomerNo; 
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
            
            //if this is new record i.e. CustomerNo = -1 then add the data
            if (CustomerNo == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerNo);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
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