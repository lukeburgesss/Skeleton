using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            DisplayStock();
        }

    }
        void DisplayStock()
        {
            //creates an instance of the collection
            clsStockCollection Stock = new clsStockCollection();
            //set the data source to list of stock in collection
            lstStockList.DataSource = Stock.StockList;
            //set the name of the primary key
            lstStockList.DataValueField = "ProductId";
            //set the data field to display
            lstStockList.DataTextField = "ProductName";
            //bind the data to the list
            lstStockList.DataBind();
        }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicat this is a new record
        Session["ProductId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to b edited
        Int32 ProductId;
        //if a record has been selected form the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record was selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to b edited
        Int32 ProductId;
        //if a record has been selected form the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to the edit page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record was selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}