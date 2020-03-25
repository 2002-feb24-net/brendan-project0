using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
    {
        public class Products
        {
            
            public void Displayallorders()
            {
                System.Console.WriteLine("What do you want to order?");
                System.Console.WriteLine("beverages, combinations, entrees, desserts");
                string choice = System.Console.ReadLine();


                Dictionary<string, double> My_beverages = new Dictionary<string, double>();
                //private.Dictionary<string, s>
                My_beverages.Add("1 Mango Juice", 3.00);
                My_beverages.Add("2 Bottled", 2.00);
                My_beverages.Add("3 Soft Drinks", 2.25);
                My_beverages.Add("4 Ice Tea", 2.25);
                My_beverages.Add("5 Cranberry Juice", 2.25);
                My_beverages.Add("6 Coffee", 2.25);

                if (choice == "beverages")
                {
                    foreach (KeyValuePair<string, double> beverage in My_beverages)
                    {
                        Console.WriteLine(beverage.Key.ToString() + " " + beverage.Value.ToString());
                    }
                    System.Console.WriteLine("what will you like to drink?");
                    string test = System.Console.ReadLine();
                    System.Console.WriteLine("you chose: " + test);
                }

                Dictionary<string, double> My_Entrees = new Dictionary<string, double>();
                My_Entrees.Add("1 Scotch Eggs", 3.00);
                My_Entrees.Add("2 Chin Chin", 3.00);
                My_Entrees.Add("3 Puff Puff", 2.00);
                My_Entrees.Add("4 Spicy Chicken", 4.00);
                My_Entrees.Add("5 Glazed Chicken", 4.00);
                My_Entrees.Add("6 Chapati", 1.50);

                if (choice == "entrees")
                {
                    foreach (KeyValuePair<string, double> entree in My_Entrees)
                    {
                        Console.WriteLine(entree.Key.ToString() + " " + entree.Value.ToString());
                    }
                    System.Console.WriteLine("what entrees will you like?");
                    string test = System.Console.ReadLine();
                    System.Console.WriteLine("you chose: " + test);
                }

                Dictionary<string, double> My_CombinationPlates = new Dictionary<string, double>();
                // Dictionary<string, food> My_CombinationPlates = new Dictionary<string, double>();
                My_CombinationPlates.Add("1 Fried Rice", 13.00);
                My_CombinationPlates.Add("2 Yam & Egusi", 15.50);
                My_CombinationPlates.Add("3 Suya", 10.00);
                My_CombinationPlates.Add("4 Grilled Fish", 15.50);
                My_CombinationPlates.Add("5 Grilled Chicken", 12.25);
                My_CombinationPlates.Add("6 Rice & Stew", 11.50);
                My_CombinationPlates.Add("7 Peperred Meat", 18.50);

                if (choice == "combinations")
                {
                    foreach (KeyValuePair<string, double> combinations in My_CombinationPlates)
                    {
                        Console.WriteLine(combinations.Key.ToString() + " " + combinations.Value.ToString());
                    }
                    System.Console.WriteLine("what do you want to order?");
                    string test = System.Console.ReadLine();
                    System.Console.WriteLine("you chose: " + test);
                }
                Dictionary<string, double> My_Desserts = new Dictionary<string, double>();
                My_Desserts.Add("1 Mocha of Mango", 4.00);
                My_Desserts.Add("2 Mocha of Chocolate", 4.00);
                My_Desserts.Add("3 Mocha of Strawberry", 4.00);
                My_Desserts.Add("4 Mocha Green Tea", 4.00);
                My_Desserts.Add("5 Mocha of Vanilla", 4.00);
                My_Desserts.Add("6 Mocha Mont Blanc", 5.50);

                if (choice == "desserts")
                {
                    foreach (KeyValuePair<string, double> desserts in My_Desserts)
                    {
                        Console.WriteLine(desserts.Key.ToString() + " " + desserts.Value.ToString());
                    }
                    System.Console.WriteLine("will you like any desserts?");
                    string test = System.Console.ReadLine();
                    System.Console.WriteLine("you chose: " + test);
                }
            }
        }

    }