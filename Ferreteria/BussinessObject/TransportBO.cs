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
        public LinkedList<Transport> getLinkedTransport()
        {
            return tdao.getTransportLink();
        }

        public DataTable getTransportDataTable()
        {
            return tdao.getTransportDataTable();
        }

        /*Permite realizar un nuevo envió con el servicio o producto creado
         */
        public void createTransport(string idcar, int iduser)
        {
            Transport newTransport = new Transport(idcar, iduser);
            tdao.addTransport(newTransport);
        }

        /* Método para actualizar transporte
         */
        public void updateTransport(string idcar, int iduser, int oldId)
        {
            Transport newTransport = new Transport(idcar, iduser);
            tdao.updateTransport(newTransport, oldId);
        }

        /*Eliminar un transporte por id
         * 
         * 
         */
        public void deleteTransport(int id)
        {
            tdao.deleteTransport(id);
        }



        /*Actualizar el estado del transporte, si se encuentran camiones disponibles o
         * realizando entregas
         * 
         */
        public void updateStatus(int status, string idCar)
        {
            tdao.updateStatus(status, idCar);
        }
        public DataTable selectTransportStatus()
        {
            return tdao.selectTransportStatus();
        }

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
