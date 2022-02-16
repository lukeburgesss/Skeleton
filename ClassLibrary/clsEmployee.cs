using System;

namespace ClassLibrary
{
    public class clsEmployee
    {
        //EmployeeID
        public int SupplierID { get; set; }

        //EmployeeName
        public string EmployeeName { get; set; }

        //EmployeeDob
        public DateTime EmployeeDob { get; set; }

        //ContactNumber
        public string phoneNo { get; set; }

        //HomeAddress
        public string HouseAddress { get; set; }

        //Salary
        public Decimal salary { get; set; }

        //ContractStatusOK
        public Boolean ContractStatus { get; set; }

    }
}