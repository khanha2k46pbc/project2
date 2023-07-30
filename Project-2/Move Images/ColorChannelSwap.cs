using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2.Move_Images
{
    public partial class ColorChannelSwap : Form
    {
        private string path;
        public ColorChannelSwap(String path)
        {
            InitializeComponent();
            this.path = path;
            // create image and editedImage Bitmap
            Bitmap image = new Bitmap(path);
            Bitmap editedImage = image;
            //RBG
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.B, pixelColor.G);
                    editedImage.SetPixel(x, y, newColor);
                }
            }
            pictureBoxRBG.Image = new Bitmap(editedImage);
            //GRB
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.G, pixelColor.R, pixelColor.B);
                    editedImage.SetPixel(x, y, newColor);
                }
            }
            pictureBoxGRB.Image = new Bitmap(editedImage);
            //GBR
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.G, pixelColor.B, pixelColor.R);
                    editedImage.SetPixel(x, y, newColor);
                }
            }
            pictureBoxGBR.Image = new Bitmap(editedImage);
            //BRG
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.B, pixelColor.R, pixelColor.G);
                    editedImage.SetPixel(x, y, newColor);
                }
            }
            pictureBoxBRG.Image = new Bitmap(editedImage);
            //BGR
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.B, pixelColor.G, pixelColor.R);
                    editedImage.SetPixel(x, y, newColor);
                }
            }
            pictureBoxBGR.Image = new Bitmap(editedImage);
            // Dispose image and editedImage
            image.Dispose();
            editedImage.Dispose();
        }

        private void pictureBoxRBG_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the filename of the original image
                string fileName = Path.GetFileNameWithoutExtension(path);
                // Destination
                string destination = path.Replace(fileName, fileName + "-modified");
                // Save the edited image
                if (File.Exists(destination))
                {
                    DialogResult dialogResult = MessageBox.Show("File " + destination + " already exists. Do you want to replace it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        pictureBoxRBG.Image.Save(destination);
                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RootFolder.refresh();
                        this.Close();
                    }
                }
                else
                {
                    pictureBoxRBG.Image.Save(destination);
                    MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RootFolder.refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxGRB_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the filename of the original image
                string fileName = Path.GetFileNameWithoutExtension(path);
                // Destination
                string destination = path.Replace(fileName, fileName + "-modified");
                // Save the edited image
                if (File.Exists(destination))
                {
                    DialogResult dialogResult = MessageBox.Show("File " + destination + " already exists. Do you want to replace it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        pictureBoxGRB.Image.Save(destination);
                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RootFolder.refresh();
                        this.Close();
                    }
                }
                else
                {
                    pictureBoxGRB.Image.Save(destination);
                    MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RootFolder.refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxGBR_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the filename of the original image
                string fileName = Path.GetFileNameWithoutExtension(path);
                // Destination
                string destination = path.Replace(fileName, fileName + "-modified");
                // Save the edited image
                if (File.Exists(destination))
                {
                    DialogResult dialogResult = MessageBox.Show("File " + destination + " already exists. Do you want to replace it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        pictureBoxGBR.Image.Save(destination);
                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RootFolder.refresh();
                        this.Close();
                    }
                }
                else
                {
                    pictureBoxGBR.Image.Save(destination);
                    MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RootFolder.refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxBRG_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the filename of the original image
                string fileName = Path.GetFileNameWithoutExtension(path);
                // Destination
                string destination = path.Replace(fileName, fileName + "-modified");
                // Save the edited image
                if (File.Exists(destination))
                {
                    DialogResult dialogResult = MessageBox.Show("File " + destination + " already exists. Do you want to replace it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        pictureBoxBRG.Image.Save(destination);
                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RootFolder.refresh();
                        this.Close();
                    }
                }
                else
                {
                    pictureBoxBRG.Image.Save(destination);
                    MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RootFolder.refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxBGR_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the filename of the original image
                string fileName = Path.GetFileNameWithoutExtension(path);
                // Destination
                string destination = path.Replace(fileName, fileName + "-modified");
                // Save the edited image
                if (File.Exists(destination))
                {
                    DialogResult dialogResult = MessageBox.Show("File " + destination + " already exists. Do you want to replace it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        pictureBoxBGR.Image.Save(destination);
                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RootFolder.refresh();
                        this.Close();
                    }
                }
                else
                {
                    pictureBoxBGR.Image.Save(destination);
                    MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RootFolder.refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColorChannelSwap_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn phím ESC không
            if (e.KeyCode == Keys.Escape)
            {
                // Đóng Form khi người dùng nhấn nút ESC
                this.Close();
            }
        }
    }
}
