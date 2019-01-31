using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class NorthAmericaDB
    {
        public List<Country> Countries = new List<Country>();

        public NorthAmericaDB()
        {
            string[] Americancolors = { "Red", "White", "Blue" };
            Countries.Add(new Country("USA", "English", "Hello world!", Americancolors));
            string[] Mexico = { "Red", "White", "Green" };
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo", Mexico));
            string[] Canada = { "Red", "White" };
            Countries.Add(new Country("Canada", "English and French", "Bonjour le Monde", Canada));

        }

    }
}
