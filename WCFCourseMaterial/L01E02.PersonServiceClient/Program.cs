using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01E02.PersonServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonServiceReference.PersonServiceClient client = new PersonServiceReference.PersonServiceClient();

            while (true)
            {
                Console.WriteLine("Name:" + client.GetFullname()
                    + Environment.NewLine + client.GetAddress());
                Console.WriteLine();

                Console.WriteLine("Make a decision: ");
                Console.WriteLine("1. edit firstname");
                Console.WriteLine("2. edit lastname");
                Console.WriteLine("3. edit phone");
                Console.WriteLine("4. edit address");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter new firstname: ");
                        client.EditFirstname(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Enter new lastname: ");
                        client.EditLastname(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Enter new phone number: ");
                        client.EditPhone(int.Parse(Console.ReadLine()));
                        break;
                    case "4":
                        Console.WriteLine("Enter new street address: ");
                        client.EditAddress(Console.ReadLine());
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
        }
    }
}
