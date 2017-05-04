using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageEditor;
using System.IO;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "All files|*.*|PNG|*.png|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            file_dialog.FilterIndex = 1;
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(file_dialog.FileName);
                bitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                //bitmap = bitmap.CopyToSquareCanvas(StartPicture.Width);
                StartPicture.Image = bitmap;

                ChooseFileBtn.Text = file_dialog.FileName;
            }
        }

        private void SobelBtn_Click(object sender, EventArgs e)
        {
            ResultPicture.Image =  bitmap.Sobel3x3Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
        }


        private void Sobel5x5Btn_Click(object sender, EventArgs e)
        {
            ResultPicture.Image = bitmap.Sobel5x5Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
        }

        private void Kirsch_Click(object sender, EventArgs e)
        {
            ResultPicture.Image = bitmap.KirschFilter(GaussianCB.Checked, BlackWhiteCB.Checked);
        }

        private void Prewitt_Click(object sender, EventArgs e)
        {
            ResultPicture.Image = bitmap.PrewittFilter(GaussianCB.Checked, BlackWhiteCB.Checked);
        }

        private void Laplacian3x3Btn_Click(object sender, EventArgs e)
        {
            ResultPicture.Image = bitmap.Laplacian3x3Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
        }

        private void Laplacian5x5Btn_Click(object sender, EventArgs e)
        {
            ResultPicture.Image = bitmap.Laplacian5x5Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
        }
    }
}
