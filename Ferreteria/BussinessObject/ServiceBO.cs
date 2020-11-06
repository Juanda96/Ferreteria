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
        ServiceDAO sDao = new ServiceDAO();

        public DataTable getServDataTable()
        {
            return sDao.getServDataTable();
        }

        public void createServ(string name, string cate, string descri, int price)
        {
            Service newServ = new Service(name, cate, descri, price);
            sDao.addServ(newServ);
        }
        public void updateServ(int id,string name, string cate, string descri, int price, int oldid)
        {
            Service newServ = new Service(id, name, cate, descri, price);
            sDao.updateServ(newServ, oldid);
        }

        public void deleteServ(int id)
        {
            sDao.deleteServ(id);
        }
    }
}

