using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MjpegProcessor;
namespace IpWebCam
{
    public partial class Form1 : Form
    {
        MjpegDecoder mjpeg;
        String ipAddress;
        SoundPlayer sound;
        
        public Form1()
        {
            InitializeComponent();
            mjpeg = new MjpegDecoder();
            mjpeg.FrameReady += frameReady;
        }

        private void frameReady(object sender, FrameReadyEventArgs e)
        {
            outputBox.Image = e.Bitmap;
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ipAddress = "http://" + ipTextBox.Text.ToString();
            mjpeg.ParseStream(new Uri(ipAddress + "/videofeed"));
            sound = new SoundPlayer();
            
        }

        private void disButton_Click(object sender, EventArgs e)
        {
            mjpeg.StopStream();
        }

        private void button1_Click  (object sender, EventArgs e)
        {
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ipAddress + "/enabletorch");
            wr.GetResponse().Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ipAddress + "/disabletorch");
            wr.GetResponse().Close();
        }
    }
}
