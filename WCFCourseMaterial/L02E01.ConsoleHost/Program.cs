﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using L02E01.EvalServiceLibrary;
using System.ServiceModel.Description;

namespace L02E01.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EvalService));

            //configure host before opening
            host.AddServiceEndpoint(typeof(IEvalService),new BasicHttpBinding(),"Http://localhost:8080/evals/basic");
            host.AddServiceEndpoint(typeof(IEvalService), new WSHttpBinding(), "Http://localhost:8080/evals/ws");
            host.AddServiceEndpoint(typeof(IEvalService), new NetTcpBinding(), "net.tcp://localhost:8081/evals");

            try
            {
                host.Open();
                #region service info
                Console.WriteLine($"{host.Description.ServiceType} is up and running with these endpoints:\n");
                foreach (ServiceEndpoint se in host.Description.Endpoints)
                {
                    Console.WriteLine(se.Address);
                }
                Console.WriteLine();
                #endregion

                EvalService evalService = new EvalService();

                Eval eval = new Eval()
                {
                    Submitter = "ivan prgomet",
                    TimeSent = DateTime.Now,
                    Comments = "Hello World",
                };
                Eval eval2 = new Eval()
                {
                    Submitter = "jon jonsson",
                    TimeSent = DateTime.Now,
                    Comments = "Hello Universe",
                };

                evalService.SubmitEval(eval);
                evalService.SubmitEval(eval2);


                List<Eval> myEvals = evalService.GetEvals();

                foreach (var e in myEvals)
                {
                    Console.WriteLine("Submitter: "+e.Submitter);
                    Console.WriteLine("Comment: "+e.Comments);
                    Console.WriteLine("TimeSent: "+e.TimeSent+"\n");
                }

                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                host.Abort();
            }
        }
    }
}
