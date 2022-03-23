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
        //if this si the first ttime the pahge is displayed
        if (IsPostBack == false)
        {
            DisplayEmployees();
        }
    }
        void DisplayEmployees()
        {
            clsEmployeeCollection Employees = new clsEmployeeCollection();

            lstEmployeeList.DataSource = Employees.EmployeeList;

            lstEmployeeList.DataValueField = "EmployeeID";

            lstEmployeeList.DataTextField = "EmployeeName";

            lstEmployeeList.DataBind();

        }
    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["EmployeeID"] = -1;

        Response.Redirect("EmployeeManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;

        if (lstEmployeeList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstEmployeeList.SelectedValue);

            Session["EmployeeID"] = EmployeeID;

            Response.Redirect("EmployeeManagementDataEntry.aspx");
        }
        else 
        {
            lblError.Text = "please select a record to edit form the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;

        if (lstEmployeeList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstEmployeeList.SelectedValue);

            Session["EmployeeID"] = EmployeeID;

            Response.Redirect("EmployeeManagementConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "plese select a record to delete from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsEmployeeCollection Employees = new clsEmployeeCollection();
        Employees.ReportByName("");
        
        txtfilter.Text = "";
        lstEmployeeList.DataSource = Employees.EmployeeList;

        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "EmployeeName";
        lstEmployeeList.DataBind();



    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsEmployeeCollection Employees = new clsEmployeeCollection();

        Employees.ReportByName(txtfilter.Text);
        lstEmployeeList.DataSource = Employees.EmployeeList;

        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "EmployeeName";
        lstEmployeeList.DataBind();
    }
}