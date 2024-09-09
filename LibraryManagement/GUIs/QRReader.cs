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
using LibraryManagement.controllers;
using LibraryManagement.models;

namespace LibraryManagement.GUIs
{
    public partial class QRReader : Form
    {
        bool isMember;
        int bookId = 0;
        bool isReturn;
        RegisterMember registerMember = new RegisterMember();

        public QRReader(bool isMember, int bookId)
        {
            InitializeComponent();
            this.isMember = isMember;
            this.bookId = bookId;
        }
        public QRReader(bool isMember, int bookId, bool isReturn)
        {
            InitializeComponent();
            this.isMember = isMember;
            this.bookId = bookId;
            this.isReturn = isReturn;
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

        private void exitCamera()
        {
            if (videoCaptureDevice != null)
            {
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

        private void borrowBook (long idNo, int idCopies)
        {
            MemberController memberController = new MemberController();
      
            if (memberController.memberAvailable(idNo)) {
                DateTime currentDate = DateTime.Now;
                DateTime nextMonthDate = currentDate.AddMonths(1);
                DateTime returnDate = DateTime.Parse(nextMonthDate.ToString("yyyy-MM-dd"));
                BorrowedDetailController borrowedDetailController = new BorrowedDetailController();
                bool result = borrowedDetailController.add(idCopies, idNo, returnDate);
                if (result)
                {
                    MessageBox.Show("Cho bạn đọc có mã cccd " + idNo + " mượn sách thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cho bạn đọc mượn thất bại vui lòng thử lại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn đọc chưa trả sách đã mượn không thể mượn thêm", "Thông báo");
            }
            
        }

        private void returnBook(int idCopies)
        {
            BookController bookController = new BookController();
            if (bookController.returnBook(idCopies))
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Trả sách thất bại!", "Thông báo");
            }
        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            MemberController memberController = new MemberController();
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
                        if (!isReturn)
                        {
                            if (!isMember)
                            {
                                registerMember.Name = splitString[2];
                                registerMember.idNo = splitString[0];
                                registerMember.ShowDialog();
                                this.Close();
                                return;
                            }
                            else
                            {
                                long idNo = long.Parse(splitString[0]);
                                borrowBook(idNo, this.bookId);
                            }
                        }
                        else
                        {
                            returnBook(int.Parse(splitString[0]));
                        }

                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
