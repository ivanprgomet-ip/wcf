using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02.MediaHost
{
    class Program
    {
        static void Main(string[] args)
        {
            /// [x] enable HTTP-get (see appconfig in MyMediaServiceLibrary)
            /// [] set HTTP-get-url to http://localhost:8080/mediaService/meta
            /// [] create bindings: 
            ///     basicHttpBinding
            ///     WsHttpBinding
            ///     netTcpBinding

            ServiceReference.MediaServiceClient client = new ServiceReference.MediaServiceClient();

        }
    }
}
