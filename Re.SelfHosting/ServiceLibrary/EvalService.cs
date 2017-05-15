using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class EvalService : IEvalService
    {
        List<Eval> evals = new List<Eval>();
        public List<Eval> GetEvals()
        {
            return evals;
        }

        public void SubmitEval(Eval eval)
        {
            if (eval != null)
                evals.Add(eval);
            else
                Console.WriteLine("the eval is null");
        }
    }

    [DataContract]
    public class Eval
    {
        [DataMember]
        public string Submitter { get; set; }
        [DataMember]
        public DateTime TimeSent { get; set; }
        [DataMember]
        public string Comments { get; set; }
    }

    [ServiceContract]
    public interface IEvalService
    {
        [OperationContract]
        void SubmitEval(Eval eval);
        List<Eval> GetEvals();

    }
}
