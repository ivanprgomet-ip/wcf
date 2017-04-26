using L01E01.ServiceHost.GreetServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01E01.ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetServiceClient service = new GreetServiceClient("BasicHttpBinding_IGreetService");
            Name current = new Name();

            Console.WriteLine("Enter firstname: ");
            current.Firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname: ");
            current.Lastname = Console.ReadLine();

            Console.WriteLine(service.Greet(current));

            Console.ReadKey();
        }
    }
}
