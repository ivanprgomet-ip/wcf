using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L01E02.WinFormPersonServiceClient
{
    public partial class Form1 : Form
    {
        PersonServiceReference.PersonServiceClient client;

        public Form1()
        {
            InitializeComponent();

            // initial load
            client = new PersonServiceReference.PersonServiceClient();
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.EditFirstname(textBox1.Text);
            client.EditLastname(textBox2.Text);
            client.EditPhone(int.Parse(textBox3.Text));
            client.EditAddress(textBox4.Text);

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblfullname.Text = client.GetFullname();
            lbladdress.Text = client.GetAddress();
        }
    }
}
