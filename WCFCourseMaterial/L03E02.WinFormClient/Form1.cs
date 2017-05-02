using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L03E02.WinFormClient
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiKey = "ab9bdeb9853fe9cc2c089464d393810531ff5ff44667";
            string url = @"https://api.thumbnail.ws/api/" + apiKey + "/thumbnail/get?url=" + textBox1.Text + "&width=" + pictureBox1.Width;

            try
            {
                // Creates an HttpWebRequest for the specified URL. 
                HttpWebRequest request= (HttpWebRequest)WebRequest.Create(url);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                label1.Text = response.StatusDescription;

                // get the thumb using stream
                Stream s = response.GetResponseStream();
                var image = Image.FromStream(s);
                pictureBox1.Image = image;

                response.Close();
            }
            catch (Exception err)
            {

                MessageBox.Show("Error: "+err.Message);
            }

        }
    }
}
