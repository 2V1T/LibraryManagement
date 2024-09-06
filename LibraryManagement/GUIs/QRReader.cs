using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Aspose.BarCode.BarCodeRecognition;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using System.Drawing;
using ZXing.Aztec;

namespace LibraryManagement.GUIs
{
    public partial class QRReader : Form
    {
        bool isMember;
        RegisterMember registerMember = new RegisterMember();

        public QRReader(bool isMember)
        {
            InitializeComponent();
            this.isMember = isMember;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void startScanBt_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            statusLB.Visible = true;
            timer1.Start();
        }

        private void QRReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitCamera();
        }

        private void exitCamera ()
        {
            if (videoCaptureDevice != null) {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                videoCaptureDevice = null;
            }
        }


        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            var bitmap = (Bitmap)eventArgs.Frame.Clone();
            // Display the image in a PictureBox
            pictureBox.Image = (Bitmap)bitmap.Clone();
        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            if (pictureBox.Image != null && videoCaptureDevice != null)
            {
                Result result = reader.Decode((Bitmap)pictureBox.Image);
                try
                {
                    string decode = result?.ToString().Trim();
                    if (decode != null)
                    {
                        timer1.Stop();
                        statusLB.Text = "Detected";
                        statusLB.ForeColor = Color.Green;
                        string[] splitString = decode.Split("|");
                        if (!isMember)
                        {
                            registerMember.Name = splitString[2];
                            registerMember.idNo = splitString[0];
                            registerMember.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("idNo: " + splitString[0]);
                        }
                        
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                }
            } 
        }
    }
}
