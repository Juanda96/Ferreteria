using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DataAccess;
using Entity;

namespace DataAccessObject
{
    public class UserDAO
    {
        UserDA uda = new UserDA();

        public LinkedList<User> getUserLink() 
        {
            LinkedList<User> users = new LinkedList<User>();
            DataTable dataUsers = uda.selectUsers();
            DataTableReader reader = dataUsers.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                        users.AddLast(user);
                    }
                }
            } while (reader.NextResult());
            return users;
        }

        public DataTable getUserDataTable()
        {
            return uda.selectUsers();
        }

    }
}
