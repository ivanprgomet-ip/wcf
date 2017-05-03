using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L04E02.BookLibrary.WebApi.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public List<Book> Titles { get; set; }
    }
}