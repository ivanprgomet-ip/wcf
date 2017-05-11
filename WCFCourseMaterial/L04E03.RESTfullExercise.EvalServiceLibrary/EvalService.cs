using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace L04E03.RESTfullExercise.EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        static List<Eval> evals = new List<Eval>();
        static int evalCount = 0;

        public Eval GetEval(string id)
        {
            return evals.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Eval> GetEvals()
        {
            return GetEvalsBySybmitter(null);
        }

        public List<Eval> GetEvalsBySybmitter(string submitter)
        {
            if (string.IsNullOrEmpty(submitter))
                return evals;
            else
                return evals.Where(e => e.Submitter == submitter).ToList();
        }

        public void RemoveEval(string id)
        {
            Eval evalToRemove = evals.Find(e => e.Id == id);

            evals.Remove(evalToRemove);
        }

        public void SubmitEval(Eval eval)
        {
            if (eval != null)
            {
                eval.Id = (evalCount += 1).ToString();

                evals.Add(eval);
            }
            else
                Console.WriteLine("eval object is null");
        }
    }
    [ServiceContract]
    public interface IEvalService
    {
        [WebInvoke(Method="POST",UriTemplate="evals")] // servicemodel.web
        [OperationContract(IsOneWay = true)]
        void SubmitEval(Eval eval);
        [OperationContract]
        [WebGet(UriTemplate ="evals")]
        List<Eval> GetEvals();

        [OperationContract]
        [WebGet(UriTemplate ="eval/{id}")]
        Eval GetEval(string id);
        [OperationContract]
        [WebGet(UriTemplate ="evals/{submitter}")]
        List<Eval> GetEvalsBySybmitter(string submitter);
        [OperationContract]
        [WebInvoke(Method ="DELETE",UriTemplate ="eval/{id}")]
        void RemoveEval(string id);
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
