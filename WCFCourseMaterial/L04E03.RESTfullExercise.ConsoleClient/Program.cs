using L04E03.RESTfullExercise.EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace L04E03.RESTfullExercise.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebChannelFactory<IEvalService> cf = new WebChannelFactory<IEvalService>(
                 new Uri("http://localhost:8080/evalservice"));

            IEvalService client = cf.CreateChannel();

            while (true)
            {
                Console.WriteLine("Enter a commando >> ");
                string comm = Console.ReadLine();

                switch (comm)
                {
                    case "submit":
                        // getting all the required fields for the new eval to create
                        Console.WriteLine("Who is the subbmitter? >> ");
                        string submter = Console.ReadLine();

                        Console.WriteLine("enter comments in one string >> ");
                        string comments = Console.ReadLine();

                        Console.WriteLine("Enter an unique id for the EVAL >> ");
                        string id = Console.ReadLine();

                        // creating the EVAL
                        Eval e = new Eval()
                        {
                            Comments = comments,
                            Submitter = submter,
                            TimeSent = DateTime.Now,
                            Id = id,
                        };

                        // subbmitting the new eval
                        client.SubmitEval(e);

                        Console.WriteLine("Created!");

                        break;
                    case "get":
                        Console.WriteLine("enter a id");
                        string input = Console.ReadLine();

                        Eval retrieved = client.GetEval(input);
                        Console.WriteLine("Entered: ");
                        Console.WriteLine(retrieved.Comments + ' ' + retrieved.Submitter);
                        break;
                    case "list":
                        Console.WriteLine("Enter a subbmitter >>");
                        string submitterInput = Console.ReadLine();

                        client.GetEvalsBySybmitter(submitterInput);

                        break;
                    case "remove":
                        Console.WriteLine("Id to remove >> ");
                        string removeId = Console.ReadLine();
                        client.RemoveEval(removeId);
                        break;
                    default:
                        Console.WriteLine("Command is not supported!");
                        break;
                }
                if (comm == "exit")
                    break;
                Console.ReadKey();
            }

            Console.WriteLine("exiting program");
        }
    }
}
