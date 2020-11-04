using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class TransportDAO
    {
        TransportDA tda = new TransportDA();

        public LinkedList<Transport> getTransportLink()
        {
            LinkedList<Transport> transports = new LinkedList<Transport>();
            DataTable dataTransport = tda.selectTransport();
            DataTableReader reader = dataTransport.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Transport transport = new Transport(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()));
                        transports.AddLast(transport);
                    }
                }
            } while (reader.NextResult());
            return transports;
        }

        public DataTable getTransportDataTable()
        {
            return tda.selectTransport();
        }

        public void addTransport(Transport t)
        {
            string value = "'" + t.carID + "','" + t.idUser + "'";
            string SQL = "INSERT INTO UTN.transport (idcar, iduser) VALUES (" + value + ")";
           tda.audTransport(SQL);
        }

        public void deleteTransport(int id)
        {
            string SQL = "DELETE FROM UTN.transport WHERE id = '" + id + "'";
            tda.audTransport(SQL);
        }

        public void updateTransport(Transport t, int id)
        {
            string SQL = "UPDATE UTN.transport SET iduser = '" + t.idUser + "' WHERE id = '" + id + "'";
            tda.audTransport(SQL);
        }
    }
}
