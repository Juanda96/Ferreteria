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

        public DataTable getUsersDataTable() 
        {
            return udao.getUserDataTable();
        }
    }
}
