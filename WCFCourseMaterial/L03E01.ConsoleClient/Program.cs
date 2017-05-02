using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03E01.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.addSoapClient freeWebServiceClient = new ServiceReference.addSoapClient();
            double time = new double();
            int sum = new int();

            int num1 = 5;
            int num2 = 10;

            sum = freeWebServiceClient.add(5, 10,out time);

            Console.WriteLine($"FreeWebServices.com/add.wsdl returned:\n\n>> {num1}+{num2}={sum}, time={time}");
            Console.ReadKey();
        }
    }
}
