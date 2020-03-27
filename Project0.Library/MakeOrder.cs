using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Outlook;
using Project0.Library.Entities;

namespace Project0.Library
{
    public class MakeOrders
    {
        public static void PlaceOrder(Customers customer)
        {
            int customerID = customer.CustomerId;

            Console.WriteLine("Enter your preferred Restaurant");

            using var context = new RestaurantAfrikContext();
            var storeList = context.StoreLoc.ToList();
            foreach (var store in storeList)
            {
                Console.WriteLine(store.StoreId + " " + store.Name);
            }
            int storeid = int.Parse(Console.ReadLine()); 


        /*if (custinput == "1" || custinput == "2")
        {
            int storeId = int.Parse(custinput);
            using (var ctx = new RestaurantAfrikContext())
            {
                var Store = (from s in ctx.StoreLoc
                             where s.StoreId == storeId
                             select s).SingleOrDefault();

            }
        }*/
        Startorder:
            
            Console.WriteLine("Select the foodtype you will like to order");

            var foodtypes = context.Foods.ToList();
            foreach (var foods in foodtypes)
            {
                Console.WriteLine(foods.FoodId + " " + foods.Name);
            }
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please Enter your desired food quantity");
            var food = context.Foods.Find(input);
            int qty = int.Parse(Console.ReadLine());
           
            var new_order = new Orders
            {
                FoodId = input,
                Price = qty * food.Price,
                Name = food.Name,
                OrderTime = DateTime.Now,
                StoreId = storeid,
                CustomerId = customer.CustomerId
            };
            Console.WriteLine($"You ordered {qty} {food.Name}");
            Console.WriteLine("Is this order correct y/n");
            var response = Console.ReadLine().ToLower();

            while (response != "y" && response != "n")
            {
                Console.WriteLine("Input y or n");
                response = Console.ReadLine();
                if (response == "y")
                {
                    context.Orders.Add(new_order);
                    context.SaveChanges();
                }
                else if (response == "n")
                {
                    goto Startorder;
                }
            }

        }
        public static void displayOrders()
        {
            Console.WriteLine("Enter the Id of Customer to display orders");
            int input = int.Parse(Console.ReadLine());
            using var context = new RestaurantAfrikContext();
            var orderHistory = context.Orders.Where(order=>order.CustomerId==input);

            foreach (var order in orderHistory)
            {
                Console.WriteLine($"CustomerID:{order.CustomerId} " +
                    $"\nFoodID:{order.FoodId} " +
                    $"\nFood Name:{order.Name} \nStoreID: {order.StoreId} Price: ${order.Price} \nDate.Time { DateTime.Now}");
            }
         
        }
          
    }
}
        
    
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    







        
    /*public static void PrintallOrders(RestaurantAfrikContext ctx)
    {
    var ol = ctx.Orders.Where(b => b.OrderId == 1);
    if (ol.Any())
    {
        int MaxId = ctx.orderlistId.Max(a => a.orderlistId);
        orderlistId = MaxId + 1
    }
    
    List<Customer> customer = ctx.Customers.ToList()
        public override string ToString(RestaurantAfrikContext ctx)
        int orderSelect = Convert.ToInt32(Console.ReadLine());
        Foods prodcut Price = Food.first(prodcut `)

    }
    
       

    
    /*public static void PrintallFoodTypes(RestaurantAfrikContext ctx)
    {

        List<Foods> FoodTypes = ctx.Foods.ToList();
        public override string ToString(RestaurantAfrikContext ctx)
    { 
        string result = $"{FoodType.Name} {Price} ";
        foreach (FoodTypes item in FoodTypes)
        {
            if (item.FoodTypes != null)
            {
                result += $"{item.FoodTypes.Name} ";
            }
        }
        return result;
    
    }
}*/








