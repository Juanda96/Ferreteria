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
    public class SaleDA
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionJuan"].ConnectionString);

        public DataTable selectSale()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[sale]", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectSalePayment()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[sale] WHERE status = 0", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public void audSale(string SQL)
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
