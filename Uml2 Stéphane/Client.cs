using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Stéphane
{
    internal class Client
    {
        private string _name;
        private string _password;
        private string _adress;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public Client(string name, string password, string adress)
        {
            Name = name;
            Password = password;
            Adress = adress;

        }
    }
}
