namespace Project_2
{
    partial class ModeSelectionForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonMoveImages = new System.Windows.Forms.Button();
            this.buttonDrawBoudingBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonMoveImages
            // 
            this.buttonMoveImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMoveImages.Location = new System.Drawing.Point(0, 0);
            this.buttonMoveImages.Margin = new System.Windows.Forms.Padding(6);
            this.buttonMoveImages.Name = "buttonMoveImages";
            this.buttonMoveImages.Size = new System.Drawing.Size(300, 42);
            this.buttonMoveImages.TabIndex = 2;
            this.buttonMoveImages.Text = "Move Images";
            this.buttonMoveImages.UseVisualStyleBackColor = true;
            this.buttonMoveImages.Click += new System.EventHandler(this.buttonMoveImages_Click);
            // 
            // buttonDrawBoudingBox
            // 
            this.buttonDrawBoudingBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDrawBoudingBox.Location = new System.Drawing.Point(0, 40);
            this.buttonDrawBoudingBox.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDrawBoudingBox.Name = "buttonDrawBoudingBox";
            this.buttonDrawBoudingBox.Size = new System.Drawing.Size(300, 42);
            this.buttonDrawBoudingBox.TabIndex = 3;
            this.buttonDrawBoudingBox.Text = "Draw Bounding Box";
            this.buttonDrawBoudingBox.UseVisualStyleBackColor = true;
            this.buttonDrawBoudingBox.Click += new System.EventHandler(this.buttonDrawBoudingBox_Click);
            // 
            // ModeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 82);
            this.Controls.Add(this.buttonDrawBoudingBox);
            this.Controls.Add(this.buttonMoveImages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ModeSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mode Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonMoveImages;
        private System.Windows.Forms.Button buttonDrawBoudingBox;
    }
}

