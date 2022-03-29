using System;
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

        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblSupplier_SelectAll");

           // PopulateArray(DB);

        }
        

        public int Add()
        {
            // add new record to db based on values of mThisSupplier
            // set pk value of new record
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierDateAdde", mThisSupplier.SupplierDateAdded);
            DB.AddParameter("@SupplierArchive", mThisSupplier.SupplierArchive);

            return DB.Execute("sproc_tblSupplier_Insert");
        }
    }
}