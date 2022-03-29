using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {

        //private data member 
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //Sort out later
            }
        }

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblSupplier_SelectAll");

           // PopulateArray(DB);

        }




        public clsSupplier ThisSupplier { get; set; }
    }
}