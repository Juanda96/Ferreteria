using DataAccessObject;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class TransportBO
    {
        TransportDAO tdao = new TransportDAO();
        public LinkedList<Transport> getLinkedTransport()
        {
            return tdao.getTransportLink();
        }

        public DataTable getTransportDataTable()
        {
            return tdao.getTransportDataTable();
        }

        public void createTransport(string idcar, int iduser)
        {
            Transport newTransport = new Transport(idcar, iduser);
            tdao.addTransport(newTransport);
        }

        public void updateTransport(string idcar, int iduser, int oldId)
        {
            Transport newTransport = new Transport(idcar, iduser);
            tdao.updateTransport(newTransport, oldId);
        }

        public void deleteTransport(int id)
        {
            tdao.deleteTransport(id);
        }

        public void updateStatus(int status, string idCar)
        {
            tdao.updateStatus(status, idCar);
        }
        public DataTable selectTransportStatus()
        {
            return tdao.selectTransportStatus();
        }

        public LinkedList<string> selectTransportStatusLink()
        {
            return tdao.selectTransportStatusLink();
        }
    }
}
