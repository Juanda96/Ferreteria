using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ProductDAO
    {
        ProductDA pda = new ProductDA();

        public LinkedList<Product> getProductLink()
        {
            LinkedList<Product> products = new LinkedList<Product>();
            DataTable dataProduct = pda.selectProduct();
            DataTableReader reader = dataProduct.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[4].ToString()), int.Parse(reader[5].ToString()));
                        products.AddLast(product);
                    }
                }
            } while (reader.NextResult());
            return products;
        }

        public DataTable getProductDataTable()
        {
            return pda.selectProduct();
        }

        public LinkedList<Product> getProductLinkSales()
        {
            LinkedList<Product> products = new LinkedList<Product>();
            DataTable dataProduct = pda.selectProductSales();
            DataTableReader reader = dataProduct.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[4].ToString()), int.Parse(reader[5].ToString()));
                        products.AddLast(product);
                    }
                }
            } while (reader.NextResult());
            return products;
        }

        public DataTable getProductDataTableSales()
        {
            return pda.selectProductSales();
        }

        public void addProduct(Product p)
        {
            string value = "'" + p.name + "','" + p.category + "','" + p.description + "','" + p.price + "'" + "','" + p.quantity + "'";
            string SQL = "INSERT INTO UTN.product (name, category, description, price) VALUES (" + value + ")";
            pda.audProduct(SQL);
        }

        public void deleteProduct(int id)
        {
            string SQL = "DELETE FROM UTN.product WHERE id = '" + id + "'";
            pda.audProduct(SQL);
        }

        public void updateProduct(Product p, int id)
        {
            string SQL = "UPDATE UTN.product SET name = '" + p.name + "', category = '" + p.category + "', description = '" + p.description + "', price = '" + p.price + "'"+ "','" + p.quantity + "' WHERE id = '" + id + "'";
            pda.audProduct(SQL);
        }
    }
}
