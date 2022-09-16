using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace English_word
{
    public partial class Picture_viewer : Form
    {
        public Picture_viewer()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            if (PicturePictureBox.Width != 1127)
            {
                PicturePictureBox.Width += 40;
                PicturePictureBox.Height += 24;
                label1.Text = "W :" + PicturePictureBox.Width + "      H :" + PicturePictureBox.Height;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            PicturePictureBox.Width -= 40;
            PicturePictureBox.Height -= 24;
            label1.Text = "W :" + PicturePictureBox.Width + "      H :" + PicturePictureBox.Height;
        }


        //That method is necessary to convert the byte format in the db to be easily read by the C#
        public Image bytetoimg(object imagedata)
        {
            try
            {
                byte[] b = (byte[])(imagedata);
                MemoryStream ms = new MemoryStream(b);
                ms.Seek(0, SeekOrigin.Begin);
                Image im = Image.FromStream(ms);
                ms.Dispose();
                return (im);
            }
            catch (Exception)
            {
                return null;
                throw;
            }


        }

        private void PicturePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (PicturePictureBox.Width != 1127)
            {
                PicturePictureBox.Width += 40;
                PicturePictureBox.Height += 24;
                label1.Text = "W :" + PicturePictureBox.Width + "      H :" + PicturePictureBox.Height;
            }
        }

        private void PicturePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (PicturePictureBox.Width != 1127)
            {
                PicturePictureBox.Width -= 40;
                PicturePictureBox.Height -= 24;
                label1.Text = "W :" + PicturePictureBox.Width + "      H :" + PicturePictureBox.Height;
            }
        }

        private void btnRotLeft_Click(object sender, EventArgs e)
        {
            PicturePictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            PicturePictureBox.Width += 1;
            PicturePictureBox.Width -= 1;
        }

        private void btnRotRight_Click(object sender, EventArgs e)
        {
            PicturePictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            PicturePictureBox.Width += 1;
            PicturePictureBox.Width -= 1;
        }

        private void btnPasswordClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End of Converting image

    }
}
