using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace L04E02.BookLibrary.WebApi.Models
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public virtual List<Author> Authors { get; set; }
    }
}