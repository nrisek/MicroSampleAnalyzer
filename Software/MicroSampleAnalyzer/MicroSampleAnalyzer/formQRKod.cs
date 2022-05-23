using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace MicroSampleAnalyzer
{
    public partial class formQRKod : Form
    {
        public formQRKod(int id)
        {
            InitializeComponent();
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(id.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBoxQR.Image = code.GetGraphic(8);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
            this.Close();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBoxQR.Width, pictureBoxQR.Height);
            pictureBoxQR.DrawToBitmap(bm, new Rectangle(0,0,pictureBoxQR.Width,pictureBoxQR.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
