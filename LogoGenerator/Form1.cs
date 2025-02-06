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

namespace LogoGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (ValidSize(openFileDialog1.FileName, 2048, 2048))
                {
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    btnAndroid.Enabled = true;
                    btnApple.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Image size must be 2048x2048!");
                    btnAndroid.Enabled = false;
                    btnApple.Enabled = false;
                }
            }
            else
            {
                btnAndroid.Enabled = false;
                btnApple.Enabled = false;
            }

        }

        private bool ValidSize(string filename, int limitWidth, int limitHeight)
        {
            using (var img = new Bitmap(filename))
            {
                if (img.Width == limitWidth && img.Height == limitHeight) return true;
            }

            return false;
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            Image newimg = new Bitmap(pictureBox1.Image); 
            Image img = new Bitmap(pictureBox1.Image);

            img = Form1.ResizeImage(newimg, 1024, 1024);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo1024.png");
            img = Form1.ResizeImage(newimg, 720, 720);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo720.png");
            img = Form1.ResizeImage(newimg, 512, 512);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo512.png");
            img = Form1.ResizeImage(newimg, 224, 224);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo224.png");
            img = Form1.ResizeImage(newimg, 216, 216);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo216.png");
            img = Form1.ResizeImage(newimg, 203, 203);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo203.png");
            img = Form1.ResizeImage(newimg, 196, 196);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo196.png");
            img = Form1.ResizeImage(newimg, 182, 182);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo182.png");
            img = Form1.ResizeImage(newimg, 180, 180);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo180.png");
            img = Form1.ResizeImage(newimg, 172, 172);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo172.png");
            img = Form1.ResizeImage(newimg, 167, 167);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo167.png");
            img = Form1.ResizeImage(newimg, 164, 164);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo164.png");
            img = Form1.ResizeImage(newimg, 152, 152);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo152.png");
            img = Form1.ResizeImage(newimg, 144, 144);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo144.png");
            img = Form1.ResizeImage(newimg, 120, 120);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo120.png");
            img = Form1.ResizeImage(newimg, 114, 114);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo114.png");
            img = Form1.ResizeImage(newimg, 100, 100);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo100.png");
            img = Form1.ResizeImage(newimg, 88, 88);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo88.png");
            img = Form1.ResizeImage(newimg, 87, 87);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo87.png");
            img = Form1.ResizeImage(newimg, 83, 83);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo83.png");
            img = Form1.ResizeImage(newimg, 80, 80);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo80.png");
            img = Form1.ResizeImage(newimg, 76, 76);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo76.png");
            img = Form1.ResizeImage(newimg, 72, 72);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo72.png");
            img = Form1.ResizeImage(newimg, 64, 64);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo64.png");
            img = Form1.ResizeImage(newimg, 60, 60);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo60.png");
            img = Form1.ResizeImage(newimg, 58, 58);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo58.png");
            img = Form1.ResizeImage(newimg, 57, 57);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo57.png");

            // this is for the watch and cannot have an alpha channel  
            Bitmap orig55 = new Bitmap(Form1.ResizeImage(newimg, 55, 55));
            Bitmap clone55 = new Bitmap(orig55.Width, orig55.Height,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (Graphics gr = Graphics.FromImage(clone55)) {
                gr.DrawImage(orig55, new Rectangle(0, 0, clone55.Width, clone55.Height));
            }
            img = new Bitmap(clone55);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo55.png");
            
            img = Form1.ResizeImage(newimg, 52, 52);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo52.png");
            img = Form1.ResizeImage(newimg, 50, 50);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo50.png");

            // this is for the watch and cannot have an alpha channel
            Bitmap orig48 = new Bitmap(Form1.ResizeImage(newimg, 48, 48));
            Bitmap clone48 = new Bitmap(orig48.Width, orig48.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (Graphics gr = Graphics.FromImage(clone48))
            {
                gr.DrawImage(orig48, new Rectangle(0, 0, clone48.Width, clone48.Height));
            }
            img = new Bitmap(clone48);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo48.png");

            img = Form1.ResizeImage(newimg, 44, 44);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo44.png");
            img = Form1.ResizeImage(newimg, 40, 40);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo40.png");
            img = Form1.ResizeImage(newimg, 36, 36);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo36.png");
            img = Form1.ResizeImage(newimg, 32, 32);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo32.png");
            img = Form1.ResizeImage(newimg, 29, 29);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo29.png");
            img = Form1.ResizeImage(newimg, 20, 20);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\App-Logo20.png");

            MessageBox.Show(this, "Created Apple Logos successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void btnAndroid_Click(object sender, EventArgs e)
        {
            Image newimg = new Bitmap(pictureBox1.Image);
            Image img = new Bitmap(pictureBox1.Image);

            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-1024.png");

            img = Form1.ResizeImage(newimg, 512, 512);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-highres512.png");

            img = Form1.ResizeImage(newimg, 192, 192);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-xxhdpi192.png");

            img = Form1.ResizeImage(newimg, 144, 144);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-xxhdpi144.png");

            img = Form1.ResizeImage(newimg, 96, 96);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-xhdpi96.png");

            img = Form1.ResizeImage(newimg, 72, 72);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-hdpi72.png");

            img = Form1.ResizeImage(newimg, 48, 48);
            img.Save(Path.GetDirectoryName(openFileDialog1.FileName) + "\\And-mdpi48.png");

            MessageBox.Show(this, "Created Android Logos successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
