namespace Project_2.Move_Images
{
    partial class MoveImagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChooseRootFolder = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.AddLabel = new System.Windows.Forms.ToolStripButton();
            this.RemoveLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BackImage = new System.Windows.Forms.ToolStripButton();
            this.NextImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.ColorChannelSwap = new System.Windows.Forms.ToolStripButton();
            this.listViewLabels = new System.Windows.Forms.ListView();
            this.columnHeaderLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelImageCount = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseRootFolder,
            this.Refresh,
            this.AddLabel,
            this.RemoveLabel,
            this.toolStripSeparator1,
            this.BackImage,
            this.NextImage,
            this.toolStripSeparator2,
            this.Undo,
            this.ColorChannelSwap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ChooseRootFolder
            // 
            this.ChooseRootFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChooseRootFolder.Image = global::Project_2.Properties.Resources.open_folder;
            this.ChooseRootFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChooseRootFolder.Name = "ChooseRootFolder";
            this.ChooseRootFolder.Size = new System.Drawing.Size(23, 22);
            this.ChooseRootFolder.Text = "Choose Root Folder";
            this.ChooseRootFolder.Click += new System.EventHandler(this.ChooseRootFolder_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refresh.Image = global::Project_2.Properties.Resources.refresh;
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(23, 22);
            this.Refresh.Text = "Refresh Root Folder";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddLabel.Image = global::Project_2.Properties.Resources.add_label;
            this.AddLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(23, 22);
            this.AddLabel.Text = "Add Label";
            this.AddLabel.Click += new System.EventHandler(this.AddLabel_Click);
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveLabel.Image = global::Project_2.Properties.Resources.remove_label;
            this.RemoveLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(23, 22);
            this.RemoveLabel.Text = "Remove Label";
            this.RemoveLabel.Click += new System.EventHandler(this.RemoveLabel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BackImage
            // 
            this.BackImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackImage.Image = global::Project_2.Properties.Resources.back;
            this.BackImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackImage.Name = "BackImage";
            this.BackImage.Size = new System.Drawing.Size(23, 22);
            this.BackImage.Text = "Back";
            this.BackImage.Click += new System.EventHandler(this.BackImage_Click);
            // 
            // NextImage
            // 
            this.NextImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextImage.Image = global::Project_2.Properties.Resources.next;
            this.NextImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextImage.Name = "NextImage";
            this.NextImage.Size = new System.Drawing.Size(23, 22);
            this.NextImage.Text = "Next";
            this.NextImage.Click += new System.EventHandler(this.NextImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Undo
            // 
            this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo.Image = global::Project_2.Properties.Resources.undo;
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(23, 22);
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // ColorChannelSwap
            // 
            this.ColorChannelSwap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorChannelSwap.Image = global::Project_2.Properties.Resources.The_three_primary_colors_of_RGB_Color_Model__Red__Green__Blue_;
            this.ColorChannelSwap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorChannelSwap.Name = "ColorChannelSwap";
            this.ColorChannelSwap.Size = new System.Drawing.Size(23, 22);
            this.ColorChannelSwap.Text = "Color Channel Swap";
            this.ColorChannelSwap.Click += new System.EventHandler(this.ColorChannelSwap_Click);
            // 
            // listViewLabels
            // 
            this.listViewLabels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLabel,
            this.columnHeaderKey,
            this.columnHeaderNumber});
            this.listViewLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLabels.FullRowSelect = true;
            this.listViewLabels.HideSelection = false;
            this.listViewLabels.Location = new System.Drawing.Point(0, 0);
            this.listViewLabels.MultiSelect = false;
            this.listViewLabels.Name = "listViewLabels";
            this.listViewLabels.Size = new System.Drawing.Size(182, 425);
            this.listViewLabels.TabIndex = 4;
            this.listViewLabels.UseCompatibleStateImageBehavior = false;
            this.listViewLabels.View = System.Windows.Forms.View.Details;
            this.listViewLabels.SelectedIndexChanged += new System.EventHandler(this.listViewLabels_SelectedIndexChanged);
            // 
            // columnHeaderLabel
            // 
            this.columnHeaderLabel.Text = "Label";
            this.columnHeaderLabel.Width = 87;
            // 
            // columnHeaderKey
            // 
            this.columnHeaderKey.Text = "Key";
            this.columnHeaderKey.Width = 35;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Number";
            this.columnHeaderNumber.Width = 57;
            // 
            // labelImageCount
            // 
            this.labelImageCount.AutoSize = true;
            this.labelImageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageCount.Location = new System.Drawing.Point(540, 7);
            this.labelImageCount.Name = "labelImageCount";
            this.labelImageCount.Size = new System.Drawing.Size(23, 15);
            this.labelImageCount.TabIndex = 5;
            this.labelImageCount.Text = "/ 0";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listViewLabels);
            this.splitContainer.Size = new System.Drawing.Size(800, 425);
            this.splitContainer.SplitterDistance = 614;
            this.splitContainer.TabIndex = 6;
            this.splitContainer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.splitContainer_KeyDown);
            this.splitContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            this.splitContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseMove);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Project_2.Properties.Resources.Please_Choose_Root_Folder1;
            this.pictureBox.InitialImage = global::Project_2.Properties.Resources.Please_Choose_Root_Folder1;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(614, 425);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndex.Location = new System.Drawing.Point(497, 4);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(37, 21);
            this.textBoxIndex.TabIndex = 7;
            this.textBoxIndex.Text = "0";
            this.textBoxIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIndex_KeyDown);
            this.textBoxIndex.Leave += new System.EventHandler(this.textBoxIndex_Leave);
            // 
            // MoveImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelImageCount);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "MoveImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Move Images";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoveImagesForm_FormClosing);
            this.Load += new System.EventHandler(this.MoveImagesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveImagesForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ChooseRootFolder;
        private System.Windows.Forms.ToolStripButton NextImage;
        private System.Windows.Forms.ToolStripButton BackImage;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton AddLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView listViewLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderLabel;
        private System.Windows.Forms.ColumnHeader columnHeaderKey;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.Label labelImageCount;
        private System.Windows.Forms.ToolStripButton RemoveLabel;
        private System.Windows.Forms.ToolStripButton ColorChannelSwap;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox textBoxIndex;
    }
}