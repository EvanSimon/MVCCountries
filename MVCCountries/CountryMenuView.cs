using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryMenuView
    {
        public static string UserPick()
        {
            Console.WriteLine("What contient would you like to learn about");
            string input = Console.ReadLine();
            return input;
        }

        //public static void PickCont(string UserPick)
        //{
        //    List<Country> countries;
        //    List<string> countryNames = new List<string>();
        //    string input = CountryMenuView.UserPick();
        //    if (input.ToLower() == "north america")
        //    {
        //       NorthAmericaDB nadb = new NorthAmericaDB();
        //        countries = nadb.Countries;
        //        foreach (Country item in countries)
        //       {
        //            countryNames.Add(item.Name);
        //            Console.WriteLine(item.Name);
        //        }

        //    }

        //}

        //public static void PickCountry()
        //{

        //}

    }
}
