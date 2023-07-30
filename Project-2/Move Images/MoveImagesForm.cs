using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_2.Move_Images
{
    public partial class MoveImagesForm : Form
    {
        // Constructor
        public MoveImagesForm()
        {
            InitializeComponent();
        }
        // Object Initialization
        internal static List<Label> labels = new List<Label>();
        static List<Transaction> transactions = new List<Transaction>();
        // Additional function
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
            // Update textBoxIndex
            textBoxIndex.Text = "" + (RootFolder.current_index + 1);
            // Update labelImageCount
            labelImageCount.Text = "/ " + RootFolder.imagePath.Count();
            // Update pictureBox
            pictureBox.ImageLocation = RootFolder.imagePath[RootFolder.current_index];
        }

        private void Clean()
        {
            Refresh.Enabled = false;
            RemoveLabel.Enabled = false;
            BackImage.Enabled = false;
            NextImage.Enabled = false;
            Undo.Enabled = false;
            ColorChannelSwap.Enabled = false;

            textBoxIndex.Visible = false;
            labelImageCount.Visible = false;
        }
        // Handle event
        private void MoveImagesForm_Load(object sender, EventArgs e)
        {
            Clean();
        }
        // -------------------------------------------------------------
        private void ChooseRootFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) return;
                RootFolder.path = folderBrowserDialog.SelectedPath;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want scan images from subfolders?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                RootFolder.isAllDirectories = true;
            }
            else
            {
                RootFolder.isAllDirectories = false;
            }
            // Search for images
            RootFolder.refresh();
            if (RootFolder.imagePath.Count() == 0)
            {
                MessageBox.Show("Can't find any image!");
                return;
            }

            // Display the first image
            RootFolder.current_index = 0;
            ShowImage();

            // Enable button
            Refresh.Enabled = true;
            if (RootFolder.imagePath.Count() > 1)
            {
                NextImage.Enabled = true;
            }
            ColorChannelSwap.Enabled = true;

            textBoxIndex.Visible = true;
            labelImageCount.Visible = true;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Clean();
            // Update Root Folder----------------------------------------------
            DialogResult dialogResult = MessageBox.Show("Do you want scan images from subfolders?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                RootFolder.isAllDirectories = true;
            }
            else
            {
                RootFolder.isAllDirectories = false;
            }
            // Search for images
            RootFolder.refresh();
            if (RootFolder.imagePath.Count() == 0)
            {
                MessageBox.Show("Can't find any image!");
                return;
            }

            // Display the first image
            RootFolder.current_index = 0;
            ShowImage();

            // Enable button
            Refresh.Enabled = true;
            if (RootFolder.imagePath.Count() > 1)
            {
                NextImage.Enabled = true;
            }
            ColorChannelSwap.Enabled = true;

            textBoxIndex.Visible = true;
            labelImageCount.Visible = true;

            //Update labels and listViewLabels
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].refresh();
            }
            ShowLabel();
        }
        // -------------------------------------------------------------
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
        // --------------------------------------------------------------
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
        // ---------------------------------------------------------------
        private void listViewLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLabels.SelectedItems.Count > 0)
            {
                RemoveLabel.Enabled = true;
            }
            else RemoveLabel.Enabled = false;
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            string destination = transactions[transactions.Count - 1].destination;
            string source = transactions[transactions.Count - 1].source;
            try
            {
                File.Move(destination, source); //destination to source
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while moving the image: " + ex.Message);
                return;
            }
            //Update data -----------------------------------------------------------------
            //Update RootFolder
            RootFolder.refresh();
            //Update label in labels
            for (int i = 0; i < labels.Count; i++)
            {
                if (labels[i].path == Path.GetDirectoryName(destination))
                {
                    labels[i].refresh();
                    break;
                }
            }
            //Update transactions
            transactions.RemoveAt(transactions.Count - 1);
            //Update view-----------------------------------------------------------------
            // Update BackImage
            if (RootFolder.current_index > 0)
            {
                BackImage.Enabled = true;
            }
            // Update NextImage
            if (RootFolder.current_index < RootFolder.imagePath.Count - 1)
            {
                NextImage.Enabled = true;
            }
            // Update Undo
            if (transactions.Count == 0) Undo.Enabled = false;
            // Update PictureBox and textBoxIndex and labelImageCount
            ShowImage();
            // Update listViewLabels
            ShowLabel();
            // Update textBoxIndex and labelImageCount
            textBoxIndex.Visible = true;
            labelImageCount.Visible = true;
        }

        private void ColorChannelSwap_Click(object sender, EventArgs e)
        {
            ColorChannelSwap colorChannelSwap = new ColorChannelSwap(RootFolder.imagePath[RootFolder.current_index]);
            colorChannelSwap.ShowDialog();
            ShowImage();
        }
        // ---------------------------------------------------------------
        private void MoveImagesForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn phím ESC không
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            // Back image
            if (e.KeyCode == Keys.Left && BackImage.Enabled)
            {
                BackImage.PerformClick();
            }
            // Next image
            if (e.KeyCode == Keys.Right && NextImage.Enabled)
            {
                NextImage.PerformClick();
            }
            // Kiểm tra nếu TextBox hoặc control khác đang có focus
            if (ActiveControl is TextBox || ActiveControl is RichTextBox || ActiveControl is ComboBox)
            {
                // Nếu là TextBox hoặc các control bạn muốn loại trừ, hủy bỏ xử lý sự kiện bàn phím
                return;
            }
            // Move file
            char pressedChar = (char)e.KeyCode;
            for (int i = 0; i < labels.Count; i++)
            {
                if (pressedChar == labels[i].key)
                {
                    string source = RootFolder.imagePath[RootFolder.current_index];
                    string fileName = Path.GetFileName(source);
                    string destination = Path.Combine(labels[i].path, fileName);
                    // move images
                    try
                    {
                        File.Move(source, destination);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while moving the file: " + ex.Message);
                        return;
                    }
                    // Update data -------------------------------------------------------------------
                    // Update RootFolder
                    RootFolder.imagePath.RemoveAt(RootFolder.current_index);
                    while (RootFolder.current_index >= RootFolder.imagePath.Count && RootFolder.current_index > 0)
                    {
                        RootFolder.current_index--;
                    }
                    // Update label in labels
                    labels[i].refresh();
                    // Create transaction and add to transactions
                    Transaction transaction = new Transaction(source, destination);
                    transactions.Add(transaction);
                    // if there are no image------------------------------------------------------------
                    if (RootFolder.imagePath.Count == 0)
                    {
                        MessageBox.Show("Congratulations, you have moved all the images");
                        Clean();
                        Undo.Enabled = true;
                        pictureBox.Image = Properties.Resources.Please_Choose_Root_Folder1;
                        return;
                    }
                    // if there are still images update views-------------------------------------------
                    // Update BackImage
                    if (RootFolder.current_index == 0)
                    {
                        BackImage.Enabled = false;
                    }
                    // Update NextImage
                    if (RootFolder.current_index == RootFolder.imagePath.Count - 1)
                    {
                        NextImage.Enabled = false;
                    }
                    // Update Undo
                    Undo.Enabled = true;
                    // Update PictureBox and textBoxIndex and labelImageCount
                    ShowImage();
                    // Update listViewLabels
                    ShowLabel();
                }
            }
        }

        private void MoveImagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transactions.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save transaction history? This will create a file log on your Root Folder.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int index = 0;
                    string destination;
                    do
                    {
                        index++;
                        destination = Path.Combine(RootFolder.path, "move image log " + index + ".txt");
                    } while (File.Exists(destination));

                    string log = "";
                    foreach (Transaction transaction in transactions)
                    {
                        log += transaction.source + "=>" + transaction.destination + "\n";
                    }
                    File.WriteAllText(destination, log);
                }
            }
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //-------------------------------------------------------------
        private void textBoxIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int index = int.Parse(textBoxIndex.Text);
                    if (index < 1 || index > RootFolder.imagePath.Count)
                    {
                        throw new Exception("out of index");
                    }
                    RootFolder.current_index = index - 1;
                    if (RootFolder.current_index == 0) BackImage.Enabled = false;
                    if (RootFolder.current_index == RootFolder.imagePath.Count - 1) NextImage.Enabled = false;
                    if (RootFolder.current_index > 0) BackImage.Enabled = true;
                    if (RootFolder.current_index < RootFolder.imagePath.Count - 1) NextImage.Enabled = true;
                }
                catch { }
                ShowImage();
                pictureBox.Focus();
            }
        }

        private void textBoxIndex_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBoxIndex.Text);
                if (index < 1 || index > RootFolder.imagePath.Count)
                {
                    throw new Exception("out of index");
                }
                RootFolder.current_index = index - 1;
                if (RootFolder.current_index == 0) BackImage.Enabled = false;
                if (RootFolder.current_index ==  RootFolder.imagePath.Count - 1) NextImage.Enabled = false;
                if (RootFolder.current_index > 0) BackImage.Enabled = true;
                if (RootFolder.current_index < RootFolder.imagePath.Count - 1) NextImage.Enabled = true;
            }
            catch { }
            ShowImage();
        }
        //-------------------------------------------------------------
        private void splitContainer_KeyDown(object sender, KeyEventArgs e)
        {
            splitContainer.IsSplitterFixed = true;
        }

        private void splitContainer_MouseDown(object sender, MouseEventArgs e)
        {
            splitContainer.IsSplitterFixed = false;
        }

        private void splitContainer_MouseMove(object sender, MouseEventArgs e)
        {
            splitContainer.IsSplitterFixed = false;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox.Focus();
        }
    }
}