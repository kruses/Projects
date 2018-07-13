using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTLSClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestTLSClient.ServiceReference1.Service1Client sr = new TestTLSClient.ServiceReference1.Service1Client();
            sr.Open();

            string result = sr.GetData(99);

            MessageBox.Show(result);
        }
    }
}
