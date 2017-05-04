using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace L04E02.BookLibrary.WebApi.Models
{
    //[Serializable]
    //[DataContract(IsReference = true)]
    public class Author
    {
        public int AuthorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //public virtual IList<Book> Titles { get; set; }
    }
}