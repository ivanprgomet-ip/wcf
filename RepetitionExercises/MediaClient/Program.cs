using MediaClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace MediaClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IMediaServiceChannel> cf = new ChannelFactory<IMediaServiceChannel>("WSHttpBinding_IMediaService");
            IMediaServiceChannel channel = cf.CreateChannel();

            //ServiceReference.MediaServiceClient client = new MediaServiceClient();

            try
            {
                channel.Open(); // [] is this neccessary to open???

                // do stuff with books and papers
                #region stuff
                channel.AddBook(new Book() { Id = 1, NrOfPages = 231, Price = 499, Title = "ivans life", Type = "some" });
                List<Book> books = channel.GetAllBooks().ToList();
                foreach (var b in books)
                {
                    Console.WriteLine(b.Title);

                }
                Console.ReadLine();

                #endregion

                channel.Close();
            }
            catch (Exception)
            {
                channel.Abort();
                throw;
            }
            
        }
    }
}
