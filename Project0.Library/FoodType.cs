using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project0.Library.Entities;


namespace Project0.Library
{
    public class FoodType
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public decimal Price { get; set; }
        public static int count { get; internal set; }

        static List<string> FoodTypeName = new List<string>();
        #region NAVIGATIONAL PROPERTIES

        public static void showFoodTypes(RestaurantAfrikContext ctx)
        {

            List<Foods> FoodTypes = ctx.Foods.ToList();

            foreach (var item in FoodTypes)
            {
                Console.WriteLine($"{item.FoodId} {item.Name} {item.Price}");
            }
            
            Console.WriteLine("What would you like to order");
            Console.ReadLine();

        }
        public static void Orderfood(RestaurantAfrikContext ctx)
        {
            Console.WriteLine("Choose what you want to buy from the FoodTypes");
            int uInput = int.Parse(Console.ReadLine());
            int Foodchoice = Convert.ToInt32(Console.ReadLine());
            var FoodId = from Food in ctx.Foods
                         where Food.FoodId == Foodchoice
                         select Food.FoodId;
            //var FoodsId = ctx.Foods.First(schoice);
        }
        public static void placeOrder(RestaurantAfrikContext ctx)
        {

            string searchFood = Console.ReadLine();

            var foodItem = from Foods in ctx.Foods
                           where Foods.Name == searchFood
                           select Foods;

            Console.WriteLine("Choose the foodtype you will like to order: ");
            var allFoodType = ctx.Foods.ToList();
            foreach (var items in allFoodType)
            {
                Console.WriteLine(items.Name + "\t" + items.Price);

            }
            
            var foodchoice = Console.ReadLine().ToUpper();
       
        }
    }
}
        
               

        /*public FoodType(string name, int stock, decimal price)
        {
            this.name = name.ToLower();
            this.Id = Id;
            this.price = price;
            FoodTypeName.Add(name.ToLower());
        }
        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }
        public static bool CheckNames(string str)
        {
            if (FoodTypeName.Contains(str))
            {
                return true;
            }
            return false;
        }

    }
}*/
# endregion