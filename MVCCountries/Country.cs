using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class Country
    {
        public string Name;
        public string Lang;
        public string Hello;
        public string[] colors;

        public Country(string Name, string Lang, string Hello, string[] colors)
        {
            this.Name = Name;
            this.Lang = Lang;
            this.Hello = Hello;
            this.colors = colors;
        }

    }
}