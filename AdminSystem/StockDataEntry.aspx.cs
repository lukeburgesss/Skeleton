using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductId != -1)
            {
                //display the current data
                DisplayStock();
            }
        }

    }

    private void DisplayStock()
    {
        //create an instance of the class we want to create
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        Stock.ThisStock.Find(ProductId);
        //display the data for this record
        txtProductName.Text = Stock.ThisStock.ProductName;
        chkInStock.Checked = Stock.ThisStock.InStock;
        txtProductQuantity.Text = Stock.ThisStock.ProductQuantity.ToString();
        txtLastAdjustment.Text = Stock.ThisStock.LastAdjustment.ToString();
        txtColour.Text = Stock.ThisStock.Colour;
        txtPrice.Text = Stock.ThisStock.Price.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creates  anew instance of clsStock
        clsStock theStock = new clsStock();
        //capture the Product Name
        string ProductName = txtProductName.Text;
        //captures the Product Quantity
        string ProductQuantity = txtProductQuantity.Text;
        //captures the Last Adjustment
        string LastAdjustment = txtLastAdjustment.Text;
        //captures the Colour
        string Colour = txtColour.Text;
        //captures the Price
        string Price = txtPrice.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = theStock.Valid(ProductName, LastAdjustment, Colour);
        if (Error == "")
        {
            //capures the Product Id
            theStock.ProductId = ProductId;
            //captures the Product Name
            theStock.ProductName = ProductName;
            //captures the In Stock
            theStock.InStock = chkInStock.Checked;
            //captures the Product Quantity
            theStock.ProductQuantity = Convert.ToInt32(ProductQuantity);
            //captures the Last Adjustment
            theStock.LastAdjustment = Convert.ToDateTime(LastAdjustment);
            //captures the Colour
            theStock.Colour = Colour;
            //captures the Price
            theStock.Price = Convert.ToDouble(Price);
            //creates a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record then add data
            if (ProductId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = theStock;
                //add the new record
                StockList.Add();
            }
            //otherwise must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ProductId);
                //set the ThisStock property
                StockList.ThisStock = theStock;
                //update record
                StockList.Update();
            }
            //redirect to listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            //create an instance of the address class
            clsStock theStock = new clsStock();
            //variable to store the primary key
            Int32 ProductId;
            //variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            ProductId = Convert.ToInt32(txtProductId.Text);
            //find the record
            Found = theStock.Find(ProductId);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtProductId.Text = Convert.ToString(theStock.ProductId);
                txtProductName.Text = Convert.ToString(theStock.ProductName);
                chkInStock.Text = Convert.ToString(theStock.InStock);
                txtProductQuantity.Text = Convert.ToString(theStock.ProductQuantity);
                txtColour.Text = Convert.ToString(theStock.Colour);
                txtPrice.Text = Convert.ToString(theStock.Price);
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}