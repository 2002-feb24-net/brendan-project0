using System;
using System.Collections.Generic;

namespace Project0.Library.Entities
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int OrderDate { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderTime { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual StoreLoc Store { get; set; }
    }
}
