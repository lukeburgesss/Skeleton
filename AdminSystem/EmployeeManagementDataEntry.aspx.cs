using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeID = Convert.ToInt32(Session["EmpoloyeeID"]);
        if (IsPostBack == false)
        {
            if (EmployeeID != -1)
            {
                DisplayEmployees();

            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance cls employee
        clsEmployee AnEmployee = new clsEmployee();

        //capture employee ID       
        string EmployeeID = txtEmployeeNo.Text;
        //capture employee name
        string EmployeeName = txtEmployeeName.Text;
        //capture employee Dob
        string EmployeeDob = txtDOB.Text;
        //capture employee Address
        string EmployeeHouseAddress = txtHouseAddress.Text;
        //capture employee Salary
        string Employeesalary = txtsalary.Text;


        string Error="";
        Error = AnEmployee.Valid(EmployeeID, EmployeeName, EmployeeDob, EmployeeHouseAddress, Employeesalary);
        if (Error == "")
        {
            AnEmployee.EmployeeID =Convert.ToInt32(EmployeeID);
            AnEmployee.EmployeeName = EmployeeName;
            AnEmployee.EmployeeDob =Convert.ToDateTime(EmployeeDob);
            AnEmployee.EmployeeHouseAddress = EmployeeHouseAddress;
            AnEmployee.Employeesalary =Convert.ToInt32(Employeesalary);
            AnEmployee.EmployeeContractStatus =Convert.ToBoolean(chkActive.Checked);

            clsEmployeeCollection EmployeeList = new clsEmployeeCollection();

            if (EmployeeID == -1)
            {
                EmployeeList.ThisEmployee = AnEmployee;
                EmployeeList.Add();

            }

            else 
            {
                EmployeeList.ThisEmployee.Find(EmployeeID);

                EmployeeList.ThisEmployee = AnEmployee;

                EmployeeList.Update();
            }

            //navicates to list page
            Response.Redirect("EmployeeManagementList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void txtHouseAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmployeeNo_TextChanged(object sender, EventArgs e)
    {

    }
    
        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create an instance of the employee class
            clsEmployee anEmployee = new clsEmployee();
            //store primary key
            Int32 EmployeeID;
            //variable to store the results of the find operation
            Boolean Found=false;
            //get the primary key enterd bu the user
            EmployeeID = Convert.ToInt32(txtEmployeeNo.Text);
            //find the record
            Found = anEmployee.Find(EmployeeID);
            //if found
            if (Found == true)
            {
                txtEmployeeNo.Text = Convert.ToString(anEmployee.EmployeeID);
                txtEmployeeName.Text = anEmployee.EmployeeName;
                txtDOB.Text = Convert.ToString(anEmployee.EmployeeDob);
                txtHouseAddress.Text = anEmployee.EmployeeHouseAddress;
                txtsalary.Text = Convert.ToString(anEmployee.Employeesalary);
                chkActive.Checked = anEmployee.EmployeeContractStatus;


            }
        }

    void DisplayEmployees()
    {
        clsEmployeeCollection employeebook = new clsEmployeeCollection();

        employeebook.ThisEmployee.Find(EmployeeID);

        txtEmployeeNo.Text = employeebook.ThisEmployee.EmployeeID.ToString();
        txtEmployeeName.Text = employeebook.ThisEmployee.EmployeeName;
        txtDOB.Text = employeebook.ThisEmployee.EmployeeDob.ToString();
        txtHouseAddress.Text = employeebook.ThisEmployee.EmployeeHouseAddress;
        txtsalary.Text = employeebook.ThisEmployee.Employeesalary.ToString();
        chkActive.Checked = employeebook.ThisEmployee.EmployeeContractStatus;
    }

}