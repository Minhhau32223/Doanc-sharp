using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace Doanc_sharp.src.GUI
{
    public partial class QuetMaVach : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public QuetMaVach()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString); // chọn camera đầu tiên
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("Không tìm thấy camera.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = null;
            Bitmap cloneBitmap = null;

            try
            {
                bitmap = (Bitmap)eventArgs.Frame.Clone();
                cloneBitmap = (Bitmap)bitmap.Clone(); // tạo bản sao để decode

                // Cập nhật UI (luồng chính)
                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1.Invoke(new MethodInvoker(delegate
                    {
                        if (!pictureBox1.IsDisposed)
                        {
                            pictureBox1.Image?.Dispose(); // giải phóng ảnh cũ
                            pictureBox1.Image = (Bitmap)bitmap.Clone(); // clone để tránh bị dispose sớm
                        }
                    }));
                }
                else
                {
                    if (!pictureBox1.IsDisposed)
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = (Bitmap)bitmap.Clone();
                    }
                }

                // Decode trên clone để tránh xung đột
                var reader = new BarcodeReaderGeneric();
                var source = new BitmapLuminanceSource(cloneBitmap);
                var result = reader.Decode(source);

                if (result != null)
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        if (!txtResult.IsDisposed)
                            txtResult.Text = result.Text;
                    }));
                }
            }
            catch { }
            finally
            {
                bitmap?.Dispose();
                cloneBitmap?.Dispose();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.NewFrame -= VideoSource_NewFrame; // ngắt sự kiện
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
                videoSource = null;
            }

            // Giải phóng hình ảnh trong pictureBox
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }
    }
}
