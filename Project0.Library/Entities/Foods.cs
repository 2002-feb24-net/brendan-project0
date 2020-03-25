using System;
using System.Collections.Generic;

namespace Project0.Library.Entities
{
    public partial class Foods
    {
        public Foods()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int FoodId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
