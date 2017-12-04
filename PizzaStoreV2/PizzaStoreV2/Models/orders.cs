using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreV2.Models
{
    public class orders
    {
        private int orderID = 0;
        private string cusName = "";
        private string cusAddress = "";
        private string cusCreditCard = "";
        private string cusCellPhone = "";
        private string cusZip = "";
        private bool delivary = false;
        private float total = 0.0f;

        public int OrderID
        {
            get { return this.orderID; }
            set { this.orderID = value; }
        }
        public string CusName
        {
            get { return this.cusName; }
            set { this.cusName = value; }
        }
        public string CusAddress
        {
            get { return this.cusAddress; }
            set { this.cusAddress = value; }
        }
        public string CusCreditCard
        {
            get { return this.cusCreditCard; }
            set { this.cusCreditCard = value; }
        }
        public string CusCellPhone
        {
            get { return this.cusCellPhone; }
            set { this.cusCellPhone = value; }
        }
        public string CusZip
        {
            get { return this.cusZip; }
            set { this.cusZip = value; }
        }
        public bool Delivary
        {
            get { return this.delivary; }
            set { this.delivary = value; }
        }
        public float Total
        {
            get { return this.total; }
            set { this.total = value; }
        }



        public orders()
        { }

        public orders(int aOrderID, string aCusName, string aCusAddress, string aCusCreditCard, string aCusCellPhone ,string aCusZip, bool aDelivary, float aTotal)
        {
            this.OrderID = aOrderID;
            this.CusName = aCusName;
            this.CusAddress = aCusAddress;
            this.CusCreditCard = aCusCreditCard;
            this.CusCellPhone = aCusCellPhone;
            this.CusZip = aCusZip;
            this.Delivary = aDelivary;
            this.Total = aTotal;
        }

        public orders(int aOrderID, string aCusName, string aCusAddress, string aCusCreditCard, string aCusCellPhone, string aCusZip, bool aDelivary): this (aOrderID, aCusName, aCusAddress, aCusCreditCard, aCusCellPhone, aCusZip, aDelivary, 0.0f)
        { }

        public orders(int aOrderID, string aCusName, string aCusAddress, string aCusCreditCard, string aCusCellPhone, string aCusZip) : this(aOrderID, aCusName, aCusAddress, aCusCreditCard, aCusCellPhone, aCusZip, false, 0.0f)
        { }

        public orders(int aOrderID, string aCusName, string aCusAddress, string aCusCreditCard, string aCusCellPhone) : this(aOrderID, aCusName, aCusAddress, aCusCreditCard, aCusCellPhone, "N/a", false, 0.0f)
        { }
        public orders(int aOrderID, string aCusName, string aCusAddress, string aCusCreditCard) : this(aOrderID, aCusName, aCusAddress, aCusCreditCard, "N/a", "N/a", false, 0.0f)
        { }
        public orders(int aOrderID, string aCusName, string aCusAddress) : this(aOrderID, aCusName, aCusAddress, "N/a", "N/a", "N/a", false, 0.0f)
        { }
        public orders(int aOrderID, string aCusName) : this(aOrderID, aCusName, "N/a", "N/a", "N/a", "N/a", false, 0.0f)
        { }
        public orders(int aOrderID) : this(aOrderID, "N/a", "N/a", "N/a", "N/a", "N/a", false, 0.0f)
        { }


    }
}