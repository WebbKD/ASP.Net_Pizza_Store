using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreV2.Models
{
    public class Report
    {
        private int pizzaID = 0;
        private int orderID = 0;
        private string cusName = "";
        private string sizeName = "N/a";
        private bool pepperoni = false;
        private bool mushrooms = false;
        private bool onions = false;
        private bool sasusage = false;
        private bool bacon = false;
        private bool extraCheese = false;
        private bool blackOlives = false;
        private bool pineapple = false;
        private bool spinach = false;
        private float price = 0.0f;

        public int PizzaID
        {
            get { return this.pizzaID; }
            set { this.pizzaID = value; }
        }

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

        public string SizeName
        {
            get { return this.sizeName; }
            set { this.sizeName = value; }
        }

        public bool Pepperoni
        {
            get { return this.pepperoni; }
            set { this.pepperoni = value; }
        }

        public bool Mushrooms
        {
            get { return this.mushrooms; }
            set { this.mushrooms = value; }
        }

        public bool Onions
        {
            get { return this.onions; }
            set { this.onions = value; }
        }

        public bool Sasuage
        {
            get { return this.sasusage; }
            set { this.sasusage = value; }
        }

        public bool Bacon
        {
            get { return this.bacon; }
            set { this.bacon = value; }
        }

        public bool ExtraCheese
        {
            get { return this.extraCheese; }
            set { this.extraCheese = value; }
        }

        public bool BlackOlives
        {
            get { return this.blackOlives; }
            set { this.blackOlives = value; }
        }

        public bool Spinach
        {
            get { return this.spinach; }
            set { this.spinach = value; }
        }

        public bool Pineapple
        {
            get { return this.pineapple; }
            set { this.pineapple = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Report()
        { }

       public Report(int aPizzaID, int aOrderID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage, bool aBacon, bool aExtraCheese, bool aBlackOlives, bool aSpinach, bool aPineapple, float aPrice, string aSizeName, string aCusName)
        {
            this.PizzaID = aPizzaID;
            this.OrderID = aOrderID;
            
            this.Pepperoni = aPeperoni;
            this.Mushrooms = aMushrooms;
            this.Onions = aOnions;
            this.Sasuage = aSasuage;
            this.Bacon = aBacon;
            this.ExtraCheese = aExtraCheese;
            this.BlackOlives = aBlackOlives;
            this.Spinach = aSpinach;
            this.Pineapple = aPineapple;
            this.Price = aPrice;
            this.SizeName = aSizeName;
            this.CusName = aCusName;
        }
    }
}