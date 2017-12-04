using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreV2.Models
{
    public class toppings
    {
        private int toppingID = 0;
        private string toppName = "";
        private float toppPrice = 0.0f;

        public int ToppingID
        {
            get { return this.toppingID; }
            set { this.toppingID = value; }
        }

        public string ToppName
        {
            get { return this.toppName; }
            set { this.toppName = value; }
        }

        public float ToppPrice
        {
            get { return this.toppPrice; }
            set { this.toppPrice = value; }
        }

        public toppings()
        { }

        public toppings(int aToppingID, string aToppName, float aToppPrice)
        {
            this.ToppingID = aToppingID;
            this.ToppName = aToppName;
            this.ToppPrice = aToppPrice;
        }

        public toppings(int aToppingID, string aToppName) : this(aToppingID, "N/a", 0.0f)
        { }

        public toppings(int aToppingID) : this(aToppingID, "N/a", 0.0f)
        { }
    }
}