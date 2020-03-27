using System;
using Project0.Library.Entities;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
     public static class MainMenu
    {
        


        public static void mainMenuPrompt(RestaurantAfrikContext ctx,Customers customer)
            
        { 
            
            while(true)
            {
                Console.WriteLine("Choose from the following options: ");

                Console.WriteLine("\t1) Select from Customer List");
                Console.WriteLine("\t2) Add Customer");
                Console.WriteLine("\t3) Show Stores");
                Console.WriteLine("\t4) Will you like to make an order");
                Console.WriteLine("\t5) Print order history");
                Console.WriteLine("\t6) Close");
                int uInput = 0;
                while (true)
                {
                    try
                    {
                        uInput = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input. Please try again");
                    }
                }

                switch (uInput)
                {
                    case 1:
                        Customer.SearchCustomer(ctx);
                        break;

                    case 2:
                        Console.WriteLine("Would you like to Register");
                        Customer.addnewCustomer(ctx);
                        break;

                    case 3:
                        tableStores.showStores(ctx);
                        break;

                    case 4:
                        MakeOrders.PlaceOrder(customer);
                        break;
                    case 5:
                        MakeOrders.displayOrders();
                        break;
                    default:
                        break;
                }

            }
        }
            
    }
}
