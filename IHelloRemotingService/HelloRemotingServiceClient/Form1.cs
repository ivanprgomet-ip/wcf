using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace HelloRemotingServiceClient
{
    public partial class Form1 : Form
    {
        IHelloRemotingService.IHelloRemotingService client;

        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingService.IHelloRemotingService)Activator.GetObject
                (typeof(IHelloRemotingService.IHelloRemotingService),"tcp://localhost:8080/Hello");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// you first go into the C:\Users\Ivan\Source\Repos\wcf\IHelloRemotingService\RemotingServiceHost\bin\Debug
            /// and run the .exe to make the service available. then you consume it from the HelloRemotingServiceClient winform!

            label1.Text = client.Hello(textBox1.Text);
        }
    }
}
