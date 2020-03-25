using System;
using Project0.Library.Entities;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
     public static class MainMenu
    {
        


        public static void mainMenuPrompt(RestaurantAfrikContext ctx)
        { 
            

            Console.WriteLine("Choose from the following options: ");
            Console.WriteLine("\t1) Select from Customer List");
            Console.WriteLine("\t2) Customer Login");
            Console.WriteLine("\t3) New Customer");
            Console.WriteLine("\t4) Choose your location");
            Console.WriteLine("\t5) Will you like to make an order");
            Console.WriteLine("\t6) Restart");
            
           

            int uInput = int.Parse(Console.ReadLine());

            switch (uInput)
            {
                case 1:
                    Customer.DisplayCustomers(ctx);
                   
                    break;
                    
                case 2:
                    Console.WriteLine("Please enter your credentials");
                    Customer.CustomerLogin(ctx);
                    break;
                    
                case 3:
                    Console.WriteLine("Would you like to Register");
                    Customer.addnewCustomer(ctx);
                    break;

                case 4:
                    tableStores.showStores(ctx);
                    break;
                case 5:
                    FoodType.showFoodTypes(ctx);
                    break;

                case 6:
                    Console.WriteLine("Lets give it another try");
                    break;
                default:
                    break;
            }

        }
    }
}
