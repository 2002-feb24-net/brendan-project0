using System;
using System.Collections.Generic;

namespace brendan_project0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customers c = new Customers();
            c.Register();
            
            Products p = new Products();
            p.Displayallorders();

            StoreLocations l = new StoreLocations();
            l.DisplayLcoations();
        }
    }
    public class Customers
    {
        private string firstName;
        private string lastName;
        private string address;
        //private int zipcode;
        private string phoneNumber;
        public void Register()
        {
            Console.Write("Enter your name: ");
            firstName = System.Console.ReadLine();
            
            Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            Console.Write("Enter street address");
            address = System.Console.ReadLine();

            for(int t = 3; t >= 0; t--)
            {
                Console.Write("Enter phone");
                string phone = System.Console.ReadLine();
                char[] phoneArr = phone.ToCharArray();
                int x = 0;
                while(x < phoneArr.Length)
                {
                    char p = phoneArr[x];

                    bool b = Char.IsDigit(p);

                    if(b == true)
                    {
                        
                        x++;
                    }
                    else
                    {
                        //System.Console.WriteLine("Invalid input. You have " + t + " tries left.");
                        break;
                    }
                }
                
                    if (x > 10 || x < 10)
                    {
                        phoneNumber = phone;
                        System.Console.WriteLine("Invalid input. You have " + t + " tries left.");
                        
                    }
                    
                    if(t == 0)
                    {
                        Console.WriteLine("You have reached the maximum limit. Please restart application");
                        System.Environment.Exit(1);

                    }
                    break;
            }
            
        }
         
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // public string Street  { get; set; }
        // public int Zipcode { get; set; }
        // public int Phone { get; set; }
        
        // public string Display() 
        // {
        //     return firstName + " " + lastName + " " + address + " " + phoneNumber;
        // }
            
        
    }
    
    class Products
    {
        public void Displayallorders()
        {
            System.Console.WriteLine("What do you want to order?");
            System.Console.WriteLine("beverages, combinations, entrees, desserts");
            string choice = System.Console.ReadLine();
            
            Dictionary <string, double> My_beverages = new Dictionary<string, double>();
            My_beverages.Add ("1 Mango Juice", 3.00);
            My_beverages.Add ("2 Bottled", 2.00);
            My_beverages.Add ("3 Soft Drinks", 2.25);
            My_beverages.Add ("4 Ice Tea", 2.25);
            My_beverages.Add ("5 Cranberry Juice", 2.25);
            My_beverages.Add ("6 Coffee", 2.25);


            if (choice == "beverages")
            {
                foreach (KeyValuePair<string, double> beverage in My_beverages)
                {
                     Console.WriteLine( beverage.Key.ToString() + " " + beverage.Value.ToString());
                }
                System.Console.WriteLine("what will you like to drink?");
                 string test = System.Console.ReadLine();
                 System.Console.WriteLine("you chose: " + test);
            }
            

            Dictionary <string, double> My_Entrees = new Dictionary<string, double>();
            My_Entrees.Add ("1 Scotch Eggs", 3.00);
            My_Entrees.Add ("2 Chin Chin", 3.00);
            My_Entrees.Add ("3 Puff Puff", 2.00);
            My_Entrees.Add ("4 Spicy Chicken", 4.00);
            My_Entrees.Add ("5 Glazed Chicken", 4.00);
            My_Entrees.Add ("6 Chapati", 1.50);

            if (choice == "entrees")
            {
                foreach (KeyValuePair<string, double> entree in My_Entrees)
                {
                     Console.WriteLine( entree.Key.ToString() + " " + entree.Value.ToString());
                }
                System.Console.WriteLine("what entrees will you like?");
                 string test = System.Console.ReadLine();
                 System.Console.WriteLine("you chose: " + test);
            }
            
            Dictionary <string, double> My_CombinationPlates = new Dictionary<string, double>();
             My_CombinationPlates.Add ("1 Fried Rice", 13.00);
             My_CombinationPlates.Add ("2 Yam & Egusi", 15.50);
             My_CombinationPlates.Add ("3 Suya", 10.00);
             My_CombinationPlates.Add ("4 Grilled Fish", 15.50);
             My_CombinationPlates.Add ("5 Grilled Chicken", 12.25);
             My_CombinationPlates.Add ("6 Rice & Stew", 11.50);
             My_CombinationPlates.Add ("7 Peperred Meat", 18.50);

             if (choice == "combinations")
             {
                 foreach (KeyValuePair<string, double> combinations in My_CombinationPlates)
                 {
                     Console.WriteLine( combinations.Key.ToString() + " " + combinations.Value.ToString());
                 }
                 System.Console.WriteLine("what do you want to order?");
                 string test = System.Console.ReadLine();
                 System.Console.WriteLine("you chose: " + test);
             }
             Dictionary <string, double> My_Desserts = new Dictionary<string, double>();
             My_Desserts.Add ("1 Mocha of Mango", 4.00);
             My_Desserts.Add ("2 Mocha of Chocolate", 4.00);
             My_Desserts.Add ("3 Mocha of Strawberry", 4.00);
             My_Desserts.Add ("4 Mocha Green Tea", 4.00);
             My_Desserts.Add ("5 Mocha of Vanilla", 4.00);
             My_Desserts.Add ("6 Mocha Mont Blanc", 5.50);
            
            if (choice == "desserts")
             {
                 foreach (KeyValuePair<string, double> desserts in My_Desserts)
                 {
                     Console.WriteLine( desserts.Key.ToString() + " " + desserts.Value.ToString());
                 }
                 System.Console.WriteLine("will you like any desserts?");
                 string test = System.Console.ReadLine();
                 System.Console.WriteLine("you chose: " + test);
             }
        }
    }
    class StoreLocations
    {
        public void DisplayLcoations()
        {
            System.Console.WriteLine("Indicate your location?");
            System.Console.WriteLine("Arlington, Houston, Dallas, San Antonio");
            string choice = System.Console.ReadLine();

            List<string> locations = new List<string>();
            locations.Add("a Arlington");
            locations.Add("b Houston");
            locations.Add("c Dallas");
            locations.Add("d San Antonio");
            
            if (choice == "location")
             {
                 foreach (string location in locations)
                 {
                     Console.WriteLine(locations);
                 }
             }
        }
        
    }
}   

           

    //     public Displayorderhistory()




    // }

    // class StoreLocations
    // {

    // }
