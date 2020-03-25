using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project0.Library.Entities;

namespace Project0.Library
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string name { get; set; }
        public int CustomerId { get; set; }
        public decimal price { get; set; }
        public DateTime OrderDate { get; set; }


    }
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Orders Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
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




   
                
                
     
