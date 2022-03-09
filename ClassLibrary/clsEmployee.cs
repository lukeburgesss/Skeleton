using System;

namespace ClassLibrary
{
    public class clsEmployee
    {
        private Int32 mEmployeeID;
        private string mEmployeePhoneNo;
        private string mEmployeeHouseAddress;
        private decimal mEmployeesalary;
        private bool mEmployeeContractStatus;
        private string mEmployeeName;
        private DateTime mEmployeeDob;



        public Int32 EmployeeID
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeeID;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeeID = value;
            }
        }
        public string EmployeePhoneNo
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeePhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeePhoneNo = value;
            }
        }
        public string EmployeeHouseAddress
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeeHouseAddress;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeeHouseAddress = value;
            }
        }
        public decimal Employeesalary
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeesalary;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeesalary = value;
            }
        }
        public bool EmployeeContractStatus
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeeContractStatus;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeeContractStatus = value;
            }
        }
        public string EmployeeName
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeeName;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeeName = value;
            }
        }
        public DateTime EmployeeDob
        {
            get
            {
                //this line of code sends data out the property
                return mEmployeeDob;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeeDob = value;
            }
        }

        public bool Find(int employeeID)
        {
            //set private data to test
            mEmployeeID = 21;
            mEmployeeDob = Convert.ToDateTime("16/9/2015");
            mEmployeePhoneNo = "0727274";
            mEmployeeHouseAddress = "17 fake streat";
            mEmployeesalary = Convert.ToDecimal(17000);
            mEmployeeName = "mark wallburg";
            mEmployeeContractStatus = true;

            //always return true
            return true;
        }
    }
}