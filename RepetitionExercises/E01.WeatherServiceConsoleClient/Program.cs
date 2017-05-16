using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01.WeatherServiceConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.GlobalWeatherSoapClient client = new ServiceReference.GlobalWeatherSoapClient("GlobalWeatherSoap");
            string Country = "Germany";
            string citiesReturned = client.GetCitiesByCountry(Country);

            Console.WriteLine(Country+": ");
            Console.WriteLine(citiesReturned);
        }
    }
}
