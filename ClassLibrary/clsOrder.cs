using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
       
        public int ProductID { get; set; }
        public int TotalProduct { get; set; }
        public bool OrderIsPaid { get; set; }
        public DateTime OrderCreationDate { get; set; }
        public string OrderName { get; set; }
        public int OrderId { get; set; }
    }
}