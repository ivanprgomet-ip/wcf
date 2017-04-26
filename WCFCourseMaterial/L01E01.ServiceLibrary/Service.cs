using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace L01E01.ServiceLibrary
{
    public class GreetService : IGreetService
    {
        public string Greet(Name obj)
        {
            return "Hello " + obj.Firstname + " " + obj.Lastname;
        }
    }

    [DataContract]
    public class Name
    {
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
    }

    [ServiceContract]
    public interface IGreetService
    {
        [OperationContract]
        string Greet(Name obj);
    }
}
