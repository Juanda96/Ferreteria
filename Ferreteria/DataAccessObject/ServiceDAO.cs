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
    public class ServiceDAO
    {
        ServiceDA sev = new ServiceDA();


        public LinkedList<Service> getServLink()
        {
            LinkedList<Service> serv = new LinkedList<Service>();
            DataTable dataService = sev.selectServ();
            DataTableReader reader = dataService.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Service servi = new Service(int.Parse(reader[0].ToString()),  reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),int.Parse(reader[4].ToString()));
                        serv.AddLast(servi);
                    }
                }
            } while (reader.NextResult());
            return serv;
        }

        public DataTable getServDataTableSale()
        {
            return sev.selectServiceSale();
        }

        public DataTable getServDataTable()
        {
            return sev.selectServ();
        }
        public void addServ(Service s)
        {
            string value = "'" +s.name + "','" + s.cate + "','" + s.descri + "','" + s.price + "'";
            string SQL = "INSERT INTO UTN.serv (name, cate, descri, price) VALUES (" + value + ")";
            sev.audServ(SQL);
        }

        public void deleteServ(int id)
        {
            string SQL = "DELETE FROM UTN.serv WHERE id = '" + id + "'";
            sev.audServ(SQL);
        }

        public void updateServ(Service s, int id)
        {
            string SQL = "UPDATE UTN.serv SET name = '" + s.name + "', cate = '" + s.cate + "', descri = '" + s.descri +
                "', price = '" + s.price + "' WHERE id = '" + id + "'";
            sev.audServ(SQL);
        }
    }
}

