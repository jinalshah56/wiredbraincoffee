﻿

using WiredBrainCofee.DataAccess.model;

namespace WiredBrainCofee.DataAccess
{
    public class coffeshopdataprovider
    {
        public IEnumerable<coffeeshop> LoadCoffeeShops() 
        {
            yield return new coffeeshop { location = "ahmedabad", BeansInStockInKg = 108 };
            yield return new coffeeshop { location = "memdavad", BeansInStockInKg = 18 };
            yield return new coffeeshop { location = "abcd", BeansInStockInKg = 80 };
            yield return new coffeeshop { location = "cd", BeansInStockInKg = 809 };
            yield return new coffeeshop { location = "abd", BeansInStockInKg = 287 };
            yield return new coffeeshop { location = "bcd", BeansInStockInKg = 230 };

        }
    }
}
