using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_2.Move_Images;

namespace Project_2.Move_Images
{
    public partial class AddLabelForm : Form
    {
        public AddLabelForm()
        {
            InitializeComponent();
        }

        private void buttonChoosePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) return;
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonAddLabel_Click(object sender, EventArgs e)
        {
            //Check codition
            bool check = true;
            errorProviderName.Clear();
            errorProviderKey.Clear();
            errorProviderPath.Clear();
            if (textBoxName.Text.Length == 0 )
            {
                errorProviderName.SetError(textBoxName, "Name can't be blank");
                check = false;
            }
            if (textBoxKey.Text.Length != 1 )
            {
                errorProviderKey.SetError(textBoxKey, "Key must be a character");
                check = false;
            }
            if (!Directory.Exists(textBoxPath.Text))
            {
                errorProviderPath.SetError(textBoxPath, "The folder path does not exist.");
                check = false;
            }
            // Check Duplicate name, key
            foreach (Label label in MoveImagesForm.labels)
            {
                if (label.name == textBoxName.Text)
                {
                    errorProviderName.SetError(textBoxName, "Duplicate name");
                    check = false;
                }
                if (label.key.ToString() == textBoxKey.Text)
                {
                    errorProviderKey.SetError(textBoxKey, "Duplicate key");
                    check = false;
                }
                if (label.path == textBoxPath.Text)
                {
                    errorProviderPath.SetError(textBoxPath, "Duplicate path");
                    check = false;
                }
            }

            // 
            if (!check)
            {
                return;
            }
            string name = textBoxName.Text;
            char key = textBoxKey.Text[0];
            string path = textBoxPath.Text;
            Label newLabel = new Label(name, key, path);
            MoveImagesForm.labels.Add(newLabel);

            // Refresh the text in 3 text boxes
            textBoxName.Text = "";
            textBoxKey.Text = "";
            textBoxPath.Text = "";
        }
    }
}
