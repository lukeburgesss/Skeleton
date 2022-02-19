using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public bool InStock { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime LastAdjustment { get; set; }
        public string Colour { get; set; }
        public double Price { get; set; }
    }
}