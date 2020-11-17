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
        public LinkedList<Service> getLinkedServ()
        {
            return sDao.getServLink();
        }

        public DataTable getServDataTableSale()
        {
            return sDao.getServDataTableSale();
        }

        /*
         * Create or request a new service
         */
        public void createServ(int id,string name, string cate, string descri, int price)
        {
            Service newServ = new Service(id,name, cate, descri, price);
            sDao.addServ(newServ);
        }

        /*
         * It allows modifying a service already registered previously
         */
        public void updateServ(string name, string cate, string descri, int price, int oldid)
        {
            Service newServ = new Service( name, cate, descri, price);
            sDao.updateServ(newServ, oldid);
        }

        /*
         * Method to delete a service by id
         */
        public void deleteServ(int id)
        {
            sDao.deleteServ(id);
        }
    }
}

