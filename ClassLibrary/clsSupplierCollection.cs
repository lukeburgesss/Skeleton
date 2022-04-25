using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblSupplier_SelectAll");

            PopulateArray(DB);

        }

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

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mSupplierList = new List<clsSupplier>();


            while (Index < RecordCount)
            {
                clsSupplier aSupplier = new clsSupplier();

                aSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);

                aSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);

                aSupplier.SupplierDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["SupplierDateAdded"]);

                aSupplier.SupplierArchive = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierArchive"]);

                mSupplierList.Add(aSupplier);

                Index++;
            }


        }


        public int Add()
        {
            // add new record to db based on values of mThisSupplier
            // set pk value of new record
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierDateAdded", mThisSupplier.SupplierDateAdded);
            DB.AddParameter("@SupplierArchive", mThisSupplier.SupplierArchive);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        
        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierDateAdded", mThisSupplier.SupplierDateAdded);
            DB.AddParameter("@SupplierArchive", mThisSupplier.SupplierArchive);

            return DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);

            DB.Execute("sproc_tblSupplier_Delete");

        }

        public void ReportByName(string SupplierName)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("SupplierName", SupplierName);

            DB.Execute("sproc_tblSupplier_FilterByName");

            PopulateArray(DB);


        }
    }
}