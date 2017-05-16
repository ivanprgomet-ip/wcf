using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace E02.MyMediaServiceLibrary
{
    class MyMediaServiceLibrary
    {
    }

    [DataContract]
    public class Media
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int NrOfPages { get; set; }
    }
    [DataContract]
    public class Book : Media
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
    [DataContract]
    public class Paper : Media
    {
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}
