using Microsoft.Office.Interop.Outlook;
using System;
using System.Linq;
using Project0.Library.Entities;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public static class tableStores
    {
        public static int count { get; set; }
        public static void showStores(RestaurantAfrikContext ctx)
        {

            List<StoreLoc> listStores = ctx.StoreLoc.ToList();

            foreach (var item in listStores)
            {
                Console.WriteLine($" {item.StoreId} {item.Name} {item.Phone} {item.Email} {item.Street} {item.City} {item.State} {item.ZipCode} ");
            }
            Console.WriteLine("What store will you like to order from");
            Console.ReadLine();

        }
        public static void addStores(RestaurantAfrikContext ctx)
        {
            Console.WriteLine("Enter your preferred location");
            var StoreLoc = Console.ReadLine();
        }
        public static void PreferredStore(RestaurantAfrikContext ctx)
        {

            Console.WriteLine("Choose from a store: ");
            List<StoreLoc> allStores = ctx.StoreLoc.ToList();
            foreach (var items in allStores)
            {
                Console.WriteLine(items.StoreId + "\t" + items.State);
            }
            var choseStore = Console.ReadLine().ToLower();
            if (choseStore == "addS")
            {
                tableStores.addStores(ctx);
            }
            else if (choseStore != null)
            {
                Console.WriteLine($"You Chose + {choseStore}");
                
            }
            else
            {
                Console.WriteLine("I apologize that store does not exist");
            }


        }
    }
}
    

        
    

        /*public decimal Revenue
        {
            get
            {
                return Orders.Sum(o => o.Completed ? o.Price : 0.0M);
            }

        }
        public Stores()
        {
            StoreId = DateTime.Now.Ticks;
        }
        public override long GetId()
        {
            return StoreId;
        }
    }

}*/

        
        /*int StoreId = myStores.StoreId;
        string StoreName = myStores.StoreName;
        long Storelocation = myStores.Storelocation;
        Id = DateTime.Now.Ticks;


        public Stores()
        {
            Id = DateTime.Now.Ticks;
            Console.WriteLine("Enter name of Drink: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price of Drink");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Drink type");
            bool Drinkchoice = true;
            do
            {
                try
                {
                    Drinktype food = (Drinktype)string.Parse(typeof(Drinktype).Console.ReadLine());
                    Drinkchoice = false;
                }
                catch
                {
                    Console.WriteLine("Please Enter the Correct Drink Type");
                }
            }

          















   /* public void DisplayLcoations()
    {
        System.Console.WriteLine("Indicate your location?");
        System.Console.WriteLine("Arlington, Houston, Dallas, San Antonio");
        string choice = System.Console.ReadLine();


        List<Store> location = new List<Store>()
            {
               new Store { Id = 1, Name = "Arlington" },
               new Store { Id = 2, Name = "Houston" },
               new Store { Id = 3, Name = "San Antonio" },
               new Store { Id = 4, Name = "Dallas" },
            };*/

        //return location;


        //List<store> locations = new List<store>();
        //store1.Name = "1 Arlington";
        //store2.Name = "2 Houston";
        //store3.Name = "3 Dallas";
        //store4.Name = "4 San Antonio";

       /* *//*List<string> locations = new List<string>();
        locations.Add("1 Arlington");
        locations.Add("2 Houston");
        locations.Add("3 Dallas");
        locations.Add("4 San Antonio");*//*

        if (choice == "location")
        {
            foreach (var locations in location)
            {
                Console.WriteLine(locations);
                Console.WriteLine();
            }
        }


    }*/


/*public class Store
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Store> location = new List<Store>();



}*/
/*}
        *//*private static int Storelocations = 0;

        public StoreLocations()
        {
            foreach(string value in Mylocatoins)
            {
                Store NewStore = new Store();
                NewStore.SetName(value.ToLower());

                Mystorelocations.Add(value, NewStore);
            }
            MyStoreCreator.Initialize();

        }
        public override void SetCurrent(string x)
        {
            CurrentStore = Mystorelocations[x];
        }
        public override int GetTotal()
        {
            return Storelocations;
        }
        public override bool checkFor(string x)
        {
            if (myStorelocations.ContainsKey(x))
            {
                return true;
            }
            return false;
        }
    }
}*/


      /*public DbSet<User> Users { get; set; }
    /*    public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    public class MyContext : DbContext
    {
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StoreDB;");
        }
    }
    }
}*//**/
