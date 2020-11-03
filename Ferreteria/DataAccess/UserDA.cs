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
    public class UserDA
    {
        //DataBase connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString);

        public DataTable selectUsers() 
        {
            SqlCommand command = new SqlCommand("SELECT [id],[dni],[name],[last],[code],[type],[password] FROM[Ferreteria].[UTN].[users]",connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable users = new DataTable();
            data.Fill(users);
           
            return users;
        }

        public void addUser(string SQL) 
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
