using SSGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SSGeek.Web.DAL
{
    public class ProductSqlDAO : IProductDAO
    {             

        public Product GetProduct(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                Product product = new Product();
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM products WHERE product_id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    product = RowToObject(reader);
                }
                return product;
            }
        }

        public IList<Product> GetProducts()
        {
            IList<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM products", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(RowToObject(reader));
                }
            }
            return products;
        }

        private Product RowToObject(SqlDataReader reader)
        {
            return new Product()
            {
                Name = Convert.ToString(reader["name"]),
                Description = Convert.ToString(reader["Description"]),
                Price = Convert.ToDecimal(reader["price"]),
                ImageName = Convert.ToString(reader["image_name"]),
                ProductId = Convert.ToInt32(reader["product_id"]),

            };
        }

        private readonly string connectionString;

        public ProductSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        
    }

}
