using ClassLibBTDT.Business.Entities;
using ClassLibBTDT.Data.Framework;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClassLibBTDT.Data
{
    internal class CoffeeData : SqlServer<List<Coffee>>
    {
        private const string TABLE_NAME = "Coffees";
        public SelectResult<List<Coffee>> SelectAll()
        {
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = $"SELECT * FROM {TABLE_NAME};";
            return base.Select(selectCommand);
        }

        public InsertResult Insert(Coffee coffee)
        {
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = $"INSERT INTO {TABLE_NAME} (Name, Price) VALUES (@Name, @Price);";
            insertCommand.Parameters.AddWithValue("@Name", coffee.Name);
            insertCommand.Parameters.AddWithValue("@Price", coffee.Price);
            return base.Insert(insertCommand);
        }
    }
}