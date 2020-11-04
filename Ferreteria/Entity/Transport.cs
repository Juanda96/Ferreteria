using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Transport
    {
        private int _id;
        private string _carID;
        private int _idUser;

        public Transport(int id, string carID, int idUser)
        {
            _id = id;
            _carID = carID;
            _idUser = idUser;
        }

        public Transport(string carID, int idUser)
        {
            _carID = carID;
            _idUser = idUser;
        }

        public int idUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public string carID
        {
            get { return _carID; }
            set { _carID = value; }
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
