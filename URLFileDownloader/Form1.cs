using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace URLFileDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string fileSavePath, fileSavePath2;
        private void Form1_Load(object sender, EventArgs e)
        {
            metroButton3.Enabled = true;
            metroButton3.Visible = true;
            metroProgressBar1.Enabled = false;
            metroProgressBar1.Visible = false;
            metroTextBox1.Text = null;
            metroTextBox2.Text = null;
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
            if (string.IsNullOrEmpty(metroTextBox1.Text) || string.IsNullOrWhiteSpace(metroTextBox1.Text))
            {
                MessageBox.Show("URL cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(metroTextBox2.Text) || string.IsNullOrWhiteSpace(metroTextBox2.Text))
            {
                MessageBox.Show("File path cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            metroButton3.Enabled = false;
            metroButton3.Visible = false;
            metroProgressBar1.Enabled = true;
            metroProgressBar1.Visible = true;
            metroLabel2.Text = "[PREPARING]";
            WebClient webcl = new WebClient();
            string sourceFile = metroTextBox1.Text;
            string destFile = metroTextBox2.Text;
            metroLabel2.Text = "[DOWNLOADING]";
            webcl.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
            webcl.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webcl.DownloadFileAsync(new Uri(sourceFile), destFile);
            metroLabel2.Text = "[IDLE]";
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }
        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File download completed", "Download Manager", MessageBoxButtons.OK);
            metroProgressBar1.Enabled = false;
            metroProgressBar1.Visible = false;
            metroButton3.Enabled = true;
            metroButton3.Visible = true;
            metroTextBox1.Text = null;
            metroTextBox2.Text = null;
        }
        internal static async void DownloadVideo(string URL, Button btn, Label lbl, string targetFileName, ProgressBar pb)
        {
            var youtube = new YoutubeClient();
            var component = new Component();
            lbl.Text = "[PARSING MANIFEST]";
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(URL);
            lbl.Text = "[SAVING STREAMINFO]";
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
            IProgress<double> progress = new Progress<double>(value =>
            {
                pb.Value = (int)(value * 100);
            });
            btn.Visible = false;
            pb.Visible = true;
            lbl.Text = "[DOWNLOADING VIDEO]";
            await youtube.Videos.Streams.DownloadAsync(streamInfo, targetFileName, progress);
            MessageBox.Show("Video downloaded", "Download Manager", MessageBoxButtons.OK);
            btn.Visible = true;
            pb.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBox4.Text) || string.IsNullOrWhiteSpace(metroTextBox4.Text))
            {
                MessageBox.Show("URL cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(metroTextBox3.Text) || string.IsNullOrWhiteSpace(metroTextBox3.Text))
            {
                MessageBox.Show("File path cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (metroTextBox4.Text.Contains("https://www.youtube.com") || metroTextBox4.Text.Contains("www.youtube.com"))
            {
                metroButton2.Visible = false;
                metroProgressBar2.Visible = true;
                Environment.SetEnvironmentVariable("SLAVA_UKRAINI", "1");
                DownloadVideo(metroTextBox4.Text, metroButton2, metroLabel1, metroTextBox3.Text, metroProgressBar2);
                Environment.SetEnvironmentVariable("SLAVA_UKRAINI", null);
                metroTextBox4.Text = null;
                metroTextBox3.Text = null;
                metroButton2.Visible = true;
                metroProgressBar2.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("This link isn't valid YouTube link, link: " + metroTextBox4.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "Video Files | *.mp4";
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                fileSavePath2 = saveFileDialog2.FileName;
                metroTextBox3.Text = fileSavePath2;
            }
        }
    }
}