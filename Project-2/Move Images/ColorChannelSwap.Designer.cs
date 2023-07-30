namespace Project_2.Move_Images
{
    partial class ColorChannelSwap
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
            this.pictureBoxGBR = new System.Windows.Forms.PictureBox();
            this.pictureBoxBGR = new System.Windows.Forms.PictureBox();
            this.pictureBoxBRG = new System.Windows.Forms.PictureBox();
            this.pictureBoxGRB = new System.Windows.Forms.PictureBox();
            this.pictureBoxRBG = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGBR
            // 
            this.pictureBoxGBR.Location = new System.Drawing.Point(368, 12);
            this.pictureBoxGBR.Name = "pictureBoxGBR";
            this.pictureBoxGBR.Size = new System.Drawing.Size(172, 125);
            this.pictureBoxGBR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGBR.TabIndex = 4;
            this.pictureBoxGBR.TabStop = false;
            this.pictureBoxGBR.Click += new System.EventHandler(this.pictureBoxGBR_Click);
            // 
            // pictureBoxBGR
            // 
            this.pictureBoxBGR.Location = new System.Drawing.Point(190, 143);
            this.pictureBoxBGR.Name = "pictureBoxBGR";
            this.pictureBoxBGR.Size = new System.Drawing.Size(172, 125);
            this.pictureBoxBGR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBGR.TabIndex = 3;
            this.pictureBoxBGR.TabStop = false;
            this.pictureBoxBGR.Click += new System.EventHandler(this.pictureBoxBGR_Click);
            // 
            // pictureBoxBRG
            // 
            this.pictureBoxBRG.Location = new System.Drawing.Point(12, 143);
            this.pictureBoxBRG.Name = "pictureBoxBRG";
            this.pictureBoxBRG.Size = new System.Drawing.Size(172, 125);
            this.pictureBoxBRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBRG.TabIndex = 2;
            this.pictureBoxBRG.TabStop = false;
            this.pictureBoxBRG.Click += new System.EventHandler(this.pictureBoxBRG_Click);
            // 
            // pictureBoxGRB
            // 
            this.pictureBoxGRB.Location = new System.Drawing.Point(190, 12);
            this.pictureBoxGRB.Name = "pictureBoxGRB";
            this.pictureBoxGRB.Size = new System.Drawing.Size(172, 125);
            this.pictureBoxGRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGRB.TabIndex = 1;
            this.pictureBoxGRB.TabStop = false;
            this.pictureBoxGRB.Click += new System.EventHandler(this.pictureBoxGRB_Click);
            // 
            // pictureBoxRBG
            // 
            this.pictureBoxRBG.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxRBG.Name = "pictureBoxRBG";
            this.pictureBoxRBG.Size = new System.Drawing.Size(172, 125);
            this.pictureBoxRBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRBG.TabIndex = 0;
            this.pictureBoxRBG.TabStop = false;
            this.pictureBoxRBG.Click += new System.EventHandler(this.pictureBoxRBG_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(420, 195);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ColorChannelSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 278);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxGBR);
            this.Controls.Add(this.pictureBoxBGR);
            this.Controls.Add(this.pictureBoxBRG);
            this.Controls.Add(this.pictureBoxGRB);
            this.Controls.Add(this.pictureBoxRBG);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorChannelSwap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ColorChannelSwap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorChannelSwap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRBG;
        private System.Windows.Forms.PictureBox pictureBoxGRB;
        private System.Windows.Forms.PictureBox pictureBoxBRG;
        private System.Windows.Forms.PictureBox pictureBoxBGR;
        private System.Windows.Forms.PictureBox pictureBoxGBR;
        private System.Windows.Forms.Button buttonClose;
    }
}