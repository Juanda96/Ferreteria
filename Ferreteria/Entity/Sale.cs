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
        private DateTime _date;
        private int _delivery;




        public Sale(int id, string bill, int idUser, int idProduct, int quantity, string type,int status, DateTime date , int delivery)
        {
            _id = id;
            _bill = bill;
            _idUser = idUser;
            _idProduct = idProduct;
            _quantity = quantity;
            _type = type;
            _status = status;
            _date = date;
            _delivery = delivery;
        }

        public Sale(string bill, int idUser, int idProduct, int quantity, string type, int status, int delivery)
        {
            _bill = bill;
            _idUser = idUser;
            _idProduct = idProduct;
            _quantity = quantity;
            _type = type;
            _status = status;
            _delivery = delivery;
        }

        public int delivery
        {
            get { return _delivery; }
            set { _delivery = value; }
        }

        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }


        public int status
        {
            get { return _status; }
            set { _status = value; }
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
