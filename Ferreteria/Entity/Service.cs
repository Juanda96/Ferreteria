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
            private int _dni;
            private string _name;
            private string _last;
            private string _cate;
            private string _desc;
            private string _precio;

            public Service(int id, int dni, string name, string last, string cate, string desc, string precio)
            {
                _id = id;
                _dni = dni;
                _name = name;
                _last = last;
                _cate = cate;
                _desc = desc;
                _precio = precio;
            }

            public int id
            {
                get { return _id; }
                set { _id = value; }
            }

            public int dni
            {
                set { _dni = value; }
                get { return _dni; }
            }

            public string name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string last
            {
                get { return _last; }
                set { _last = value; }
            }

            public string cate
            {
                get { return _cate; }
                set { _cate = value; }
            }

            public string desc
            {
                get { return _desc; }
                set { _desc = value; }
            }

            public string precio
            {
                get { return _precio; }
                set { _precio = value; }
            }
        }
    }

