using System;
using System.Collections.Generic;
using MySql.Data;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ProductsUI
{
    class DataAccess
    {
        public List<Product> GetProducts(string modelNumber)
        {
            //##MySql access
            //using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(Helper.CnnVal("db750001494")))
            //{
            //  return connection.Query<Product>("select * from products where model_no = '{ model_no }'").ToList();
            //}
            //##SqlServer access
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("50offknives")))
            {
                var output = connection.Query<Product>("dbo.Products_GetByModelNumber @ModelNumber", new { ModelNumber = modelNumber }).ToList();
                return output;
            }
        }

        public void InsertProduct(string modelNumber, string manufacturer, string description, float size, string type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("50offknives")))
            {
                List<Product> products = new List<Product>();

                products.Add(new Product { ModelNumber = modelNumber, Manufacturer = manufacturer, Description = description, Size = size, Type = type });

                connection.Execute("dbo.Products_Insert @ModelNumber, @Manufacturer, @Description, @Size, @Type", products);
            }
        }
    }
}
