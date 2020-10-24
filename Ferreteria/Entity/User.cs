using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class User
    {
        private int _id;
        private int _dni;
        private string _name;
        private string _last;
        private string _code;
        private string _type;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int MyProperty
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

        public string  code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
