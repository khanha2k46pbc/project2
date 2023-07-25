namespace Project_2.Move_Images
{
    partial class ColorChannelSwapForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRedGreen = new System.Windows.Forms.Button();
            this.buttonGreenBlue = new System.Windows.Forms.Button();
            this.buttonBlueRed = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 273);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRedGreen
            // 
            this.buttonRedGreen.Location = new System.Drawing.Point(342, 12);
            this.buttonRedGreen.Name = "buttonRedGreen";
            this.buttonRedGreen.Size = new System.Drawing.Size(96, 23);
            this.buttonRedGreen.TabIndex = 1;
            this.buttonRedGreen.Text = "Red <=> Green";
            this.buttonRedGreen.UseVisualStyleBackColor = true;
            this.buttonRedGreen.Click += new System.EventHandler(this.buttonRedGreen_Click);
            // 
            // buttonGreenBlue
            // 
            this.buttonGreenBlue.Location = new System.Drawing.Point(342, 41);
            this.buttonGreenBlue.Name = "buttonGreenBlue";
            this.buttonGreenBlue.Size = new System.Drawing.Size(96, 23);
            this.buttonGreenBlue.TabIndex = 2;
            this.buttonGreenBlue.Text = "Green <=> Blue";
            this.buttonGreenBlue.UseVisualStyleBackColor = true;
            // 
            // buttonBlueRed
            // 
            this.buttonBlueRed.Location = new System.Drawing.Point(342, 70);
            this.buttonBlueRed.Name = "buttonBlueRed";
            this.buttonBlueRed.Size = new System.Drawing.Size(96, 23);
            this.buttonBlueRed.TabIndex = 3;
            this.buttonBlueRed.Text = "Blue <=> Red";
            this.buttonBlueRed.UseVisualStyleBackColor = true;
            this.buttonBlueRed.Click += new System.EventHandler(this.buttonBlueRed_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(0, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(446, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // ColorChannelSwapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 313);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBlueRed);
            this.Controls.Add(this.buttonGreenBlue);
            this.Controls.Add(this.buttonRedGreen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ColorChannelSwapForm";
            this.Text = "ColorChannelSwapForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRedGreen;
        private System.Windows.Forms.Button buttonGreenBlue;
        private System.Windows.Forms.Button buttonBlueRed;
        private System.Windows.Forms.Button buttonSave;
    }
}