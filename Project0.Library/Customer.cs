using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Project0.Library.Entities;

namespace Project0.Library
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string lastname { get; set; }
        public int Id { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }

        public Orders Order { get; set; }


        public static void DisplayCustomers(RestaurantAfrikContext ctx)
        {

            List<Customers> Customer = ctx.Customers.ToList();

            foreach (var item in Customer)
            {
                Console.WriteLine($"{item.CustomerId} \n{item.FirstName} {item.LastName} \n{item.Address} {item.Phone} {item.City} {item.State} {item.Zipcode} ");
            }
            Console.WriteLine(" If you are already Registered, Select from the customer list");
            Console.ReadLine();

        }
        public static void addnewCustomer(RestaurantAfrikContext ctx)
        {

            Customers newCustomer = new Customers();

            Console.Write("Please enter your first name: ");
            newCustomer.FirstName = Console.ReadLine();


            Console.Write("Ok, now enter your last name: ");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is your address: ? ");
            newCustomer.Address = Console.ReadLine();


            Console.Write("Enter phone: ");
            newCustomer.Phone = System.Console.ReadLine();

            ctx.Customers.Add(newCustomer);
            ctx.SaveChanges();
            Thread.Sleep(2000);
        }
        public static void CustomerLogin(RestaurantAfrikContext ctx)
        {

            Console.Write("Please Enter Username: ");
            string Username = Console.ReadLine();
            Console.Write("Now Please Enter your Password: ");
            string password = ReadPassword();
            Console.WriteLine("\n If no one is looking at your device");
            Console.WriteLine("I will confirm the password you just gave");
            Console.WriteLine("All your inputs will disappear in 3 seconds");
            Console.WriteLine("\n Press any key to see it now");
            Console.WriteLine("\n If your password does not match try again");
            Console.ReadKey(true);
            Console.Write("\nThe password you entered is :" + password);
            Thread.Sleep(1000);
            Console.Clear();
            Console.ReadKey(true);
        }
        public static string CustomerReadPassword(RestaurantAfrikContext ctx)
        {
            Console.WriteLine("Provide a valid machine or domain account. [domain\\user]");
            Console.WriteLine("   Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("   Enter password:");
                string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    password += info.KeyChar;
                    info = Console.ReadKey(true);
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring
                        (0, password.Length - 1);
                    }
                    info = Console.ReadKey(true);
                }
            }
            for (int i = 0; i < password.Length; i++)
                Console.Write("*");
            return password;
        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            Console.WriteLine();
            return password;

        }



        /*public DisplayCustomer(string first, string last, string address, long phone)
        {
            this.firstName = first;
            this.lastName = last;
            this.address = address;
            this.Id = Id;
            this.phoneNumber = phone;

        }*/
    }


}


    /*public string Customers()
    {
         return firstName + " " + lastName + " " + address + " " + zipcode + " " + phoneNumber;
    }


    private string firstName;
    private string lastName;
    private string address;
    //private int zipcode;
    private string phoneNumber;*//*

    // this code below will act as method for the user to input information of some form if necessary.
    // depending on which on works better. 
    public void Register()
    {
        Console.Write("Enter your name: ");
        firstName = System.Console.ReadLine();

        Console.Write("Enter your last name: ");
        lastName = System.Console.ReadLine();

        Console.Write("Enter street address: ");
        address = System.Console.ReadLine();

        for (int t = 3; t >= 0; t--)
        {
            Console.Write("Enter phone");
            string phone = System.Console.ReadLine();
            char[] phoneArr = phone.ToCharArray();
            int x = 0;
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
                phoneNumber = phone;
                System.Console.WriteLine("Invalid input. You have " + t + " tries left.");

            }

            if (t == 0)
            {
                Console.WriteLine("You have reached the maximum limit. Please restart application");
                System.Environment.Exit(1);

            }
            break;
        }

    }
    public static void AddDrinkType()
    {
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
        while (Drinkchoice);
        Food addFood = new Food();
        addFood.addFoodtype(name, price, food);
        Console.WriteLine(addFoodtype.ToString());

    }
    public List<Drinks> displayDrinks = new List<Drinks>();
    public void Adddrink(string name, double cost, drinktype cat);
    {
        Drinks entry = new Drinks(name, price, cat, Id);
    displayDrinks.Add(entry);

    puplic override string ToString()
    {
        string drinkString = " ";

        return drinkStirng;
    }

    public static void AddFoodtype()
    {
        Console.WriteLine("Enter name of Food: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter price of Food: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Food type");
        bool Foodchoice = true;
        do
        {
            try
            {
                Foodtype food = (Foodtype)string.Parse(typeof(Foodtype).Console.ReadLine());
                Foodchoice = false;
            }
            catch
            {
                Console.WriteLine("Please Enter the Correct Food Type");
            }
        }
        while (Foodchoice);
        Food addFood = new Food();
        addFood.addFoodtype(name, price, food);
        Console.WriteLine(addFoodtype.ToString());

    }
    public static void AddStore()
    {
        Console.WriteLine("Enter location of Store: ");
        string location = Console.ReadLine();
        Console.WriteLine("Enter Id of Store: ");
        int Id = int.Parse(Console.ReadLine());

        bool Storechoice = true;
        do
        {
            try
            {
                Foodtype food = (Foodtype)string.Parse(typeof(Foodtype).Console.ReadLine());
                Storelocation = false;
            }
            catch
            {
                Console.WriteLine("Please Enter the Correct Food Type");
            }
        }
        while (Foodchoice);
        Food addFood = new Food();
        addFood.addFoodtype(name, price, food);
        Console.WriteLine(addFoodtype.ToString());

    }
}*/


