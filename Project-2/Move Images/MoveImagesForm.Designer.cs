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
            this.RefreshRootFolder = new System.Windows.Forms.ToolStripButton();
            this.AddLabel = new System.Windows.Forms.ToolStripButton();
            this.RemoveLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BackImage = new System.Windows.Forms.ToolStripButton();
            this.NextImage = new System.Windows.Forms.ToolStripButton();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorChannelSwap = new System.Windows.Forms.ToolStripDropDownButton();
            this.RBG = new System.Windows.Forms.ToolStripMenuItem();
            this.GRB = new System.Windows.Forms.ToolStripMenuItem();
            this.GBR = new System.Windows.Forms.ToolStripMenuItem();
            this.BRG = new System.Windows.Forms.ToolStripMenuItem();
            this.BGR = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewLabels = new System.Windows.Forms.ListView();
            this.columnHeaderLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelIndex = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseRootFolder,
            this.RefreshRootFolder,
            this.AddLabel,
            this.RemoveLabel,
            this.toolStripSeparator1,
            this.BackImage,
            this.NextImage,
            this.Undo,
            this.toolStripSeparator2,
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
            // RefreshRootFolder
            // 
            this.RefreshRootFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshRootFolder.Image = global::Project_2.Properties.Resources.refresh;
            this.RefreshRootFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshRootFolder.Name = "RefreshRootFolder";
            this.RefreshRootFolder.Size = new System.Drawing.Size(23, 22);
            this.RefreshRootFolder.Text = "Refresh Root Folder";
            this.RefreshRootFolder.Click += new System.EventHandler(this.RefreshRootFolder_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ColorChannelSwap
            // 
            this.ColorChannelSwap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorChannelSwap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RBG,
            this.GRB,
            this.GBR,
            this.BRG,
            this.BGR});
            this.ColorChannelSwap.Image = global::Project_2.Properties.Resources.The_three_primary_colors_of_RGB_Color_Model__Red__Green__Blue_;
            this.ColorChannelSwap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorChannelSwap.Name = "ColorChannelSwap";
            this.ColorChannelSwap.Size = new System.Drawing.Size(29, 22);
            this.ColorChannelSwap.Text = "Color Channel Swap";
            // 
            // RBG
            // 
            this.RBG.Name = "RBG";
            this.RBG.Size = new System.Drawing.Size(96, 22);
            this.RBG.Text = "RBG";
            this.RBG.Click += new System.EventHandler(this.RBG_Click);
            // 
            // GRB
            // 
            this.GRB.Name = "GRB";
            this.GRB.Size = new System.Drawing.Size(96, 22);
            this.GRB.Text = "GRB";
            this.GRB.Click += new System.EventHandler(this.GRB_Click);
            // 
            // GBR
            // 
            this.GBR.Name = "GBR";
            this.GBR.Size = new System.Drawing.Size(96, 22);
            this.GBR.Text = "GBR";
            this.GBR.Click += new System.EventHandler(this.GBR_Click);
            // 
            // BRG
            // 
            this.BRG.Name = "BRG";
            this.BRG.Size = new System.Drawing.Size(96, 22);
            this.BRG.Text = "BRG";
            this.BRG.Click += new System.EventHandler(this.BRG_Click);
            // 
            // BGR
            // 
            this.BGR.Name = "BGR";
            this.BGR.Size = new System.Drawing.Size(96, 22);
            this.BGR.Text = "BGR";
            this.BGR.Click += new System.EventHandler(this.BGR_Click);
            // 
            // listViewLabels
            // 
            this.listViewLabels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLabel,
            this.columnHeaderKey,
            this.columnHeaderNumber});
            this.listViewLabels.FullRowSelect = true;
            this.listViewLabels.HideSelection = false;
            this.listViewLabels.Location = new System.Drawing.Point(617, 28);
            this.listViewLabels.MultiSelect = false;
            this.listViewLabels.Name = "listViewLabels";
            this.listViewLabels.Size = new System.Drawing.Size(183, 410);
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
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(552, 12);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(59, 13);
            this.labelIndex.TabIndex = 5;
            this.labelIndex.Text = "Image: 0/0";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Project_2.Properties.Resources.Please_Choose_Root_Folder;
            this.pictureBox.InitialImage = global::Project_2.Properties.Resources.Please_Choose_Root_Folder;
            this.pictureBox.Location = new System.Drawing.Point(0, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(611, 410);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(444, 2);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveImage.TabIndex = 6;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Visible = false;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // MoveImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.listViewLabels);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "MoveImagesForm";
            this.Text = "Move Images";
            this.Load += new System.EventHandler(this.MoveImagesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveImagesForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ChooseRootFolder;
        private System.Windows.Forms.ToolStripButton NextImage;
        private System.Windows.Forms.ToolStripButton BackImage;
        private System.Windows.Forms.ToolStripButton RefreshRootFolder;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton AddLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView listViewLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderLabel;
        private System.Windows.Forms.ColumnHeader columnHeaderKey;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.ToolStripButton RemoveLabel;
        private System.Windows.Forms.ToolStripDropDownButton ColorChannelSwap;
        private System.Windows.Forms.ToolStripMenuItem RBG;
        private System.Windows.Forms.ToolStripMenuItem GRB;
        private System.Windows.Forms.ToolStripMenuItem GBR;
        private System.Windows.Forms.ToolStripMenuItem BRG;
        private System.Windows.Forms.ToolStripMenuItem BGR;
        private System.Windows.Forms.Button buttonSaveImage;
    }
}