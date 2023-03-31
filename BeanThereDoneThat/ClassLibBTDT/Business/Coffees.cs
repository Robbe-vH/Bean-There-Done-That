using ClassLibBTDT.Business.Entities;
using ClassLibBTDT.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClassLibBTDT.Business
{
    public static class Coffees
    {
        public static List<Coffee> GetCoffees()
        {
            List<Coffee> coffees = new List<Coffee>();
            SqlConnection conn = new SqlConnection(ConnectionSettings.ConnString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Coffees", conn))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Coffee coffee = new Coffee
                        (
                            reader.GetInt32(0),     // CoffeeID
                            reader.GetString(1),    // Origin
                            reader.GetString(2),    // Roast
                            reader.GetString(3),    // Flavor
                            reader.GetInt32(4),     // ArabicaPercentage
                            reader.GetBoolean(5),   // Decaf
                            reader.GetDouble(6),    // Price
                            reader.GetInt32(7)      // Stock
                        );

                        coffees.Add(coffee);
                    }
                }
            }

            return coffees;
        }
    }
}