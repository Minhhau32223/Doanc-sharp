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
        public event Action<string> MaVachQuetThanhCong;
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
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += VideoSource_NewFrame;
                    videoSource.Start();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy camera.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động camera: " + ex.Message);
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = null;
            Bitmap cloneBitmap = null;

            try
            {
                if (eventArgs.Frame != null)
                {
                    bitmap = (Bitmap)eventArgs.Frame.Clone();
                    cloneBitmap = (Bitmap)bitmap.Clone();
                    if (pictureBox1.InvokeRequired)
                    {
                        pictureBox1.Invoke(new MethodInvoker(delegate
                        {
                            if (!pictureBox1.IsDisposed)
                            {
                                pictureBox1.Image?.Dispose();
                                pictureBox1.Image = (Bitmap)bitmap.Clone();
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

                    var reader = new BarcodeReaderGeneric();
                    var source = new BitmapLuminanceSource(cloneBitmap);
                    var result = reader.Decode(source);

                    if (result != null)
                    {
                        Invoke(new MethodInvoker(delegate
                        {

                            // Gọi sự kiện trả về kết quả cho form chính
                            MaVachQuetThanhCong?.Invoke(result.Text);

                            // Đóng form sau khi quét thành công
                            bitmap?.Dispose();
                            cloneBitmap?.Dispose();
                            this.Close();
                        }));
                    }
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
            try
            {
                if (videoSource != null)
                {
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();

                        // Thêm timeout khi chờ camera dừng để tránh bị treo
                        for (int i = 0; i < 10 && videoSource.IsRunning; i++)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }

                    videoSource.NewFrame -= VideoSource_NewFrame;
                    videoSource = null;
                }

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng camera: " + ex.Message);
            }
        }
    }
}
