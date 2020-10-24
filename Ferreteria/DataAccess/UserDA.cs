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
            SqlCommand command = new SqlCommand("SELECT [id],[dni],[name],[last],[code],[type] FROM[Ferreteria].[UTN].[users]");
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable users = new DataTable();
            data.Fill(users);
           
            return users;
        }


        
    }
}
