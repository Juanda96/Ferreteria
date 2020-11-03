using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _category;
        private string _description;
        private int _price;

        public Product(int id, string name, string category, string description, int price)
        {
            _id = id;
            _name = name;
            _category = category;
            _description = description;
            _price = price;
        }

        public Product(string name, string category, string description, int price)
        {
            _name = name;
            _category = category;
            _description = description;
            _price = price;
        }

        public int price
        {
            get { return _price; }
            set { _price = value; }
        }


        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        
    }
}
