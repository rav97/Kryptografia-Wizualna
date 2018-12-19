using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCryptoTest
{
    public partial class Form : System.Windows.Forms.Form
    {
        string imagePath, u1Path, u2Path;
        bool split;
        Bitmap image;
        Bitmap[] u = new Bitmap[2];
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Split.CheckState = CheckState.Checked;
            split = true;
            Merge.CheckState = CheckState.Unchecked;
            ReadImages.Enabled = false;
            SaveImages.Enabled = false;
            Start.Enabled = false;
        }

        private void ReadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                ImagePath.Text = imagePath;
                image = new Bitmap(imagePath);
                SourceImage.Image = image;
                Start.Enabled = true;
            }
        }

        private void ImagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SourceImage_Click(object sender, EventArgs e)
        {

        }

        private void Split_CheckedChanged(object sender, EventArgs e)
        {
            switch (Split.CheckState)
            {
                case CheckState.Checked:
                    {
                        Merge.CheckState = CheckState.Unchecked;
                        split = true;
                        ReadImage.Enabled = true;
                        ReadImages.Enabled = false;
                    };break;
                case CheckState.Unchecked:
                    {
                        Merge.CheckState = CheckState.Checked;
                        SourceImage.Image = null;
                        split = false;
                        ReadImage.Enabled = false;
                        ReadImages.Enabled = true;
                        SaveImages.Enabled = false;
                    };break;
            }
        }

        private void Merge_CheckedChanged(object sender, EventArgs e)
        {
            switch (Merge.CheckState)
            {
                case CheckState.Checked:
                    {
                        Split.CheckState = CheckState.Unchecked;
                        split = false;
                        ReadImage.Enabled = false;
                        ReadImages.Enabled = true;
                        SaveImages.Enabled = false;
                    }; break;
                case CheckState.Unchecked:
                    {
                        Split.CheckState = CheckState.Checked;
                        SourceImage.Image = null;
                        split = true;
                        ReadImage.Enabled = true;
                        ReadImages.Enabled = false;
                    }; break;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            VisCrypt vc = new VisCrypt();
            if(split)
            {
                u = vc.GenerateImage(image);
                U1Image.Image = u[0];
                U2Image.Image = u[1];
                SaveImages.Enabled = true;
            }
            else
            {
                image = vc.MergeImages(u);
                SourceImage.Image = image;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void U1Image_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void U2Image_Click(object sender, EventArgs e)
        {

        }

        private void ReadImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                u1Path = openFileDialog1.FileName;
                u[0] = new Bitmap(u1Path);
                U1Image.Image = u[0];

                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    u2Path = openFileDialog2.FileName;
                    u[1] = new Bitmap(u2Path);
                    U2Image.Image = u[1];
                    Start.Enabled = true;
                }
            }
        }

        private void SaveImages_Click(object sender, EventArgs e)
        {
            u[0] = (Bitmap)U1Image.Image;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                u[0].Save(saveFileDialog1.FileName);

                u[1] = (Bitmap)U2Image.Image;
                SaveFileDialog saveFileDialog2 = new SaveFileDialog();
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    u[1].Save(saveFileDialog2.FileName);
                }
            }
        }
    }
}
