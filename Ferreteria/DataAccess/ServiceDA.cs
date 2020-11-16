using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ServiceDA
    {
        //DataBase connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionJuan"].ConnectionString);

        public DataTable selectServ()
        {
            SqlCommand command = new SqlCommand("SELECT [id],[name],[cate],[descri],[price] FROM[Ferreteria].[UTN].[serv] ", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable serv = new DataTable();
            data.Fill(serv);

            return serv;
        }

        public DataTable selectServiceSale()
        {
            SqlCommand command = new SqlCommand("SELECT [id],[name],[descri],[price] FROM[Ferreteria].[UTN].[serv] ", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable serv = new DataTable();
            data.Fill(serv);

            return serv;
        }

        public void audServ(string SQL)
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