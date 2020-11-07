using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDA
    {
        //DataBase connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString);

        public DataTable selectProduct()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[product]", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable products = new DataTable();
            data.Fill(products);

            return products;
        }

        public DataTable selectProductSales()
        {
            SqlCommand command = new SqlCommand("SELECT [id],[name],[price],[quantity] FROM [Ferreteria].[UTN].[product]", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable products = new DataTable();
            data.Fill(products);

            return products;
        }

        public void audProduct(string SQL)
        {
            SqlCommand command = new SqlCommand(SQL, connection);
            try
            {
                Console.WriteLine(SQL);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
