using MVC_Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Countries
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("USA", "North America", new List<string> {"Red", "White", "Blue" }),
            new Country("Nigeria", "Africa", new List<string> {"Green", "White" }),
            new Country("India", "Asia", new List<string> {"Orange", "White", "Green" }),
            new Country("Minnie's Country", "Antartica", new List<string> {"Purple", "Black", "Blue" }),
        };
        

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            bool goAgain = true;
            while (goAgain)
            {
                CountryListView wv = new CountryListView();
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                CountryListAction();
                Console.WriteLine("Would you like to learn about another country? y/n");
                string another = Console.ReadLine();
                if (another == "y")
                {
                    goAgain = true;
                }
                else if (another == "n")
                {
                    Console.WriteLine("Goodbye");
                    goAgain = false;
                }
                else
                {
                    Console.WriteLine("That was invalid.");
                    another = Console.ReadLine();
                }
            }
        }
        public void CountryListAction()
        {
            CountryListView clv = new CountryListView();
            clv.Display();
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Console.WriteLine(index);
            Console.WriteLine();
           
             //* This should print the name and index of each country in our CountriesDb. Next allow the user to select a country by index. 
             //* Upon getting the country out of CountryDb, pass that country along to the CountryAction() method. 
             //* After that’s done, ask if the user would like to learn about another country. 

        }

    }
}
