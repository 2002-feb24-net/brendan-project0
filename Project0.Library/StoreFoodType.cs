using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class StoreFoodType 
    {
       public int StoreId { get; set; }
       public int ProductId { get; set; }
        #region NAVIGATIONAL PROPERTIES
        public Store Store { get; set; }
       public  FoodType FoodType { get; set; }
        #endregion
    }
}
