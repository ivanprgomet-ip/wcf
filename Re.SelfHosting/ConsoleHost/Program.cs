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
        /// <summary>
        /// you only need to run this host, and will have access to the service via console interface.
        /// no need to first start the servcelibrary before running this project, because this is a host,
        /// not a client (which is a consumer and needs to have an upp and running servcie somewhere so taht
        /// the client can consume it).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(EvalService));

            // CONFIGURATION in program instead off in the app.config
            //host.AddServiceEndpoint(typeof(IEvalService), new BasicHttpBinding(), "Http://localhost:8080/evals/basic");

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
