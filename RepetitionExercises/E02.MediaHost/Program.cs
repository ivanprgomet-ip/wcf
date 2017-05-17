using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02.MyMediaServiceLibrary;
using System.ServiceModel;

namespace E02.MediaHost
{
    class Program
    {
        static void Main(string[] args)
        {
            /// [x] enable HTTP-get (see appconfig in MyMediaServiceLibrary)
            /// [x] set HTTP-get-url to http://localhost:8080/mediaService/meta
            /// [x] create bindings: 
            ///     basicHttpBinding
            ///     WsHttpBinding
            ///     netTcpBinding
            
            ServiceHost host = new ServiceHost(typeof(MediaService));
            try
            {
                host.Open();

                Console.WriteLine("host {0}...", host.State);
                Console.ReadLine();

                host.Close();
            }
            catch (Exception)
            {
                host.Abort();
                throw;
            }
        }
    }
}
