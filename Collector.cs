using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatist
{
    public class Сollector
    {
        private string name;
        private string country;
        private string details;
        private string rarecoin;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        public string Rarecoin
        {
            get { return rarecoin; }
            set { rarecoin = value; }
        }

        public Сollector()
        {
            this.name = string.Empty;
            this.country = string.Empty;
            this.details = string.Empty;
            this.rarecoin = string.Empty;
        }

        public Сollector(string n, string c, string d, string r)
        {
            name = n;
            country = c;
            details = d;
            rarecoin = r;
        }
    }
}
