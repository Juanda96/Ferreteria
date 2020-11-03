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
            DataTable dataUsers = sev.selectServ();
            DataTableReader reader = dataUsers.CreateDataReader();
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

        public DataTable getServDataTable()
        {
            return sev.selectServ();
        }
        public void addServ(Service s)
        {
            string value = "'" +s.name + "','" + s.cate + "','" + s.descri + "','" + s.price + "'";
            string SQL = "INSERT INTO UTN.serv (name, cate, descri, price) VALUES (" + value + ")";
            sev.addServ(SQL);
        }
    }
}

