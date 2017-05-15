using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary;
using System.ServiceModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(EvalService));

            // CONFIGURE host before open(). so that the host can actually find the 
            // servicelibrary project and the service its supposed to consume!


            try
            {
                host.Open();

                EvalService service = new EvalService();

                Eval eone= new Eval();
                eone.Submitter = "ivan prgomet";
                eone.Comments = "really cool | sweet | neat";
                eone.TimeSent = DateTime.Now;

                service.SubmitEval(eone);
                List<Eval> evals = service.GetEvals();

                PrintEvals(evals);

                host.Close();
            }
            catch (Exception)
            {
                host.Abort();
                throw;
            }

        }

        public static void PrintEvals(List<Eval> evals)
        {
            Console.WriteLine("_____________");
            foreach (var eval in evals)
            {
                Console.WriteLine(eval.Submitter);
                Console.WriteLine(eval.Comments);
                Console.WriteLine(eval.TimeSent);
                Console.WriteLine("_____________");
            }
        }
    }
}
