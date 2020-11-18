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
    public class TransportDA
    {
        //DataBase connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionJuan"].ConnectionString);

        public DataTable selectTransport()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[transport]", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable transports = new DataTable();
            data.Fill(transports);

            return transports;
        }

        public DataTable selectTransportStatus()
        {
            SqlCommand command = new SqlCommand("SELECT [idCar],[status] FROM[Ferreteria].[UTN].[TransportStatus] WHERE status = 0", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable transports = new DataTable();
            data.Fill(transports);

            return transports;
        }
        public DataTable selectTransportStatus1()
        {
            SqlCommand command = new SqlCommand("SELECT [idCar],[status] FROM[Ferreteria].[UTN].[TransportStatus] WHERE status = 1", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable transports = new DataTable();
            data.Fill(transports);

            return transports;
        }

        public void audTransport(string SQL)
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
