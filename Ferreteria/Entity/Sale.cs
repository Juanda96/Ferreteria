using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sale
    {
        private int _id;
        private string _bill;
        private int _idUser;
        private int _idProduct;
        private int _quantity;
        private string _type;
        private int _status;

        public int status
        {
            get { return _status; }
            set { _status = value; }
        }


        public Sale(int id, string bill, int idUser, int idProduct, int quantity, string type,int status)
        {
            _id = id;
            _bill = bill;
            _idUser = idUser;
            _idProduct = idProduct;
            _quantity = quantity;
            _type = type;
            _status = status;
        }

        public Sale(string bill, int idUser, int idProduct, int quantity, string type, int status)
        {
            _bill = bill;
            _idUser = idUser;
            _idProduct = idProduct;
            _quantity = quantity;
            _type = type;
            _status = status;
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }


        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public int idProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }


        public int idUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }


        public string bill
        {
            get { return _bill; }
            set { _bill = value; }
        }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
