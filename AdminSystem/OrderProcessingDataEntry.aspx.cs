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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder 
        clsOrder theOrder = new clsOrder();
        //capture the OrderId
       theOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the Product ID
      theOrder.ProductID = Convert.ToInt32(txtProductID.Text);
        //capture the Total Product
       theOrder.TotalProduct = Convert.ToInt32(txtTotalProduct.Text);
        //capture the OrderIsPaid
        theOrder.OrderIsPaid = Convert.ToBoolean(chkOrderIsPaid.Checked);
        //capture the OrderIsPaid
       theOrder.OrderCreationDate = Convert.ToDateTime(txtOrderCreationDate.Text);
        //capture the OrderName
        theOrder.OrderName = txtOrderName.Text;
        //get the data from the session object
        Session["theOrder"] = theOrder;
        //naviget to the viewer page 
        Response.Redirect("OrderProcessingViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Order class
        clsOrder theOrder = new clsOrder();
        //variable to store primary key
        Int32 OrderId;
        //variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key enterd bu the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = theOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 

            txtProductID.Text = theOrder.ProductID.ToString();
            txtTotalProduct.Text = theOrder.TotalProduct.ToString();
           // txtOrderIsPaid.Text = theOrder.OrderIsPaid.ToString();
            txtOrderCreationDate.Text = theOrder.OrderCreationDate.ToString();
            txtOrderName.Text = theOrder.OrderName;
            
           

        }
    }
}
