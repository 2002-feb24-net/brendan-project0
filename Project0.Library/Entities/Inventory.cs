using System;
using System.Collections.Generic;

namespace Project0.Library.Entities
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
        public int StoreId { get; set; }
        public int FoodId { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Foods Food { get; set; }
        public virtual StoreLoc Store { get; set; }
    }
}
