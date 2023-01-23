using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URLFileDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string fileSavePath;
        private void Form1_Load(object sender, EventArgs e)
        {
            metroButton3.Enabled = true;
            metroButton3.Visible = true;
            metroProgressBar1.Enabled = false;
            metroProgressBar1.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSavePath = saveFileDialog1.FileName;
                metroTextBox2.Text = fileSavePath;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroButton3.Enabled = false;
            metroButton3.Visible = false;
            metroProgressBar1.Enabled = true;
            metroProgressBar1.Visible = true;
            WebClient webcl = new WebClient();
            string sourceFile = metroTextBox1.Text;
            string destFile = metroTextBox2.Text;
            webcl.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
            webcl.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webcl.DownloadFileAsync(new Uri(sourceFile), destFile);
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }
        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Manager", "File download completed", MessageBoxButtons.OK);
        }
    }
}
