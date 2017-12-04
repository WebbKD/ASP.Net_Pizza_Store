using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace PizzaStoreV2.Models
{
    public class DB
    {
        //setting up singleton
        //null connection
        private static OleDbConnection aConn = null;

        //single conneciton
        public static OleDbConnection Instance()
        {
            OleDbConnection myconnection;

            if (DB.aConn != null)
            {
                myconnection = DB.aConn;
            }
            else
            {
                myconnection = new OleDbConnection();
            }
            return myconnection;
        }

        //list of objects
        private List<size> aListOfPizzaSizes = new List<size>();
        private List<orders> aListOfOrders = new List<orders>();
        private List<OrderTracker> aListOfordersConfirm = new List<OrderTracker>();
        private List<Report> aListOfReports = new List<Report>();
        


        // getting info from database
        public List<size> getPizzaSizes()
        {
            string aSQL = "SELECT sizeID, sizeName FROM tbl_size";

            aConn = DB.Instance();

            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";

            //opening the connection
            aConn.Open();
            //creating the aSQL Command
            OleDbCommand aCommand = aConn.CreateCommand();
            aCommand.CommandText = aSQL;
            //allows for the data to read from the text command 
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int aSizeID = (int)(aReader)["sizeID"];
                string aSizeName = (string)(aReader)["sizeName"];
                
                size aSize = new size();
                aSize.SizeID = aSizeID;
                aSize.SizeName = aSizeName;

                aListOfPizzaSizes.Add(aSize);
            }
            aConn.Close();
            return aListOfPizzaSizes;
        }

        public List<OrderTracker> getTotalsFromOrders()
        {
            string aSQL = "SELECT tbl_Pizza.orderID, tbl_order.cusName, tbl_Pizza.pizzaID, tbl_size.sizeName, tbl_Pizza.pepperoni, tbl_Pizza.bacon, tbl_Pizza.blackOlives, tbl_Pizza.extraCheese, tbl_Pizza.mushrooms, tbl_Pizza.onions, tbl_Pizza.pineapple, tbl_Pizza.sasusage, tbl_Pizza.spinach, tbl_Pizza.pizzaPrice FROM tbl_order INNER JOIN tbl_Pizza on tbl_Pizza.orderID = tbl_order.orderID INNER JOIN tbl_size on tbl_size.sizeID = tbl_Pizza.sizeID";
            aConn = DB.Instance();

            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";

            //opening the connection
            aConn.Open();
            //creating the aSQL Command
            OleDbCommand aCommand = aConn.CreateCommand();
            aCommand.CommandText = aSQL;
            //allows for the data to read from the text command 
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int aOrderId = (int)(aReader)["orderID"];
                string aCusName = (string)(aReader)["cusName"];
                int aPizzaID = (int)(aReader)["pizzaID"];
                string aSizeName = (string)(aReader)["sizeName"];
                bool aPepperoni = (bool)(aReader)["pepperoni"];
                bool aBacon = (bool)(aReader)["bacon"];
                bool ablackOlives = (bool)(aReader)["blackOlives"];
                bool aExtracheese = (bool)(aReader)["extraCheese"];
                bool aBlackOlives = (bool)(aReader)["blackOlives"];
                bool aPineapple = (bool)(aReader)["pineapple"];
                bool aSpinach = (bool)(aReader)["spinach"];
                float aPrice = (float)(aReader)["pizzaPrice"];



                OrderTracker aOrder = new OrderTracker();
                aOrder.OrderID = aOrderId;
                aOrder.CusName = aCusName;
                aOrder.PizzaID = aPizzaID;
                aOrder.SizeName = aSizeName;
                aOrder.Pepperoni = aPepperoni;
                aOrder.Bacon = aBacon;
                aOrder.BlackOlives = ablackOlives;
                aOrder.ExtraCheese = aExtracheese;
                aOrder.Pineapple = aPineapple;
                aOrder.Spinach = aSpinach;
                aOrder.Price = aPrice;
                

                aListOfordersConfirm.Add(aOrder);
            }
            aConn.Close();
            return aListOfordersConfirm;
        }

        public List<Report> getAllTheReports() {

            string aSQL = "SELECT tbl_Pizza.orderID, tbl_order.cusName, tbl_Pizza.pizzaID, tbl_size.sizeName, tbl_Pizza.pepperoni, tbl_Pizza.bacon, tbl_Pizza.blackOlives, tbl_Pizza.extraCheese, tbl_Pizza.mushrooms, tbl_Pizza.onions, tbl_Pizza.pineapple, tbl_Pizza.sasusage, tbl_Pizza.spinach, tbl_Pizza.pizzaPrice FROM tbl_order INNER JOIN tbl_Pizza on tbl_Pizza.orderID = tbl_order.orderID INNER JOIN tbl_size on tbl_size.sizeID = tbl_Pizza.sizeID";
            aConn = DB.Instance();

            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";

            //opening the connection
            aConn.Open();
            //creating the aSQL Command
            OleDbCommand aCommand = aConn.CreateCommand();
            aCommand.CommandText = aSQL;
            //allows for the data to read from the text command 
            OleDbDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                int aPizzaID = (int)(aReader)["tbl_Pizza.pizzaID"];
                int aOrderID = (int)(aReader)["tbl_Pizza.orderID"];
                string aCusName = (string)(aReader)["tbl_order.cusName"];
                string aSizeName = (string)(aReader)["tbl_size.sizeName"];
                bool aPepperoni = (bool)(aReader)["tbl_Pizza.pepperoni"];
                bool aMushrooms = (bool)(aReader)["tbl_Pizza.mushrooms"];
                bool aOnions = (bool)(aReader)["tbl_Pizza.onions"];
                bool aSasusage = (bool)(aReader)["tbl_Pizza.sasusage"];
                bool aBacon = (bool)(aReader)["tbl_Pizza.bacon"];
                bool aExtraCheese = (bool)(aReader)["tbl_Pizza.extraCheese"];
                bool aBlackOlives = (bool)(aReader)["tbl_blackOlives"];
                bool aPineapple = (bool)(aReader)["tbl_pineapple"];
                bool aSpinach = (bool)(aReader)["tbl_spinach"];
                float aPrice = (float)(aReader)["tbl_Pizza.pizzaPrice"];

                Report aReport = new Report();
                aReport.PizzaID = aPizzaID;
                aReport.OrderID = aOrderID;
                aReport.CusName = aCusName;
                aReport.Pepperoni = aPepperoni;
                aReport.Mushrooms = aMushrooms;
                aReport.Onions = aOnions;
                aReport.Sasuage = aSasusage;
                aReport.Bacon = aBacon;
                aReport.ExtraCheese = aExtraCheese;
                aReport.BlackOlives = aBlackOlives;
                aReport.Pineapple = aPineapple;
                aReport.Spinach = aSpinach;
                aReport.Price = aPrice;

                aListOfReports.Add(aReport);
            }
                aConn.Close();
            return aListOfReports;
            }

        public bool addOrder(string name, string address, string phone, bool delivary)
        {
            bool aFlag = false;
            string aSQL1 = "INSERT INTO tbl_order (cusName, cusAddress, cusPhone, delivary) VALUES (  ?, ?,  ?, ? ) ";
            aConn = DB.Instance();
            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";
           
            using (OleDbCommand aCommand = new OleDbCommand(aSQL1, aConn))
            {
                aCommand.CommandType = System.Data.CommandType.Text;
                aCommand.Parameters.AddWithValue("cusName", name);
                aCommand.Parameters.AddWithValue("cusAddress", address);
                aCommand.Parameters.AddWithValue("cusPhone", phone);
                aCommand.Parameters.AddWithValue("delivary", delivary);
                aConn.Open();
                aCommand.ExecuteNonQuery();
            }
            aFlag = true;
            aConn.Close();
            return aFlag;
        }

        public bool addPizzaDetails(string name, int size, bool pepperoni, bool mushrooms, bool onions, bool sasusage, bool bacon, bool extracheese, bool blackOlives, bool spinach, bool pineapple, float pizzaPrice)
        {
            bool aFlag = false;

            aConn = DB.Instance();
            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";
            
            string aSQLOrderID = "SELECT orderID FROM tbl_order WHERE cusName = ? ";

            int OrderID;

            using (OleDbCommand aCommand = new OleDbCommand(aSQLOrderID, aConn))
            {
                aCommand.CommandType = System.Data.CommandType.Text;
                aCommand.Parameters.AddWithValue("cusName", name);

                aConn.Open();
                // read from the database
                using (OleDbDataReader aReader = aCommand.ExecuteReader())
                {
                    
                    //using the read method to move through the colum data
                    aReader.Read();
                    OrderID = (int)(aReader)["orderID"];
                    aReader.Close();
                }
                aConn.Close();
            }
            
                //add in the price
            string aSQL2 = "INSERT INTO tbl_Pizza(orderID, sizeID, pepperoni, mushrooms, onions, sasusage, bacon, extraCheese, blackOlives, spinach ,pineapple, pizzaPrice) VALUES ( ? ,? , ?, ? , ?, ?, ?, ?, ?, ?, ?, ?)";
            using (OleDbCommand aCommand = new OleDbCommand(aSQL2, aConn))
            {
                
                aCommand.CommandType = System.Data.CommandType.Text;
                aCommand.Parameters.AddWithValue("orderID",OrderID);
                aCommand.Parameters.AddWithValue("sizeID", size);
                aCommand.Parameters.AddWithValue("pepperoni", pepperoni);
                aCommand.Parameters.AddWithValue("mushrooms", mushrooms);
                aCommand.Parameters.AddWithValue("onions", onions);
                aCommand.Parameters.AddWithValue("sasusage", sasusage);
                aCommand.Parameters.AddWithValue("bacon", bacon);
                aCommand.Parameters.AddWithValue("extraCheese", extracheese);
                aCommand.Parameters.AddWithValue("blackOlives", blackOlives);
                aCommand.Parameters.AddWithValue("spinach", spinach);
                aCommand.Parameters.AddWithValue("pineapple", pineapple);
                aCommand.Parameters.AddWithValue("pizzaPrice", Convert.ToDouble(pizzaPrice));
                aConn.Open();
                aCommand.ExecuteNonQuery();
            } 

            aFlag = true;
            aConn.Close();
            return aFlag;
        }

        public bool addTotal(string name, float total)
        {
            bool aFlag = false;
            string aSQL1 = "UPDATE tbl_order  SET total = ?  WHERE cusName =  ?  ";
            aConn = DB.Instance();
            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";

            

            using (OleDbCommand aCommand = new OleDbCommand(aSQL1, aConn))
            {
                aCommand.CommandType = System.Data.CommandType.Text;
                aCommand.Parameters.AddWithValue("total", Convert.ToDouble(total));
                aCommand.Parameters.AddWithValue("cusName", name);
                
                aConn.Open();
                aCommand.ExecuteNonQuery();
            }

            aFlag = true;
            aConn.Close();
            return aFlag;
        }

        public bool deleteFrom(int pizzaID)
        {
            bool aFlag = false;
            string aSQL1 = "DELETE FROM tbl_Pizza WHERE pizzaID = '"+ pizzaID +"'";
            aConn = DB.Instance();
            aConn.ConnectionString = @"Provider=sqloledb;
                Data Source=LAPTOP-6MQIPCEV\SQLEXPRESS;Initial Catalog=pizzaShop;Integrated Security =SSPI";
            OleDbCommand aCommand = aConn.CreateCommand();
            aConn.Open();

            aCommand.CommandText = aSQL1;
            aCommand.ExecuteNonQuery();
            aFlag = true;

            aConn.Close();


            return aFlag;
        }

    }
}