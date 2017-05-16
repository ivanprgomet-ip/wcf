using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace E02.MyMediaServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class MediaService : IMediaService
    {
        List<Book> books = new List<Book>();
        List<Paper> papers = new List<Paper>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddPaper(Paper paper)
        {
            papers.Add(paper);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Paper> GetAllPapers()
        {
            return papers;
        }

        public void RemoveBookFromLibrary(int id)
        {
            books.Remove(books.Where(b => b.Id == id).FirstOrDefault());
        }

        public void RemovePaperFromLibrary(int id)
        {
            //Paper toRemove = papers.Where(p => p.Id == id).FirstOrDefault();
            papers.Remove(papers.Where(b => b.Id == id).FirstOrDefault());
            //return toRemove;
        }
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

    [ServiceContract]
    public interface IMediaService
    {
        [OperationContract]
        void AddBook(Book book);
        [OperationContract]
        void AddPaper(Paper paper);
        [OperationContract]
        List<Book> GetAllBooks();
        [OperationContract]
        List<Paper> GetAllPapers();
        [OperationContract]
        void RemoveBookFromLibrary(int id);
        [OperationContract]
        void RemovePaperFromLibrary(int id);
    }

}
