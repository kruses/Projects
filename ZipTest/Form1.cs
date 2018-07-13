using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;


namespace ZipTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string attachmentpath = @"c:\temp\";
            string attachmentpath = @"z:\";
            string outpath = @"d:\temp\ziptest.zip";
            if (File.Exists(outpath))
            {
                File.Delete(outpath);
            }
            ZipFile.CreateFromDirectory(attachmentpath, outpath, CompressionLevel.Fastest, false);
        }
    }
}
