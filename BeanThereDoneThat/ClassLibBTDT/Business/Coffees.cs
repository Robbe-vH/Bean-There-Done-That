using ClassLibBTDT.Business.Entities;
using ClassLibBTDT.Data;
using ClassLibBTDT.Data.Framework;
using System.Collections.Generic;

namespace ClassLibBTDT.Business
{
    public static class Coffees
    {
        public static SelectResult<List<Coffee>> GetCoffees()
        {
            CoffeeData coffeeData = new CoffeeData();
            SelectResult<List<Coffee>> result = coffeeData.SelectAll();
            return result;
        }

        public static InsertResult InsertCoffee(Coffee coffee)
        {
            CoffeeData coffeeData = new CoffeeData();
            InsertResult result = coffeeData.Insert(coffee);
            return result;
        }
    }
}