using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        private int _id;
        private int _dni;
        private string _name;
        private string _last;
        private string _code;
        private string _type;
        private string _password;

        public User(int id, int dni, string name, string last, string code, string type, string password)
        {
            _id = id;
            _dni = dni;
            _name = name;
            _last = last;
            _code = code;
            _type = type;
            _password = password;

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

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
