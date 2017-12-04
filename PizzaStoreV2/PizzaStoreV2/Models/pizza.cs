using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreV2.Models
{
    public class pizza
    {
        private int pizzaID = 0;
        private int orderID = 0;
        private int sizeID = 0;
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

        public int SizeID
        {
            get { return this.sizeID; }
            set { this.sizeID = value; }
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

        public pizza()
        { }

        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage, bool aBacon, bool aExtraCheese, bool aBlackOlives, bool aSpinach, bool aPineapple ,float aPrice)
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

        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage, bool aBacon, bool aExtraCheese, bool aBlackOlives, bool aSpinach): this (aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, aOnions, aSasuage, aBacon, aExtraCheese, aBlackOlives, aSpinach, false ,0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage, bool aBacon, bool aExtraCheese, bool aBlackOlives) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, aOnions, aSasuage, aBacon, aExtraCheese, aBlackOlives, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage, bool aBacon, bool aExtraCheese) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, aOnions, aSasuage, aBacon, aExtraCheese, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage, bool aBacon) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, aOnions, aSasuage, aBacon, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions, bool aSasuage) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, aOnions, aSasuage, false, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms, bool aOnions) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, aOnions, false, false, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni, bool aMushrooms) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, aMushrooms, false, false, false, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID, bool aPeperoni) : this(aPizzaID, aOrderID, aSizeID, aPeperoni, false, false, false, false, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID, int aSizeID) : this(aPizzaID, aOrderID, aSizeID, false, false, false, false, false, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID, int aOrderID) : this(aPizzaID, aOrderID, 0, false, false, false, false, false, false, false, false, false, 0.0f)
        { }
        public pizza(int aPizzaID) : this(aPizzaID, 0, 0, false, false, false, false, false, false, false, false, false, 0.0f)
        { }




        public override string ToString()
        {
            string aMessage = "";

            aMessage += "SizeID " + this.SizeID + "<br />";
            aMessage += "Pepperoni " + this.Pepperoni + "<br />";
            aMessage += "Mushrooms " + this.Mushrooms + "<br />";
            aMessage += "Onions " + this.Onions + "<br />";
            aMessage += "Sasusage " + this.Sasuage + "<br />";
            aMessage += "Bacon " + this.Bacon + "<br />";
            aMessage += "Extra Cheese " + this.ExtraCheese + "<br />";
            aMessage += "Black Olives " + this.BlackOlives + "<br />";
            aMessage += "Spinach " + this.Spinach + "<br />";
            aMessage += "Pineapple " + this.Pineapple + "<br />";
            aMessage += "Price " + this.Price + "<br />";

            return aMessage;
        }
    }
}