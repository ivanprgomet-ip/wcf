using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoWeatherService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.GlobalWeatherSoapClient client = new ServiceReference.GlobalWeatherSoapClient("GlobalWeatherSoap");

            string Country = "Croatia";

            string cities = client.GetCitiesByCountry(Country);

            Console.WriteLine(cities);

        }
    }
}
