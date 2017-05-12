using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class PersonService : IPersonService
    {
        public string GetFullname(Name name)
        {
            return name.Firstname + ' ' + name.Lastname;
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
    interface IPersonService
    {
        [OperationContract]
        string GetFullname(Name name);
    }
}
