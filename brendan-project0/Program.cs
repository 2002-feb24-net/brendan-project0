using Project0.Library;
using System;
using Project0.Library.Entities;
using System.Collections.Generic;

namespace brendan_project0
{
    class Program
    {

        private static readonly RestaurantAfrikContext ctx = new RestaurantAfrikContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RestaurantAfrik!");

            var loggedInCustomer = Project0.Library.Customer.CustomerReadPassword(ctx);
            MainMenu.mainMenuPrompt(ctx,loggedInCustomer);
            tableStores.PreferredStore(ctx);
            FoodType.addFoodType(ctx);
           
            




           /* Project0.Library.Customer.addnewCustomer(ctx);*/
/*
            char[] phoneArr = phone.ToCharArray();
            int x = 0;
            int t = 5;
            while (x < phoneArr.Length)
            {
                char p = phoneArr[x];

                bool b = Char.IsDigit(p);

                if (b == true)
                {

                    x++;
                }
                else
                {
                    System.Console.WriteLine("Invalid input. You have " + t + " tries left.");
                    break;
                }
            }

            if (x != 10)
            //(x > 10 || x < 10) 
            {
                string phoneNumber = phone;
                System.Console.WriteLine("Invalid input. You have " + t + " tries left.");

            }

            if (t == 0)
            {
                Console.WriteLine("You have reached the maximum limit. Please restart application");
                System.Environment.Exit(1);

            }*/
            
        }
    }
}


    



