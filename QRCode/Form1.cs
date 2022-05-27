using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // QR KOD OLUŞTURMA
        private void btnQR_Click(object sender, EventArgs e)
        {
            if (txtOlusturulacakKod.Text != "")
            {
                var options = new QrCodeEncodingOptions
                {
                    Height = pckQR.Height,
                    Width = pckQR.Width
                };
                //create instance of BarcodeWrider
                var writer = new BarcodeWriter();
                //set format
                writer.Format = BarcodeFormat.QR_CODE;
                writer.Options = options;
                var text = txtOlusturulacakKod.Text;
                var result = writer.Write(text);
                pckQR.Image = result;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string initialDIR = @"C:\Users\PCName\Desktop\FileName";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pckQR.Image.Save(dialog.FileName);
            }
        }
        private void btnQRoku_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new BarcodeReader();
                var imgfile = Image.FromFile(dialog.FileName) as Bitmap;
                pckQR.Image = imgfile;
                var result = reader.Decode(imgfile);
                txtOkunanKod.Text = result.Text;
            }
        }
    }
}
