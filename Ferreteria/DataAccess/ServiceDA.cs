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
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString);

        public DataTable selectServ()
        {
            SqlCommand command = new SqlCommand("SELECT [id],[name],[cate],[descri],[price] FROM[Ferreteria].[UTN].[serv]", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable serv = new DataTable();
            data.Fill(serv);

            return serv;
        }

        public void addServ(string SQL)
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