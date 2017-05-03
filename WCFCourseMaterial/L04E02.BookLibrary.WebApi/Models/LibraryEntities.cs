using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L04E02.BookLibrary.WebApi.Models
{
    public class LibraryEntities:DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
    }
}