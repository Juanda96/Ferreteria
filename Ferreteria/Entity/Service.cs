using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Service
    {
            private int _id;
            private string _name;
            private string _cate;
            private string _descri;
            private int _price;

            public Service(int id,  string name, string cate, string descri, int price)
            {
                _id = id;
                _name = name;
                _cate = cate;
                _descri = descri;
                _price = price;
            }

        public Service(string name, string cate, string desc, int price)
        {
            this.name = name;
            this.cate = cate;
            this.descri = desc;
            this.price = price;
            
        }

        public int id
            {
                get { return _id; }
                set { _id = value; }
            }


            public string name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string cate
            {
                get { return _cate; }
                set { _cate = value; }
            }

            public string descri
            {
                get { return _descri; }
                set { _descri = value; }
            }

            public int price
            {
                get { return _price; }
                set { _price = value; }
            }
        }
    }

