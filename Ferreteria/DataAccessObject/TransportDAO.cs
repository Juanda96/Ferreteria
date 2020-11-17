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

        public DataTable selectTransportStatus()
        {
            return tda.selectTransportStatus();
        }

        public DataTable selectTransportStatus1()
        {
            return tda.selectTransportStatus1();
        }

        public LinkedList<string> selectTransportStatusLink()
        {
            LinkedList<string> transports = new LinkedList<string>();
            DataTable dataTransport = tda.selectTransportStatus();
            DataTableReader reader = dataTransport.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string dats = reader[0].ToString();
                        transports.AddLast(dats);
                    }
                }
            } while (reader.NextResult());
            return transports;
        }

        public LinkedList<string> selectTransportStatusLink1()
        {
            LinkedList<string> transports = new LinkedList<string>();
            DataTable dataTransport = tda.selectTransportStatus1();
            DataTableReader reader = dataTransport.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string dats = reader[0].ToString();
                        string dato = reader[1].ToString();
                        transports.AddLast(dats);
                    }
                }
            } while (reader.NextResult());
            return transports;
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
            string SQL = "UPDATE UTN.transport SET idcar = '"+t.carID+"', iduser = '" + t.idUser + "' WHERE id = '" + id + "'";
            tda.audTransport(SQL);
        }

        
        public void updateStatus(int status, string idCar)
        {
            string SQL = "UPDATE UTN.transportStatus SET status = " + status + " WHERE idcar = '" + idCar + "'";
            tda.audTransport(SQL);
        }
    }
}
