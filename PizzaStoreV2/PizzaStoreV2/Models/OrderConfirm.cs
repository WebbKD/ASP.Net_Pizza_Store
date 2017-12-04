using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreV2.Models
{
    public class orderConfirm
    {
        private int pizzaID = 0;
        private int orderID = 0;
        private string sizeID = "n/a";
        private string pepperoni = "n/a";
        private string mushrooms = "n/a";
        private string onions = "n/a";
        private string sasusage = "n/a";
        private string bacon = "n/a";
        private string extraCheese = "n/a";
        private string blackOlives ="n/a";
        private string pineapple = "n/a";
        private string spinach = "n/a";
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

        public string SizeID
        {
            get { return this.sizeID; }
            set { this.sizeID = value; }
        }

        public string Pepperoni
        {
            get { return this.pepperoni; }
            set { this.pepperoni = value; }
        }

        public string Mushrooms
        {
            get { return this.mushrooms; }
            set { this.mushrooms = value; }
        }

        public string Onions
        {
            get { return this.onions; }
            set { this.onions = value; }
        }

        public string Sasuage
        {
            get { return this.sasusage; }
            set { this.sasusage = value; }
        }

        public string Bacon
        {
            get { return this.bacon; }
            set { this.bacon = value; }
        }

        public string ExtraCheese
        {
            get { return this.extraCheese; }
            set { this.extraCheese = value; }
        }

        public string BlackOlives
        {
            get { return this.blackOlives; }
            set { this.blackOlives = value; }
        }

        public string Spinach
        {
            get { return this.spinach; }
            set { this.spinach = value; }
        }

        public string Pineapple
        {
            get { return this.pineapple; }
            set { this.pineapple = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public orderConfirm()
        { }

        public orderConfirm(int aPizzaID, int aOrderID, string aSizeID, string aPeperoni, string aMushrooms, string aOnions, string aSasuage, string aBacon, string aExtraCheese, string aBlackOlives, string aSpinach, string aPineapple ,float aPrice)
        {
            this.PizzaID = aPizzaID;
            this.OrderID = aOrderID;
            this.SizeID = aSizeID;
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
        }

        
        public override string ToString()
        {
            string aMessage = "";

            aMessage += "You ordered a " + this.SizeID + " " + this.Pepperoni + " " + this.Mushrooms + " " + this.Onions + " " + this.Sasuage + " " + this.Bacon + " " + this.ExtraCheese + " " + this.BlackOlives + " " + this.Spinach + " " + this.Pineapple + "Pizza " + "<br />";
           
            return aMessage;
        }
    }
}