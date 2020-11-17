using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObject;
using Entity;

namespace BussinessObject
{
    public class UserBO
    {
        UserDAO udao = new UserDAO();

        public User getLogin(int user, string password) 
        {
            User u = null;
            foreach (User item in udao.getUserLink())
            {
                if((user == item.dni) && password.Equals(item.password))
                {
                    u = item;
                }
            }
            return u;
        }

        public LinkedList<User> getLinkedUser() 
        {
            return udao.getUserLink();
        }

        public DataTable getUsersDataTable() 
        {
            return udao.getUserDataTable();
        }

        public LinkedList<User> getLinkedClients()
        {
            return udao.getClientsLink();
        }

        public DataTable getClientsDataTable()
        {
            return udao.getClientDataTable();
        }



        /*Create a new user with added parameters
         * 
         * 
         */
        public void createUser(int dni,string name,string last,string type,string code,string pass)
        {
            User newUser = new User(dni,name,last,code,type,pass);
            udao.addUser(newUser);
        }

        /*
         * Update an already registered user
         * 
         */
        public void updateUser(int dni, string name, string last, string type, string code, string pass, int oldDni) 
        {
            User newUser = new User(dni, name, last, code, type, pass);
            udao.updateUser(newUser,oldDni);
        }

        /*
         *Delete a user by ID
         */
        public void deleteUser(int dni)
        {
            udao.deleteUser(dni);
        }
    }
}
