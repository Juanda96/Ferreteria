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

        public LinkedList<User> getClientsLink()
        {
            LinkedList<User> users = new LinkedList<User>();
            DataTable dataUsers = uda.selectClients();
            DataTableReader reader = dataUsers.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                        users.AddLast(user);
                    }
                }
            } while (reader.NextResult());
            return users;
        }

        public DataTable getClientDataTable() 
        {
            return uda.selectClients();
        }


        /*
         * Add a new user with the database
         */
        public void addUser(User u) 
        {
            string value = "'"+u.dni+"','"+u.name+"','"+u.last+"','"+u.code+"','"+u.type+"','"+u.password+"'";
            string SQL = "INSERT INTO UTN.users (dni, name, last, code, type,password) VALUES ("+value+")";
            uda.audUser(SQL);
        }

        /*
      * Delete a user already registered with the database by ID
      */
        public void deleteUser(int dni)
        {
            string SQL = "DELETE FROM UTN.users WHERE dni = '"+dni+"'";
            uda.audUser(SQL);
        }


        /*
      * Update a user by ID with the database
      */
        public void updateUser(User u, int dni) 
        {
            string SQL = "UPDATE UTN.users SET dni = '" + u.dni + "', name = '" + u.name + "', last = '" + u.last + "', code = '" + u.code + "', type = '" + u.type + "',password = '" + u.password +"' WHERE dni = '"+ dni+"'";
            uda.audUser(SQL);
        }

    }
}
