using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2.Move_Images
{
    public partial class MoveImagesForm : Form
    {
        // Object Initialization
        internal static List<Label> labels = new List<Label>();
        static List<Transaction> transactions = new List<Transaction>();
        // Additional function
        private void MoveImage(Label label)
        {
            string source = RootFolder.imagePath[RootFolder.current_index];
            string destination = Path.Combine(label.path, Path.GetFileName(source));
            try
            {
                File.Move(source, destination);
                if (RootFolder.current_index == RootFolder.imagePath.Count - 1)
                {
                    RootFolder.imagePath.RemoveAt(RootFolder.current_index);
                    RootFolder.current_index--;
                }
                else
                {
                    RootFolder.imagePath.RemoveAt(RootFolder.current_index);
                }
                if (RootFolder.imagePath.Count == 0)
                {
                    MessageBox.Show("You're done");
                    return;
                };
                
                ShowImage();
                label.imagePath.Add(destination);
                for (int i = 0; i < labels.Count; i++)
                {
                    if (listViewLabels.Items[i].SubItems[0].Text == label.name) 
                    {
                        listViewLabels.Items[i].SubItems[2].Text = int.Parse(listViewLabels.Items[i].SubItems[2].Text) + 1 + "";
                    }
                }

                Transaction transaction = new Transaction(source, destination);
                transactions.Add(transaction);
                Undo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while moving the image: " + ex.Message);
            }
        }

        internal void ShowLabel()
        {
            listViewLabels.Items.Clear();
            foreach (Label label in labels)
            {
                string labelColumn = label.name;
                string keyColumn = label.key.ToString();
                string numberColumn = label.imagePath.Count().ToString();

                ListViewItem item = new ListViewItem(labelColumn);
                item.SubItems.Add(keyColumn);
                item.SubItems.Add(numberColumn);
                listViewLabels.Items.Add(item);
            }
        }

        private void ShowImage()
        {
            labelIndex.Text = "Image: " + (RootFolder.current_index + 1) + '/' + RootFolder.imagePath.Count();
            pictureBox.ImageLocation = RootFolder.imagePath[RootFolder.current_index];
        }
        private void Clean()
        {
            RefreshRootFolder.Enabled = false;
            AddLabel.Enabled = false;
            RemoveLabel.Enabled = false;
            BackImage.Enabled = false;
            NextImage.Enabled = false;
            Undo.Enabled = false;
            ColorChannelSwap.Enabled = false;
        }
        // Handle event
        public MoveImagesForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void MoveImagesForm_Load(object sender, EventArgs e)
        {
            Clean();
        }

        private void ChooseRootFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) return;
                RootFolder.path = folderBrowserDialog.SelectedPath;
            }

            // Search for images
            DialogResult dialogResult = MessageBox.Show("Do you want scan images from subfolders?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                RootFolder.imagePath = Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpg", searchOption: SearchOption.AllDirectories).ToList();
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.png", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.bmp", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.gif", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpeg", searchOption: SearchOption.AllDirectories));
            }
            else
            {
                RootFolder.imagePath = Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpg", searchOption: SearchOption.TopDirectoryOnly).ToList();
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.png", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.bmp", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.gif", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpeg", searchOption: SearchOption.TopDirectoryOnly));
            }

            if (RootFolder.imagePath.Count() == 0)
            {
                MessageBox.Show("Can't find any image!");
                return;
            }

            // Display the first image
            RootFolder.current_index = 0;
            ShowImage();

            // Enable button
            RefreshRootFolder.Enabled = true;
            AddLabel.Enabled = true;
            if (RootFolder.imagePath.Count() > 1)
            {
                NextImage.Enabled = true;
            }
            ColorChannelSwap.Enabled = true;
        }

        private void RefreshRootFolder_Click(object sender, EventArgs e)
        {
            Clean();
            // Search for images
            DialogResult dialogResult = MessageBox.Show("Do you want scan images from subfolders?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                RootFolder.imagePath = Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpg", searchOption: SearchOption.AllDirectories).ToList();
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.png", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.bmp", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.gif", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpeg", searchOption: SearchOption.AllDirectories));
            }
            else
            {
                RootFolder.imagePath = Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpg", searchOption: SearchOption.TopDirectoryOnly).ToList();
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.png", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.bmp", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.gif", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpeg", searchOption: SearchOption.TopDirectoryOnly));
            }

            if (RootFolder.imagePath.Count() == 0)
            {
                MessageBox.Show("Can't find any image!");
                return;
            }

            // Display the first image
            int start_index = 0;
            RootFolder.current_index = start_index;
            ShowImage();

            // Enable button
            RefreshRootFolder.Enabled = true;
            AddLabel.Enabled = true;
            if (RootFolder.imagePath.Count() > 1)
            {
                NextImage.Enabled = true;
            }
            ColorChannelSwap.Enabled = true;
        }

        private void AddLabel_Click(object sender, EventArgs e)
        {
            AddLabelForm addLabelForm = new AddLabelForm();
            addLabelForm.ShowDialog();
            //Display the labels to the listViewLabel
            ShowLabel();
        }

        private void RemoveLabel_Click(object sender, EventArgs e)
        {
            if (listViewLabels.SelectedItems.Count > 0)
            {
                string name = listViewLabels.SelectedItems[0].SubItems[0].Text;
                for (int i = 0; i < labels.Count; i++)
                {
                    if (labels[i].name == name)
                    {
                        labels.RemoveAt(i);
                        ShowLabel();
                        RemoveLabel.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void listViewLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLabels.SelectedItems.Count > 0)
            {
                RemoveLabel.Enabled = true;
                foreach (Label label in labels)
                {
                    if (label.name == listViewLabels.SelectedItems[0].SubItems[0].Text)
                    {
                        MoveImage(label);
                        break;
                    }
                }
                
            }
        }

        private void BackImage_Click(object sender, EventArgs e)
        {
            NextImage.Enabled = true;
            RootFolder.current_index--;
            ShowImage();
            if (RootFolder.current_index == 0)
            {
                BackImage.Enabled = false;
            }
        }

        private void NextImage_Click(object sender, EventArgs e)
        {
            BackImage.Enabled = true;
            RootFolder.current_index++;
            ShowImage();
            if (RootFolder.current_index == RootFolder.imagePath.Count - 1)
            {
                NextImage.Enabled=false;
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            string source = transactions[transactions.Count - 1].destination;
            string destination = transactions[transactions.Count - 1].source;
            try
            {
                File.Move(source, destination);
                RootFolder.imagePath.Add(destination);
                transactions.RemoveAt(transactions.Count - 1);
                if (transactions.Count == 0)
                {
                    Undo.Enabled = false;
                }
                ShowImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while moving the image: " + ex.Message);
            }
        }
    }
}
