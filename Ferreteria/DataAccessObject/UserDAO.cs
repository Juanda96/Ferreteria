using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public DataTable GetUsers() 
        {
            return uda.selectUsers();
        }

    }
}
