using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //var to store the primary key value
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the sesson object
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            //creates a new instance of the class we want to create
            clsStockCollection Stock = new clsStockCollection();
            //find the record
            Stock.ThisStock.Find(ProductId);
            //delete
            Stock.Delete();
            //redirect to the main page
            Response.Redirect("StockList.aspx");
        }
    }
}