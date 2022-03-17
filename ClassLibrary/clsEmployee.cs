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

      /*  public string Valid(string EmployeeID,
                            string EmployeePhoneNo,
                            string EmployeeHouseAddress,
                            string Employeesalary,
                            string EmployeeContractStatus,
                            string EmployeeName,
                            string EmployeeDob);
      */

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

        public bool Find(int EmployeeID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the employee no to search for
            DB.AddParameter("@EmployeeID", EmployeeID);
            //execute the stored procedure
            DB.Execute("sproc_tblemployee_filterByemployeeID");
            //if one record is found there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mEmployeeID = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeID"]);
                mEmployeePhoneNo = Convert.ToString(DB.DataTable.Rows[0]["EmployeePhoneNo"]);
                mEmployeeHouseAddress = Convert.ToString(DB.DataTable.Rows[0]["EmployeeHouseAddress"]);
                mEmployeeName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeName"]);
                mEmployeesalary = Convert.ToInt32(DB.DataTable.Rows[0]["Employeesalary"]);
                mEmployeeDob = Convert.ToDateTime(DB.DataTable.Rows[0]["EmployeeDob"]);
                mEmployeeContractStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["EmployeeContractStatus"]);
                //return that everything worked OK
                return true;
                //if no record was found
            } else
            { 
                //return false indicating a problem
                return false;
            }
            
            //set private data to test
            /*mEmployeeID = 21;
            mEmployeeDob = Convert.ToDateTime("16/9/2015");
            mEmployeePhoneNo = "0727274";
            mEmployeeHouseAddress = "17 fake streat";
            mEmployeesalary = Convert.ToDecimal(17000);
            mEmployeeName = "mark wallburg";
            mEmployeeContractStatus = true;

            //always return true
            return true;
            */
        }

        public string Valid(string employeeName, string employeeHouseAddress, string employeesalary, string employeePhoneNo, string employeeDob)
        {
            String Error = "";
            DateTime DateTemp;
            if (employeePhoneNo.Length == 0)
            {
                Error = Error + "the phone number may not be empty";
            }
            if (employeePhoneNo.Length > 16)
            {
                Error = Error + "phone number must be less than 16 digits";
            }
            DateTemp = Convert.ToDateTime(employeeDob);
            if (DateTemp < DateTime.Now.AddYears(-16)) 
            {
                Error = Error + "The Dob canot be that early : ";   
            }
            if (DateTemp < DateTime.Now.AddYears(+90))
            {
                Error = Error + "The Dob canot be that late: ";
            }
            if (employeesalary.Length > 9)
            {
                Error = Error + "too high salary";
            }
            if (employeesalary.Length < 3)
            {
                Error = Error + "too low salary";
            }
            if (employeeName.Length < 1)
            {
                Error = Error + "too short name";
            }
            if (employeeName.Length > 49)
            {
                Error = Error + "too long name";
            }
            if (employeeHouseAddress.Length < 1)
            {
                Error = Error + "enter a full address";
            }
            if (employeeHouseAddress.Length > 49)
            {
                Error = Error + "address too long";
            }


            return Error;
        }

      
    }
}