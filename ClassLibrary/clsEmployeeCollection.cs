using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsEmployeeCollection{

    
        //private data member 
        List<clsEmployee> mEmployeeList = new List<clsEmployee>();

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
        public clsEmployee ThisEmployee { get; set; }
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
        
        
        public clsEmployeeCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblEmployee_SelectAll");

            RecordCount = DB.Count;

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



        clsEmployee TestItem = new clsEmployee();

        TestItem.EmployeeID = 1;
        TestItem.EmployeeName = "luke";
        TestItem.EmployeeDob = Convert.ToDateTime("08/06/2002");
        TestItem.EmployeeHouseAddress = "19 coldstream close";
        TestItem.Employeesalary = 180;
        TestItem.EmployeeContractStatus = true;

        mEmployeeList.Add(TestItem);

        TestItem = new clsEmployee();

        TestItem.EmployeeID = 2;
        TestItem.EmployeeName = "Dog";
        TestItem.EmployeeDob = Convert.ToDateTime("08/06/2002");
        TestItem.EmployeeHouseAddress = "18 coldstream close";
        TestItem.Employeesalary = 150;
        TestItem.EmployeeContractStatus = true;

        mEmployeeList.Add(TestItem);

        }
    
    
    
    
    
    
    }


}