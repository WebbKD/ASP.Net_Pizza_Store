using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStoreV2.Models;

namespace PizzaStoreV2.Controllers
{
    public class HomeController : Controller
    {
        DB aConn = new DB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            //loading pizza Size and Price
            List<size> aPizzaList = new List<size>();
            aPizzaList = aConn.getPizzaSizes();
            ViewBag.PizzaList = aPizzaList;

            return View();
        }

        public ActionResult OrderForm()
        {
            //loading the pizza sizes
            List<size> aPizzaList = new List<size>();
            aPizzaList = aConn.getPizzaSizes();
            ViewBag.PizzaList = aPizzaList;

            return View();
        }

        
        public ActionResult addOrder(string name, string address, string zip, string cc, string phone, bool delivary, int amountOfPizza, int[] size, bool[] pepperoni, bool[] mushrooms, bool[] onions, bool[] sasusage, bool[] bacon, bool[] extracheese, bool[] blackOlives, bool[] spinach, bool[] pineapple)
        {
            List<pizza> aListOfPizza = new List<pizza>();
            List<orderConfirm> aListOfOrder = new List<orderConfirm>();
            
            float pizzaprice = 0.0f;
            float toppingprice = 0.0f;
            float orderTotal = 0.0f;
            pizza thePizza;
            orderConfirm confirmPizza;

            aConn.addOrder(name, address, phone, delivary);

           


            for (int i = 0; i < amountOfPizza; i++)
            {

                thePizza = new pizza();
                confirmPizza = new orderConfirm();

                //setting the price for my pizza
                
                    switch (size[i])
                    {
                        case 1:
                            pizzaprice = 7.45f;
                            thePizza.SizeID = 1;
                            confirmPizza.SizeID = "Small";
                            break;
                        case 2:
                            pizzaprice = 10.45f;
                            thePizza.SizeID = 2;
                            confirmPizza.SizeID = "Medium";
                            break;
                        case 3:
                            pizzaprice = 13.45f;
                            thePizza.SizeID = 3;
                            confirmPizza.SizeID = "Large";
                            break;
                    }
                
               
               
                if (pepperoni[i] == true)
                {
                    toppingprice += 1.25f;
                    thePizza.Pepperoni = true;
                    confirmPizza.Pepperoni = "pepperoni";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Pepperoni = " ";
                }

               
                if (mushrooms[i] == true)
                {
                    toppingprice += 0.75f;
                    thePizza.Mushrooms = true;
                    confirmPizza.Mushrooms = "mushroom";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Mushrooms = " ";
                }
               
                
                if (onions[i] == true)
                {
                    toppingprice += 1f;
                    thePizza.Onions = true;
                    confirmPizza.Onions = "onions";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Onions = " ";
                }
                
                if (sasusage[i] == true)
                {
                    toppingprice += 2f;
                    thePizza.Sasuage = true;
                    confirmPizza.Sasuage = "Sasuage";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Sasuage = " ";
                }
                
                if (bacon[i] == true)
                {
                    toppingprice += 2.50f;
                    thePizza.Bacon = true;
                    confirmPizza.Bacon = "Bacon";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Bacon = " ";
                }

                
                if (extracheese[i] == true)
                {
                    toppingprice += 1f;
                    thePizza.ExtraCheese = true;
                    confirmPizza.ExtraCheese = "Extra Cheese";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.ExtraCheese = " ";
                }

                
                if (blackOlives[i] == true)
                {
                    toppingprice += 0.75f;
                    thePizza.BlackOlives = true;
                    confirmPizza.BlackOlives = "black Olives ";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.BlackOlives = " ";
                }
                
      
                if (spinach[i] == true)
                {
                    toppingprice += 1.50f;
                    thePizza.Spinach = true;
                    confirmPizza.Spinach = "Spinach ";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Spinach = " ";
                }
               

                if (pineapple[i] == true)
                {
                    toppingprice += 1.50f;
                    thePizza.Pineapple = true;
                    confirmPizza.Pineapple = "pineapple";
                }
                else
                {
                    toppingprice += 0;
                    confirmPizza.Pineapple = " ";
                    
                }

                if (delivary == true)
                {
                    pizzaprice += 1.0f;
                }
                else
                {
                    pizzaprice += 0;
                }

                //Setting the price of one pizza
                float pizzaPrice = pizzaprice + toppingprice;

                thePizza.Price = pizzaPrice;
                // Put it inseide a list
                aListOfPizza.Add(thePizza);
                aListOfOrder.Add(confirmPizza);

                aConn.addPizzaDetails( name, size[i], pepperoni[i], mushrooms[i], onions[i], sasusage[i], bacon[i], extracheese[i], blackOlives[i], spinach[i], pineapple[i], pizzaPrice);  
            }

            //adding all the prices in pizza
            foreach (var pizzas in aListOfPizza)
            {
                orderTotal += pizzas.Price;
            }

            //one more insert statement
            aConn.addTotal(name, orderTotal);


            ViewBag.Pizzas = aListOfOrder;
            ViewBag.TheOrderPrice = orderTotal;
            ViewBag.AmountOfPizzas = amountOfPizza;
            return View();
        }

        
    }
}