using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsEmployeeCollection
    {


        //private data member 
        List<clsEmployee> mEmployeeList = new List<clsEmployee>();

        clsEmployee mThisEmployee = new clsEmployee();

        public List<clsEmployee> EmployeeList
        {
            get
            {
                return mEmployeeList;
            }
            set
            {
                mEmployeeList = value;
            }
        }
        public clsEmployee ThisEmployee
        {
            get
            {
                return mThisEmployee;
            }
            set
            {
                mThisEmployee = value;
            }
        }
        public int Count
        {
            get
            {
                return mEmployeeList.Count;
            }
            set
            {
                // i will worry later then
            }
        }

        //constructor for the class
        public clsEmployeeCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblEmployee_SelectAll");

            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);
            DB.AddParameter("@EmployeePhoneNo", mThisEmployee.EmployeePhoneNo);
            DB.AddParameter("@EmployeeHouseAddress", mThisEmployee.EmployeeHouseAddress);
            DB.AddParameter("@Employeesalary", mThisEmployee.Employeesalary);
            DB.AddParameter("@EmployeeContractStatus", mThisEmployee.EmployeeContractStatus);
            DB.AddParameter("@EmployeeName", mThisEmployee.EmployeeName);
            DB.AddParameter("@EmployeeDob", mThisEmployee.EmployeeDob);

            return DB.Execute("sproc_tblEmployee_Insert");
        }

        public int Update()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);
            DB.AddParameter("@EmployeePhoneNo", mThisEmployee.EmployeePhoneNo);
            DB.AddParameter("@EmployeeHouseAddress", mThisEmployee.EmployeeHouseAddress);
            DB.AddParameter("@Employeesalary", mThisEmployee.Employeesalary);
            DB.AddParameter("@EmployeeContractStatus", mThisEmployee.EmployeeContractStatus);
            DB.AddParameter("@EmployeeName", mThisEmployee.EmployeeName);
            DB.AddParameter("@EmployeeDob", mThisEmployee.EmployeeDob);

            return DB.Execute("sproc_tblEmployee_Update");
        }

        public void Delete()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeID", mThisEmployee.EmployeeID);
            DB.Execute("sproc_tblEmployees_Delete");
        }




        public void ReportByName(string EmployeeName)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeName", EmployeeName);

            DB.Execute("sproc_tblEmployee_FilterByName");

            PopulateArray(DB);


        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mEmployeeList = new List<clsEmployee>();


            while (Index < RecordCount)
            {
                clsEmployee AnEmployee = new clsEmployee();

                AnEmployee.EmployeeID = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeID"]);
                AnEmployee.EmployeeName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeName"]);
                AnEmployee.EmployeeDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmployeeDob"]);
                AnEmployee.EmployeeHouseAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeHouseAddress"]);
                AnEmployee.Employeesalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Employeesalary"]);
                AnEmployee.EmployeeContractStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmployeeContractStatus"]);

                mEmployeeList.Add(AnEmployee);

                Index++;
            }


        }

    }
}