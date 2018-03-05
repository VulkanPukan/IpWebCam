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
using MetroFramework;
using MetroFramework.Forms;

namespace IpWebCam
{
    public partial class Form1 : MetroForm
    {
        MjpegDecoder mjpeg;
        String ipAddress;
        SoundPlayer sound;
        bool flash = false;

        void FocusCam()
        {
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ipAddress + "/focus");
            wr.GetResponse().Close();
        }

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
            outputBox.Visible = true;
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ipAddress + "/disabletorch");
            wr.GetResponse().Close();
            metroToggle1.Checked = false;
            Focus();

        }

        private void disButton_Click(object sender, EventArgs e)
        {
            mjpeg.StopStream();
            outputBox.Visible = false;
            ipAddress = null;
          
        }

       

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (flash)
                {
                    HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ipAddress + "/disabletorch");
                    wr.GetResponse().Close();
                    flash = false;
                    metroToggle1.Checked = false;
                }
                else
                {
                    HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ipAddress + "/enabletorch");
                    wr.GetResponse().Close();
                    flash = true;
                    metroToggle1.Checked = true;
                }
                Focus();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "You are not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
           
        }
    }
}
