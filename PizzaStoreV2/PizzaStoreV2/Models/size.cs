using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreV2.Models
{
    public class size
    {
        private int sizeID = 0;
        private string sizeName = "N/a";

        public int SizeID
        {
            get { return this.sizeID; }
            set { this.sizeID = value; }
        }
        public string SizeName
        {
            get { return this.sizeName; }
            set { this.sizeName = value; }
        }

        public size()
        { }

        public size(int aSizeID, string aSizeName)
        {
            this.SizeID = aSizeID;
            this.SizeName = aSizeName;
        }

        public size(int aSizeID): this (aSizeID, "N/a")
        { }
    }
}