using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        // SupplierID
        public DateTime DateAdded { get; set; }

        // OrderDate
        public int SupplierID { get; set; }

        // ProductName
        public string Street { get; set; }
        
        // ProductQuantity 
        public int ProductQuantity { get; set; }

        // Purchase
        public bool Purchase { get; set; }

        // Price
        public decimal Price { get; set; }

    }
}