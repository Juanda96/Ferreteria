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
    public class ServiceBO
    {
        ServiceDAO sevDao = new ServiceDAO();
        public DataTable getServDataTable()
        {
            return sevDao.getServDataTable();
        }
    }
}
