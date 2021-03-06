﻿using DataAccessObject;
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

        /*
         * GET ALL TRANSPORT LINKEDLIST
         */
        public LinkedList<Transport> getLinkedTransport()
        {
            return tdao.getTransportLink();
        }
        /*
         * GET ALL TRANSPORT DATATABLE
         */
        public DataTable getTransportDataTable()
        {
            return tdao.getTransportDataTable();
        }

        /*
         * It allows to make a new shipment with the service or product created
         */
        public void createTransport(string idcar, int iduser)
        {
            Transport newTransport = new Transport(idcar, iduser);
            tdao.addTransport(newTransport);
        }

        /* 
         * Method to update transportation
         */
        public void updateTransport(string idcar, int iduser, int oldId)
        {
            Transport newTransport = new Transport(idcar, iduser);
            tdao.updateTransport(newTransport, oldId);
        }

        /* 
         *Delete a transport by id 
         */
        public void deleteTransport(int id)
        {
            tdao.deleteTransport(id);
        }



        /*
         * Update the transport status, if trucks are available or making deliveries
         */
        public void updateStatus(int status, string idCar)
        {
            tdao.updateStatus(status, idCar);
        }
        /*
         * GET TRANSPORT STATUS DATATABLE
         */
        public DataTable selectTransportStatus()
        {
            return tdao.selectTransportStatus();
        }
        /*
         * GET TRANSPORT STATUS DATATABLE
         */
        public DataTable selectTransportStatus1()
        {
            return tdao.selectTransportStatus1();
        }

        public LinkedList<string> selectTransportStatusLink()
        {
            return tdao.selectTransportStatusLink();
        }
        public LinkedList<string> selectTransportStatusLink1()
        {
            return tdao.selectTransportStatusLink1();
        }
    }
}
