using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace L04E03.RESTfullExercise.EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        static List<Eval> evals = new List<Eval>();

        public List<Eval> GetEvals()
        {
            return evals;
        }

        public void SubmitEval(Eval eval)
        {
            if (eval != null)
                evals.Add(eval);
            else
                Console.WriteLine("eval object is null");
        }
    }
    [ServiceContract]
    public interface IEvalService
    {
        [OperationContract(IsOneWay = true)]
        void SubmitEval(Eval eval);
        [OperationContract]
        List<Eval> GetEvals();
    }

    [DataContract(Namespace = "http://localhost:8080/evals")]
    public class Eval
    {

        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Submitter { get; set; }
        [DataMember]
        public DateTime TimeSent { get; set; }
        [DataMember]
        public string Comments { get; set; }
    }
}
