using MVC_Countries;
namespace MVC_Countries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryController countries = new CountryController();
            countries.WelcomeAction();
        }
    }
}