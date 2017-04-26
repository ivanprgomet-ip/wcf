using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace L01E02.PersonServiceLibrary
{
    public class PersonService : IPersonService
    {
        private static Person Person = new Person()
        {
            Firstname = "ivan",
            Lastname = "prgomet",
            Address = "Gatunamn 123",
            Phone = 0734637289,
        };

        public bool EditAddress(string newAddress)
        {
            Person.Address = newAddress;
            return true;
        }

        public bool EditFirstname(string newFirstname)
        {
            Person.Firstname = newFirstname;
            return true;
        }

        public bool EditLastname(string newLastname)
        {
            Person.Lastname = newLastname;
            return true;
        }

        public bool EditPhone(int newPhone)
        {
            Person.Phone = newPhone;
            return true;
        }

        public string GetAddress()
        {
            return Person.Address;
        }

        public string GetFullname()
        {
            return Person.Firstname + " " + Person.Lastname;
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Phone { get; set; }
    }

    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        bool EditFirstname(string newFirstname);
        [OperationContract]
        bool EditLastname(string newLastname);
        [OperationContract]
        bool EditAddress(string newAddress);
        [OperationContract]
        bool EditPhone(int newPhone);
        [OperationContract]
        string GetFullname();
        [OperationContract]
        string GetAddress();
    }

}
