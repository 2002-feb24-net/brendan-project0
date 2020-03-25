using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Drinks
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public long Id { get; set; }
        static List<string> drinkNames = new List<string>();

        public Drinks()
        {
            Id = DateTime.Now.Ticks;
        }
        public Drinks(string name, int stock, decimal price)
        {
            this.name = name.ToLower();
            this.Id = Id;
            this.price = price;
            drinkNames.Add(name.ToLower());
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
            if (drinkNames.Contains(str))
            {
                return true;
            }
            return false;
        }
    }
}


/*public List<Drinks> displayDrinks = new List<Drinks>();
    public void Adddrink(string name, double cost, drinktype cat);

    Drinks entry = new Drinks(name, price, cat, Id);
    displayDrinks.Add(entry);

puplic override string ToString()
    {
        string drinkString = " ";

        return drinkStirng;
    }*/



















