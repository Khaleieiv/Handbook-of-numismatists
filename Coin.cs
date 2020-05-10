using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatist
{
    public class Coin
    {
        private string name;
        private string year;
        private string country;
        private string describe;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }

        public Coin()
        {
            this.name = string.Empty;
            this.year = string.Empty;
            this.country = string.Empty;
            this.describe = string.Empty;
        }

        public Coin(string n, string y, string c, string d)
        {
            name = n;
            year = y;
            country = c;
            describe = d;
        }
    }
}
