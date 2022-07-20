using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeGenerator
{
    public partial class BarCode : Form
    {
        public BarCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = textBox1.Text;
            try {
                Zen.Barcode.Code128BarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brcode.Draw(barcode, 100);
            }
            catch(Exception){}
        }
    }
}
