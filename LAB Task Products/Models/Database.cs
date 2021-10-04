using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB Task Products.Models
{
    public class Database
    {
        
            public class Database
        {
            public Products Products { get; set; }

            public Database()
            {
                string connString = @"Server=LAPTOP-6HJ3MM96\SQLEXPRESS;Database=Products;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connString);
                Products = new Products(conn);

            }
        }
    }
}