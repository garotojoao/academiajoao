using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.IO;

namespace CONTROLE_ACADEMIA.visao
{
    public partial class FormWebCam : Form
    {
        public FormWebCam()
        {
            InitializeComponent();
        }

        private FilterInfoCollection VideoDevices;
        private VideoCaptureDevice VideoDevice; 
        private void FormWebCam_Load(object sender, EventArgs e)
        {
            VideoDevices = new FilterInfoCollection(
                FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in VideoDevices)
            {
               CbDevices.Items.Add(device.Name);
            }
            if(CbDevices.Items.Count == 0)
            {
                BtnConectar.Enabled = false;
                BtnFoto.Enabled = false;
            }
            
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if(CbDevices.SelectedIndex == - 1)
            {
               MessageBox.Show("Camera nao seleciona");
                return;
            }

            VideoDevice = new VideoCaptureDevice(
                VideoDevices[CbDevices.SelectedIndex].MonikerString);
            VideoDevice.NewFrame += VideoDevice_NewFrame;
            VideoDevice.Start();
        }

        private void VideoDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            PbVideo.Image = bitmap;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (VideoDevice != null && VideoDevice.IsRunning)
            { 
                VideoDevice.Stop();
                Application.DoEvents();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            base.OnFormClosing(e);
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            PbFoto.Image = PbVideo.Image;
        }

        internal string caminho { get; set; }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminho))
            {
                Application.DoEvents();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(caminho);
                PbFoto.Image.Save(caminho);
                MessageBox.Show($"Foto salva com sucesso em {caminho}!");
                this.Dispose();
            }
            else
            {
                PbFoto.Image.Save(caminho);
                MessageBox.Show($"Foto salva em {caminho}");
                this.Dispose();
            }
        }
    }
}
